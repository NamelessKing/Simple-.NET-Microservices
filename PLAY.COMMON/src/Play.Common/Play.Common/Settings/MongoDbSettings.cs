namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }
        public int Port { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public bool Authentication { get; set; }
        public string ConnectionStringWithAuth => $"mongodb://{Username}:{Password}@{Host}:{Port}";
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
//mongodb://localhost:55002/