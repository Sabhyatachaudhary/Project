// See https://aka.ms/new-console-template for more information
namespace Sabh
{
     class ValRefTypes
    {
        public static void Main()
        {
            int i = 100;
            int j;
            j = i;
            Console.WriteLine(j);
            ++i;
            Console.WriteLine(j);
            int[] arr1 = { 1, 2, 3 };
            int[] arr2;
            arr2 = arr1;
            arr1[0]++;
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr1[0]);
        }
    }
}
