using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class Delete
    {
        ShowUser showUser = new ShowUser();
        Presentation presentation = new Presentation();
        SQLconnection sqlConnection = new SQLconnection();

        public void DeleteUsers()
        {
            Program program = new Program();
            showUser.ShowUsers();

            program.DeleteUInteraction();
            int deleteChoice = int.Parse(Console.ReadLine());

            string deleteMemberQuery = "CALL `deleteMember`" + "(" + deleteChoice + ");";
           sqlConnection.DeleteBoatSQL(deleteMemberQuery);

            
            Console.Clear();
            program.ContinueOnKeyPressed();
        }
    }
}