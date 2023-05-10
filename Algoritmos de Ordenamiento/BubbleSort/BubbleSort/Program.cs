namespace BubbleSort
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 20, 400, 605, -5, 0, 100, 100000, 77 };

            Console.WriteLine("----- Datos sin ordenar ------");
            printArray(data);

            Console.WriteLine("----- Datos ordenados ------");
            bubbleSort(data);
            printArray(data);
        }

        static void bubbleSort(int[] arr)
        {
            int arrSize = arr.Length;
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tempo = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempo;
                    }
                }
            }
        }

        static void printArray(int[] arr)
        {
            int arrSize = arr.Length;
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine($"Posicion: {i} | Valor: {arr[i]}");
            }
        }
    }
}