using System;
using System.Collections.Generic;
using System.Linq;
namespace IS413Assignment5Real.Models
{
    public class Cart
    {

        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        // add to cart
        public void AddItem(Book book, float quantity)
        {

            CartLine line = Lines.FirstOrDefault( b=>
            b.book.BookId == book.BookId);

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            };

        }

        // take away from cart
        public void RemoveItem(Book book) =>
        Lines.RemoveAll(b => b.book.BookId == book.BookId);

        // clear cart
        public void Clear() => Lines.Clear();

        public double ComputeTotalSum() => Math.Round(Lines.Sum(b => (b.book.Price * b.Quantity)),2);
        public int ComputeBookCount()
        {
           int BookQuantity =  (int) Lines.Sum(b => b.Quantity);
            return BookQuantity;
           
        }


        public class CartLine
        {
            public int BookLineID { get; set; }
            public Book book { get; set; }
            public float Quantity { get; set; }

        }
    }

}

