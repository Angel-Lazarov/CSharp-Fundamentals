using MySchoolWebApplication.Data;
using MySchoolWebApplication.Data.Models;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.TeacherViewModels;

namespace MySchoolWebApplication.Services.DataServices
{
	public class TeacherDataService : ITeacherDataService
	{
		private readonly ApplicationDbContext dbContext;

		public TeacherDataService(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public List<TeacherViewModel> TeacherInfo()
		{
			List<TeacherViewModel> teachersViewModels = dbContext.Teachers
				.Select(t => new TeacherViewModel()
				{
					Id = t.Id,
					Name = t.Name,
					CourseName = t.Course.Name
				})
				.ToList();

			return teachersViewModels;
		}

		public async Task<bool> Teacher_Add(TeacherAddFormModel teacherFormModel)
		{
			if (!dbContext.Courses.Any(c => c.Name == teacherFormModel.CourseName))
			{
				//throw new Exception("No such course!-!!!");

				Course newCourse = new Course()
				{
					Name = teacherFormModel.CourseName
				};

				await dbContext.Courses.AddAsync(newCourse);
				await dbContext.SaveChangesAsync();
			}

			Teacher newTeacher = new Teacher()
			{
				Name = teacherFormModel.Name,
				Course = dbContext.Courses.First(c => c.Name == teacherFormModel.CourseName)
			};
			await dbContext.Teachers.AddAsync(newTeacher);
			await dbContext.SaveChangesAsync();
			return true;
		}

	}
}
