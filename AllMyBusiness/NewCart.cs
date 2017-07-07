
using System;
using System.Collections.Generic;

namespace AllMyBusiness.Domain
{
  public class NewCart
  {
    public static NewCart CreateCartFromProductSelection
      (string sourceUrl, string customerCookie, int productId, int quantity,
       decimal displayedPrice) 
    {
      var cart = new NewCart(sourceUrl, customerCookie);
      cart.InitializeCart();
      cart.InsertNewCartItem(productId, quantity, displayedPrice);
      return cart;
    }

    private NewCart(string sourceUrl, string customerCookie) {
      if (Uri.IsWellFormedUriString(sourceUrl, UriKind.Absolute)) {
        SourceUrl = sourceUrl;
      }
      else { SourceUrl = ""; }

      CustomerCookie = customerCookie;
      CartItems = new List<CartItem>();
    }

    private void InsertNewCartItem(int productId, int quantity, decimal displayedPrice) {
      CartItems.Add(CartItem.Create(productId, quantity, displayedPrice, CartCookie));
    }

    private void InitializeCart() {
      Initialized = DateTime.Now;
     
      CartCookie = Guid.NewGuid().ToString();
    }

    public void CustomerFound(int customerId)
    {
      CustomerId = customerId;
    }

    public int CartId { get; set; }
    public string CartCookie { get; private set; }
    public DateTime Initialized { get; private set; }
    public DateTime Expires { get; private set; }
    public string SourceUrl { get; private set; }
    public int CustomerId { get; private set; }
    public ICollection<CartItem> CartItems { get; private set; }
    //TODO: decide if I should store this property in the database or not
    public string CustomerCookie { get; private set; }
    
  }
}