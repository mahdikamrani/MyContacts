using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace MyContacts
{
    interface IContactsRepository
    {
        DataTable selectAll();

        DataTable selectRow(int ContactID);

        DataTable search(string parameter);
        bool insert(string name,string family,string email,string phoneNumber, int age,string address);

        bool update(int ContactID, string name, string family, string email, string phoneNumber, int age, string address);

        bool delete(int ContactID);
        
    }
}
