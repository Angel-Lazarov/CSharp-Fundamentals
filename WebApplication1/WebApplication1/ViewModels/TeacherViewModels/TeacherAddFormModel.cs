using System.ComponentModel.DataAnnotations;

namespace MySchoolWebApplication.ViewModels.TeacherViewModels
{
    public class TeacherAddFormModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string CourseName { get; set; } = null!;
    }
}
