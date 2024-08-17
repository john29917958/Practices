#include "stdio.h"

void swap(int index_1, int index_2, int arr[])
{
    int num_cache = arr[index_1];
    arr[index_1] = arr[index_2];
    arr[index_2] = num_cache;
}

void sort(int arr[], int size)
{
    int is_sorted_this_round = 0;

    do
    {
        is_sorted_this_round = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                swap(i, i + 1, arr);
                is_sorted_this_round = 1;
            }
        }
    } while (is_sorted_this_round == 1);
}

void print_arr(int arr[], int size)
{
    printf("[");
    if (size > 0)
    {
        printf("%d", arr[0]);
        for (int i = 1; i < size; i++)
        {
            printf(", %d", arr[i]);
        }
    }
    printf("]");
}

int main(int argc, char **argv)
{
    printf("Bubble sort program starts!\n");
    int arr[] = {6, 1, 5, 2, 4, 3};
    int size = sizeof(arr) / sizeof(arr[0]);
    printf("Array before sort: ");
    print_arr(arr, size);
    printf("\n");
    sort(arr, size);
    printf("Array after sort: ");
    print_arr(arr, size);

    return 0;
}
