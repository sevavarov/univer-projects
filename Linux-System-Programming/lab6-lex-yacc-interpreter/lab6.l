%{
#include <stdio.h>
#include <math.h>
#include <string.h>
#include "y.tab.h"
#include "symbol_table.h"
struct symtab symtab[NSYMS];
%}

%% 

[ \t] ; /* ignore whitespace */

([0-9]+|([0-9]*\.[0-9]+)([eE][-+]?[0-9]+)?) {
    yylval.dval = atof(yytext);
    return NUMBER;   
}

[A-Za-z][A-Za-z0-9]* {
    struct symtab *sp = symlook(yytext);
    yylval.symp = sp;
    return NAME;
}

"$" { return 0;}
\n |
. return yytext[0];

%%

/* look up asymbol table entry, add if not present */
struct symtab *symlook(char *s)
{
struct symtab *sp;
for( sp = symtab; sp< &symtab[NSYMS]; sp++) {
    if(sp->name && !strcmp(sp->name, s)) return sp; /* name is found */
    if(!sp->name){sp->name = strdup(s); return sp;} /* make new row */
} /* otherwise continue to the next row until end of table */
yyerror("Too many symbols");
exit(1); /* cannot continue */
} /* symlook */