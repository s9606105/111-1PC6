using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] sa = new string[] { "台科", "北科", "亞東"};
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int a_i = 0; a_i < sa.Length; a_i ++)
            {
                ListItem l_t = new ListItem();
                l_t.Text = l_t.Value = sa[a_i];
                //Response.Write(l_t.Text + "<br>" + l_t.Value + "<br>");
                ddl_Test.Items.Add(l_t);
            }
        }
    }
}