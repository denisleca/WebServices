using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebAplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
           CalculatorReference.WebService1SoapClient client=
                new CalculatorReference.WebService1SoapClient();
            int result=client.Add(Convert.ToInt32(textFirstNumber.Text), 
                Convert.ToInt32(textSecondNumber.Text));
            LabeResult.Text=result.ToString();
        }
    }
}