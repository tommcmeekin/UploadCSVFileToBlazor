namespace UploadCSVFileToBlazor.Repositories;

public interface IPeopleRepository
{
    Task<bool> UploadPeopleAsync();
}
