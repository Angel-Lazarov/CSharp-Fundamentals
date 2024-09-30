using System.ComponentModel.DataAnnotations;

namespace MySchoolWebApplication.ViewModels.CourseViewModels
{
	public class CourseAddFormModel
	{
		[Required]
		[MinLength(3)]
		[MaxLength(50)]
		public string Name { get; set; } = null!;
	}
}
