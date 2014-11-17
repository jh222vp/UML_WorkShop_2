using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class EditUser
    {
        ShowUser showUser = new ShowUser();
        
        SQLconnection sqlConnection = new SQLconnection();
        public void EditUserInfo()
        {
            Program program = new Program();
            showUser.ShowUsers();

            Console.WriteLine("");

            program.EditUserInteraction(1);
            string userEdit = Console.ReadLine();

            program.EditUserInteraction(2);
            string fName = Console.ReadLine();

            program.EditUserInteraction(3);
            string lName = Console.ReadLine();

            program.EditUserInteraction(4);
            string pNumber = Console.ReadLine();

            string editUserQuery = "UPDATE member SET firstname='" + fName + "'" + ", lastname='" + lName + "'" + ", socialsecuritynumber= '" + pNumber + "'" + " WHERE memberID='" + userEdit + "'";

            sqlConnection.AddBoatSQL(editUserQuery);

            Console.Clear();
            program.ContinueOnKeyPressed();
        }
    }
}