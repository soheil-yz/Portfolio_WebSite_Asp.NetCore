using System.ComponentModel.DataAnnotations;

namespace DevCart.Models
{
	public class Contact
	{
		[Required]
        public string  Name { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public string Message { get; set; }
		public string Service { get; set; }
    }
}
