using System;
using System.Collections.Generic;
using System.Text;

namespace ArticlesAndCategories
{
    class Article
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Article(int id, int categoryId, string title, string body)
        {
            Id = id;
            CategoryId = categoryId;
            Title = title;
            Body = body;
        }
    }
}
