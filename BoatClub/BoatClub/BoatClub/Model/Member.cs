using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public int BoatCount { get; set; }
        public List<Boat> Boats { get; set; }

        public Member(int id, string fn, string ln, string ssn, int bid)
        {
            MemberId = id;
            FirstName = fn;
            LastName = ln;
            Ssn = ssn;
            BoatCount = bid;
            getBoats(id);
        }

        public void getBoats(int id)
        {
            SqlConnection con = new SqlConnection();
            string query = "CALL `getBoats`" + "(" + id + ");";
            Boats = con.getBoatsByMemberId(query);
        }
    }
}
