﻿namespace Models.People;


public class Role
{
    public int Id { get; set; }
    public string Description { get; set; }

    public Role() { }

    public Role(string description)
    {
        Description = description;
    }
}
