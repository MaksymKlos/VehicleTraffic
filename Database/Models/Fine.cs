using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Fine
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Код_Штрафу { get; set; }
    public virtual Driver Водій { get; set; }
    public virtual Transport Транспорт { get; set; }
    public string? Опис { get; set; }
    public decimal Сума { get; set; }
}