using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Role : IdentityRole<int>
{
    public RoleValue RoleValue{get;set;}
    public Role() : base()
    {
        RoleValue = new RoleValue();
    }

    public Role(string name, RoleValue roleValue) : base(name)
    {
        RoleValue = roleValue;
    }
}