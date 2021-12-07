using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFservice
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId3.Focus();
        }

        protected void btnDelete3_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDBDataContext dc = new CustomerDBDataContext();
                int Eno = int.Parse(txtId3.Text);
                Customer customer = dc.Customers.SingleOrDefault(E => E.Customer_id == Eno);
                dc.Customers.DeleteOnSubmit(customer);
                dc.SubmitChanges();
                Response.Redirect("~/WebForm1.aspx");
            }
            catch(Exception ex)
            {
                Response.Write(" ID not available in record.");

            }
        }
    }
}