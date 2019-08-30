using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int maximun;
            string ret = "";

            try
            {
                maximun = int.Parse(Max.Text);
            }
            catch (FormatException)
            {
                maximun = 0;
            }
            catch (ArgumentNullException)
            {
                maximun = 0;
            }
            catch (OverflowException)
            {
                maximun = 0;
            }

            if (maximun > 0)
            {
                int i = 1;
                while (i <= maximun)
                {
                    ret += "<div class='row'>";
                    ret += "<div class='col-2'>";
                    ret += "</div>";
                    for (int j = 0; j < 5 && i <= maximun; j++, i++)
                    {
                        ret += "<div class='col-2'>";
                        if (i % 2 == 0)
                        {
                            ret += "<table class='table table-hover table-bordered' > ";
                        }
                        else
                        {
                            ret += "<table class='table table-hover table-primary table-bordered' > ";
                        }

                        for (int k = 0; k < 11; k++)
                        {
                            ret += "<tr>";
                            ret += $"<td>{i} X {k} = {i * k}</td>";
                            ret += "</tr>";
                        }
                        ret += "</table>";
                        ret += "</div>";
                    }
                    ret += "</div>";
                }
            }
            Tabuada.Text = ret;
        }
    }
}