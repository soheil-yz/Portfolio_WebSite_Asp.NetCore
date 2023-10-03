using DevCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCart.ViewComponents
{
	public class LatestArticalesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articales = new List<Article>
			{
				new Article(1,"Project","Lorem ipsum dolor sit amet, consectetur adipiscing elit","blog-post-thumb-card-1.jpg"),
				new Article(2,"Project","Lorem ipsum dolor sit amet, consectetur adipiscing elit","blog-post-thumb-card-2.jpg"),
				new Article(3,"Project","Lorem ipsum dolor sit amet, consectetur adipiscing elit","blog-post-thumb-card-3.jpg"),
				new Article(4,"Project","Lorem ipsum dolor sit amet, consectetur adipiscing elit","blog-post-thumb-card-4.jpg") };
			return View("_LatestArticales",articales);
		}
	}
}
