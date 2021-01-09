using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increase_and_decrease_a_number
{
    class Number
    {
        private int _count;

       public Number()
        {
            this._count = 0;

        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }


        }

        public void Reset()
        {
            _count = 0;
        }

        public void Increase()
        {

            _count += 1;
        }

        public void Decrease ()
        {
            _count -= 1;

        }

    }
}
