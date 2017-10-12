using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    abstract class Food
    {
        protected string name;
        protected bool isTasty;
        protected string color;
        protected int calories;
        protected int sodium;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Calories
        {
            get { return this.calories; }
        }

        public Food()
        {

        }
        public string NameCheck()
        {
            return name;
        }

    }
}
