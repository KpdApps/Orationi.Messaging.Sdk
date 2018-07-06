namespace KpdApps.Orationi.Messaging.Sdk.Updates
{
    public interface IUpdateProvider
    {
        string GetUpdateDefinition(string version = null);
    }
}
