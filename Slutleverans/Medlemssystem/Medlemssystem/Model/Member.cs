using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public int BoatCount { get; set; }
        
        public Member(int id, string fn, string ln, string ssn, int bc)
        {
            MemberId = id;
            FirstName = fn;
            LastName = ln;
            Ssn = ssn;
            BoatCount = bc;
        }
    }
}
