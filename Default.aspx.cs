using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private List<Books> theBooks = new List<Books>();
    Books[] bookArray;

    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        if (!IsPostBack)
        {
            Session["BookID"] = 0;
            try
            {
               // this.theBooks = new List<Books>();

                cn = new OleDbConnection();

                if (Request.UserHostAddress.ToString().Equals("::1"))
                {                     // Local server...                     
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\EWU\cscd379\BooksDatabase(1).accdb;Persist Security Info=False;"; 
                    //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\App_Data\Orders.accdb;Persist Security Info=False;";
                }
                else
                {                     // Smarterasp as host...                     
                                      // E:\HostingSpaces\cp3t3rs\cscd379.com\wwwroot\Assign2\App_Data      
                                      //CHANGE
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=h:\root\home\kylemetcalfe-001\www\site1\shoppingcart\BooksDatabase(1).accdb;Persist Security Info=False;";
                }

                cmd = new OleDbCommand("SELECT * FROM Books;", cn);

                cn.Open();

                dr = cmd.ExecuteReader();
                int i = 0;
                int bID;
                while (dr.Read())
                {
                    Books book = new Books(
                        dr["Title"].ToString(),
                        dr["Author"].ToString(),
                        dr["ISBN"].ToString(),
                        dr["Pages"].ToString(),
                        dr["BigImage"].ToString(),
                        dr["Style"].ToString(),
                        dr["Weight"].ToString(),
                        dr["Price"].ToString());
                    bID = int.Parse(dr["ID"].ToString());

                    theBooks.Add(book);
                    Session["Book" + i] = book;
                    i++;
                }
                //dr.Close();
                //cn.Close();
            }catch(Exception err) { lblError.Text = err.Message; }
            System.Diagnostics.Debug.WriteLine(theBooks.Count.ToString());
            bookArray = theBooks.ToArray();
            

        }
        //Book1Button.ImageUrl = "~/Pictures/BRCover.jpg";
        //Books bookURL = theBooks[0];
        //ImageButton1.ImageUrl = theBooks[0].getURL();
    }

    public void onCoverClick(Object sender, EventArgs e)
    {
        ImageButton clickedButton = sender as ImageButton;
        if(clickedButton.ID == "Book1Button")
        {
            Session["BookID"] = 1;
        }
        if (clickedButton.ID == "Book2Button")
        {
            Session["BookID"] = 2;
        }
        if (clickedButton.ID == "Book3Button")
        {
            Session["BookID"] = 3;
        }

        Response.Redirect("BookInfo.aspx");
    }
    
}