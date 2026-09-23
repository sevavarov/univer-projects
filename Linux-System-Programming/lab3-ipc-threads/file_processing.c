#include <stdio.h>
#include <fcntl.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <stdlib.h>
#include <unistd.h>
#include <unistd.h>
#include <dirent.h>
#include <string.h>
#include <ctype.h>
char* concat(const char*, const char*);
char* concatres(const char*, const char*);
char* get_files(char*);
void write_files(char*, char*, char*);

int main(int argc, char* argv[]) {
    char* filename;
    if(argc > 1) {
        filename = argv[1];
    } else {
        filename = "out2.txt";
    }
    char* res = get_files("./input/");
    write_files("./output/", filename, res);
    exit(0);
}

void write_files(char* dir, char* file, char* text) {
    char* path = concat(dir, file);
    int fd = open(path, O_WRONLY | O_CREAT| O_TRUNC, 0666);
    if(fd < 0) {
        fprintf(stderr, "cannor open/create file");
        return;
    }
    printf("%s\n", file);

    int bytes = write(fd, text, strlen(text));
    close(fd);
}

char* get_files(char* dir) {
    DIR* dp;
    struct dirent *entry;

    if((dp = opendir(dir)) == NULL) {
        fprintf(stderr, "cannot open directory");
    }
    
    char* res = malloc(2);
    res[0] = '0';
    int count = 0;
    while((entry = readdir(dp)) != NULL) {
        char* curfile = entry->d_name;
        if(strcmp(curfile, ".") != 0 && strcmp(curfile, "..") != 0) {
            char* path = concat(dir, curfile);
            int fd = open(path, O_RDONLY);
            char text[1024];
            int bytes = read(fd, text, sizeof(text));
            int temp = 0;
            for(int i = 0; i < bytes; i++) {
                if(islower(text[i])) {
                    temp++;
                }
            } 
            if(temp < count || count == 0) {
                free(res);
                char* buf = malloc(11);
                sprintf(buf, "%d", temp);
                res = concatres(buf, curfile);
                count = temp;
            } else if(temp == count) {
                res = concatres(res, curfile);
            }
        }
    }
    return res;
}
char* concatres(const char* s1, const char* s2){
    int len1 = strlen(s1);
    int len2 = strlen(s2);
    char* res = malloc(len1 + len2 + 2);
    strcpy(res, s1);
    strcat(res, "\n");
    strcat(res, s2);
}
char* concat(const char* s1, const char* s2){
    int len1 = strlen(s1);
    int len2 = strlen(s2);
    char* res = malloc(len1 + len2 + 2);
    strcpy(res, s1);
    strcat(res, s2);
}