using Generics.Models;

namespace Generics.List
{
	public class PersonList
	{
        private Person[] items;
        public Person[] Items { get => items; set => items = value; }

        public PersonList(params Person[] items)
        {
            this.items = items;
        }

        public void Add(Person item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public Person? GetAtIndex(int idx)
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
            foreach (Person item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

