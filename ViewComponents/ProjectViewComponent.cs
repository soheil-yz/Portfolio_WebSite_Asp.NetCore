using Microsoft.AspNetCore.Mvc;

namespace DevCart.ViewComponents
{
	public class ProjectViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Projects");
		}
	}
}
