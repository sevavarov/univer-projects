%{
#include <stdio.h>
%}

%%
\".*\" { printf("STRING_CONST "); }
\'.?\'   { printf("CHAR_CONST "); }
([0-9]+\.[0-9]*)([eE][-+]?[0-9]+)?   { printf("FLOAT_CONST "); }
%%
