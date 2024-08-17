#include "stdio.h"
#include "stdlib.h"

int main(int argc, char **argv)
{
    int height;
    if (argc > 1)
    {
        char *h = argv[1];
        height = atoi(h);
    }
    else
    {
        height = 10;
        printf("Stars height is set to default value 10. If you want to set "
               "stars height, please pass the number as a command line argument.\n");
    }

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            printf("*");
        }
        printf("\n");
    }

    return 0;
}
