namespace InsertionSort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 20, 400, 605, -5, 0, 100, 100000, 77 };

            Console.WriteLine("----- Datos sin ordenar ------");
            printArray(data);

            Console.WriteLine("----- Datos ordenados ------");
            InsertionSort(data);
            printArray(data);
        }

        static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int key = data[i];
                int j = i - 1;
                while (j >= 0 && data[j] > key) 
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }

                data[j + 1] = key;
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