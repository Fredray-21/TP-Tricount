using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT
{
    public class TriBalance : IComparer<Participant>
    {
        public int Compare(Participant? x, Participant? y)
        {
            return Math.Abs(x.GetBalance()).CompareTo(Math.Abs(y.GetBalance())) *(-1) ;
        }
    }
}
