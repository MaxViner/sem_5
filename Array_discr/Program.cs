Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());

int [] FillArray(int n)
{
int[] array = new int[n];
for(int i = 0;i<n;i++) 
{
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i]+", ");
}
return array;
}
int [] Array_Discription ( int[] array )
{
    int[] Descriotion = new int[6];
    Descriotion[0]=0;
    Descriotion[1]=0;
    for(int i = 1;i<n;i+=1)
     {
        if (array[i]>array[Descriotion[0]]) Descriotion[0] = i;
        else if (array[i]<array[Descriotion[2]]) Descriotion[2] = i;
        Descriotion[4]+=array[i];
     }
     Descriotion[4]= Descriotion[4]/n;
     Descriotion[1]=array[Descriotion[0]];
     Descriotion[3]=array[Descriotion[2]];
     if (n%2==0) Descriotion[5] = (array[n/2]+array[n/2-1])/2;
     else  Descriotion[5] = (array[n/2]);
return Descriotion;
}

try{
int[] result = new int[6];
int[] array = FillArray(n);
Console.WriteLine();
result= Array_Discription(array);
Console.WriteLine("максимальный элемент "+result[1]+" с индексом "+result[0]
                    +", минимальный элемент = "+ result[3]+" с индексом "+result[2]);
Console.WriteLine("среднее арифметическое всех элементов "+result[4]+", медианное значение "+result[5]);
}
catch
{
    Console.WriteLine("ohh... something wrong");
}
