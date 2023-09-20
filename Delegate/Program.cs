//int[] numbers = new[] { 3, 7, 9, 21, 17, 2, 18, 9 };


//Console.WriteLine(Count(numbers, IsOdd));
//Console.WriteLine(Count(numbers, IsEven));
//Console.WriteLine(Count(numbers, IsGreaterThanTen));

//int Count(int[] nums, Check func)
//{
//    int count = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (func(nums[i]))
//        {
//            count++;
//        }
//    }
//    return count;
//}


//bool IsOdd(int value)
//{
//    return value % 2 == 1;
//}

//bool IsEven(int value)
//{
//    return value % 2 == 0;
//}

//bool IsGreaterThanTen(int value)
//{
//    return value > 10;
//}

//delegate bool Check(int val);

//Test(PrintUserInfo);
//Test(PrintCustomerInfo);

//void Test(Print f)
//{
//    f("Suleymna","asd",122);
//}

//void PrintUserInfo(string n, string s, int a)
//{
//    Console.WriteLine($"{n}, {s}, {a}");
//}

//void PrintCustomerInfo(string n, string s, int a)
//{
//    Console.WriteLine($"Customer: {n}, {s}, {a}");
//}

//delegate void Print(string name, string surname, int age);


// bu methodumuz gonderilen methodu cagiraraq elimdeki arrayi filter edib ekrana yazdirir.

//int[] nums = { 3, 9, 2, 7, 6, 4, 99, 63, 27, 17, 33 };
//PrintFilteredArr(nums, FilterByOdd);


//void PrintFilteredArr(int[] numbers,Filter filterFunc ) { 
//    int[] filteredNums = filterFunc(numbers);
//    foreach(int num in filteredNums)
//    {
//        Console.WriteLine(num);
//    }
//}

//int[] FilterByOdd(int[] ints)
//{
//    List<int> nums = new List<int>();

//    for(int i = 0; i < ints.Length; i++)
//    {
//        if (ints[i] % 2 == 1)
//        {
//            nums.Add(ints[i]);
//        }
//    }

//    return nums.ToArray();
//}

//delegate int[] Filter(int[] nums);





// Lambda expression (arrow function)

//Help herhansi = Test;

////Console.WriteLine(herhansi(18));

//int Test(int t)
//{
//    return t * 2;
//}

//delegate int Help(int num);


//Help meth = (r) => r + 1;

//Console.WriteLine(meth(20));

//delegate int Help(int t);


//Check check = (a, b) => a > b;

//Console.WriteLine(check(3,9));

//delegate bool Check(int a, int b);

//Hello hello = (n) => "hello " + n;

//Console.WriteLine(hello("suleyman"));
//Console.WriteLine(hello("xumar"));

//delegate string Hello(string name);




int[] numbers = new[] { 3, 7, 9, 21, 17, 2, 18, 9 };


//int c =  Count(numbers, (v) => v % 2 == 0);
//Console.WriteLine(c);

//int d = Count(numbers, (t) => t > 0);
//Console.WriteLine(d);

//int Count(int[] nums, Check func)
//{
//    int count = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (func(nums[i]))
//        {
//            count++;
//        }
//    }
//    return count;
//}



//delegate bool Check(int val);



//Help help = (t, r) => t + r;

//Console.WriteLine(help("asd",11));


//delegate string Help(string a, int b);



//int a = c+d=>a;


//Test test = (a, c, d) => a < c || c > d;


//Console.WriteLine(test(4, 5, 9));

//delegate bool Test(int a, int c, int d);



//Test test = (y, t, b) => {


//    return y + t + b + "alo";
//};

//Console.WriteLine(test(1, 2, 3));

//delegate string Test(int a, int b, int c);


//Test t = (t, y) =>
//{
//    t *= 8;
//    y -= 2;
//    Console.WriteLine(t + y);
//};

//t(5, 8);

//delegate void Test(int a, int b);



//Test e = () =>
//{
//    Console.WriteLine("Hello ");
//};

//e();

//delegate void Test();


Test test = a =>
{
    Console.WriteLine(a + 1);
};

test(12);
delegate void Test(int a);
