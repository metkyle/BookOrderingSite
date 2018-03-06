using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShippingInfo : System.Web.UI.Page
{
    ShoppingCart theCart = new ShoppingCart();
    int value = 0;
    double totalPrice = 0, bookPrice = 0;
    string[] seperators = { "ounces", "pounds", " " };
    string[] weightWithoutUnit;
    double totalWeight = 0;
    int i = 50;
    double shippingPrice = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        theCart = (ShoppingCart)Session["finalCart"];
        value = theCart.getCartList().Count;
        /*double totalPrice = 0, bookPrice = 0;
        string[] seperators = { "ounces", "pounds", " " };
        string[] weightWithoutUnit;
        double totalWeight = 0;
        int i = 0;
        double shippingPrice = 0;*/

        foreach(Books book in theCart.getCartList())
        {
            
            bookPrice += double.Parse(book.getPrice());
            weightWithoutUnit = book.getWeight().Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            totalWeight += double.Parse(weightWithoutUnit[0]);
           
        }
        
        shippingPrice = (totalWeight * .20);

        itemLbl.Text = value.ToString();
        weightLbl.Text = totalWeight.ToString();
        bookPriceLbl.Text = bookPrice.ToString();
        shippingCostLbl.Text = shippingPrice.ToString();
        totalPrice = (bookPrice + shippingPrice);
        totalLbl.Text = totalPrice.ToString();
        quantityLbl.Text = value.ToString();


    }

    protected void cmdOK_Click(object sender, EventArgs e)
    {
       
        if (!Page.IsValid)
            return;

        Session["email"] = emailBox.Text;
        CreateEmailItem();
        Response.Redirect("ConfirmationPage.aspx");
           
    }

    private void CreateEmailItem()
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("abc@mydomain.com", "EWU Books Store");
        mail.To.Add(emailBox.Text);
        mail.IsBodyHtml = true;
        mail.Subject = "Book Order Num: ABC." + i;
        mail.Body = "Your Order of Books has been processed! This is a confirmation e-mail.<br/><br/>";
        mail.Body += "Your order number is "+ i + " which contains:<br/>";
        foreach(Books book in theCart.getCartList())
        {
            mail.Body += book.getTitle() + "  $ " + book.getPrice() + "<br/>";
        }
        mail.Body += "<br/>Total Quantity Ordered: " + quantityLbl.Text + "<br/>";
        mail.Body += "Total Shipping Cost: " + shippingCostLbl.Text + "<br/>";
        mail.Body += "Total Price: " + totalLbl.Text + "<br/><br/>";
        mail.Body += "Kyle Metcalfe<br/>123 Nowhere Ln<br/>The Void<br/>South Dakota<br/>12345<br/>";
        mail.Priority = MailPriority.High;

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new System.Net.NetworkCredential("metkyle@gmail.com", "Spinwheel7");
        smtp.EnableSsl = true;

        smtp.Send(mail);
    }

   protected void cmd_ContinueShopping()
    {
        Response.Redirect("Default.aspx");
    }
}