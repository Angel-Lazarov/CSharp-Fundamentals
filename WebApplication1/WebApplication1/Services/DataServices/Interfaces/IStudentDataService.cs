using MySchoolWebApplication.ViewModels.StudentViewModel;

namespace MySchoolWebApplication.Services.DataServices.Interfaces
{
	public interface IStudentDataService
	{
		Task<bool> Student_Add(StudentAddFormModel studentFormModel);

		List<StudentViewModel> StudentInfo();
	}
}
