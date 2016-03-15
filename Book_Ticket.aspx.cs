using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Book_Ticket : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        var id = (from a in linq_obj.exe_msts
                  orderby a.intglcode descending
                  select a).ToList();
        // Create An instance of the Process class responsible for starting the newly process.

        System.Diagnostics.Process process1 = new System.Diagnostics.Process();

        // Set the directory where the file resides

        process1.StartInfo.WorkingDirectory = Request.MapPath("~/upload/");

        // Set the filename name of the file you want to open

        process1.StartInfo.FileName = Request.MapPath("~/upload/"+id[0].exefile);

        // Start the process

        process1.Start(); 
    }
}