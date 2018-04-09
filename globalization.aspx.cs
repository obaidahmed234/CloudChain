using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;
public partial class globalization : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected override void InitializeCulture()
    {
        if (Request["ctl00$ContentPlaceHolder1$DropDownList1"] != null)
        {
            string Lang = Request["ctl00$ContentPlaceHolder1$DropDownList1"];

            Thread.CurrentThread.CurrentCulture = new CultureInfo(Lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Lang);

        }
        base.InitializeCulture();
    }
}