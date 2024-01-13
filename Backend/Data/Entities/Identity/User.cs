using Data.Entities.Properties;
using Data.Lookups.Address;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Data.Entities;

public class User : IdentityUser<int>
{
    [Encrypted]
    public string? Code { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }

    public int? CountryId { get; set; }
    public virtual LkCountry? Country { get; set; }
    public int? StateId { get; set; }
    public virtual LkState? State { get; set; }
    public int? CityId { get; set; }
    public virtual LkCity? City { get; set; }

    public virtual ICollection<UserRefreshToken> UserRefreshTokens { get; set; } = new HashSet<UserRefreshToken>();
    public virtual ICollection<UserProperties> UserProperties { get; set; } = new HashSet<UserProperties>();

    public string Localize(string textAr, string textEN)
    {
        CultureInfo CultureInfo = Thread.CurrentThread.CurrentCulture;
        if (CultureInfo.TwoLetterISOLanguageName.ToLower().Equals("ar"))
            return textAr;
        return textEN;
    }
}
