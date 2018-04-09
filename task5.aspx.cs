using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static string GetAudio()
    {
        return "audio1.mp3";
    }
    [WebMethod]
    public static string GetVideo()
    {
        return "video1.mp4";
    }
   
}