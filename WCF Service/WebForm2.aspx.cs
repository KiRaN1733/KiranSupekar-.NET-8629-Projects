using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFservice
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //WebForm2 f = new WebForm2();
            CustomerDBDataContext dc = new CustomerDBDataContext();
            Customer customer = new Customer();
            // customer.Customer_id = int.Parse(txtId.Text);
            
            customer.Customer_name = txtName.Text;
            customer.Customer_mobile = txtCountry.Text;
            dc.Customers.InsertOnSubmit(customer);
            dc.SubmitChanges();
            Server.Transfer("WebForm1.aspx");

        }
    }
}