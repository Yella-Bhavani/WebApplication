using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Registration done successfully!!!";
            {
                if (txtusername.Text == "UserName")
                {
                    if (txtpwd.Text == "Password")
                    {
                        FormsAuthentication.RedirectFromLoginPage(txtusername.Text, false);
                    }
                    else
                    {
                        txtusername.Text = "Enter correct UserName";
                    }
                }
                else
                {
                    txtpwd.Text = "Enter correct Password";
                }
            }
        }
    }
    //public partial class Login : System.Web.UI.Page
    //{
    //    SqlConnection con;
    //    SqlCommand cmd;
    //    SqlDataReader srdr;
    //    string constr = "server=US-5CG016FLQ5\\SQLSERVER;database=OurSecureDb;trusted_connection=true";


    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    //        lblMsg.Visible = false;
    //    }
    //    protected void btnSignIn_Click(object sender, EventArgs e)
    //    {
    //        lblMsg.Visible = true;
    //        if ((txtUserName.Text == "sam") && (txtPwd.Text == "sam@1256"))
    //        {
    //            FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, true);
    //        }
    //        else
    //        {
    //            lblMsg.Text = "Either user name or Password Incorrect !!!";
    //        }

    //try
    //{
    //    con = new SqlConnection(constr);
    //    cmd = new SqlCommand
    //    {
    //        CommandText = "select UserName from UserLogin where UserName=@un and UserPwd=@upwd",
    //        Connection = con
    //    };
    //    cmd.Parameters.AddWithValue("@un", txtusername.Text);
    //    cmd.Parameters.AddWithValue("@upwd", txtpwd.Text);
    //    con.Open();
    //    srdr = cmd.ExecuteReader();
    //    if (srdr.HasRows)
    //    {
    //        FormsAuthentication.RedirectFromLoginPage(txtusername.Text, true);
    //    }
    //    else
    //    {
    //        lblMsg.Text = "Login Failed, Invalid Credential";
    //    }

    //}
    //catch (Exception ex)
    //{ lblMsg.Text = "Error" + ex.Message; }
    //finally
    //{ con.Close();
    //  Console.ReadKey();
    //}
}
    

