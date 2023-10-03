namespace DevCart.Models
{
	public class Project
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public string Clinet {  get; set; }

		public Project(long id, string name, string description,string image, string clinet)
		{
			Id = id;
			Name = name;
			Description = description;
			Image = image;
			Clinet = clinet;
		}
	}

}
