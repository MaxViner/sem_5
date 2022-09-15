Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());

Double [] FillArray(int n)
{
Double[] array = new Double[n];
for(int i = 0;i<n;i++) 
{
    array[i] = Math.Round((new Random().NextDouble())*(new Random().Next(-100,100)),4);
    Console.Write(array[i]+", ");
}
return array;
}
Double [] Max_unt_min ( Double[] array )
{
    Double[] Min_Max_rez = new Double[3];
    Min_Max_rez[0]=-100;
    Min_Max_rez[1]=100;
    for(int i = 0;i<n;i+=1)
     {
        if (array[i]>Min_Max_rez[0]) Min_Max_rez[0] = array[i];
        else if (array[i]<Min_Max_rez[1]) Min_Max_rez[1] = array[i];
     }
     Min_Max_rez[2]=Min_Max_rez[0]-Min_Max_rez[1];
return Min_Max_rez;
}

try{
Double[] result = new Double[3];
Double[] array = FillArray(n);
Console.WriteLine();
result= Max_unt_min(array);
Console.WriteLine("разность между максимальны "+result[0]+" и минимальным "+result[1]+" элементами массива равна = "+ result[2]);
}
catch
{
    Console.WriteLine("ohh... something wrong");
}
