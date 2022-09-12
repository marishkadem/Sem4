/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] GetArray(){
    int[] result = new int[8];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}
void PrintArray(int[]arr) {
    
    for(int i = 0; i <= 7; i++)
    {
        switch (i){
            case 0:
                System.Console.Write($"[{arr[i]}, ");
            break;

            case 7:
                System.Console.Write($"{arr[i]}]");
            break;

            default:
                System.Console.Write($"{arr[i]}, ");
            break;

        //System.Console.Write(arr[i]);
        }
    }
}
PrintArray(GetArray());