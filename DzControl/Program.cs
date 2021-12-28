int[] CreateArray(int count)
{
    return new int[count];
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}
void FillArray(int[] array, int min, int max)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

int[] A = CreateArray(10);
FillArray(A, 1, 10);
Console.WriteLine(PrintArray(A));
Console.WriteLine(); // разделить массивы 
int index = 0;

void FillArrayB(int[] array)
{
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] % 2 == 0)
        {
            array[index] = A[i];
            Console.Write($"{array[index]} ");
            index++;
        }
    }
}

int[] B = CreateArray(A.Length);
FillArrayB(B);
