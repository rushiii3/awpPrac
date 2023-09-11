using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void UserCustomValidate(object source, ServerValidateEventArgs args)
    {
        int val = Int32.Parse(args.Value.Substring(0, 1));
        if (val == 4)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
}
