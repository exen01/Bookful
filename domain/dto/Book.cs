﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.domain.dto
{
    public class Book
    {
        private int id;
        private string title;
        private string description;
        private Author author;
        private List<Genre> genre;
        private string publishingHouse;
        private string publicationDate;

        public Book() { }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public Author Author { get => author; set => author = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public string PublicationDate { get => publicationDate; set => publicationDate = value; }
        public List<Genre> Genre { get => genre; set => genre = value; }
    }
}