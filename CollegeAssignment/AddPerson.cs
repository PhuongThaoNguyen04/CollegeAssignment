using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeAssignment
{
    internal class AddPerson : DAO
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable ShowStu()
        {
            string select = "uspAllStu";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable ShowLec()
        {
            string select = "uspAllLec";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            da.SelectCommand = cmd; //execute the command
            da.Fill(dt);
            return dt;
        }
        public DataTable ShowMaleLec()
        {
            string select = "uspGetMaleLec";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        public DataTable ShowFemaleStu()
        {
            string select = "SELECT * FROM Student WHERE Gender = 'Female'";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            da.SelectCommand = cmd; //execute the command
            da.Fill(dt);
            return dt;
        }
        public DataTable StuAbove25()
        {
            string select = "uspGetStuAbove25";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        public DataTable LecBelow25()
        {
            string select = "SELECT * FROM Lecturer WHERE DATEDIFF(YEAR, DOB, GETDATE()) < 25";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            da.SelectCommand = cmd; //execute the command
            da.Fill(dt);
            return dt;
        }
        public DataTable StuDub()
        {
            string select = "uspStuDub";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        public DataTable LecDub()
        {
            string select = "SELECT * FROM Student WHERE County = 'Dublin'";
            SqlCommand cmd = new SqlCommand(select, OpenCon());
            da.SelectCommand = cmd; //execute the command
            da.Fill(dt);
            return dt;
        }
        public void AddStudent(string fn, string sn, string dob, int age, string add, string cy, string ge, string mail, string phone, string cse, string soc)
        {
            //sql statement
            string insert = "INSERT INTO Student(Firstname, Surname, DOB, Age, Address, County, Gender, Email, [Phone Number], Course, Society) VALUES(@fn, @sn, @dob, @age, @add, @cy, @ge, @mail, @phone, @cse, @soc)";
            //sql command
            SqlCommand cmd = new SqlCommand(insert, OpenCon());

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@cse", cse);
            cmd.Parameters.AddWithValue("@soc", soc);

            cmd.ExecuteNonQuery();
        }

        public void AddLecturer(string fn, string sn, string dob, string add, string cy, string ge, string mail, string phone, decimal salary)
        {
            //sql statement
            string insert = "INSERT INTO Lecturer(Firstname, Surname, DOB, Address, County, Gender, Email, [Phone Number], Salary) VALUES(@fn, @sn, @dob, @add, @cy, @ge, @mail, @phone, @salary)";
            //sql command
            SqlCommand cmd = new SqlCommand(insert, OpenCon());

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@salary", salary);

            cmd.ExecuteNonQuery();
        }

        public void UpdateStudent(int id, string fn = null, string sn = null, string dob = null, string add = null, string cy = null, string ge = null, string mail = null, string phone = null, string cse = null, string soc = null)
        {
            // SQL UPDATE statement
            string update = "UPDATE Student SET ";

            // Create a list to store parameter values
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add each field to update if provided
            if (fn != null)
            {
                update += "Firstname = @fn, ";
                parameters.Add(new SqlParameter("@fn", fn));
            }
            if (sn != null)
            {
                update += "Surname = @sn, ";
                parameters.Add(new SqlParameter("@sn", sn));
            }
            if (dob != null)
            {
                update += "DOB = @dob, ";
                parameters.Add(new SqlParameter("@dob", dob));
            }
            if (add != null)
            {
                update += "Address = @add, ";
                parameters.Add(new SqlParameter("@add", add));
            }
            if (cy != null)
            {
                update += "County = @cy, ";
                parameters.Add(new SqlParameter("@cy", cy));
            }
            if (ge != null)
            {
                update += "Gender = @ge, ";
                parameters.Add(new SqlParameter("@ge", ge));
            }
            if (mail != null)
            {
                update += "Email = @mail, ";
                parameters.Add(new SqlParameter("@mail", mail));
            }
            if (phone != null)
            {
                update += "[Phone Number] = @phone, ";
                parameters.Add(new SqlParameter("@phone", phone));
            }
            if (cse != null)
            {
                update += "Course = @cse, ";
                parameters.Add(new SqlParameter("@cse", cse));
            }
            if (soc != null)
            {
                update += "Society = @soc, ";
                parameters.Add(new SqlParameter("@soc", soc));
            }

            // Remove the trailing comma and space
            update = update.TrimEnd(',', ' ');

            // Add the WHERE clause
            update += " WHERE StudentID = @id";

            using (SqlCommand cmd = new SqlCommand(update, OpenCon()))
            {
                // Add the ID parameter
                parameters.Add(new SqlParameter("@id", id));

                // Add all parameters to the command
                cmd.Parameters.AddRange(parameters.ToArray());

                // Execute the SQL command
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateLec(int id, string fn = null, string sn = null, string dob = null, string add = null, string cy = null, string ge = null, string mail = null, string phone = null, decimal? salary = null)
        {
            // SQL UPDATE statement
            string update = "UPDATE Lecturer SET ";

            // Create a list to store parameter values
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add each field to update if provided
            if (fn != null)
            {
                update += "Firstname = @fn, ";
                parameters.Add(new SqlParameter("@fn", fn));
            }
            if (sn != null)
            {
                update += "Surname = @sn, ";
                parameters.Add(new SqlParameter("@sn", sn));
            }
            if (dob != null)
            {
                update += "DOB = @dob, ";
                parameters.Add(new SqlParameter("@dob", dob));
            }
            if (add != null)
            {
                update += "Address = @add, ";
                parameters.Add(new SqlParameter("@add", add));
            }
            if (cy != null)
            {
                update += "County = @cy, ";
                parameters.Add(new SqlParameter("@cy", cy));
            }
            if (ge != null)
            {
                update += "Gender = @ge, ";
                parameters.Add(new SqlParameter("@ge", ge));
            }
            if (mail != null)
            {
                update += "Email = @mail, ";
                parameters.Add(new SqlParameter("@mail", mail));
            }
            if (phone != null)
            {
                update += "[Phone Number] = @phone, ";
                parameters.Add(new SqlParameter("@phone", phone));
            }
            if (salary != null)
            {
                update += "Salary = @salary";
                parameters.Add(new SqlParameter("@salary", (object)salary ?? DBNull.Value));
            }

            // Remove the trailing comma and space
            update = update.TrimEnd(',', ' ');

            // Add the WHERE clause
            update += " WHERE Id = @id";

            using (SqlCommand cmd = new SqlCommand(update, OpenCon()))
            {
                // Add the ID parameter
                parameters.Add(new SqlParameter("@id", id));

                // Add all parameters to the command
                cmd.Parameters.AddRange(parameters.ToArray());

                // Execute the SQL command
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteStudent(int id)
        {             
            string delete = "DELETE FROM Student WHERE StudentID = @id ";

            SqlCommand cmd = new SqlCommand(delete, OpenCon());
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }
        
        public void DeleteLec(int id)
        {
            string delete = "DELETE FROM Lecturer WHERE Id = @id ";

            SqlCommand cmd = new SqlCommand(delete, OpenCon());
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }
    }


}
