using DevCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace DevCart.ViewComponents
{
	public class ProjectViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(2,"Project","Lorem ipsum dolor sit amet, cagna aliqua","Project-2.jpg","soheil2"),
				new Project(1,"Project","Lorem ipsum dolor sit amet, cagna aliqua","Project-1.jpg","soheil1"),
				new Project(3,"Project","Lorem ipsum dolor sit amet, cagna aliqua","Project-3.jpg","soheil3"),
				new Project(4,"Project","Lorem ipsum dolor sit amet, cagna aliqua","Project-4.jpg","soheil4")
			};
			return View("_Projects",projects);
		}
	}
}
