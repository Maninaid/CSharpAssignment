using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DROPDOWN
{
    public partial class Fruits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Banana", "cherry", "Mango", "pineapple", "strawberry" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }





        }





        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jpg";





        }



        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {





        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Banana")
            {
                TextBox1.Text = "Rs 50/-";
            }
            else if (DropDownList1.Text == "cherry")
            {
                TextBox1.Text = "Rs 200/-";
            }
            else if (DropDownList1.Text == "Mango")
            {
                TextBox1.Text = "Rs 75/-";
            }
            else if (DropDownList1.Text == "pineapple")
            {
                TextBox1.Text = "Rs 100/-";
            }
            else if (DropDownList1.Text == "strawberry")
            {
                TextBox1.Text = "Rs 300/-";
            }





            else
            {
                TextBox1.Text = "Rs 500/-";
            }
        }
    }
}