using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Author_Book_Advance
{
    class Book
    {
        private string Name;
        private Author[] Author;
        private double Price;
        private int Qty = 0;

        public Book(string name, Author[] author, double price, int qty = 0)
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
        public Author[] GetAuthors()
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
            string[] StrAuthor = new string[this.Author.Length];
           for (int i = 0; i < Author.Length; i++)
                StrAuthor[i] = this.Author[i].ToString();

                return string.Format("Book[ name={0},================== Authors ={{{1}}}=================,price={2}======, qty={3}]",
                    this.Name, Author,String.Join(",",StrAuthor), this.Price, this.Qty);
        }

        public string GetAuthorName()
        {
            string[] StrAuthorName = new string[this.Author.Length];
            for (int i = 0; i < Author.Length; i++)
                StrAuthorName[i] = this.Author[i].GetName();
            return String.Join(",", StrAuthorName);
        }
        //public string GetAuthorEmail()
        //{
        //    return this.Author.GetEmail();
        //}
        //public char GetAuthorGender()
        //{
        //    return this.Author.GetGender();
        //}
    }
}
