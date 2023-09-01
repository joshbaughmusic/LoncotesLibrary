using System.ComponentModel.DataAnnotations;
using LoncotesLibrary.Models;

namespace LoncotesLibrary.Models;

public class Material
{
    public int Id { get; set; }
    [Required]
    public string MaterialName { get; set; }
    public int MaterialTypeId { get; set; }
    public MaterialType materialType { get; set; }
    public int GenreId { get; set; }
    public Genre genre { get; set; }
    public DateTime? OutOfCirculationSince { get; set; }
    public List<Checkout> Checkouts { get; set; }

}