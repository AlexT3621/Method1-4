// Найти позицию минимального элемента в несортированной части массива
// Произвести обмен этого значения со значением первой несортиоанной позиции
// Повторять пока есть неотсортированные элементы

int[] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray(int[] array) // метод печати массива
{
    int count = array.Length;
    for(int i = 0; i<count; i++)
    {
        Console.Write(array[i]);
    }
}
Console.WriteLine();
void Sort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for(int j = i +1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

                int temp = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temp;  
                      
    }           
    
}

PrintArray(arr);
Sort(arr);
Console.WriteLine();
PrintArray(arr);
    