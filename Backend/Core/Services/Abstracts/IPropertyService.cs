using Data.Entities.Properties;

namespace Core.Services.Abstracts;

public interface IPropertyService
{
    public Task<Property> GetPropertyByIDWithIncludeAsync(int id);
    public Task<Property> GetByIDAsync(int id);
    public Task<string> AddAsync(Property Property);
    public Task<bool> IsNameArExist(string nameAr);
    public Task<bool> IsNameEnExist(string nameEn);
    public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
    public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
    public Task<string> EditAsync(Property Property);
    public Task<string> DeleteAsync(Property Property);
    public IQueryable<Property> GetPropertiesQuerable();
    public IQueryable<Property> FilterPropertyPaginatedQuerable(string search);
}
