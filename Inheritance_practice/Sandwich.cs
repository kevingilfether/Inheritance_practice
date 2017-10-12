using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Sandwich : Food
    {
        protected string bunType;
        protected string filling;

        public Sandwich()
        {

        }
        public Sandwich(string name, bool isTasty, int calories, int sodium, string bunType, string filling)
        {
            this.name = name;
            this.isTasty = isTasty;
            this.calories = calories;
            this.sodium = sodium;
            this.bunType = bunType;
            this.filling = filling;
        }

        public void HeatUp()
        {
            Console.WriteLine("Getting hotter!");
        }

        public void SaltBomb()
        {
            this.sodium += 200;
        }
        public override string NameCheck()
        {
            string burgerType = name + " --- " + bunType + " --- " + filling;
            return burgerType;
        }
    }
}
