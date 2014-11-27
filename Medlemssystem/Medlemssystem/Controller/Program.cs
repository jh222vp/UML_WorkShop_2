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
    /// This is an application create by Sandra Hanson and Jonas Holte WP13 2014-11-27
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

        public void ShowUserInfo()
        {
            List<Member> member = showUser.ShowCompleteUser();
            List<Boat> boat = showUser.ShowCompleteUserBoats();
            presentation.displayOutPutQuery(member, boat);
        }
        public void ShowUserInforSmall()
        {
            List<Member> member = showUser.ShowUsers();
            List<Boat> boat = showUser.ShowCompleteUserBoats();
            presentation.displayBoatOutPutQuery(member, boat);
        }

        public void AddUser()
        {
            presentation.Adduser();
            //Samlar in information från användaren
            string firstname = presentation.getUserName();
            string lastname = presentation.getLastName();
            int socialSecNumber = presentation.getSocialSecurityNumber();

            addUserToDatabase.addUser(firstname, lastname, socialSecNumber);
            presentation.UserIsAdded();
            ContinueOnKeyPressed();
            Menu();
        }

        public void EditBoats()
        {
            presentation.EditBoat();
            ShowUserInfo();

            int userChoice = presentation.WhoToEditBoatTo();
            int userBoatChoice = presentation.WhatTypeOfBoatEdit();
            string newBoatLength = presentation.WhatTypeOfBoatLength();
            string newBoatyp = presentation.WhatTypeOfBoat();
            editBoat.EditBoats(userChoice, userBoatChoice, newBoatLength, newBoatyp);
            presentation.BoatIsEdited();
            ContinueOnKeyPressed();
        }

        public void ShowCompleteUser()
        {
            presentation.ListAllMembers();
            ShowUserInfo();
            ContinueOnKeyPressed();
        }

        public void ShowCompleteUserBoat()
        {
            ShowUserInforSmall();
            ContinueOnKeyPressed();
        }

        public void AddBoatToUser()
        {
            ShowCompleteUserBoat();
            presentation.AddBoat();
            int withWho = presentation.hosVem();
            string boatLenght = presentation.LenghtInBoat();
            string whatBoatType = presentation.whatBoatType();
            addBoat.AddBoatToMember(withWho, boatLenght, whatBoatType);
            Console.Clear();
            presentation.BoatIsAdded();
            ContinueOnKeyPressed();
        }

        public void EditUsers()
        {
            presentation.EditUsers();
            ShowUserInforSmall();

            string userEdit = presentation.WhoToEditUser();
            string fName = presentation.WhoToEditFname();
            string lName = presentation.WhoToEditLname();
            string SSN = presentation.WhoToEditSSN();
            editUser.EditUserInfo(userEdit, fName, lName, SSN);
            presentation.MemberIsEdit();
            ContinueOnKeyPressed();
        }

        public void ShowUsers()
        {
            presentation.ListMembers();
            ShowCompleteUserBoat();
        }

        public void DeleteUsers()
        {
            ShowUserInfo();
            presentation.DeletePresentation();
            int deleteChoice = presentation.deleteUInteraction();
            delete.DeleteUsers(deleteChoice);
            presentation.UserIsDeleted();
            ContinueOnKeyPressed();
            Console.Clear();
        }

        public void DeleteBoats()
        {
            ShowUserInfo();
            int userChoice = presentation.hosVem();
            int userBoatChoice = presentation.SelectBoatToDelete();

            deleteBoat.DeleteBoats(userChoice, userBoatChoice);
            presentation.BoatIsDeleted();
            ContinueOnKeyPressed();
        }

        public void readQuery(List<Member> members, List<Boat> boats)
        {
            presentation.displayOutPutQuery(members, boats);
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