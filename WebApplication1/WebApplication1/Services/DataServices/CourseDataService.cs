using MySchoolWebApplication.Data;
using MySchoolWebApplication.Data.Models;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.CourseViewModels;

namespace MySchoolWebApplication.Services.DataServices
{
	public class CourseDataService : ICourseDataService
	{
		private readonly ApplicationDbContext dbContext;

		public CourseDataService(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}



		public async Task<bool> Course_Add(CourseAddFormModel courseFormModel)
		{
			Course newCourse = new Course()
			{
				Name = courseFormModel.Name,
			};

			await dbContext.AddAsync(newCourse);
			await dbContext.SaveChangesAsync();
			return true;
		}
		public List<CourseViewModel> CourseInfo()
		{
			List<CourseViewModel> coursesViewModels = dbContext.Courses
				.Select(c => new CourseViewModel()
				{
					Id = c.Id,
					Name = c.Name,
					TeacherName = c.Teachers.First(t => t.Course.Id == c.Id).Name
				})
				.ToList();


			return coursesViewModels;

		}

	}
}
