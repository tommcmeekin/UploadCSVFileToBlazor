using CsvHelper.Configuration;

namespace UploadCSVFileToBlazor.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Sex { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? DateOfBirth { get; set; }
    public string? JobTitle { get; set; }
}

public class EmployeeClassMap : ClassMap<Employee>
{
    public EmployeeClassMap()
    {
        Map(m => m.FirstName).Name("FirstName");
        Map(m => m.LastName).Name("LastName");
        Map(m => m.Sex).Name("Sex");
        Map(m => m.Email).Name("Email");
        Map(m => m.Phone).Name("Phone");
        Map(m => m.Phone).Name("Phone");
        Map(m => m.DateOfBirth).Name("DateOfBirth");
        Map(m => m.JobTitle).Name("JobTitle");

    }
}
