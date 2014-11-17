using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Medlemssystem
{

    /// <summary>
    /// This is an application create by Sandra Hanson and Jonas Holte WP13
    /// for the course "Objektorienterad analys och design med UML"
    /// </summary>

    class Program
    {
        ShowUser showUser = new ShowUser();
        Presentation presentation = new Presentation();
        SQLconnection sqlConnection = new SQLconnection();
        AddBoat addBoat = new AddBoat();
        Delete delete = new Delete();
        AddUser addUserToDatabase = new AddUser();
        EditBoat editBoat = new EditBoat();
        EditUser editUser = new EditUser();
        DeleteBoat deleteBoat = new DeleteBoat();
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }

        public void Menu()
        {
            SQLconnection conn = new SQLconnection();
            bool exit = false;
            do
            {
                switch (GetMenuChoice())
                {
                    case 0: { return; }
                    case 1: { AddUser(); exit = true; break; }
                    case 2: { AddBoatToUser(); break; }
                    case 3: { ShowUsers(); ContinueOnKeyPressed(); break; }
                    case 4: { ShowCompleteUser(); break; }
                    case 5: { EditUsers(); break; }
                    case 6: { EditBoats(); break; }
                    case 7: { DeleteUsers(); break; }
                    case 8: { DeleteBoats(); break; }

                }
            } while (!exit);
        }

        public void ContinueOnKeyPressed()
        {
            Console.ReadKey();
        }

        public void AddUser()
        {
            presentation.Adduser();
            //Samlar in information från användaren..
            string firstname = presentation.getUserName();
            string lastname = presentation.getLastName();
            int socialSecNumber = presentation.getSocialSecurityNumber();

            addUserToDatabase.addUser(firstname, lastname, socialSecNumber);
            presentation.UserIsAdded();
            ContinueOnKeyPressed();
        }

        public void EditBoats()
        {
            editBoat.EditBoats();
            presentation.BoatIsEdited();
            ContinueOnKeyPressed();
        }

        public void ShowCompleteUser()
        {
            presentation.ListAllMembers();
            showUser.ShowCompleteUser();
        }
        public void DeleteBoats()
        {
            deleteBoat.DeleteBoats();
            presentation.BoatIsDeleted();
        }

        public void AddBoatToUser()
        {
            presentation.AddBoat();
            addBoat.AddBoatToMember();
            presentation.BoatIsAdded();
        }

        public void EditUsers()
        {
            presentation.EditUsers();
            editUser.EditUserInfo();
            presentation.MemberIsEdit();
        }

        public void ShowUsers()
        {
            presentation.ListMembers();
            showUser.ShowUsers();

        }

        public void DeleteUsers()
        {
            presentation.DeletePresentation();
            delete.DeleteUsers();
            presentation.UserIsDeleted();
        }

        public void readQuery(List<string> queryStringList)
        {
            presentation.displayOutPutQuery(queryStringList);
        }

        public void AddBoatInteraction(int choice)
        {
            presentation.hosVem(choice);
        }

        public void DeleteUInteraction()
        {
            presentation.deleteUInteraction();
        }

        public void DeleteBoatInteraction(int choice)
        {
            presentation.DeleteBInteraction(choice);
        }

        public void EditBoatInteraction(int choice)
        {
            presentation.EditBInteraction(choice);
        }

        public void EditUserInteraction(int choice)
        {
            presentation.EditUInteraction(choice);
        }

        public int GetMenuChoice()
        {
            presentation.GetMenu();
            do
            {
                int menuChoice;

                //Läser av värdet i menyn och "outar" det valet till menyChoice, valet måste va inom 0-11 annars felmed.
                if (int.TryParse(Console.ReadLine(), out menuChoice) && (menuChoice >= 0 && menuChoice <= 11))
                {
                    Console.Clear();
                    return menuChoice;
                }
                else
                {
                    Menu();
                }
            } while (true);
        }
    }
}