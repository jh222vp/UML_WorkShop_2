using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class AddUser
    {
        SQLconnection sqlConnection = new SQLconnection();

        public void addUser(string fname, string lname, int socialSecNumber)
        {
          Program program = new Program();

            string addUserQuery = "INSERT INTO member (firstname, lastname, socialsecuritynumber) VALUES ( " + "'" + fname + "'" + "," + "'" + lname + "'" + "," + "'" + socialSecNumber + "'" + ")";
            sqlConnection.AddUserAndEditBoatSQL(addUserQuery);

            Console.Clear();
            program.ContinueOnKeyPressed();
            program.Menu();
        }
    }
}