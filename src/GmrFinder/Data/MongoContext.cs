namespace GmrFinder.Data;

public class MongoContext(IMongoDbClientFactory database) : IMongoContext
{
    internal IMongoCollectionSet<PollingItem> _pollingItems = new MongoCollectionSet<PollingItem>(database);

    public IMongoCollectionSet<PollingItem> PollingItems
    {
        get => _pollingItems;
    }
}
