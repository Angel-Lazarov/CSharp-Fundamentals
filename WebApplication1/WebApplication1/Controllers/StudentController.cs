using Microsoft.AspNetCore.Mvc;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.StudentViewModel;

namespace MySchoolWebApplication.Controllers
{
	public class StudentController : Controller
	{
		private readonly IStudentDataService studentDataService;
		public StudentController(IStudentDataService studentDataService)
		{
			this.studentDataService = studentDataService;
		}

		[HttpGet]
		public IActionResult Student_Info()
		{
			List<StudentViewModel> students = studentDataService.StudentInfo();

			return View(students);
		}

		[HttpGet]
		public IActionResult Student_Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Student_Add(StudentAddFormModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			bool addSuccess = await studentDataService.Student_Add(model);

			return RedirectToAction("Student_Info");

		}

	}
}
