#include "stdio.h"

void sortArray(int *arrayToSort, int arrayLength)
{
    int isAnySortingThisRound = 0;

    do
    {
        isAnySortingThisRound = 0;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            int currentIndex = i;
            int nextIndex = i + 1;

            if (arrayToSort[currentIndex] > arrayToSort[nextIndex])
            {
                isAnySortingThisRound = 1;
                int tempNextElemValOfCurr = arrayToSort[nextIndex];
                arrayToSort[nextIndex] = arrayToSort[currentIndex];
                arrayToSort[currentIndex] = tempNextElemValOfCurr;
            }
        }
    } while (isAnySortingThisRound == 1);
}

int main(int argc, char argv[])
{
    int array[] = {2, 7, 3, 8};
    int arraySize = sizeof(array) / sizeof(array[0]);
    sortArray(array, arraySize);
    for (int i = 0; i < arraySize; i++)
    {
        printf("%d", array[i]);
    }
    printf("\n");

    return 0;
}
