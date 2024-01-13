using Microsoft.AspNetCore.Http;

namespace Core.Services.Abstracts;

public interface IFileService
{
    public Task<string> UploadImage(string Location, IFormFile file);
}
