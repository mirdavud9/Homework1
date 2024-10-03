#region Task1:Verilmish 2 mertebeli ededin en boyuk reqemini tap

//Console.WriteLine("Her hansisa iki reqemli eded daxil edin:");
//int num = Convert.ToInt32(Console.ReadLine());

//int tens = num/10;   
//int ones = num%10;

//int maxDigit;
//if (tens > ones)
//{
//    maxDigit = tens;
//}
//else
//{
//    maxDigit = ones;

//}

//Console.WriteLine("En boyuk reqem: " + maxDigit);
#endregion
#region Task2:Verilmish ededin sade ve ya murekkeb oldugunu tap
//Console.WriteLine("Eded daxil edin:");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number <= 1)
//{
//    Console.WriteLine("Bu ne sadedir ne de murekkeb");
//    return;
//}

//bool isPrime = true;
//for (int i = 2; i < number; i++)
//{
//    if (number % i == 0)
//    {
//        isPrime = false;
//    }
//}

//string result;
//if (isPrime)
//{
//    result = "sade eded";
//}
//else
//{
//    result = "murekkeb eded";
//}
//Console.WriteLine(number + " " + result);
#endregion
#region Task3:Verilmish ededin 2nin quvveti olub olmadigini tap


Console.Write("Ededi daxil edin:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine(number + "bu eded 2nin quvveti deyil");
}
else
{
    while (number % 2 == 0)
    {
        number /= 2;
    }

    if (number == 1)
    {
        Console.WriteLine("2nin quvvetidir");
    }
    else
    {
        Console.WriteLine("2nin quvveti deyil");
    }
}
#endregion