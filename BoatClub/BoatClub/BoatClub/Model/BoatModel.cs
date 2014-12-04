using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Model
{
    class BoatModel
    {
        public void AddBoat(int userChoice, string boatLength, string boatType)
        {
            SqlConnection connection = new SqlConnection();
            string addBoatQuery = "INSERT INTO boat (memberID, boattypeID, boatlength) VALUES ( " + "'" + userChoice + "'" + "," + "'" + boatType + "'" + "," + "'" + boatLength + "'" + ")";
            connection.AddBoatAndEditUser(addBoatQuery);
        }

        public void EditBoat(int userChoice, int userBoatChoice, string newBoatLength, string newBoatype)
        {
            SqlConnection connection = new SqlConnection();
            string editBoatQuery = "UPDATE boat SET boattypeID='" + newBoatype + "'" + ", boatlength='" + newBoatLength + "'" + " WHERE boatID='" + userChoice + "'";
            connection.AddUserAndEditBoat(editBoatQuery);
        }

        public void DeleteBoat(int userChoice, int userBoatChoice)
        {
            SqlConnection connection = new SqlConnection();
            string deleteBoatQuery = "CALL `deleteBoat`" + "(" + userBoatChoice + ");";
            connection.Delete(deleteBoatQuery);
        }
    }
}