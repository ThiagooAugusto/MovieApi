using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieApi.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o título!")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o diretor!")]
        public string Diretor {  get; set; }

        [StringLength(200,ErrorMessage ="Máximo de 200 caracteres!")]
        public string Sinopse { get; set; }

        [Range(1,240,ErrorMessage ="O campo duração deve ter no mínimo 1 e máximo 240 minutos!")]
        [Display(Name ="Duração")]
        public int Duracao {  get; set; }

        public int CategoryId {  get; set; }

        [JsonIgnore]
        public Category ? Category {  get; set; }

    }
}
