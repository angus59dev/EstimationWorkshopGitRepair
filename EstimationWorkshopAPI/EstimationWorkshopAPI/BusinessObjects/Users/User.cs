using System.Reflection;
using Csla;
using EstimationWorkshopAPI.DAL;
using EstimationWorkshopAPI.DAL.DTOs;

namespace EstimationWorkshopAPI.BusinessObjects.Users;

[Serializable]
public class User : BusinessBase<User>
{
    #region constructor

    private readonly UserService _userService;
    private readonly IDataPortal<User> _portal;
    
    public User(UserService userService, IDataPortal<User> portal)
    {
        _userService = userService;
        _portal = portal;
    }

    #endregion
    
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
    
    private static readonly PropertyInfo<string> PasswordProperty = RegisterProperty<string>(c => c.Password);
    public string Password
    {
        get => GetProperty(PasswordProperty);
        set => SetProperty(PasswordProperty, value);
    }

    #endregion

    #region Static factory

    // public User New()
    // {
    //     return _portal.(AppContext);
    // }
    //
    // public static User Get(string id)
    // {
    //     return Csla.DataPortal.Fetch<User>(id);
    // }

    #endregion
    
    #region data portal

    

    public async void DataPortal_Fetch(string id)
    {
        var data = await _userService.GetAsync(id);
        if (data == null)
        {
            throw new Exception("User with Id not found.");
        }
        
        Load(data);
    }
    
    public async void DataPortal_Update()
    {
        await _userService.UpdateAsync(Id!, Write());
        // if (data == null)
        // {
        //     throw new Exception("User with Id not found.");
        // }
        //
        // Load(data);
    }
    
    public async void DataPortal_Insert()
    {
        await _userService.CreateAsync(Write());
    }
    
    #endregion

    #region load/write

    private void Load(UserDto dto)
    {
        Id = dto.Id;
        Email = dto.Email;
        Password = dto.Password;
    }

    private UserDto Write() => new UserDto()
    {
        Id = Id,
        Email = Email,
        Password = Password
    };

    #endregion
}