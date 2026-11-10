using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab7MVC.Models
{
    public class UniversityCampus
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campus Name is required")]
        [StringLength(200)]
        public string Name { get; set; }

        // Navigation property — one Campus has many Students
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
