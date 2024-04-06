using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
	public class usuario
	{
		[Key]
		public int id_usuario { get; set; }
		public string? nombre_usuario { get; set; }
		public string? password { get; set; }
		public string? genero { get; set; }
		public string? direccion { get; set; }
		public string? pasatiempos { get; set; }
		public string? cursos { get; set; }
		public string? conocimientos { get; set; }
	}
}
