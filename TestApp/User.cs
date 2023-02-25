using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class User
    {
        public string Name { get; set; }
        public string Surname{ get; set; }

        public void Any()
        {
            Console.WriteLine("Any Method is works");
        }
    }
}
