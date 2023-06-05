    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace CapstonePrototype
    {//Read all comments under all methods
        internal class DatabaseCodes
        {
            private static string connectionString = "Data Source=NATANAUAN\\SQLEXPRESS;Initial Catalog=prototype;Integrated Security=True";

        //--------------------------- FOR CASUAL SECTION ---------------------------
        public static void InsertPlateNumberCasual(string plateNumber, string name, string vehicleType, DateTime timeIn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Casual_raw(plateNumber, name, vehicleType, TimeIn) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn)", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);

                command.ExecuteNonQuery();
            }
        }//Inserts a new casual parking record with plate number, name, vehicle type, and time in.


        public static DataTable GetAllPlateNumbersCasual()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT plateNumber, name, vehicleType, CONVERT(varchar, TimeIn, 108) AS TimeIn, TimeOut, Rate FROM Casual_raw", connection);
                adapter.Fill(dt);

                // Modify the format of the TimeOut column to display only hours, minutes, and seconds
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TimeIn"] != DBNull.Value)
                    {
                        row["TimeIn"] = DateTime.Parse(row["TimeIn"].ToString()).ToString("HH:mm:ss");
                    }
                }
            }
            return dt;
        }//Retrieves all casual parking records.

        public static void UpdatePlateNumberCasual(string oldPlateNumber, string newPlateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Casual_raw SET plateNumber = @newPlateNumber WHERE plateNumber = @oldPlateNumber", connection))
                {
                    command.Parameters.AddWithValue("@newPlateNumber", newPlateNumber);
                    command.Parameters.AddWithValue("@oldPlateNumber", oldPlateNumber);

                    command.ExecuteNonQuery();
                }
            }
        }//Updates the plate number of a casual parking record.

        public static void InsertTimeOutForCasual(string plateNumber, DateTime timeOut, bool isDiscountApplied, bool isTicketLost)

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Calculate the duration and rate
                SqlCommand durationCommand = new SqlCommand("SELECT TimeIn FROM Casual_raw WHERE plateNumber = @PlateNumber", connection);
                durationCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);
                DateTime timeIn = (DateTime)durationCommand.ExecuteScalar();
                TimeSpan duration = timeOut - timeIn;

                int rate = 0;
                if (duration.TotalMinutes > 10) // Check if the duration exceeds the 10-minute grace period
                {
                    if (duration.TotalHours <= 2)
                    {
                        rate = 20;
                    }
                    else
                    {
                        int additionalHours = (int)Math.Ceiling(duration.TotalHours - 2);
                        rate = 20 + additionalHours * 10;
                    }
                }

                if (isDiscountApplied)
                {
                    rate = (int)(rate * 0.8); // Apply a 20% discount
                }

                if (isTicketLost)
                {
                    rate += 200; // Add a 200 penalty for a lost ticket
                }

                SqlCommand command = new SqlCommand("UPDATE Casual_raw SET TimeOut = @TimeOut, Rate = @Rate WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);

                command.ExecuteNonQuery();
            }
        }//Inserts the time out value for a casual parking record and calculates the rate based on the duration.

        public static void InsertCasualLog(string plateNumber, string name, string vehicleType, DateTime timeIn, DateTime timeOut, decimal rate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Casual_log (plateNumber, name, vehicleType, TimeIn, TimeOut, Rate) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn, @TimeOut, @Rate)", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);

                command.ExecuteNonQuery();
            }
        }//Inserts a casual parking record into the log.

        public static DataTable GetAllPlateNumbersCasualLog()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT plateNumber, name, vehicleType, TimeIn, TimeOut, Rate FROM Casual_log", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//Retrieves all casual parking log records.

        public static void DeleteFromCasualRaw(string plateNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Casual_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }//Deletes a casual parking record.


        //--------------------------- FOR FLATRATE SECTION ---------------------------
        public static void InsertPlateNumberFlatrate(string plateNumber, string name, string vehicleType, DateTime timeIn)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Flatrate_raw(plateNumber, name, vehicleType, TimeIn) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn)", connection);
                    command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@VehicleType", vehicleType);
                    command.Parameters.AddWithValue("@TimeIn", timeIn);

                    command.ExecuteNonQuery();
                }
        }//Inserts a new flatrate parking record with plate number, name, vehicle type, and time in.

        public static DataTable GetAllPlateNumbersFlatrate()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT plateNumber, name, vehicleType, CONVERT(varchar, TimeIn, 108) AS TimeIn, TimeOut, Rate FROM Flatrate_raw", connection);
                    adapter.Fill(dt);

                    // Modify the format of the TimeOut column to display only hours, minutes, and seconds
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["TimeIn"] != DBNull.Value)
                        {
                            row["TimeIn"] = DateTime.Parse(row["TimeIn"].ToString()).ToString("HH:mm:ss");
                        }
                    }
                }
                return dt;
        }//Retrieves all flatrate parking records.


        public static void UpdatePlateNumberFlatrate(string oldPlateNumber, string newPlateNumber)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE Flatrate_raw SET plateNumber = @newPlateNumber WHERE plateNumber = @oldPlateNumber", connection))
                    {
                        command.Parameters.AddWithValue("@newPlateNumber", newPlateNumber);
                        command.Parameters.AddWithValue("@oldPlateNumber", oldPlateNumber);

                        command.ExecuteNonQuery();
                    }
                }
        }//Updates the plate number of a flatrate parking record.


        public static void InsertTimeOutForFlatrate(string plateNumber, DateTime timeOut)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Calculate the duration and rate
                SqlCommand durationCommand = new SqlCommand("SELECT TimeIn FROM Flatrate_raw WHERE plateNumber = @PlateNumber", connection);
                durationCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);
                DateTime timeIn = (DateTime)durationCommand.ExecuteScalar();
                TimeSpan duration = timeOut - timeIn;

                int baseRate = 20;
                int penaltyRate = 500;//penalty for over staying
                DateTime penaltyTime = new DateTime(timeIn.Year, timeIn.Month, timeIn.Day, 21, 0, 0); // 9 PM on the same day

                int rate = baseRate;
                if (timeOut > penaltyTime)
                {
                    rate += penaltyRate;
                }//if the vehicle stays beyond 9pm

                SqlCommand command = new SqlCommand("UPDATE Flatrate_raw SET TimeOut = @TimeOut, Rate = @Rate WHERE plateNumber = @PlateNumber", connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Rate", rate);

                command.ExecuteNonQuery();
            }
        }//Inserts the time out value for a flatrate parking record and calculates the rate based on the duration, including any penalties for overstaying.



        public static void InsertFlatrateLog(string plateNumber, string name, string vehicleType, DateTime timeIn, DateTime timeOut, decimal rate)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Flatrate_log (plateNumber, name, vehicleType, TimeIn, TimeOut, Rate) VALUES (@PlateNumber, @Name, @VehicleType, @TimeIn, @TimeOut, @Rate)", connection);
                    command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@VehicleType", vehicleType);
                    command.Parameters.AddWithValue("@TimeIn", timeIn);
                    command.Parameters.AddWithValue("@TimeOut", timeOut);
                    command.Parameters.AddWithValue("@Rate", rate);

                    command.ExecuteNonQuery();
                }
            }//Inserts a flatrate parking record into the log.


        public static DataTable GetAllPlateNumbersFlatrateLog()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT plateNumber, name, vehicleType, TimeIn, TimeOut, Rate FROM Flatrate_log", connection);
                adapter.Fill(dt);

            }
            return dt;
        }//Retrieves all flatrate parking log records.


        public static void DeleteFromFlatrateRaw(string plateNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Flatrate_raw WHERE PlateNumber = @PlateNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }//Deletes a flatrate parking record.

    }
}
