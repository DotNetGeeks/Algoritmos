namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { -9, -100, 77, 1, 2, 3, 4, 5, 100, 90, 1, 0 };
            Console.WriteLine("--- Datos sin Ordenar ---");
            PrintArray(datos);
            Console.WriteLine("--- Datos Ordenados ---");
            QuickSortAlgorithm(datos, 0, datos.Length -1);
            PrintArray(datos);
        }

        static void QuickSortAlgorithm(int[] datos, int menor, int mayor)
        {
            if(menor < mayor)
            {
                int pivote = Partition(datos, menor, mayor);
                QuickSortAlgorithm(datos, menor, pivote - 1);
                QuickSortAlgorithm(datos, pivote + 1, mayor);
            }
        }

        static int Partition(int[] datos, int menor, int mayor)
        {
            int pivote = datos[mayor];
            int i = menor - 1;

            for(int j = menor; j < mayor; j++)
            {
                if (datos[j] < pivote)
                {
                    i++;
                    Swap(datos, i, j);
                }
            }

            Swap(datos, i + 1, mayor);

            return i + 1;
        }

        static void Swap(int[] datos, int i, int j)
        {
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;
        }

        static void PrintArray(int[] datos)
        {
            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }
        }
    }
}