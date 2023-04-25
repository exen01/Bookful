﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string PublishingHouse { get; set; }
        public string PublicationDate { get; set; }
        public string DisplayTitleYear => $"{Title} ({PublicationDate})";

        public Book() { }

        public Book(int id, string title, string author, string description, string publishingHouse, string publicationDate)
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            PublishingHouse = publishingHouse;
            PublicationDate = publicationDate;
        }
    }
}
