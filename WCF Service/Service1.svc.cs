using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.SqlClient;

namespace WCFservice
{
    public class Service1 : IService1
    {
       public CustomerData GetCustomers()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select Customer_id, Customer_name,Customer_mobile from Customers");
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd; 
            CustomerData customers = new CustomerData();
            sda.Fill(customers.CustomersTable);
            return customers;
        }
    }
}
