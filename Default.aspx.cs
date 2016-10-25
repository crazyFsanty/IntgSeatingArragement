using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // Click events for 2nd Chair & TextBox // 
    protected void ImageButton14_Click1(object sender, ImageClickEventArgs e)   
    {
        if (ImageButton14.ImageUrl == "~/Images/animated-chair-image.gif")//chair stops revolving and write the data into text box// 
        {
            ImageButton14.ImageUrl = "Images/animated-chair-image%20-%20Copy.png";
            TextBox2.Text = DropDownList1.Text;
        }
         else
         {
             ImageButton14.ImageUrl = "~/Images/animated-chair-image.gif";//else let the chair revolve & do not allow data to be written in the text box//
             TextBox2.Text = string.Empty;
         }

        if (DropDownList1.Text==TextBox1.Text) //preventing an already seated person to be seated again and keep the chair revolving,error pop up//     
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", 
                "<script>alert('Oops!! This Nigga is already seated');</script>");
            TextBox2.Text = string.Empty;
            ImageButton14.ImageUrl = "~/Images/animated-chair-image.gif";
        }
       
    }
    // Click events for 1st Chair & TextBox // 
    protected void ImageButton13_Click1(object sender, ImageClickEventArgs e)
    {
        if (ImageButton13.ImageUrl == "~/Images/animated-chair-image.gif")
        {
            ImageButton13.ImageUrl = "Images/animated-chair-image%20-%20Copy.png";
            TextBox1.Text = DropDownList1.Text;
        }
        else
        {
            ImageButton13.ImageUrl = "~/Images/animated-chair-image.gif";
            TextBox1.Text = string.Empty;
        }
    }
    // Click events for 3r Chair & TextBox // 
    protected void ImageButton15_Click1(object sender, ImageClickEventArgs e)
    {
        if (ImageButton15.ImageUrl == "~/Images/animated-chair-image.gif")
        {
            ImageButton15.ImageUrl = "Images/animated-chair-image%20-%20Copy.png";
            TextBox3.Text = DropDownList1.Text;
        }
        else
        {
            ImageButton15.ImageUrl = "~/Images/animated-chair-image.gif";
            TextBox3.Text = string.Empty;
        }
    }
    // Click events for 4th Chair & TextBox // 
    protected void ImageButton16_Click1(object sender, ImageClickEventArgs e)
    {
        if (ImageButton16.ImageUrl == "~/Images/animated-chair-image.gif")
        {
            ImageButton16.ImageUrl = "Images/animated-chair-image%20-%20Copy.png";
            TextBox4.Text = DropDownList1.Text;
        }
        else
        {
            ImageButton16.ImageUrl = "~/Images/animated-chair-image.gif";
            TextBox4.Text = string.Empty;
        }
    }
}