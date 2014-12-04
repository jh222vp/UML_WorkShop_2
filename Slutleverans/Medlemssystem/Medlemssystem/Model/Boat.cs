using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class Boat
    {
        public int BoatId { get; set; }
        public int BoatCount { get; set; }
        public int MemberId { get; set; }
        public string BoatTypeId { get; set; }
        public string Length { get; set; }

        public Boat(int bid, int mid, string btid, string l)
        {
            BoatId = bid;
            MemberId = mid;
            BoatTypeId = btid;
            Length = l;
        }
    }
}
