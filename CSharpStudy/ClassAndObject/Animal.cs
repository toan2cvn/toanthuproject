using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassAndObject
{
    public class Animal
    {
        public int foot { get; set; }
        public float weight { get; set; }
        public int? height { get; set; }

        public virtual string Sound()
        {
            return "Animal";
        }
    }
}
