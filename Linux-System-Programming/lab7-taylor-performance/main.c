#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <sys/times.h>
#include <unistd.h>
long double powexp(long double x, long double y);

int main() {
    // Teylor's row for exp
    char N_str[30], x_str[30]; // 20 - длина unsigned long long
    long double N, sum, x;
    struct tms start, end;
    long clocks_per_sec;
    double clock;
    printf("Input N: ");
    fgets(N_str, sizeof(N_str), stdin);
    printf("Input X: ");
    fgets(x_str, sizeof(x_str), stdin);
    N = atof(N_str);
    x = atof(x_str);


    clocks_per_sec = sysconf(_SC_CLK_TCK);
    times(&start);
    sum = powexp(N, x);
    times(&end);
    clock = ((double)end.tms_utime - (double)start.tms_utime)/clocks_per_sec;
    printf("Time: %g\n", clock);
    printf("e^x = %.20Lg\n", sum);
}

long double powexp(long double N, long double x) {
    long double fact, x_temp, sum, i;

    i = 1;
    sum = 1;
    fact = 1; 
    x_temp = 1;
    for(; i < N; i++) {
        x_temp *= x;
        fact *= i;
        sum = sum + x_temp/fact;
    }
    return sum;
}