using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApi.Models
{

    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome da categoria!")]
        [StringLength(100,ErrorMessage ="Tamanho máximo de 100 caracteres!")]
        public string Nome { get; set; }

        public ICollection<Movie>? Movies { get; set; }
    }
}
