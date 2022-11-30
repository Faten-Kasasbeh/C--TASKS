using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_11_task
{
    public partial class calculator : System.Web.UI.Page
    {

   
        protected void sum_Click(object sender, EventArgs e)
        {
                 double txt1 = Convert.ToDouble(input1.Text); 

         double txt2 = Convert.ToDouble(input2.Text);
       double sum = txt1 + txt2;
        output.Text = sum.ToString();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            double txt = Convert.ToDouble(input1.Text);

            double tx2 = Convert.ToDouble(input2.Text);

            double sub = txt - tx2;


            output.Text = sub.ToString();
        }

        protected void div_Click(object sender, EventArgs e)
        {
            double txt = Convert.ToDouble(input1.Text);

            double tx2 = Convert.ToDouble(input2.Text);

            double div = txt / tx2;


            output.Text = div.ToString();
        }

        protected void multi_Click(object sender, EventArgs e)
        {
            double txt = Convert.ToDouble(input1.Text);

            double tx2 = Convert.ToDouble(input2.Text);

            double multi = txt * tx2;


            output.Text = multi.ToString();
        }
    }
}