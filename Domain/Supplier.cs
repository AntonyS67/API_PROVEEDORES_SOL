using System.ComponentModel.DataAnnotations;

public class Supplier
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? NIT { get; set; }
    public string? Razon_Social { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Email { get; set; }
    public bool Active { get; set; }
    public DateTime Created_at { get; set; }
    public string? Contact_Name { get; set; }
    public string? Contact_Email { get; set; }
}
