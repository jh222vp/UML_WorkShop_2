using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class Presentation
    {

        public void GetMenu()
        {
            //visar en grundmeny
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
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=        Användare tillagd             =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }
        public void Adduser()
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
        public void EditUsers()
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
        public void MemberIsEdit()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=         Användaren är editerad       =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void UserListFull()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=   Inga platser finns i systemet.     =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================\n");
            Console.ResetColor();
        }

        public void displayOutPutQuery(List<string> queryStringList)
        {
            Program program = new Program();
            queryStringList.ForEach(i => Console.Write("{0}\n", i));
            program.ContinueOnKeyPressed();
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
        public void hosVem(int choice)
        {
            switch (choice)
            {
                case 1: { Console.Write("Hos vem?.."); break; }
                case 2: { Console.Write("Hur lång är båten: "); break; }
                case 3:
                    {
                        Console.WriteLine("Vad vill du lägga till för båt?");
                        Console.WriteLine("1.Segelbåt 2.Motorseglare 3.Motorbåt 4.Kajak/Kanot 5.Övrigt"); break;
                    }
            }
            
        }

        public void deleteUInteraction()
        {
            Console.Write("Vilken användare vill du ta bort?: ");
        }

        public void DeleteBInteraction(int choice)
        {
            switch (choice)
            {
                case 1: { Console.WriteLine("Vilken medlem vill du ta bort en båt hos..?"); break; }
                case 2: { Console.WriteLine("Vilken båt vill du ta bort..?"); break; }
            }
        }

        public void EditBInteraction(int choice)
        {
            switch (choice)
            {
                case 1: { Console.Write("Vilken medlem vill du ändra en båt hos: "); break; }
                case 2: { Console.WriteLine("Vilken båt vill ändra..?"); break; }
                case 3: { Console.WriteLine("Ange nya båtvärden.."); Console.WriteLine("Ny båtlängd:"); break; }
                case 4:
                    {
                        Console.WriteLine("Ange en ny båttyp:");
                        Console.WriteLine("1.Segelbåt 2.Motorseglare 3.Motorbåt 4.Kajak/Kanot 5.Övrigt");
                        break;
                    }
            }
        }

        public void EditUInteraction(int choice)
        {
            switch (choice)
            {
                case 1: { Console.Write("Välj vem du vill editera: "); break; }
                case 2: { Console.WriteLine("Skriv in nytt förnamn: "); break; }
                case 3: { Console.WriteLine("Skriv in nytt efternamn: "); break; }
                case 4: { Console.WriteLine("Skriv in nytt personnummer:"); break;}
            }
        }
    }
}
