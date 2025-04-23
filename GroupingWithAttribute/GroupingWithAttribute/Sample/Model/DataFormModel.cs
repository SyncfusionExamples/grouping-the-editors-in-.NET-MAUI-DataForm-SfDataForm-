using System.ComponentModel.DataAnnotations;

namespace GroupingWithAttribute
{
    public class DataFormModel
    {
        [Display(GroupName = "Name")]
        public string FirstName { get; set; } = string.Empty;
        [Display(GroupName = "Name")]
        public string LastName { get; set; } = string.Empty;
        [Display(GroupName = "Details")]
        public string Address { get; set; } = string.Empty;
        [Display(GroupName = "Details")]
        public string City { get; set; } = string.Empty;
        [Display(GroupName = "Details")]
        public string Country { get; set; } = string.Empty;
    }
}