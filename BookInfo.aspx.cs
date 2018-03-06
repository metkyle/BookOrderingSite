using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookInfo : System.Web.UI.Page
{
    Books book;
    List<Books> theBooks = new List<Books>();

    protected void Page_Load(object sender, EventArgs e)
    {
        
            int ID = 0;
            ID = (int)Session["BookID"];
            book = null;

            if (ID == 1)
            {
                book = (Books)Session["Book0"];
                BigBookImage.ImageUrl = "./Pictures/BRCover.jpg";
          
            }
            if (ID == 2)
            {
                book = (Books)Session["Book1"];
                BigBookImage.ImageUrl = "./Pictures/BDKRCover.jpg";
            }
            if (ID == 3)
            {
                book = (Books)Session["Book2"];
                BigBookImage.ImageUrl = "./Pictures/wrinkle3.jpg";
            }

            lblTitle.Text = book.getTitle();
            lblAuthor.Text = book.getAuthor();
            lblISBN.Text = book.getISBN();
            lblStyle.Text = book.getStyle();
            lblWeight.Text = book.getWeight();
            lblPages.Text = book.getPages();
             lblPrice.Text = book.getPrice();
        
    }

    public void cartBtn_Click(object sender, EventArgs e)
    {
        
        theBooks.Add(book);
        Session["cartItem"] = this.book;
        Session["bookCount"] = 0;
        Session["cartBooks"] = theBooks;
        Response.Redirect("CartPage.aspx");
    }
}