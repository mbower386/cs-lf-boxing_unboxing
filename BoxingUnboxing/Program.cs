using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main (string[] args)
        {
            List<object> listObject = new List<object> ();

            listObject.Add (7);
            listObject.Add (28);
            listObject.Add (-1);
            listObject.Add (true);
            listObject.Add ("chair");

            foreach (object l in listObject)
            {
                Console.WriteLine (l);
            }

            int sum = 0;
            foreach (object l in listObject)
            {
                if (l is int)
                {
                    sum += (int)l;
                }
            }
            Console.WriteLine (sum);
        }
    }
}