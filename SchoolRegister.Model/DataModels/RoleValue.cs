using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public enum RoleValue : int
{
User = 0,
Student = 1,
Parent = 2,
Teacher = 3,
Admin = 4
}