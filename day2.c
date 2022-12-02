#include <stdio.h>

int main() {
    FILE* input = fopen("/tmp/aoc/input","r");
    char c1, c2;
    int i1,i2;
    int score1 = 0;
    int score2 = 0;
    while (fscanf(input,"%c %c\n",&c1,&c2) != EOF) {
        i1 = (c1 & 3) - 1;
        i2 = c2 & 3;
        score1 += ((c1 & 3) %3 == i2)*6 + (i1==i2)*3 + i2 + 1;
        score2 += (((c1 & 3) + 1 + (c2 & 3)) % 3) + 1 + (3*(c2 & 3));
    }
    printf("score: %d\n",score1);
    printf("score: %d\n",score2);
}