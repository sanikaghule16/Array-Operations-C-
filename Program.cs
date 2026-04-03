using System;
class SortArray
{
static void Main()
{
Console.Write("Enter number of elements: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++) { Console.Write($"a[{i}]: "); a[i] =
int.Parse(Console.ReadLine()); }
Array.Sort(a);
Console.WriteLine("Ascending: " + string.Join(" ", a));
Array.Reverse(a);
Console.WriteLine("Descending: " + string.Join(" ", a));
}
}
