using System.Configuration;


namespace KpdApps.Orationi.Messaging.Sdk.Core.Configurations.RabbitMQ
{
    public class RabbitMQConfigurationSection : ConfigurationSection
    {
        private const string SectionName = "RabbitMQ";
        private const string HostNameKey = "hostname";
        private const string UserNameKey = "username";
        private const string PasswordKey = "password";

        public static RabbitMQConfigurationSection GetConfiguration()
        {
            return (RabbitMQConfigurationSection)ConfigurationManager.GetSection(SectionName);
        }

        [ConfigurationProperty(HostNameKey)]
        public string HostName
        {
            get => (string)this[HostNameKey];
            set => this[HostNameKey] = (object)value;
        }

        [ConfigurationProperty(UserNameKey)]
        public string UserName
        {
            get => (string)this[UserNameKey];
            set => this[UserNameKey] = (object)value;
        }

        [ConfigurationProperty(PasswordKey)]
        public string Password
        {
            get => (string)this[PasswordKey];
            set => this[PasswordKey] = (object)value;
        }
    }
}
