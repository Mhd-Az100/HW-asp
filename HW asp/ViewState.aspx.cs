using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW_asp
{
    public partial class ViewState : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) TextBox1.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Click"] != null) count = (int)ViewState["Click"] + 1; TextBox1.Text = count.ToString(); ViewState["Click"] = count;
        }
    }
}