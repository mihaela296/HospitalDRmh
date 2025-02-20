using System;
using System.Data.Entity;

public partial class User
{
    public int UserId { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string PassportSeries { get; set; }
    public string PassportNumber { get; set; }
    public string Gender { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

public partial class ModelEntities : DbContext
{
    public ModelEntities() : base("name=HospitalD") 
    {
    }

    public virtual DbSet<User> Users { get; set; }
}