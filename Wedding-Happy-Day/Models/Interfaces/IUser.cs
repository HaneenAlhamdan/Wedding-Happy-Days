using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model;
using Wedding_Happy_Day.Model.Services;

namespace Wedding_Happy_Day.Models.Interfaces
{
    public interface IUser
    {
        public Task<UserDto> Register(Register register, ModelStateDictionary modelstate);
        public Task<UserDto> Login(string username, string password);
        public Task<List<ApplicationUser>> Users();

        public Task Logout();
    }
}
