using Microsoft.AspNetCore.Identity;
using System.Runtime.ExceptionServices;

namespace big_foot.Data
{
    public class Customer : IdentityUser
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        //1:M
        public ICollection<Order> Orders { get; set;}
    }
}
