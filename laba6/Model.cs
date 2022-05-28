using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Model
    {
        public int calculateMounth(string vibMounth,string[] mounthArray)
        {
            DateTime currentDate = DateTime.Now;
            int result = Math.Abs(currentDate.Month - (Array.IndexOf(mounthArray,vibMounth) + 1));
            return result;

        }
    }
}
