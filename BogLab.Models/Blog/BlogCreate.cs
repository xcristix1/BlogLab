﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BogLab.Models.Blog
{
  public  class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(30, ErrorMessage = "Must be 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be 10-50 characters")]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Must be 300-3000 characters")]
        [MaxLength(3000, ErrorMessage = "Must be 300-3000 characters")]
        public string Content { get; set; }

        public int? PohotId { get; set; }
    }
}
