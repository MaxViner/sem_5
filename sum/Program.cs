Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());

float [] FillArray(int n)
{
float[] array = new float[n];
for(int i = 0;i<n;i++) 
{
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i]+", ");
}
return array;
}
float [] Sum_chetn ( float[] array )
{
    float[] sums = new float[2];
    for(int i = 0;i<n;i+=2) sums[0]+=array[i]; 
    for(int i = 1;i<n;i+=2) sums[1]+=array[i]; 
return sums;
}

try{
float[] result = new float[2];
float[] array = FillArray(n);
Console.WriteLine();
Console.WriteLine("сумма элементов на четных позициях: ");
result= Sum_chetn(array);
Console.WriteLine(result[0]);
Console.WriteLine("сумма элементов на нечетных позициях: ");
Console.WriteLine(result[1]);
}
catch
{
    Console.WriteLine("ohh... something wrong");
}
