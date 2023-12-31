﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ServerBlogManagement.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
