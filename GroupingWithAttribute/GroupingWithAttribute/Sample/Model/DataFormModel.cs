using System.ComponentModel.DataAnnotations;

namespace GroupingWithAttribute
{
    public class DataFormModel
    {
        [Display(GroupName = "Name")]
        public string FirstName { get; set; }
        [Display(GroupName = "Name")]
        public string LastName { get; set; }
        [Display(GroupName = "Details")]
        public string Address { get; set; }
        [Display(GroupName = "Details")]
        public string City { get; set; }
        [Display(GroupName = "Details")]
        public string Country { get; set; }
    }
}