using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Books
/// </summary>
[Serializable]
public class Books
{
    String title, author, ISBN, pages, URL, style, weight, price;

    public Books(String title, String author, String ISBN, String pages, String URL, String style, String weight, String price)
    {
        this.title = title;
        this.author = author;
        this.ISBN = ISBN;
        this.pages = pages;
        this.URL = URL;
        this.style = style;
        this.weight = weight;
        this.price = price;
        //
        // TODO: Add constructor logic here
        //
        
    }

    public Books(String title, String price)
    {
        this.title = title;
        this.price = price;
    }

    public String getURL()
    {
        return URL;
    }

    public String getTitle()
    {
        return title;
    }

    public String getAuthor()
    {
        return author;
    }

    public String getISBN()
    {
        return ISBN;
    }

    public String getStyle()
    {
        return style;
    }

    public String getPages()
    {
        return pages;
    }

    public String getWeight()
    {
        return weight;
    }

    public String getPrice()
    {
        return price;
    }
}