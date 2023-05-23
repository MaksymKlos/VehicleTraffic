using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Route
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Код_Маршруту { get; set; }
    public string? Назва { get; set; }
    public string? Початкова_Точка { get; set; }
    public string? Кінцева_Точка { get; set; }
    public double Протяжність_Маршруту { get; set; }
}