﻿using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels;

public class Role : IdentityRole<int>
{
    public virtual RoleValue RoleValue { get; set; }
    public Role() { }
    public Role(string name, RoleValue roleValue)
    {
        Name = name;
        RoleValue = roleValue;
    }
}