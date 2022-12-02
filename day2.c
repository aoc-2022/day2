#include <stdio.h>

int main() {
    FILE* input = fopen("/tmp/aoc/input","r");
    char c1, c2;
    int i1,i2;
    int score1 = 0;
    int score2 = 0;
    while (fscanf(input,"%c %c\n",&c1,&c2) != EOF) {
        i1 = c1 - 'A';
        i2 = c2 - 'X';
        score1 += ((i1+1) %3 == i2)*6 + (i1==i2)*3 + i2 + 1;
        score2 += (i2 == 0)*((i1+2) % 3 + 1) + (i2 == 1)*(i1+4) + (i2 == 2)*((i1+1) % 3 + 7);
    }
    printf("score: %d\n",score1);
    printf("score: %d\n",score2);
}
