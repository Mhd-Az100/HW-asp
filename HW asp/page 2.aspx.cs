﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW_asp
{
    public partial class page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString.Get("name");
            Response.Write("hello" + name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = true;
        }
    }
}