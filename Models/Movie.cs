using System;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    public int ID { get; set; }

    [StringLength(60, MinimumLength = 2)]
    [Required]
    public string Title { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [Required]
    [StringLength(30)]
    public string Genre { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [StringLength(5)]
    [Required]
    public string Rating { get; set; }
}