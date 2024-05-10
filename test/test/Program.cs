//0
//Console.WriteLine("Bir eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number == 0)
//{
//    Console.WriteLine("Daxil edilen eded ne musbetdir ne de tek");
//}

//else if (number > 0)
//{
//    Console.WriteLine("Daxil edilen eded musbetdir");
//}
//else
//{
//    Console.WriteLine("Daxil edilen eded menfidir");
//}

//1
//int sum = 0;
//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//sum += number1;
//Console.WriteLine("2-ci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//sum += number2;
//Console.WriteLine("3-ci ededi daxil et");
//int number3 = Convert.ToInt32(Console.ReadLine());
//sum += number3;
//Console.WriteLine("4-ci ededi daxil et");
//int number4 = Convert.ToInt32(Console.ReadLine());
//sum += number4;
//Console.WriteLine("5-ci ededi daxil et");
//int number5 = Convert.ToInt32(Console.ReadLine());
//sum += number5;
//Console.WriteLine(sum);

//2
//Console.WriteLine("Bir eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//int max = number * number;
//Console.WriteLine(max); 

//3
//Console.WriteLine("Birinci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ikinci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ucuncu ededi daxil et");
//int number3 = Convert.ToInt32(Console.ReadLine());
//int max = number1;
//if(number1>max)
//{
//    max = number2;
//}
//if (number3> max)
//{
//    max = number3;
//}
//Console.WriteLine(max);

//4
//Console.WriteLine("Birinci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ikinci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int max = number1 * number1 * number1;
//if (max > number2)
//{
//    Console.WriteLine("number1 boyukdur");
//}
//else
//{
//    Console.WriteLine("number2  boyukdur");
//}


//5
//Console.WriteLine("Bir eded daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//if (number1 % 3 == 0 && number1 % 5 == 0)
//{
//    Console.WriteLine("number1 hem 3 hem de 5 bolunur");
//}
//else
//{
//    Console.WriteLine("number1 hem 3 hem de 5 bolunmur");
//}


//6
//Console.WriteLine("Kartdaki meblegi daxil edin");
//int kart = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Mehsulun meblegini daxil edin");
//int mehsul = Convert.ToInt32(Console.ReadLine());
//if (kart >= mehsul)
//{
//    Console.WriteLine("Kartdaki mebleg mehsulu almaga yeterlidi");
//}
//else
//{
//    Console.WriteLine("Kartdaki mebleg mehsulu almaga yeterli deyil");
//}


//7
//int avg, fenn1, fenn2, fenn3, fenn4, fenn5;
//do
//{
//    Console.WriteLine("Enter the point of exams");
//    Console.WriteLine("1-ci fenden alinan bal:");
//    fenn1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("2-ci fenden alinan bal:");
//    fenn2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("3-ci fenden alinan bal:");
//    fenn3 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("4-ci fenden alinan bal:");
//    fenn4 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("5-ci fenden alinan bal:");
//    fenn5 = Convert.ToInt32(Console.ReadLine());
//}
//while ((fenn1 < 0 || fenn2 < 0 || fenn3 < 0 || fenn4 < 0 || fenn5 < 0) || (fenn1 > 100 || fenn2 > 100 || fenn3 > 100 || fenn4 > 100 || fenn5 > 100));
//avg = (fenn1 + fenn2 + fenn3 + fenn4 + fenn5) / 5;
//if (avg > 65)
//    Console.WriteLine(avg + " Passed");
//else Console.WriteLine(avg + " Not passed");


//8




//Console.WriteLine("Birinci ededi daxil edil");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ikinci ededi daxil edin");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 > number2)
//{
//    Console.WriteLine("Birinci eded ikinci ededden boyukdur");
//}

//else
//{
//    Console.WriteLine("Ikinci eded birinceden boyukdur");
//}

//9


