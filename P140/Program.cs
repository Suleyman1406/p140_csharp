//string name = "xumar";
//Console.WriteLine(name);

//string superName = "any";

//string helloMyNameIs = "asd";

//string test12 = "asd";

//string test_12 = "asd";

//string super_name = "asd";

//string 1test = "asd";

//string $test  = "Asda";

// Console.WriteLine("Hello P140");

// Console.WriteLine("Test");

// Men bu kod bloqunda integrali hesablamisam

// Console.WriteLine("hello");

/*
asd
    asd
    asd

*/

//Console.WriteLine("test");



//Console.WriteLine("asd");


//string name = "suleyman";

//byte age = -2;

//int a = 99007514252;

//int number = 13;

//double weight = 70.9;


//string name = "suleyman";

//char firstCharacterOfName = '*';


//bool isNew = true;
//bool isPrime = false;

//int a = 12;
//int b = 15;
//int c = a + b;
//int d = c - 12;
//Console.WriteLine(c);
//Console.WriteLine(d);

//Console.WriteLine(13 + 4);

//int a = 15;
//int b = 3;

//Console.WriteLine(a / b);


//int c = 14;
//int d = 18;

//Console.WriteLine(c*d);


//int a = 2;
//int b = 6;
//int c = 3;

//Console.WriteLine(a * (b + c));


//int a = 2;
//int b = 5;

//Console.WriteLine(a % b);


//Console.WriteLine(3 > 3);


//int age = 92;

//// { - curly bracket

//if (age < 18) {
//    Console.WriteLine("Giris yoxdur!");
//}
//else if (age > 90)
//{
//    Console.WriteLine("siz deyerli musterisiz ancaq biraz gozlemelisiz!");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Sizi diger sehifeye yonlendiririk!");
//}
//else {
//    Console.WriteLine("Xos geldiniz");
//}


//Console.WriteLine("Program bitti");


//int age = 66;

//if (age < 18)
//{
//    Console.WriteLine("giris yoxdur");
//}else
//{
//    Console.WriteLine("giris var");
//}

//Console.WriteLine(  );

/* && - AND
 * true && true  => true
 * true && false => false
 * false && true => false
 * false && false =>  false
 */

/* || - OR
 * true || true => true
 * true || false => true
 * false || true => true
 * false || false =>  false
 */

//Console.WriteLine(2>3 && 3>5); // False

//Console.WriteLine(2>1 && 1>2); // False

//Console.WriteLine(2>1 && 7>6); // True

//Console.WriteLine(2>1 || 2>8); // True

//Console.WriteLine(2>5 || 3>8); // False



//int age = 27;

//if (age < 18 || age>65)
//{
//    Console.WriteLine("giris yoxdur");
//}
//else
//{
//    Console.WriteLine("giris var");
//}

//string name = "suleyman";

//if(name == "suleyman")
//{
//    Console.WriteLine("giris var!");
//}
//else
//{
//    Console.WriteLine("giris yoxdur!");
//}

//int age = 22;
//string name = "suleyman";

//if( age != 18 || name != "suleyman")
//{
//    Console.WriteLine("giris var");
//}


//int day = 99;

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Bazerertesi");
//        break;
//    case 2:
//        Console.WriteLine("Cersembe axsami");
//        break;
//    case 3:
//        Console.WriteLine("Cersembe");
//        break;
//    case 4:
//        Console.WriteLine("Cume axsami");
//        break;
//    default:
//        Console.WriteLine("ele bir gun yoxdur");
//        break;
//}


//Console.WriteLine(a);

//int N1 = 12;

//Console.WriteLine(asd);
//int asd-asd-asd = 12;


//Console.WriteLine((2>3 && 5<8) || (3>1 && 2>1)); 


//Console.WriteLine("hello world");

//Console.WritLine("hello");


//int a = 12;

//a = true;

//using System.Text.RegularExpressions;

//string pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";

//Regex rg = new Regex(pattern);

//if (rg.IsMatch("s1 23@code.edu.az"))
//{
//    Console.WriteLine("Format dogrudur");
//}
//else
//{
//    Console.WriteLine("Format yanlisdir");
//}


//for(int i = 0;i<1000; i++)
//{
//    Console.WriteLine(i);
//    for(int j = 0; j < 1000; j++)
//    {

//    }
//}




//int a = 12; // 1

//Console.WriteLine(a); // 1

//a = a * 12; // 1

//Console.WriteLine(a); //1


// O(1)

//int[] numbers = { 1, 2, 3, 4, 5 }; // Length -> n

//for(int a =0; a < numbers.Length; a++) //  n + 1 
//{
//    Console.WriteLine(numbers[a]); // n
//}

// 2n + 1 => O(n)

for(int i = 0; i < 1000; i++)  // n
{
    for(int j = 0; j<1000; j++)  // n^2
    {
        Console.WriteLine(j); // n^2
    }
}

// 2n^2 + n => O(n^2)