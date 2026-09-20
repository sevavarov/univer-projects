#define NSYMS 20 /* размер таблицы имён */
struct symtab {
    char *name; /* имя переменной или функции */
    double (*funcptr1)(double); /* для функции указатель на её вычисление*/
    double (*funcptr2)(double,double); /* для функции 2 переменных*/
    double value; /* для переменной её значение */
};
struct symtab *symlook(char*);