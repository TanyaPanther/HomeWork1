Console.Clear();
int a, b, c;
 
Console.WriteLine("Введите три числа : ");
 
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
 
int max = a;
if (b > max) 
{
    Console.WriteLine("{0} наибольшее число", b);  
}   
if(c > max)
{   
    Console.WriteLine("{0} наибольшее число ", c);   
}   

Console.WriteLine(max);