using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Driver
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Код_Водія { get; set; }
    public string? Імя { get; set; }
    public string? Прізвище { get; set; }
    public string? Номер_Телефону { get; set; }
    public string? Адреса { get; set; }
}