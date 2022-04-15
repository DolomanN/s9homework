Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, m];
int temp = 0;
for (int j = 0; j < m-2; j++)
{
    for (int i = 0+j; i < m-j; i++)
{
    array [0+j,i] = temp;
    ++temp;
}
temp--;
for (int i = 0+j; i < m-j; i++)
{
    array [i,m-1-j] = temp;
    ++temp;
}
temp--;
for  (int i = m-1-j; i >= 0+j; i--) 
{
    array [m-1-j,i] = temp;
    ++temp;
}
temp--;
for  (int i = m-1-j; i >= 1+j; i--) 
{
    array [i,0+j] = temp;
    temp++;
   
}
}


for (int f = 0; f < array.GetLength(0); f++)
{
    for (int g = 0; g < array.GetLength(1); g++)
        {
            Console.Write($" {array[f, g]}"+"\t");
        }
        Console.WriteLine();
}