﻿using System.ComponentModel.DataAnnotations;

namespace BooksApi.Entity.Entities
{
    public class BookDetails
    {
        [Key]

        public int Id { get; set; }     
        public string? Title { get; set; }       
        public string? Description { get; set; } 
        public string? Author { get; set; }
    }
}
