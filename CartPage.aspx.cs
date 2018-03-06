using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CartPage : System.Web.UI.Page
{
    Books book;
    int bookCount;
    Table dt = new Table();
    ShoppingCart shopCart = new ShoppingCart();
    double orderTotal = 0;
    double weightTotal = 0;
    string[] seperators = { "ounces", "pounds", " " };
    string[] weightWithoutUnit;

    protected void Page_Load(object sender, EventArgs e)
    {
        TableRow tr = new TableRow();
        Button buttonRmv = new Button();
        buttonRmv.Text = "Remove";
        buttonRmv.OnClientClick = "rmv_Click()";

       
        if (!IsPostBack)
        {
            //shopCart = (ShoppingCart)Session["finalCart"];
            //Session["finalCart"] = shopCart;

            if (Session["theCartTable"] != null)
            {
                if (Request.ServerVariables["HTTP_REFERER"] != "Default.aspx")
                {
                    dt = (Table)Session["theCartTable"];


                    for (int i = 1; i < dt.Rows.Count; i++)
                    {

                        dt.Rows.Add(dt.Rows[i]);
                    }
                    //List<Books> theBooks = new List<Books>();
                    //theBooks = (List<Books>)Session["cartItem"];
                    //bookCount = (int)Session["Count"];
                }
            }
            

        }


        if (Session["cartItem"] != null)
        {
            book = (Books)Session["cartItem"];
            weightWithoutUnit = book.getWeight().Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            orderTotal += double.Parse(book.getPrice());
            weightTotal += double.Parse(weightWithoutUnit[0]);
            if(Session["weightTotalCartPage"] != null)
            {
                weightTotal += (double)Session["weightTotalCartPage"];
            }
            if(Session["orderTotalCartPage"] != null)
            {
                orderTotal += (double)Session["orderTotalCartPage"];
            }

            Session["orderTotalCartPage"] = orderTotal;
            Session["weightTotalCartPage"] = weightTotal;
            orderTotalLbl.Text = "Order Total: $" + orderTotal.ToString() + "   Total Weight: "+ weightTotal.ToString();
            //shopCart = (ShoppingCart)Session["finalCart"];
            if (Session["finalCart"] != null)
            {
                shopCart = (ShoppingCart)Session["finalCart"];
                shopCart.addItem(book);
                Session["finalCart"] = shopCart;
            }

            Session["finalCart"] = shopCart;

            TableRow tr2 = new TableRow();
            TableCell tc = new TableCell();
            tc.Controls.Add(buttonRmv);
            tr2.Cells.Add(AddCell(book.getTitle()));
            tr2.Cells.Add(AddCell("$" + book.getPrice()));
            tr2.Cells.Add(AddCell(book.getWeight()));
            tr2.Cells.Add(tc);
            dt.Rows.Add(tr2);

            Session["theCartTable"] = dt;

            CartTitles.Controls.Add(dt);
            lblNoCart.Visible = false;
        }


    }
   
    private TableCell AddCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Solid;
        cell.BorderWidth = 1;
        cell.Text = pText;
        return cell;
    }

    private void addToTable(TableRow tr, Table t)
    {
        t.Rows.Add(tr);
    }

    private void rmv_Click(object sender, EventArgs e)
    {

        dt.Rows.Clear();
      

    }

    public void checkout_Click(object sender, EventArgs e)
    {
        //Session["finalCart"] = shopCart;
        Response.Redirect("ShippingInfo.aspx");
    }

}