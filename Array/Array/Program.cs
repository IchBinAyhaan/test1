﻿//1


//int[] numbers = { 11, 12, 13, 14, 15 };
//for (int i = 0; i < numbers.Length; i++) 
//{
//    Console.WriteLine(numbers[i]);
//}


//2

//int[] numbers = {10,20,30,40,50 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);

//3


//int[] numbers = { 10, 20, 30, 40, 50 };
//for (int i = 4; i < numbers.Length; i--)
//{
//    Console.WriteLine(numbers[i]);
//}

//4

//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Enter the number {0}", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//for (int j = 0; j < numbers.Length / 2; j++)
//{
//    int temp = numbers[j];
//    numbers[j] = numbers[numbers.Length - 1 - j];
//    numbers[numbers.Length - 1 - j] = temp;
//}
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.WriteLine(numbers[k] + " ");
//}

//5


//int[] numbers = { 25, 11, 7, 75, 56 };
//int max = numbers[0];
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//        max = numbers[i];
//}
//Console.WriteLine("Arraydaki en boyuk element: " + max);  



//6

//int[] numbers = {21,14,43,57};
//int count = 0;
//for (int i = 0;i<numbers.Length;i++)
//{
//    count++;
//}
//Console.WriteLine($"Numbersda ededlerin sayi: {count}");


//7

//int[] numbers = { 35, 64, 28, 94, 56, 81 };
//int n = 5, i, j, deyer;
//Console.WriteLine("Insertion Sort");
//Console.Write("Initial array is: ");
//for (i = 0; i < n; i++)
//{
//    Console.Write(numbers[i] + " ");
//}
//for (i = 1; i < n; i++)
//{
//    deyer = numbers[i];
//    j = i - 1;
//    while (j >= 0 && numbers[j] > deyer)
//    {
//        numbers[j + 1] = numbers[j];
//        j = j - 1;
//    }
//    numbers[j + 1] = deyer;
//}
//Console.Write("Sorted Array is: ");
//for (i = 0; i < n; i++)
//{
//    Console.Write(numbers[i] + " ");
//}




//8

//int[] numbers = { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 };
//int sifirSayisi = 0;
//foreach (int i in numbers)
//{
//    if (i == 0)
//    {
//        sifirSayisi++;
//    }
//}

//Console.WriteLine("Numbersda 0 sayı: " + sifirSayisi);


//9


//int[] numbers = { 6, -4, 11, 3, -8, 33, -15 };
//int menfiededsayi = 0;
//foreach (int i in numbers)
//{
//    if (i < 0)
//    {
//        menfiededsayi++;
//    }
//}

//Console.WriteLine("Numbersda menfi eded sayı: " + menfiededsayi);


//10



//int[] numbers = { 6, -4, 11, 3, -8, 33, -15 };
//int sum = 0;
//foreach (int i in numbers)
//{
//    if (i > 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("Numbersda musbet ededlerin cemi: " + sum);


//11


//int[] numbers = { 8, 13, 6, 22, 16, };
//int kvadrat = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    kvadrat = numbers[i] * numbers[i];
//    Console.WriteLine(kvadrat);
//}  


//12


//int[] numbers = { 4, 2, 7, 1, 9 };

//Array.Sort(numbers);

//Console.WriteLine("Sıralanmis ededler:");
//foreach (int number in numbers)
//{
//    Console.Write(number + " ");
//}

