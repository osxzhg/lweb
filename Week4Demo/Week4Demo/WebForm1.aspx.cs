﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week4Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(TextBox1.Text);
            int sn = Convert.ToInt32(TextBox2.Text);
            int r = fn + sn;

            TextBox3.Text = r.ToString();
        }
    }
}