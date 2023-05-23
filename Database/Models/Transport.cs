using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Transport
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Код_Транспорту { get; set; }
    public string Марка { get; set; }
    public string Модель { get; set; }
    public string VIN { get; set; }
}