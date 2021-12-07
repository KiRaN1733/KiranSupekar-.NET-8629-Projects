using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using System.Data;

namespace WCFservice
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        CustomerData GetCustomers();
    }
    [DataContract]
    public class CustomerData
    {
        [DataMember]
        public DataTable CustomersTable { get; set; }

        public CustomerData()
        {
            this.CustomersTable = new DataTable("Customers");
        }
    }
}
