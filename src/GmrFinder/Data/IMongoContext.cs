using MongoDB.Driver;

namespace GmrFinder.Data;

public interface IMongoContext
{
    IMongoCollectionSet<PollingItem> PollingItems { get; }
}
