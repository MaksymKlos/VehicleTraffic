using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Shipping
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Код_Перевезення { get; set; }
    public virtual Driver Водій { get; set; }
    public virtual Transport Транспорт { get; set; }
    public virtual Route Маршрут { get; set; }
    public DateTime Початок { get; set; }
    public DateTime Завершення { get; set; }
}