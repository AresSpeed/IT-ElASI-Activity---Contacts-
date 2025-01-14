﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASI.Basecode.Data.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Decription is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Author is Required")]
        public string Author { get; set; }
        public DateTime DateTimeCreated = DateTime.Now;
    }
}
