using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models.Entities
{
   [Table("Sinh vien")] 
    public class Student
    {
        [Key]
        public string StudentID{ get; set; }
        public string FullName{ get; set; }
    }
}