using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Configuration;

namespace CollegeAssignment
{
    internal class DAO
    {
        SqlConnection con;
        public DAO()
        {
            // choose the database
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
           //open the connection
           //if they already close -> broken
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    // Handle the exception (print or log the error message)
                    Console.WriteLine($"Error opening connection: {ex.Message}");
                }
            }
            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public int GetStudentID(string firstName, string surname)
        {
            int id = -1; // Default value if not found

            // SQL statement to retrieve the student ID based on FirstName and Surname
            string selectID = "SELECT StudentID FROM Student WHERE Firstname = @fn AND Surname = @sn";

            using (SqlConnection con = OpenCon())
            using (SqlCommand cmd = new SqlCommand(selectID, con))
            {
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@sn", surname);

                // Execute the SQL command and retrieve the student ID
                object result = cmd.ExecuteScalar();

                // If result is not null, convert it to int
                if (result != null && int.TryParse(result.ToString(), out id))
                {
                    return id;
                }
            }

            // Return -1 if student ID is not found
            return id;
        }
    }
}
