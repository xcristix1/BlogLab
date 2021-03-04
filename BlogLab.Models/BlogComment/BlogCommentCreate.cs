﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
 public   class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? ParentCommentId { get; set; }
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Contet is required")]
        [MinLength(10, ErrorMessage = "Must be 10-300 characters")]
        [MaxLength(300, ErrorMessage = "Must be 10-300 characters")]
        public string Content { get; set; }
    }
}
