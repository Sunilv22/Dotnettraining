using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETCOREDEMO
{
    public class Loadparent
    {
       public void Show()
        {
            Console.WriteLine("parent show method is called");
        }
        public virtual void Test()//overridable
        {
            Console.WriteLine("parent test method is called");
        }

    }
    public class LoadChild:Loadparent 
    {
        public override void Test()
        {
            Console.WriteLine("child test method is called");
        }
        public void Show(int i)
        {
            Console.WriteLine("child show method is called");
        }
    }
}
