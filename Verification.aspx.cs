using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Verification : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        var id = (from a in linq_obj.memberid_msts
                  where a.intglcode == Convert.ToInt32(Session["memberid"])
                  select a).Single();
        if (id.verification_code == txt_vericode.Text)
        {
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            Page.RegisterStartupScript("onload", "<script language='javascript'>alert('** Incorrect your verification code**')</script> ");
        }

    }
}