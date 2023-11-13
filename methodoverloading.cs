using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETCOREDEMO
{
    public class methodoverloading
    {
        public void Test()
        {
            Console.WriteLine("1stmethod");
        }
        public void Test(int i)
        {
            Console.WriteLine("2ndmethod");
        }
        public void Test(string s)
        {
            Console.WriteLine("3ndmethod");
        }
        public void Test(int i,string s)
        {
            Console.WriteLine("4ndmethod");
        }
        public void Test(string s,int i)
        {
            Console.WriteLine("5ndmethod");
        }
    }
}
