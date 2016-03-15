using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataClassesDataContext linq_obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
    }
    public string base64Decode(string sData)
    {

        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

        System.Text.Decoder utf8Decode = encoder.GetDecoder();

        byte[] todecode_byte = Convert.FromBase64String(sData);

        int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);

        char[] decoded_char = new char[charCount];

        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);

        string result = new String(decoded_char);

        return result;

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        int flag = 0;
        var id = (from a in linq_obj.memberid_msts
                  select a).ToList();
        for (int i = 0; i < id.Count(); i++)
        {
            if (id[i].username == txt_username.Text && base64Decode(id[i].password) == txt_password.Text && id[i].status == "Active" && id[i].date_of_expiry > Convert.ToDateTime(System.DateTime.Now))
            {
                Session["memberid"] = id[i].intglcode;
                Session["name"] = id[i].username;
                flag = 1;

                Random rnd = new Random();
                int startNumber = rnd.Next(1, 9000);

                string rndno = startNumber.ToString();


                var id2 = (from a in linq_obj.memberid_msts
                           where a.intglcode == id[i].intglcode
                           select a).Single();
                id2.verification_code = rndno;
              
                string script = " <script type=\"text/javascript\"> PageLoad2();   </script> ";

                    break;

            }

        }
        if (flag == 1)
        {
            Response.Redirect("Verification.aspx");
        }
        else
        {
            Page.RegisterStartupScript("onload", "<script language='javascript'>alert('** Incorrect UserName or Password OR Your Account is not Active OR Your Account is expire Please Contact To Admin**')</script> ");
        }


    }
    
}