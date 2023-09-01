//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int a = 12;
//bool isPrime = true;

//for(int i = 2; i < a; i++)
//{
//    if (a % i == 0)
//    {
//        isPrime = false;
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine("Sadedir");
//}
//else
//{
//    Console.WriteLine("Murekkebdir");
//}


//int b = 23;

//isPrime = true;

//for (int i = 2; i < b; i++)
//{
//    if (b% i == 0)
//    {
//        isPrime = false;
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine("Sadedir");
//}
//else
//{
//    Console.WriteLine("Murekkebdir");
//}


//Hello();
//Console.WriteLine("Bitti");


//void Hello()
//{
//    Console.WriteLine("Hello World");
//}

//void PrintSomething()
//{
//    int a = 12;
//    int b = 13;

//    Console.WriteLine(a+b);
//}


//PrintSomething();
//PrintSomething();
//PrintSomething();


// f(n) = n + 1
// f(1) = 2
// f(2) = 3
// f(5) = 6





//void PrintHelloToSomeone(string name) // name = "Huseynova"
//{
//    Console.WriteLine("Hello " + name);
//    //Console.WriteLine("Hello");
//}


//PrintHelloToSomeone("Suleyman");
//PrintHelloToSomeone("Elnur");
//PrintHelloToSomeone("Huseynova");

//void CalculateSum(int a, int b)
//{
//    if(a>7 && b > 20)
//    {
//        Console.WriteLine(a + b);
//    }
//}

//CalculateSum(4,5);
//CalculateSum(6, 11);
//CalculateSum(8, 22);

//void PrintPersonInfo(string name, int age, double weight, bool isNew)
//{
//    Console.WriteLine("Name " + name + ", Age " + age +", Weight " +weight +", Is New " + isNew);
//}



//PrintPersonInfo("Reyhan", 13, 0, false);
//PrintPersonInfo("Nurane Python", 12, 0.1, true);

//Console.WriteLine();



//void CalculateSum(int a, int b)
//{
//    Console.WriteLine(a + b);
//}

//int result =  CalculateSum(2, 3);

//int CalculateSum(int a, int b)
//{
//    return a + b;
//}

//int result2 = 112 + 5; 


//Console.WriteLine(result2);


//bool IsPrime(int number)
//{
//    bool isPrime = true;

//    for(int i = 2; i < number; i++)
//    {
//        if (number % 2 == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    return isPrime;
//}



//Console.WriteLine(IsPrime(18));
//Console.WriteLine(IsPrime(22));
//Console.WriteLine(IsPrime(13));


//void DoSomething(int[] a) //  a = { 1, 2, 3, 4 }
//{
//    for (int i = 0; i < a.Length; i++)
//    {
//        Console.WriteLine(a[i]);
//    }
//}


//int[] numbers = { 1, 2, 3, 4 };

//DoSomething(numbers);



//int FindMaxInArray(int[] numbers)
//{
//    int max = numbers[0];

//    for (int i = 1; i < numbers.Length; i++)
//    {
//        if (numbers[i] > max)
//        {
//            max = numbers[i];
//        }
//    }

//    return max;
//}

//Console.WriteLine(FindMaxInArray(new int[] { 3,12,2,1,-2200 }));
//Console.WriteLine(FindMaxInArray(new int[] { 3, 12, 2, 122, -2200 }));
//Console.WriteLine(FindMaxInArray(new int[] { 3, 12, 2000, 1, -2200 }));





//void PrintHelloToSomeone(string name, int age)
//{
//    if(age < 18)
//    {
//        return;
//    }
//    Console.WriteLine(name + age);
//}

//PrintHelloToSomeone("Suleymna", 29);

//int FindMax(int a, int b, int c)
//{
//    if (a > b && a>c)
//    {
//        return a;
//    }else if (b > c && b>a)
//    {
//        return b;
//    }

//    return c;
//}


//Console.WriteLine(FindMax(22,1,2));

//void PrintHello (string name = "anyone", int age = 10)
//{
//    Console.WriteLine(name +" "+ age);
//}

//PrintHello();

//Console.WriteLine("asdsdasd".Length);

//int FindPrimeMax(int[] numbers)
//{
//    int max = numbers[0];

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (max % 2 == 0)
//        {
//            max = numbers[i];
//        }
//        if (numbers[i] > max && numbers[i] % 2 == 1)
//        {
//            max = numbers[i];
//        }
//    }
//    return max;
//}

//Console.WriteLine(FindPrimeMax(new int[] { 2, 1, 6, 8, 10 }));


string FindLongStr(string[] strings)
{
    string max = strings[0];

    for(int i =1; i < strings.Length; i++)
    {
        if (strings[i].Length > max.Length)
        {
            max = strings[i];
        }
    }

    return max;
}

Console.WriteLine(FindLongStr(new string[] {"a","bb","cc","ddd","e"}));