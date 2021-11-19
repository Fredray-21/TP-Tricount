using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TRICOUNT.Properties
{
    internal class TriParticipant : IComparer<Participant>
    {
        public int Compare(Participant? x, Participant? y)
        {
            return x.GetBalance().CompareTo(x.GetBalance());
        }
    }
}
