using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;


namespace MyContacts


{
    public class ContactsRepository : IContactsRepository
    {
        private string Connectionstring = "Data Source=.\\SQL2019;Initial Catalog=Contact_DB;Integrated Security=true";

        public bool delete(int ContactID)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\SQL2019;Initial Catalog=Contact_DB;Integrated Security=true");
            
            try
            {
                string query = "Delete From Table_1 where ContactID=@ID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", ContactID);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }



        public bool insert(string name, string family, string email, string phoneNumber, int age, string address)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\SQL2019;Initial Catalog=Contact_DB;Integrated Security=true");
            try
            {
                string query = "Insert Into Table_1 (Name,Family,Email,Age,phoneNumber,Address) values (@Name,@Family,@Email,@Age,@phoneNumber,@Address)";
                
                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();


                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable search(string parameter)
        {
            string query = "select * From Table_1 Where  Name like @parameter or Family like @parameter";

            SqlConnection connection = new SqlConnection(Connectionstring);

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();

            adapter.Fill(data);

            return data;
        }

        public DataTable selectAll()
        {
            string query = "select * From Table_1";

            SqlConnection connection = new SqlConnection(Connectionstring);

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable data = new DataTable();

            adapter.Fill(data);

            return data;
        }

        public DataTable selectRow(int ContactID)
        {
            string query = "select * From Table_1 where ContactID=" + ContactID;
            SqlConnection connection = new SqlConnection(Connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool update(int ContactID, string name, string family, string email, string phoneNumber, int age, string address)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string query = "Update Table_1 Set Name=@Name,Family=@Family,phoneNumber=@phoneNumber,Email=@Email,Age=@Age,Address=@Address Where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", ContactID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Address", address);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
    
}

