using System.ComponentModel.DataAnnotations;

namespace LabMVC5.Models
{
    public class Student
    {
        [Display(Name = "編號")]
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "學號不可以為空白")]
        [StringLength(2)]
        //[CheckValidStudNo]
        [Display(Name = "學號")]
        public string StudNo { get; set; } = null!;

        [Required(ErrorMessage = "姓名不可以為空白")]
        [StringLength(50)]
        [Display(Name = "姓名")]
        public string CName { get; set; } = null!;
        // null!=not null...

        [Display(Name = "出生年")]
        [Range(1960, 2024)]
        public int? Year { get; set; }

        [Required]
        [Display(Name = "學習心得")]
        public string? Feedback { get; set; }

    }
}
