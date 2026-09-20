%{
#include <stdio.h>
#include <string.h>
#include <math.h>
#include "symbol_table.h"
extern struct symtab symtab[NSYMS];
/* если следующие две строки вызывают ошибку (error), убрать их */
/* если только warning, и компиляция проходит, не трогать */
extern int yylex(void);
int yyerror(const char* format){ return printf("%s\n", format); }
%}
%union {
    double dval;
    struct symtab *symp;
}
%token <symp> NAME
%token <dval> NUMBER
%left '-' '+'
%left '*' '/' 
%nonassoc UMINUS
%type <dval> expression
%start statement_list

%%

statement_list: statement '\n'
| statement_list statement '\n'
;
statement: NAME '=' expression { $1->value = $3; }
| expression { printf("= %g\n", $1); }
;
expression: expression '+' expression { $$ = $1 + $3; }
| expression '-' expression { $$ = $1 - $3; }
| expression '*' expression { $$ = $1 * $3; }
| expression '/' expression {
    if( $3 == 0.0 )
        { yyerror("divide by zero"); 
        $$ = $3;}
    else $$ = $1 / $3;
} 

| '-' expression %prec UMINUS { $$ = -$2; }
| '(' expression ')' { $$ = $2; }
| NUMBER
| NAME { $$ = $1->value; }
| NAME '(' expression ')' {
    if( $1->funcptr1 ) $$ = $1->funcptr1( $3 );
    else {
        printf("%s not a function", $1->name);
        $$ = 0.0;
    }
} 

;

%%

void addfunc1(char *name, double (*func)(double))
{
    struct symtab *sp = symlook(name);
    sp->funcptr1 = func;
}
int main()
{
    extern double sqrt(double), exp(double), log(double), sin(double), cos(double);
    addfunc1("sqrt", sqrt);
    addfunc1("exp", exp );
    addfunc1("log", log );
    addfunc1("sin", sin);
    addfunc1("cos", cos);
    yyparse();
}