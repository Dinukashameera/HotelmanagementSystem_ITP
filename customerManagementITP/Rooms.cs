using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace customerManagementITP
{
    class Rooms
    {


        //method to get rooms List from database
        //get room list according to the room type
        private SqlConnection sqlcon = DBConnection.getConnection();
        public DataTable getRoomList(String type)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Accomodation a, room r where a.accID = r.roomId and r.roomName = @type and a.Status = 'NOT OCCUPIED'", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@type", type);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }


        //Update Accomodation SET Status = 'Occupied', customer_id = @id WHERE accID = @roomId

        //booking the room for respective customer
        public Boolean BookRoom(String roomId,int customerId)
        {   
                SqlCommand command = new SqlCommand("roomBook", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
            
                command.Parameters.AddWithValue("@roomId", roomId);
                command.Parameters.AddWithValue("@id", customerId);

            DBConnection.openDBConnection();
            if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Added sucessfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;

                }
                else
                {
                    MessageBox.Show("Error When adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;

                }
         }

        public DataTable RoomDetails()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Accomodation WHERE accID LIKE 'R%'", sqlcon);
            //command.ExecuteNonQuery();
            //connection.openConnection();
            DataTable datatable = new DataTable();
            SqlDataAdapter sqldapter = new SqlDataAdapter(command);
            sqldapter.Fill(datatable);

            return datatable;

        }


        public float GetRoomCheckinCost(int customer_id)
        {
            //getting the accomodation cost of rooms
            float total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getRoomCheckinCost(@cid)", sqlcon);

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();
            total = float.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }

        public String getRoomType(String roomId)
        {
            String type = null; 
            SqlCommand command = new SqlCommand("SELECT [dbo].getType(@roomId)", sqlcon);

            command.Parameters.AddWithValue("@roomId", roomId);

            DBConnection.openDBConnection();
            type = command.ExecuteScalar().ToString();
            DBConnection.closeDBConnection();
            return type;
        }

        public int getFloor(String roomId)
        {
            int floor = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getFloor(@roomId)", sqlcon);

            command.Parameters.AddWithValue("@roomId", roomId);

            DBConnection.openDBConnection();
            try
            {
                floor = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("" + ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DBConnection.closeDBConnection();
            return floor;
        }



        public DataTable getAllRoom()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM", sqlcon);
            command.CommandType = CommandType.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }



        public Boolean UpdateRoom(String roomId,String roomType,int floor)
        {
            SqlCommand command = new SqlCommand("updateRoom", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@roomType", roomType);
            command.Parameters.AddWithValue("@floor", floor);



            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() == 2)
            {
                MessageBox.Show("Updated sucessfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;

            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Room cannot be Updated, It is Occupied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;
            }

            else
            {
                MessageBox.Show("Error When updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;

            }
        }



        public Boolean AddNewRooms(String roomId,String roomtype,int floor)
        {
            SqlCommand command = new SqlCommand("AddNewRooms", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@roomId",roomId);
            command.Parameters.AddWithValue("@roomType",roomtype);
            command.Parameters.AddWithValue("@floor",floor);

            DBConnection.openDBConnection();

            try
            {
                if (command.ExecuteNonQuery() == 2)
                {
                    MessageBox.Show("New Room Added sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBConnection.closeDBConnection();
                    return true;
                }
                else
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBConnection.closeDBConnection();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The Room Number Already Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

        }


        public int getTotalOccupancy()
        {
            int occupancy = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getTotalOccupancy()", sqlcon);

            DBConnection.openDBConnection();
            occupancy = int.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return occupancy;
        }


        public int getDeluxeAvailabilty()
        {
            int occupancy = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getDeluxeAvailabilty()", sqlcon);

            DBConnection.openDBConnection();
            occupancy = int.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return occupancy;
        }

        public int getPremiumAvailabilty()
        {
            int occupancy = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getPremiumAvailabilty()", sqlcon);

            DBConnection.openDBConnection();
            occupancy = int.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return occupancy;
        }


        public int getSuperiorAvailabilty()
        {
            int occupancy = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getSuperiorAvailabilty()", sqlcon);

            DBConnection.openDBConnection();
            occupancy = int.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return occupancy;
        }


        public DataTable getCustomerRoom(int id)
        {
            SqlCommand command = new SqlCommand("SELECT accID FROM Accomodation WHERE customer_id =  @id", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }




    }
}
