using System.Collections.Generic;

namespace WebApplication.Models
{
    public class CompanyViewModel
    {
        public CompanyViewModel()
        {
            this.Users = new List<UserPreviewViewModel>();
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Document { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Complementary { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }

        public List<UserPreviewViewModel> Users { get; set; }
    }
}