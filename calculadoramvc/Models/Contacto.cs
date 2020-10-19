using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calculadoramvc.Models
{
    [Table("t_contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
         [Column("Name")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]
        public String LastName { get; set; }

        [Display(Name="Email")]
        [Column("email")]
        public String Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name="Edad")]
        [Column("Age")]
        public int Age { get; set; }

        [Display(Name="Distrito")]
        [Column("subject")]
        public String Subject { get; set; }

        [Display(Name="Banco")]
        [Column("banco")]

        public String banco { get; set; }

        [Display(Name="genero")]
        [Column("genero")]
        public String genero { get; set; }


        [NotMapped]
        public String Response { get; set; }

    }
}
