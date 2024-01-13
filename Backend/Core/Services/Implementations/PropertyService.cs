using Core.Services.Abstracts;
using Data.Entities.Properties;
using Infrastructure.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Core.Services.Implementations;

public class PropertyService : IPropertyService
{
    #region Fields
    private readonly IPropertyRepository _PropertyRepository;
    #endregion

    #region constructors
    public PropertyService(IPropertyRepository PropertyRepository)
    {
        _PropertyRepository = PropertyRepository;
    }


    #endregion
    #region Handle Functions

    public async Task<Property> GetPropertyByIDWithIncludeAsync(int id)
    {
        var Property = _PropertyRepository.GetTableNoTracking()
                                      .Include(x => x.Broker)
                                      .Where(x => x.Id.Equals(id))
                                      .FirstOrDefault();
        return Property;
    }

    public async Task<string> AddAsync(Property Property)
    {
        //Added Property
        await _PropertyRepository.AddAsync(Property);
        return "Success";
    }

    public async Task<bool> IsNameArExist(string nameAr)
    {
        //Check if the name is Exist Or not
        var Property = _PropertyRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr)).FirstOrDefault();
        if (Property == null) return false;
        return true;
    }

    public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
    {
        //Check if the name is Exist Or not
        var Property = await _PropertyRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr) & !x.Id.Equals(id)).FirstOrDefaultAsync();
        if (Property == null) return false;
        return true;
    }

    public async Task<string> EditAsync(Property Property)
    {
        await _PropertyRepository.UpdateAsync(Property);
        return "Success";
    }

    public async Task<string> DeleteAsync(Property Property)
    {
        var trans = _PropertyRepository.BeginTransaction();
        try
        {
            await _PropertyRepository.DeleteAsync(Property);
            await trans.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {
            await trans.RollbackAsync();
            Log.Error(ex.Message);
            return "Falied";
        }

    }

    public async Task<Property> GetByIDAsync(int id)
    {
        var Property = await _PropertyRepository.GetByIdAsync(id);
        return Property;
    }

    public IQueryable<Property> GetPropertiesQuerable()
    {
        return _PropertyRepository.GetTableNoTracking().Include(x => x.Broker).AsQueryable();
    }

    public IQueryable<Property> FilterPropertyPaginatedQuerable(string search)
    {
        var querable = _PropertyRepository.GetTableNoTracking().Include(x => x.Broker).AsQueryable();
        if (search != null)
        {
            querable = querable.Where(x => x.NameAr.Contains(search));
        }

        return querable;
    }

    public async Task<bool> IsNameEnExist(string nameEn)
    {
        //Check if the name is Exist Or not
        var Property = _PropertyRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn)).FirstOrDefault();
        if (Property == null) return false;
        return true;
    }

    public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
    {
        //Check if the name is Exist Or not
        var Property = await _PropertyRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn) & !x.Id.Equals(id)).FirstOrDefaultAsync();
        if (Property == null) return false;
        return true;
    }

    #endregion
}
