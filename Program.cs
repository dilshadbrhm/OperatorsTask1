//1) 3 ədəd verilir ən böyük olanı ekrana çıxaran algorithm yazın.Misal: input a=3, b=15, c=9  output 15

using static System.Runtime.InteropServices.JavaScript.JSType;

int num1 = 3;
int num2 = 12;
int num3 = 9;

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1);
}
else if (num1 < num2 && num3 < num2)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}

//2)Telebenin yekun qiymeti verilir. Əgər qiymət 65-dən kiçikdirsə kəsilib, 65 ile 84 araligindadirsa "Adi Diplom alıb", 85 ile 94 aralığındadırsa "Şərəf Diplomu 
//alıb", 95 ilə 100 aralığındadırsa "Yüksək Şərəf Diplomu 
//alıb"(Bu tələbənin sağ əli sizin başınıza) yazısını ekrana çıxaran algorithm yazın. Misal: input -> grade=97, output -> Yüksək Şərəf Diplomu alıb

int grade = 85;
if (grade >= 95 && grade <= 100)
{
    Console.WriteLine("Yüksək Şərəf Diplomu alıb");
}
else if (grade >= 65 && grade <= 84)
{
    Console.WriteLine("Adi Diplom alıb");
}
else if (grade >= 85 && grade <= 94)
{
    Console.WriteLine("Şərəf Diplomu alıb");
}
else
{
    Console.WriteLine("Kəsilib");
}

//3) 2 mərtəbəli ədəd verilir. Verilmish ədədin mərtəbələri cəmini tapan algorithm(c# -da mərtəbələrin tapılmasını araşdıra bilərsiz). Misal: Input 25, output 7

int num = 25;
int sum = 0;

if (num >= 10 && num <= 99)
{
    int first = num / 10;
    int second = num % 10;

    sum = first + second;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Eded 2 reqemli deyil");
}