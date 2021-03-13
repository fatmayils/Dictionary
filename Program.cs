using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(100, "armut");
            dictionary.Add(150, "elma");
            dictionary.Add(200, "kivi");
            dictionary.Add(450, "muz");
            dictionary.Add(160, "mandalina");
            dictionary.List();
           
        }
    }
}
