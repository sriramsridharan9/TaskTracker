﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTT.Usr_Ctl
{
    public partial class Footer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFooter1.Text = "Personal Task Tracker";
        }
    }
}