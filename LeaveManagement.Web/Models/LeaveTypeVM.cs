using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Number of days should be between 1 and 25.")]
        public int DefaultDays { get; set; }
    }
}
