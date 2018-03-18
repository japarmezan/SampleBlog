﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlog.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; }
    }
}
