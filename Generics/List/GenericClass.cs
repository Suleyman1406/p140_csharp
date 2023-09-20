using System;
using Generics.Models;
namespace Generics.List;


public class GenericClass<T>
    //where T : struct
    //where T : Person
    //where T: G
    //where T : struct, IAlive
    //where T : class, new()
    //where T : class, IAlive, new()
    //where T : new()
{
    //public T value;
    //public G value2;

    public GenericClass()
    {
        //this.value = value;
        //this.value2 = value2;
    }
}

