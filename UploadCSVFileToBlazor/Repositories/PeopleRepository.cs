using CsvHelper;
using EFCore.BulkExtensions;
using System.Globalization;
using UploadCSVFileToBlazor.Data;
using UploadCSVFileToBlazor.Domain.Entities;

namespace UploadCSVFileToBlazor.Repositories;

public class PeopleRepository(AppDbContext appDbContext) : IPeopleRepository
{
    private readonly AppDbContext _appDbContext = appDbContext;
    public List<Employee> employees = [];

    private readonly string inputFile = @"C:\Users\tommc\OneDrive\Desktop\csv_import\people-100000.csv";

    public async Task<bool> UploadPeopleAsync()
    {
        using (var reader = new StreamReader(inputFile))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<EmployeeClassMap>();
            employees = csv.GetRecords<Employee>().ToList();
        }

        await _appDbContext.BulkInsertAsync(employees);

        return true;
    }
}


