using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab7MVC.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        public string Address { get; set; }

        // Foreign key to UniversityCampus
        [ForeignKey("UniversityCampus")]
        public int CampusID { get; set; }

        // Navigation property — one Student belongs to one Campus
        public virtual UniversityCampus UniversityCampus { get; set; }
    }
}
