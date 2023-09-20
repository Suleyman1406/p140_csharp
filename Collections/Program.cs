using System.Collections;

//List<int> numbers = new List<int> { 3, 5, 5, 8};
//numbers.Add(9);
//Console.WriteLine(numbers[3]);

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}
//numbers.Remove(9);
//numbers.Remove(3);
//numbers.Remove(5);

//numbers.RemoveAt(0);
//numbers.RemoveAt(0);

//numbers.RemoveAll();

//Console.WriteLine(numbers.Contains(33));

//numbers.AddRange(new int[] { 3, 4, 5 });

//numbers.RemoveRange(5,3 );

//for (int i = 0; i<numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//ArrayList arrayList = new ArrayList();

//arrayList.Add(1);
//arrayList.Add("asd");
//arrayList.Add(true);
//arrayList.Add(new { name = "suleyman" });

//Console.WriteLine();


//Dictionary<string, string> dictionary = new Dictionary<string, string>();

//dictionary.Add("apple", "alma");
//dictionary.Add("pen", "qelem");
//dictionary.Add("asda", "nese");
////string value;
////dictionary.TryGetValue("test", out value);

////Console.WriteLine(value);

//foreach (var item in dictionary)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}


//Dictionary<string, string> phoneBook = new Dictionary<string, string>();

//phoneBook.Add("Suleyman", "+9492323");
//phoneBook.Add("asd", "+9492323");
//phoneBook.Add("asd1", "+9492323");


//foreach (var item in phoneBook)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}


//Dictionary<int, bool> isPrimeDictionary = new Dictionary<int, bool>
//{
//    { 1, true },
//    { 2, true },
//    { 3, true },
//    { 4, false },
//    { 5, true }
//};

//Console.WriteLine(isPrimeDictionary.ContainsKey(10));

//foreach (var item in isPrimeDictionary.Keys)
//{
//    Console.WriteLine(item);
//}


//Queue<int> numbersQueue = new Queue<int>();

//numbersQueue.Enqueue(1);
//numbersQueue.Enqueue(2);
//numbersQueue.Enqueue(88);
//numbersQueue.Enqueue(56);

//Console.WriteLine("Silinen ilk " + numbersQueue.Dequeue());
////Console.WriteLine("Silinen ikinci " + numbersQueue.Dequeue());
////Console.WriteLine("Silinen ucuncu " + numbersQueue.Dequeue());
////Console.WriteLine("Silinen ucuncu " + numbersQueue.Dequeue());
////Console.WriteLine("Silinen ucuncu " + numbersQueue.Dequeue());
////Console.WriteLine("Silinen ucuncu " + numbersQueue.Dequeue());
//int res;
//numbersQueue.TryPeek(out res);

//foreach (int num in numbersQueue)
//{
//    Console.WriteLine(num);
//}


Stack<string> texts = new Stack<string>();

texts.Push("hello");
texts.Push("first");
texts.Push("last");
texts.Push("again");


foreach(string test in texts)
{
    Console.WriteLine(test);
}

//texts.Pop();
//texts.Pop();

//Console.WriteLine("siradaki: "+texts.Peek());
//texts.Pop();
//texts.Pop();
//texts.Pop();
//texts.Pop();
//Console.WriteLine("siradaki: " + texts.Peek());


//foreach (string num in texts)
//{
//    Console.WriteLine(num);
//}
