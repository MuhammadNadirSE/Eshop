using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;


public class Cart
{
    private List<CartItem> _Items = new List<CartItem>();
    public List<CartItem> Items { get { return _Items; } }
    double total=0.0;
    public double TotalValue { get { return total; } }
    
    public void AddItem(int productID, int qty, double price)
    {
        _Items.Add( new CartItem { ProductID = productID, Qty = qty, Price = price });
        total=total+(qty*price);
    }
    
    public void Clear()
    {
        _Items.Clear();
        total=0.0;
    }

    public void RemoveItem(int index)
    {
        total=total-(_Items[index].Price*_Items[index].Qty);
        _Items.RemoveAt(index);
    }
}


public class CartItem
{
    public int ProductID { get; set; }
    public int Qty { get; set; }
    public double Price { get; set; }
}