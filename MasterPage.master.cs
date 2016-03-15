using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack)
        //    return;
        //if (Session["name"] == null)
        //{
        //    Response.Redirect("Default.aspx");
        //}
        //else
        //{
        //    lbl_admin_name.Text = "Welcome" + "&nbsp;&nbsp;" + Session["name"].ToString();
        //}
        //string final;
        //var id = (from a in linq_obj.memberid_msts
        //          where a.intglcode == Convert.ToInt32(Session["memberid"])
        //          select a).ToList();
        //DateTime aaa = System.DateTime.Now;
        //DateTime abc = Convert.ToDateTime(id[0].date_of_expiry);
        //System.TimeSpan diff2 = abc - aaa;
        //string[] words = diff2.ToString().Split(new char[] { '.' });
        //if (words[0].Length == 1)
        //{
        //     final = "0" + words[0];
        //}
        //else
        //{
        //    final = words[0];
        //}

        //Label1.Text = "  Your Licence Id Expired in" + "&nbsp" + final + "&nbsp" + "Days";
    }
    protected void lnk_logout_Click(object sender, EventArgs e)
    {
        try
        {
            Session["memberid"] = "";
            Session["name"] = "";
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Default.aspx", false);
        }
        catch (Exception ex)
        {
        }
    }
    protected void lnk_logout1_Click(object sender, EventArgs e)
    {
        try
        {
            Session["username"] = "";
            Session["userid"] = "";
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Default.aspx", false);
        }
        catch (Exception ex)
        {
        }
    }
}
