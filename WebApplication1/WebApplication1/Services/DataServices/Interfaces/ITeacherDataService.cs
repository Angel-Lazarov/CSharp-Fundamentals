using MySchoolWebApplication.ViewModels.TeacherViewModels;

namespace MySchoolWebApplication.Services.DataServices.Interfaces
{
	public interface ITeacherDataService
	{
		Task<bool> Teacher_Add(TeacherAddFormModel teacherFormModel);
		List<TeacherViewModel> TeacherInfo();

	}
}
