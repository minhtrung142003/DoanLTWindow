using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class themmoi
    {
        public class Employee
        { 
            public string Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }
            public Image Image { get; internal set; }
        }

    }
}
