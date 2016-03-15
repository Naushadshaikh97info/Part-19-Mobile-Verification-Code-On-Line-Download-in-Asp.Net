using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

       
      

        //// Create An instance of the Process class responsible for starting the newly process.

        //System.Diagnostics.Process process1 = new System.Diagnostics.Process();

        //// Set the directory where the file resides

        //process1.StartInfo.WorkingDirectory = Request.MapPath("~/upload/");

        //// Set the filename name of the file you want to open

        //process1.StartInfo.FileName = Request.MapPath("~/upload/TrackerSetup.exe");

        //// Start the process

        //process1.Start(); 
    }
}