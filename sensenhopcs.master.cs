using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sensenhopcs : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        mstrpagedate.Text = DateTime.Today.ToString("MMMM dd yyyy");
  
    }
}
