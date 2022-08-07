namespace EstimationWorkshopAPI.Settings;

public class AppDatabaseSetting
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string UserCollectionName { get; set; } = null!;
}