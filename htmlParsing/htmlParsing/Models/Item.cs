using System;

namespace htmlParsing.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }
        public string bookId { get; set; }
        public string author { get; set; }
        public string imgUrl { get; set; }

    }

}