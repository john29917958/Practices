#include <iostream>
#include <string>

void swap(int index_1, int index_2, int arr[])
{
    int numCache = arr[index_1];
    arr[index_1] = arr[index_2];
    arr[index_2] = numCache;
}

void sort(int arr[], int size)
{
    bool is_sorted_this_round = false;

    do
    {
        is_sorted_this_round = false;

        for (int i = 0; i < size - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                swap(i, i + 1, arr);
                is_sorted_this_round = true;
            }
        }
    } while (is_sorted_this_round);
}

void print_array(int arr[], int size)
{
    std::string message = "Array: [";
    if (size > 0)
    {
        message += std::to_string(arr[0]);
        for (int i = 1; i < size; i++)
        {
            message += ", " + std::to_string(arr[i]);
        }
    }
    message += "]";
    std::cout << message;
}

int main(int argc, char argv[])
{
    std::cout << "Welcome to a bubble sort program." << std::endl;
    int arr[] = {6, 1, 5, 2, 4, 3};
    int arr_size = sizeof(arr) / sizeof(arr[0]);
    std::cout << "Prints array before sort." << std::endl;
    print_array(arr, arr_size);
    std::cout << std::endl;
    sort(arr, arr_size);
    std::cout << "Prints array after sort." << std::endl;
    print_array(arr, arr_size);

    return 0;
}