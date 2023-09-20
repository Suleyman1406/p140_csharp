using System;
namespace Generics.List
{
	public class IntList
	{
        private int[] items;
        public int[] Items { get => items; set => items = value; }

        public IntList(params int[] items)
        {
            this.items = items;
        }

        public void Add(int item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public int? GetAtIndex(int idx)
        {
            if (idx < 0 || idx >= items.Length)
            {
                Console.WriteLine("Bu Index istifade edile bilmir.");
                return null;
            }
            return items[idx];
        }

        public void Print()
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

