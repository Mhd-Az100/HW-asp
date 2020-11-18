using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW_asp
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = TextBox1.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            TextBox1.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"]==null)
            { TextBox2.Text = "no cookies found"; }
            else
            {
                TextBox2.Text = Request.Cookies["name"].Value;
            }
        }
    }
}