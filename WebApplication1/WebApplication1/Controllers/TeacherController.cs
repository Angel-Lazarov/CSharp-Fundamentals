using Microsoft.AspNetCore.Mvc;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.TeacherViewModels;

namespace MySchoolWebApplication.Controllers
{
	public class TeacherController : Controller
	{
		private readonly ITeacherDataService teacherDataService;

		public TeacherController(ITeacherDataService teacherDataService)
		{
			this.teacherDataService = teacherDataService;
		}

		[HttpGet]
		public IActionResult Teacher_Info()
		{
			List<TeacherViewModel> teachers = teacherDataService.TeacherInfo();

			//return View();
			return View(teachers);
		}

		[HttpGet]
		public IActionResult Teacher_Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Teacher_Add(TeacherAddFormModel model)
		{

			if (!ModelState.IsValid)
			{
				return View(model); //Reload the same page with Model errors!
			}

			bool addSuccess = await teacherDataService.Teacher_Add(model);

			return RedirectToAction("Teacher_Info");
		}


	}
}
