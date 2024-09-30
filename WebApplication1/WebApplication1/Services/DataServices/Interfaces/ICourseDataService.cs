using MySchoolWebApplication.ViewModels.CourseViewModels;

namespace MySchoolWebApplication.Services.DataServices.Interfaces
{
	public interface ICourseDataService
	{
		Task<bool> Course_Add(CourseAddFormModel courseFormModel);
		List<CourseViewModel> CourseInfo();

	}
}
