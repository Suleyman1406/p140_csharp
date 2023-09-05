// i++ ++i i-- --i


//int i = 0; // 1 2

////i++;
////++i;

//Console.WriteLine(i++ );
//Console.WriteLine(++i);

//int a = 1; // 1 2
//int b = a++; // 1 2
//int c = b++; // 1

//Console.WriteLine("{0} {1} {2}", a, b, c);

int a = 1; // 1 2 3 4 3 4
int b = a++ + ++a; // 1 + 3 // 4 5
int c = ++a - ++b - a--; // 4 - 5 - 4  // -5 -6 -5
int d = --c - ++c - a++; // -6 + 5 - 3 // -4

Console.WriteLine("{0} {1} {2} {3}", a, b, c,d);

// Xumar 4 6 -4 -4
// Huseynova 4 5 -5 -4
// Nurane 3 3 -6 -4
// Aysel 4 -2 5 -5
// Hesenov 4 5 -5 -5
// Elnur 2 4 -4 -8
// Yusifov 3 4 -4 5

