using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class PresentationView
    {
        public void GetMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===============================");
            Console.WriteLine("  Båtklubben MemberSystem v.3.2");
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                Menyval               =");
            Console.WriteLine("= --Arkiv----------------------------- =");
            Console.WriteLine("=    0. Avsluta.                       =");
            Console.WriteLine("=    1. Lägg till användare            =");
            Console.WriteLine("=    2. Lägg till båt                  =");
            Console.WriteLine("=    3. Kortfattad lista av medlemmar. =");
            Console.WriteLine("=    4. Komplett lista av medlemmar.   =");
            Console.WriteLine("= --Redigera-------------------------- =");
            Console.WriteLine("=    5. Editera Användare              =");
            Console.WriteLine("=    6. Editera Båt                    =");
            Console.WriteLine("= --Ta bort--------------------------- =");
            Console.WriteLine("=    7. Ta bort Användare              =");
            Console.WriteLine("=    8. Ta bort Båt                    =");
            Console.WriteLine("= ==================================== =");
            Console.WriteLine("=          Ange menyval [0-8]          =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
            Console.Write("Skriv in ditt val: ");
        }

        public void ListMembers()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=     Kortfattad lista av medlemmar    =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void ListAllMembers()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=     Komplett lista av medlemmar      =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void UserIsAdded()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Användare tillagd             =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void AddMember()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Lägg till användare           =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void BoatIsAdded()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Båt tillagd                   =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void BoatIsEdited()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Båt tillagd                   =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void AddBoat()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Lägg till båt                 =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void BoatIsDeleted()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Båt togs bort                 =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void DeletePresentation()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=  Vilken användare vill du ta bort?   =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void UserIsDeleted()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Användaren togs bort          =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void UserIsNotDeleted()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=     Ingen Användaren togs bort       =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void EditMember()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=         Editera användare            =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void EditBoat()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=         Editera Båt                  =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void MemberIsEdit()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=         Användaren är editerad       =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void FullMemberOutPut(List<Member> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                Console.Write(i);
                Console.Write("  ");
                Console.Write(members[i].FirstName);
                Console.Write("  ");
                Console.Write(members[i].LastName);
                Console.Write("  ");
                Console.Write(members[i].Ssn);
                Console.WriteLine("  ");

                int count = 0;
                foreach (var boats in members[i].Boats)
                {
                    Console.WriteLine(count);
                    Console.Write(boats.BoatId);
                    Console.Write(" ");
                    Console.Write(boats.BoatTypeId);
                    Console.Write(" ");
                    Console.Write(boats.Length);
                    Console.WriteLine("||");
                    count++;
                }
            }
        }

        public void ShortMemberOutPut(List<Member> members)
        {
            int count = 0;

            for (var i = 0; i < members.Count; i++)
            {
                Console.Write("Medlemsnummer: ");
                Console.Write(i);
                Console.Write("  ");
                Console.Write(members[i].FirstName);
                Console.Write("  ");
                Console.WriteLine(members[i].LastName);
                Console.Write("Antal Båtar: ");
                Console.Write(members[i].BoatCount);
                Console.WriteLine(" ");

                foreach (var boats in members[i].Boats)
                {
                    Console.Write("Båtnummer: ");
                    Console.WriteLine(count);
                    Console.Write(" ");
                    switch (boats.BoatTypeId)
                    {
                        case "1": { Console.Write("Segelbåt"); break; }
                        case "2": { Console.Write("Motorseglare"); break; }
                        case "3": { Console.Write("Motorbåt"); break; }
                        case "4": { Console.Write("Kanot/Kajak"); break; }
                        case "5": { Console.Write("Övrigt"); break; }

                    }
                    Console.Write(" ");
                    Console.Write(boats.Length);
                    Console.WriteLine("");
                    Console.WriteLine("||");
                    Console.WriteLine("||");
                    count++;
                }
            }
        }

        public string getUserName()
        {
            Console.Write("Skriv in förnamn: ");
            string fname = Console.ReadLine();
            return fname;
        }

        public string getLastName()
        {
            Console.Write("Skriv in efternamn: ");
            string lname = Console.ReadLine();
            return lname;
        }

        public int getSocialSecurityNumber()
        {
            Console.Write("Skriv in personnummer: ");
            int pnumber = int.Parse(Console.ReadLine());
            return pnumber;
        }

        public int MemberChoice()
        {
            Console.Write("Hos vem?: ");
            int userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }

        public string LenghtInBoat()
        {
            Console.Write("Hur lång är båten: ");
            string boatLength = Console.ReadLine();
            return boatLength;
        }

        public string whatBoatType()
        {
            Console.WriteLine("Vad vill du lägga till för båt?");
            Console.WriteLine("1.Segelbåt 2.Motorseglare 3.Motorbåt 4.Kajak/Kanot 5.Övrigt");
            string boatType = Console.ReadLine();
            return boatType;
        }

        public int deleteMemberInteraction()
        {
            Console.Write("Vilken användare vill du ta bort?: ");
            int deleteChoice = int.Parse(Console.ReadLine());

            return deleteChoice;
        }

        public int deleteMemberBoatInteraction()
        {
            Console.Write("Vilken användare vill du ta bort en båt hos? ");
            int deleteChoice = int.Parse(Console.ReadLine());

            return deleteChoice;
        }

        public int deleteBoatInteraction()
        {
            Console.Write("Vilken båt vill du ta bort?: ");
            int deleteBoatChoice = int.Parse(Console.ReadLine());

            return deleteBoatChoice;
        }
        /*===========DELETEBOATVIEW===================*/
        public int SelectBoatToDelete()
        {
            Console.WriteLine("Vilken båt vill du ta bort..?");
            int userBoatChoice = int.Parse(Console.ReadLine());

            return userBoatChoice;
        }
        /*============EditBoatView===================*/
        public int WhoToEditBoatTo()
        {
            Console.Write("Vilken medlem vill du ändra en båt hos: ");
            int userChoice = int.Parse(Console.ReadLine());

            return userChoice;
        }

        public int WhatTypeOfBoatEdit()
        {
            Console.WriteLine("Vilken båt vill ändra..?");
            int userBoatChoice = int.Parse(Console.ReadLine());

            return userBoatChoice;
        }

        public string WhatTypeOfBoatLength()
        {
            Console.WriteLine("Ange nya båtvärden..");
            Console.WriteLine("Ny båtlängd:");
            string newBoatLength = Console.ReadLine();

            return newBoatLength;
        }

        public string WhatTypeOfBoat()
        {
            Console.WriteLine("Ange en ny båttyp:");
            Console.WriteLine("1.Segelbåt 2.Motorseglare 3.Motorbåt 4.Kajak/Kanot 5.Övrigt");
            string newBoatype = Console.ReadLine();

            return newBoatype;
        }

        /*===============EDITUSER==============*/
        public int WhoToEditUser()
        {
            Console.Write("Välj vem du vill editera: ");
            int userEdit = int.Parse(Console.ReadLine());

            return userEdit;
        }

        public string WhoToEditFname()
        {
            Console.WriteLine("Skriv in nytt förnamn: ");
            string fName = Console.ReadLine();

            return fName;
        }

        public string WhoToEditLname()
        {
            Console.WriteLine("Skriv in nytt efternamn: ");
            string lName = Console.ReadLine();

            return lName;
        }

        public string WhoToEditSSN()
        {
            Console.WriteLine("Skriv in nytt personnummer:");
            string pNumber = Console.ReadLine();

            return pNumber;
        }

        public void ContinueOnKeyPressed()
        {
            Console.ReadKey();
        }
    }
}