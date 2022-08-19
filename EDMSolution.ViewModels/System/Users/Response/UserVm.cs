using EDMSolution.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EDMSolution.ViewModels.System.Users.Response
{
    public class UserVm
    {
        public Guid Id { set; get; }
        public string FullName { set; get; }
        public string PhoneNumber { set; get; }
        public string UserName { set; get; }
        public string Email { set; get; }
        public DateTime Dob { set; get; }
        public string RoleId { set; get; }
        public string RoleName { set; get; }
        public string Avata { set; get; }
        public IFormFile FormFile { set; get; }
        public Status Status { set; get; }
    }
}
