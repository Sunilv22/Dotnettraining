using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETCOREDEMO
{
    public class employe
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Email { get; set; }   
        public void printfuname()
        {
            Console.WriteLine(firstname + lastname);
        }

    }
    public class Fulltimeemploye:employe
    {
        public float yearlysalary { get; set; }
        
    }
    public class Parttimeemploye:Fulltimeemploye
    {
        public float hourlyrate { get; set; }
    }
}
