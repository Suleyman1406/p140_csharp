//using System.Text;
//int a = 12;
//int b = a;
//a = 15;

//Console.WriteLine(b);

//int[] numbers = { 1, 2, 3 };
//int[] values = numbers;
//numbers[0] = 15;

//Console.WriteLine(values[0]);



//int a = 18;
//int b = a;

//a = 14;

//Console.WriteLine(b);

//int[] numbers = { 7, 6, 2 };
//int[] value = numbers;

//numbers[0] = 11;

//Console.WriteLine(value[0]);


//void Any(int number)
//{
//    number = 15;
//}

//int test = 11;

//Any(test);

//Console.WriteLine(test);

//void Any(int[] numbers)
//{
//    numbers[0] = 17;
//}

//int[] values = { 1, 2, 3 };

//Any(values);

//Console.WriteLine(values[0]);


//string a = "asd";
//string b = a;

//a = "test";

//Console.WriteLine(b);



// REF & OUT



//void Any(ref int b) 
//{
//    Console.WriteLine(b);
//}

//int a=14;

//Any(ref a);

//Console.WriteLine(a);

//void Any(out int c)
//{

//    c = 14;
//    c += 1;
//}

//int b;

//Any(out b);


//Console.WriteLine(b);

//int a = 12;


//byte c = (byte) a;

//string age = "1s4";

//byte test = Convert.ToByte(age);

//Console.WriteLine(test);



//Console.Write("Adinizi girin: ");
//string name = Console.ReadLine();
//Console.Write("Tevelludunuzu girin: ");
//int birthYear;

//Int32.TryParse(Console.ReadLine(), out birthYear);


//int age = 2023 - birthYear;

//Console.WriteLine($"{name}, {age}");

//int result;

//Int32.TryParse("18", out result);

//Console.WriteLine(result);

//void ReverseStr(string text)
//{
//    string reversedText = "";
//    for(int i = text.Length-1; i>=0; i--)
//    {
//        reversedText += text[i];
//    }

//    Console.WriteLine(reversedText);
//}

//ReverseStr("Hello");


//StringBuilder builder = new StringBuilder();
//builder.Append("h").Append("e").Append("l").AppendLine("lo").Append(" asdas");


//Console.WriteLine(builder);


//void ReverseStr(string text)
//{
//    StringBuilder builder = new StringBuilder();
//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        builder.Append(text[i]);
//    }

//    Console.WriteLine(builder);
//}
//ReverseStr("Hello");


//StringBuilder helloBuilder = new StringBuilder("hello");

//helloBuilder.Insert(1, "12");
//helloBuilder.Remove(3, 1);
//helloBuilder.Replace("l", "t");

//Console.WriteLine(helloBuilder.ToString());


//int a = 5;
//int x = 20; // 15
//int y = 10;
//                                            //            20      10  
//void Calculate(int x, ref int a, ref int b) // t = 5, r = #x, d = #y
//{
//    a = x + b;
//   //#x = 5 + 10 = 15
//}

//Calculate(a, ref x, ref y);

//Console.WriteLine(x+y);