using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseLayer.User user = new DatabaseLayer.User
                {
                    Email = txtEmail.Value,
                    IsActive = true,
                    Password = txtPassword.Value,
                    Phone = txtPhone.Value,
                    Username = txtUsername.Value
                };

                using (DatabaseLayer.EMSDBEntities db = new DatabaseLayer.EMSDBEntities())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    message.InnerText = "Your data has been saved successfully";
                }
            }
            catch(Exception ex)
            {
                message.InnerText = "An error occurred while trying to save your data";
            }
        }
    }
}