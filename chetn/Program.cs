Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());

int [] FillArray(int n)
{
int[] array = new int[n];
for(int i = 0;i<n;i++) 
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i]+", ");
}
return array;
}
void Positive_Numbers ( int[] array )
{
    int count = 0;
    for(int i = 0;i<n;i++) if (array[i]%2==0) count+=1;
    Console.Write(count);   
}

int [] array = FillArray(n);
Console.WriteLine("колличество четных элементов: ");
Positive_Numbers(array);


