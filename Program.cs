// See https://aka.ms/new-console-template for more information

int a, x;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

x = a % 2;

//Console.Write(x);

if(x == 1 | x == -1){
    Console.Write("Число не является четным и делится на 2 с остатком");    
}else
{
    Console.Write("Число является четным и делится на 2 без остатка");    
}