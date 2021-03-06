using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string? Email { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 10, ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Slug => Firstname? .Replace(' ', '-').ToLower() + "-" + Lastname?.Replace(' ', '-').ToLower();

    }
}
