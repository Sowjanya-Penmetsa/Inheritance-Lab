using System;
using System.Collections.Generic;
using System.Text;

namespace Random_list
{
    class Randomlist:List<string>
    {
        private Random random = new Random();
        public string RandomString()
        {
            int index = random.Next(0, this.Count);
            string remove = this[index];
            this.RemoveAt(index);
            return remove;

        }
    }
}
