using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Book
{
    class Book
    {
        private string Name;
        private Author Author;
        private double Price;
        private int Qty = 0;

        public Book(string name, Author author, double price, int qty = 0)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Qty = qty;
        }

        public string GetName()
        {
            return Name;
        }
        public Author GetAuthor()
        {
            return Author;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double price)
        {
            this.Price = price;
        }
        public int GetQty()
        {
            return Qty;
        }
        public void SetQty(int qty)
        {
            this.Qty = qty;
        }

        public override string ToString()
        {
            return string.Format("Book[ name={0}, Author[ name={1}, email={2}, gender={3}, price={4}, qty={5}]]", this.Name, Author.GetName(), Author.GetEmail(), Author.GetGender(), this.Price, this.Qty);
        }

        public string GetAuthorName()
        {
            return this.Author.GetName();
        }
        public string GetAuthorEmail()
        {
            return this.Author.GetEmail();
        }
        public char GetAuthorGender()
        {
            return this.Author.GetGender();
        }
    }
}
