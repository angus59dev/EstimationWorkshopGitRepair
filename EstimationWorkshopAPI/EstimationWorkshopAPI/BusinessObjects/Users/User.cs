using System.Reflection;
using Csla;

namespace EstimationWorkshopAPI.BusinessObjects.Users;

[Serializable]
public class User : BusinessBase<User>
{
    #region properties
    
    // https://github.com/MarimerLLC/csla/tree/main/Samples/CslaFastStart
    // https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio
    
    private static readonly PropertyInfo<string?> IdProperty = RegisterProperty<string?>(c => c.Id);
    public string? Id
    {
        get => GetProperty(IdProperty);
        private set => SetProperty(IdProperty, value);
    }
    
    private static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(c => c.Email);
    public string Email
    {
        get => GetProperty(EmailProperty);
        set => SetProperty(EmailProperty, value);
    }

    #endregion

    #region load/write

    

    #endregion
}