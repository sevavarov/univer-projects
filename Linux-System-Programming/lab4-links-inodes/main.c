#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>

void removeExtraHardLinks(char* dir) {
    DIR* dp;
    struct dirent* entry;
    
    dp = opendir(dir);
    if (dp == NULL) {
        fprintf(stderr, "cannot open directory");
    }
    
    ino_t* inodes = (ino_t*)malloc(sizeof(ino_t) * 100);
    int inodesCount = 0;
    
    while ((entry = readdir(dp)) != NULL) {
        char filename[256];
        sprintf(filename, "%s/%s", dir, entry->d_name);
        
        struct stat statBuf;
        if (lstat(filename, &statBuf) == -1) {
            fprintf(stderr, "error getting inode information");
        }
        
        ino_t inode = statBuf.st_ino;
        int i;
        for (i = 0; i < inodesCount; i++) {
            if (inodes[i] == inode) {
                if (unlink(filename) == -1) {
                    fprintf(stderr, "error when deleting a hard link");
                }
                printf("deleting a hard link: %s\n", filename);
                break;
            }
        }
        
        if (i == inodesCount) {
            inodes[inodesCount++] = inode;
        }
    }
    
    free(inodes);
    closedir(dp);
}

int main() {
    link("./input/text1.txt","./input/link1.txt");
    link("./input/text1.txt","./input/link11.txt");
    link("./input/text2.txt","./input/link2.txt");
    link("./input/text3.txt","./input/link3.txt");
    link("./input/text3.txt","./input/link33.txt");
    link("./input/text3.txt","./input/link333.txt");
    symlink("./text1.txt","./input/stext1.txt");
    symlink("./text1.txt","./input/stext11.txt");
    removeExtraHardLinks("./input/");
    
    return 0;
}
