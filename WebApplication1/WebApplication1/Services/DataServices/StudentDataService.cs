using MySchoolWebApplication.Data;
using MySchoolWebApplication.Data.Models;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.StudentViewModel;

namespace MySchoolWebApplication.Services.DataServices
{
	public class StudentDataService : IStudentDataService
	{
		private readonly ApplicationDbContext dbContext;

		public StudentDataService(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task<bool> Student_Add(StudentAddFormModel studentFormModel)
		{
			Student newStudent = new Student()
			{
				Name = studentFormModel.Name,
				Age = studentFormModel.Age,
				CourseId = dbContext.Courses.First(c => c.Name == studentFormModel.CourseName).Id
			};

			await dbContext.Students.AddAsync(newStudent);
			await dbContext.SaveChangesAsync();

			return true;
		}

		public List<StudentViewModel> StudentInfo()
		{
			var students = dbContext.Students
				.Select(s => new StudentViewModel()
				{
					Id = s.Id,
					Name = s.Name,
					Age = s.Age,
					CourseName = dbContext.Courses.First(c => c.Id == s.CourseId).Name
				})
				.ToList();

			return students;
		}
	}
}
