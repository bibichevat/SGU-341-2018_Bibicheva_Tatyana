using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Task2
{
    public class Book
    {
        private string title;
        private int numberPages;
        private string publishing;
        private DateTime datePublication;
        private DateTime dateWriting;
        private Author author;

        public Book(string title, int numberPages, string publishing, DateTime dateWriting, DateTime datePublication, Author author)
        {
            this.Title = title;
            this.NumberPages = numberPages;
            this.Publishing = publishing;
            this.DateWriting = dateWriting;
            this.DatePublication = datePublication;
            this.Author = author;
        }

        protected string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.title = value;
            }
        }

        protected int NumberPages
        {
            get
            {
                return numberPages;
            }
            set
            {
                if (value > 0)
                {
                    numberPages = value;
                }
            }
        }

        protected string Publishing
        {
            get
            {
                return publishing;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.publishing = value;
            }
        }

        protected DateTime DatePublication
        {
            get
            {
                return datePublication;
            }
            set
            {
                if (value.Date >= this.dateWriting.Date)
                {
                    this.datePublication = value.Date;
                }
            }
        }

        protected DateTime DateWriting
        {
            get
            {
                return dateWriting;
            }
            set
            {
                this.dateWriting = value.Date;
            }
        }

        protected Author Author
        {
            get
            {
                return author;
            }
            set
            {
                if (value != null)
                {
                    this.author = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Title: {Title} NumberPages: {NumberPages} Publishing: {Publishing} DateWriting: {DateWriting.ToShortDateString()} DatePublication: {DatePublication.ToShortDateString()} " + this.Author.ToString();
        }
    }
}
