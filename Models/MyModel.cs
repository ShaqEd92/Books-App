using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;

namespace Lybrary.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Letters]
        [Required]
        [MinLength(2)]
        public string Author { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        public string Genre { get; set; }

        public string BookCode { get; set; }

        public DateTime AddedAt { get; set; }

        public int ReaderID { get; set; }

        public Reader Submitter { get; set; }

        public List<Read> ReadBy { get; set; }

        public List<ReadList> ToRead { get; set; }

        public List<Favorite> Faved { get; set; }

        public List<Comment> BookComments { get; set; }

    }


    public class Read
    {
        [Key]
        public int ReadID { get; set; }

        public int ReaderID { get; set; }

        public Reader TheReader { get; set; }

        public int BookID { get; set; }

        public Book TheBook { get; set; }
    }


    public class ReadList
    {
        [Key]
        public int ReadListID { get; set; }

        public int ReaderID { get; set; }

        public Reader TheReader { get; set; }

        public int BookID { get; set; }

        public Book TheBook { get; set; }
    }


    public class Favorite
    {
        [Key]
        public int FavoriteID { get; set; }

        public int ReaderID { get; set; }

        public Reader TheReader { get; set; }

        public int BookID { get; set; }

        public Book TheBook { get; set; }
    }


    public class Comment
    {
        public int CommentID { get; set; }

        public int ReaderID { get; set; }

        public Reader TheReader { get; set; }

        public int BookID { get; set; }

        public Book TheBook { get; set; }

        public string Content { get; set; }

        public DateTime CommentedAt { get; set; }
    }

}
