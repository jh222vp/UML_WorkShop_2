using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub
{
    class Program
    {
        MemberModel mm = new MemberModel();
        BoatModel bm = new BoatModel();

        PresentationView view = new View.PresentationView();

        internal BoatClub.Model.MemberModel MemberModel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal BoatClub.Model.BoatModel BoatModel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal BoatClub.View.PresentationView PresentationView
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }

        public void Menu()
        {
            bool exit = false;
            do
            {
                switch (GetMenuChoice())
                {
                    case 0: { return; }
                    case 1: { AddMember(); exit = true; break; }
                    case 2: { AddBoatToUser(); break; }
                    case 3: { DisplayShortList(); view.ContinueOnKeyPressed(); break; }
                    case 4: { ShowCompleteList(); break; }
                    case 5: { EditMembers(); break; }
                    case 6: { EditBoats(); break; }
                    case 7: { DeleteMember(); break; }
                    case 8: { DeleteBoat(); break; }

                }
            } while (!exit);
        }

        //Läser av värdet i menyn och "outar" det valet till menyChoice, valet måste va inom 0-8 annars felmeddelande.
        public int GetMenuChoice()
        {
            view.GetMenu();
            do
            {
                int menuChoice;

                if (int.TryParse(Console.ReadLine(), out menuChoice) && (menuChoice >= 0 && menuChoice <= 8))
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

        public void AddMember()
        {
            view.AddMember();
            string firstname = view.getUserName();
            string lastname = view.getLastName();
            int socialSecNumber = view.getSocialSecurityNumber();

            mm.AddMember(firstname, lastname, socialSecNumber);
            view.UserIsAdded();
            view.ContinueOnKeyPressed();
            Menu();
        }

        public void AddBoatToUser()
        {
            view.AddBoat();
            List<Member> members = mm.GetFullMembers();
            view.ShortMemberOutPut(members);

            int memberChoice = view.MemberChoice();
            string boatLenght = view.LenghtInBoat();
            string whatBoatType = view.whatBoatType();

            int memberID = members[memberChoice].MemberId;

            bm.AddBoat(memberID, boatLenght, whatBoatType);
            view.BoatIsAdded();
            view.ContinueOnKeyPressed();
        }

        public void DisplayShortList()
        {
            view.ListMembers();
            List<Member> members = mm.GetFullMembers();
            view.ShortMemberOutPut(members);
            view.ContinueOnKeyPressed();
        }

        public void ShowCompleteList()
        {
            view.ListAllMembers();
            List<Member> members = mm.GetFullMembers();
            view.FullMemberOutPut(members);
            view.ContinueOnKeyPressed();
        }

        public void EditMembers()
        {
            view.EditMember();
            List<Member> members = mm.GetFullMembers();
            view.ShortMemberOutPut(members);

            int userEdit = view.WhoToEditUser();
            string fName = view.WhoToEditFname();
            string lName = view.WhoToEditLname();
            string SSN = view.WhoToEditSSN();
            int memberID = members[userEdit].MemberId;

            mm.EditMember(memberID, fName, lName, SSN);
            view.MemberIsEdit();
            view.ContinueOnKeyPressed();
        }
        
        //Denna funktion editerar en önskad båt från vald medlem ur datorbasen
        public void EditBoats()
        {
            view.EditBoat();
            List<Member> members = mm.GetShortMembers();
            view.ShortMemberOutPut(members);

            int memberChoice = view.WhoToEditBoatTo();
            int memberBoatChoice = view.WhatTypeOfBoatEdit();
            string newBoatLength = view.WhatTypeOfBoatLength();
            string newBoatype = view.WhatTypeOfBoat();
            int memberID = members[memberChoice].MemberId;
            int boatID = members[memberChoice].Boats[memberBoatChoice].BoatId;

            bm.EditBoat(boatID, memberID, newBoatLength, newBoatype);
            view.BoatIsEdited();
            view.ContinueOnKeyPressed();
        }

        //Denna funktion tar bort en önskad medlem ur datorbasen
        public void DeleteMember()
        {
            view.DeletePresentation();
            List<Member> members = mm.GetShortMembers();
            view.ShortMemberOutPut(members);
            int deleteMemberChoice = view.deleteMemberInteraction();
            int memberID = members[deleteMemberChoice].MemberId;

            mm.DeleteMember(memberID);
            view.UserIsDeleted();
            view.ContinueOnKeyPressed();
        }

        //Denna funktion tar bort en önskad båt ur datorbasen
        public void DeleteBoat()
        {
            List<Member> members = mm.GetShortMembers();
            view.ShortMemberOutPut(members);
            int deleteMemberChoice = view.deleteMemberBoatInteraction();
            int deleteBoatChoice = view.deleteBoatInteraction();
            int memberID = members[deleteMemberChoice].MemberId;
            int boatID = members[deleteMemberChoice].Boats[deleteBoatChoice].BoatId;

            bm.DeleteBoat(memberID, boatID);
            view.BoatIsDeleted();
            view.ContinueOnKeyPressed();
        }
    }
}
