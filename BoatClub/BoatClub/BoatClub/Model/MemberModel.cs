using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class MemberModel
    {
        internal SqlConnection SqlConnection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public List<Member> GetFullMembers()
        {
            SqlConnection connection = new SqlConnection();
            string memberDisplayQuery = "CALL `memberlist`();";
            List<Member> member = connection.ShowShortMembers(memberDisplayQuery);
            return member;
        }

        public List<Member> GetShortMembers()
        {
            SqlConnection connection = new SqlConnection();
            string memberDisplayQuery = "CALL `miniMemList`();";
            List<Member> member = connection.ShowShortMembers(memberDisplayQuery);
            return member;
        }

        public void AddMember(string fname, string lname, int socialSecNumber)
        {
            SqlConnection connection = new SqlConnection();
            string addMemberQuery = "INSERT INTO member (firstname, lastname, socialsecuritynumber) VALUES ( " + "'" + fname + "'" + "," + "'" + lname + "'" + "," + "'" + socialSecNumber + "'" + ")";
            connection.AddUserAndEditBoat(addMemberQuery);
        }

        public void EditMember(int userEdit, string fName, string lName, string pNumber)
        {
            SqlConnection connection = new SqlConnection();
            string editMemberQuery = "UPDATE member SET firstname='" + fName + "'" + ", lastname='" + lName + "'" + ", socialsecuritynumber= '" + pNumber + "'" + " WHERE memberID='" + userEdit + "'";
            connection.AddBoatAndEditUser(editMemberQuery);
        }

        public void DeleteMember(int deleteChoice)
        {
            SqlConnection connection = new SqlConnection();
            string deleteMemberQuery = "CALL `deleteMember`" + "(" + deleteChoice + ");";
            connection.Delete(deleteMemberQuery);
        }
    }
}
