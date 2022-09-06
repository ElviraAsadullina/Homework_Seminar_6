void FillandPrintArray (int[] array)
{
    Console.WriteLine("Полученный массив: ");
    int N = array.Length;
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 101);
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Введите число элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[N];
FillandPrintArray(nums);
int sum = 0;
int i = 0;
int j = N - 1;
while(i < j)
{
    sum += nums[i] * nums[j];
    i++;
    j--;
}
Console.WriteLine ($"Сумма произведений парных элементов массива = {sum}");