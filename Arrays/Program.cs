
string[] names = new string[] { "Nurane", "Reyhan", "Xumar" };

//for(int i = 0; i < names.Length; i++)
//{
//    Console.Write(names[i] +" ");
//}


//foreach(string name in names)
//{
//    Console.Write(name +" ");
//}



//int[] numbers = { 4, 8, 12 };

//Array.Resize(ref numbers, 2);


//Console.WriteLine(numbers[2]);


//int[] FilterArr(int[] numbers)
//{
//    int[] filteredArr = new int[0];

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i]%3==0 || numbers[i] % 5 == 0)
//        {
//            Array.Resize(ref filteredArr, filteredArr.Length + 1);
//            filteredArr[filteredArr.Length - 1] = numbers[i];
//        }
//    }
//    return filteredArr;
//}

//int[] result = FilterArr(new int[] { 4, 9, 3, 2, 1, 7, 5, 15 });

//foreach(int value in result)
//{
//    Console.WriteLine(value);
//}

//int[] numbers = { 1, 2, 3, 4, 5, 9, 6 };

//Array.Reverse(numbers);

//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}

//void ReverseArr(int[] numbers)
//{
//    int[] reversedNumbers = new int[numbers.Length];

//    for(int i = 0; i < numbers.Length; i++)
//    {
//        reversedNumbers[reversedNumbers.Length - 1 - i] = numbers[i];
//    }
//}

//ReverseArr(new int[] { 4, 8, 12, 16 });

//int[] ReverseArr(int[] numbers)
//{
//    for(int i =0 ; i < numbers.Length/2; i++)
//    {
//        int temp = numbers[i];
//        numbers[i] = numbers[numbers.Length - 1 - i];
//        numbers[numbers.Length - 1 - i] = temp;
//    }

//    return numbers;
//}

//int[] result = ReverseArr(new int[] { 4, 8, 5,12, 16 });

//foreach(int value in result)
//{
//    Console.WriteLine(value);
//}


//int[] numbers = { 7, 2, 8, 12, 99, 11 };


//Array.Sort(numbers);

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Array.Clear(numbers);
//Console.WriteLine(numbers[0]);

