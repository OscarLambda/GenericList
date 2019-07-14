
using System;

namespace GenericList
{
    class Program
    {
        //a generic array
        //add function 
        //remove function 
        //contains
        static void Main(string[] args)
        {
            
        }
        public class GenericList<T>
        {
            int[] intArray = {};
            public void Add<T>(T[] array)
            {
                int[] bigIntArray = new int[intArray.Length + 1];
            }
            public void Remove<T>(T[] array)
            {
                int[] smallIntArray = new int[intArray.Length - 1];
            }
        }
    }
}
