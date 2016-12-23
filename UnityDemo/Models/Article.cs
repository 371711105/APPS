using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDemo.Models
{
    /// <summary>
    /// Article实体类
    /// </summary>
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}