//Console.WriteLine("Temperaturu daxil edin");
//int temp = Convert.ToInt32(Console.ReadLine());
//if (temp < 0)
//{
//    Console.WriteLine("Temperatur suyun donma temperaturundan asagidir");
//}
//else
//{
//    Console.WriteLine("Temperatun suyun donma temperaturunda yuxaridir");
//}


//------------------------------------------------------------------------------------------------------


//1



//Console.WriteLine("Ededler");
//int n = 50;
//for (int i = 1; i <= n; i++) 
//{
//    Console.WriteLine(i);
//}

//2


//Console.WriteLine("Ededler");
//int n = 40;
//int count = 0;
//for (int i = 1; i <= n; i++) 
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine("40-a qeder 3-e bolunen ededlerin sayi:" + count);

//3




//Console.WriteLine("Hem 3 hem de 7 bolunen ededler");
//int n = 100;
//for (int i= 1;i<=n;i++)
//{
//    if (i%3==0 && i%7==0)
//    {
//        Console.WriteLine(i);
//    }
//}


//4
//static int CountDigits(int number);
//{
//    int count = 0;
//    int n = 0;
//    while (n != 0)
//    {
//        n = n / 10;
//        count++;
//    }
//    return count;
//}
//int number = 12345;
//int digitCount = CountDigits(number);
//Console.WriteLine("Ədədin rəqəmlərinin sayı: " + digitCount);


//5


//int num = 12345;
//int reversedNum = ReverseNumber(num);
//Console.WriteLine("Ədədin tərsi: " + reversedNum);

//    static int ReverseNumber(int number)
//{
//    int reversedNumber = 0;
//    while (number != 0)
//    {
//        int digit = number % 10;
//        reversedNumber = (reversedNumber * 10) + digit;  
//        number /= 10;
//    }
//    return reversedNumber;
//}

//6

//int f = 1;
//int number;
//Console.Write("Bir eded daxil edin: ");
//number = int.Parse(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    f *= i;
//}
//Console.Write(number + " ededinin faktorialı: " + f);

//7


//int n = Convert.ToInt32(Console.ReadLine());
//int squareroot = Convert.ToInt32(Math.Sqrt(n));
//bool isprimitive = true;
//for (int i = 2; i <= squareroot; i++)
//{
//    if (n % i == 0)
//    {
//        isprimitive = false;
//        break;
//    }
//}
//if (isprimitive)
//{
//    Console.WriteLine("Sade");
//}
//else
//{
//    Console.WriteLine("Murekkeb");
//}


//8


//int n, sum = 0, m;
//Console.Write("Eded daxil edin: ");
//n = int.Parse(Console.ReadLine());
//while (n > 0)
//{
//    m = n % 10;
//    sum = sum + m;
//    n = n / 10;
//}
//Console.Write("Sum = " + sum);


//9

//Console.WriteLine("ededi daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());

//int max = 0;
//while (num > 0)
//{
//    int reqem = num % 10;
//    if (reqem > max)
//    {
//        max = reqem;
//    }
//    num /= 10;
//}
//Console.WriteLine("ededin en boyuk reqemi: " + max);


//10



//Console.WriteLine("70-den kiçik cüt ededler");
//for (int i = 70; i > 0; i--)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//11

//Console.WriteLine("Ayi daxil edin");
//int ay = Convert.ToInt32(Console.ReadLine());
//switch (ay)
//{
//    case 1:
//        Console.WriteLine("Qis");
//        break;
//    case 2:
//        Console.WriteLine("Yaz");
//        break;
//    case 3:
//        Console.WriteLine("Yay");
//        break;
//    case 4:
//        Console.WriteLine("Payiz");
//        break;
//}


//11


//int rows = 5;
//int columns = 5;
//for (int i = 1; i <= rows; i++)
//{
//    for (int n = 1; n <= columns; n++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//12


//int rows = 10;

//for (int i = 1; i <= rows; i++)
//{
//    for (int n= 1; n <= i; n++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//13


//int rows = 10; 
//for (int i = rows; i >= 1; i--)
//{
//    for (int n = 1; n <= i; n++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}