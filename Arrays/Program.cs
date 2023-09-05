
//string[] names = new string[] { "Nurane", "Reyhan", "Xumar" };

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



/*
 * A. Big-O, Flowchart, Pseudocode
    1. Bir integer array və bir integer dəyəri (limit adlı) parametr olaraq qəbul edən funskiya yaradın.
    2. Funksiya arrayin içində olan ədədlərdən limit'dən yüksək olanlarını seçib yeni bir arraya doldurmalı və yeni arrayi ekrana yazdırmalıdır.
    Example:
    func( [ 1, 2, -5, 8, -3, 9 , -7 ], 4) print [8, 9]
    func( [ -7, -3, 2, -8, 5 , -4 ], -4)  then print [-3, 2, 5]
 */

//int[] FindOverLimit(int[] numbers, int limit)
//{
//    int count = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > limit)
//        {
//            count++;
//        }
//    }

//    int[] filteredNumbers = new int[count];
//    int lastIndex = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > limit)
//        {
//            filteredNumbers[lastIndex] = numbers[i];
//            lastIndex++;
//        }
//    }
//    return filteredNumbers;
//}

//int[] result =  FindOverLimit(new int[]{1, 2, -5, 8, -3, 9, -7}, 4);

//foreach (int value in result)
//{
//    Console.WriteLine(value);
//}


//B.Big - O, Flowchart, Pseudocode
//1. Bir integer return edən funskiya yaradın. Funksiya parametr olaraq bir integer array və bir integer dəyər alır.
//2. Funksiya girilən integer dəyərdən arrayin içində neçə ədəd olduğunu return eləsin.
//Example:
//func(new[] { 1, 5, 8, 5, 3, 9 }, 5) => 2
//func(new[] { 7, 7, 9, 8, 5, 4, 7 }, 7) => 3

//int CountValueInArray(int[] numbers, int value)
//{
//    int count = 0;
//    foreach(int num in numbers)
//    {
//        if(num == value)
//        {
//            count++;
//        }
//    }
//    return count;
//}



//C.Big - O
//1.Bir array return edən funksiya yaradın. Funksiya parametr olaraq array alır.
//2. Funksiya girilən arraydəki elementlərin yerini bir sonrakı ilə(əgər varsa) dəyişib arrayi return eləməlidir.
//Example:
//func([1, 2, 3, 4, 5, 6, 7]) => [2, 1, 4, 3, 6, 5, 7]
//func([4, 8, 12, 3 ]) => [8, 4, 3, 12]


//int[] SwapNeighboors(int[] numbers)
//{

//    for(int i = 0; i<numbers.Length-1; i += 2)
//    {
//        int temp = numbers[i];
//        numbers[i] = numbers[i + 1];
//        numbers[i + 1] = temp;
//    }

//    return numbers;
//}

//int[] result =  SwapNeighboors(new int[] { 2, 5, 4, 7, 11,13 });

//foreach(var value in result)
//{
//    Console.WriteLine(value);
//}

string[] array = {"hello", "World",
                "Geeks", "are", "here" };

// Using Join method
// Here separator used is '/'( slash )
string s1 = string.Join("-", array);

Console.WriteLine(s1);
