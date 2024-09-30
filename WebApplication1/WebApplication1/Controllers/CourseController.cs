using Microsoft.AspNetCore.Mvc;
using MySchoolWebApplication.Services.DataServices.Interfaces;
using MySchoolWebApplication.ViewModels.CourseViewModels;

namespace MySchoolWebApplication.Controllers
{
	public class CourseController : Controller
	{
		private readonly ICourseDataService dataService;

		public CourseController(ICourseDataService dataService)
		{
			this.dataService = dataService;
		}

		public IActionResult Course_Info()
		{
			//List<CourseViewModel> courses = new List<CourseViewModel>()
			//{
			//    new CourseViewModel(){Id = 1, Name = "Биология"},
			//};
			List<CourseViewModel> courses = dataService.CourseInfo();

			return View(courses);
		}

		[HttpGet]
		public IActionResult Course_Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Course_Add(CourseAddFormModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model); //Reload the same page with Model errors!
			}

			bool addSuccess = await this.dataService.Course_Add(model);

			return RedirectToAction("Course_Info");
		}



	}
}
