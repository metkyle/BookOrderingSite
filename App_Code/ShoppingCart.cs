using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    public List<Books> books = new List<Books>(); 

    //public static readonly ShoppingCart Instance;

   // static ShoppingCart()
    //{
        //
        // TODO: Add constructor logic here
        //
       /* if (HttpContext.Current.Session["ASPNETShoppingCart"] == null)
        {
            Instance = new ShoppingCart();
            Instance.books = new List<Books>();
            HttpContext.Current.Session["ASPNETShoppingCart"] = Instance;
        }
        else
        {
            Instance = (ShoppingCart)HttpContext.Current.Session["ASPNETShoppingCart"];
        }*/
    //}

   // protected ShoppingCart() { }

    public ShoppingCart() {
        //books = new List<Books>();
    }

    public void addItem(Books aBook)
    {
        books.Add(aBook);
    }
    
    public List<Books> getCartList()
    {
        return books;
    }

    public void RemoveItem(String productTitle, String productPrice)
    {
        Books book = new Books(productTitle, productPrice);
        books.Remove(book);
    }

    

    //ADD TOTAL METHOD
}