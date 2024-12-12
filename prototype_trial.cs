
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase database = client.GetDatabase("test");
        IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("people");

        // Create
        var person = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(person);

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).ToList();
        foreach (var document in result)
        {
            Console.WriteLine(document);
        }

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 31);
        collection.UpdateOne(updateFilter, update);

        // Read updated document
        var updatedResult = collection.Find(filter).ToList();
        foreach (var document in updatedResult)
        {
            Console.WriteLine(document);
        }

        // Delete
        collection.DeleteOne(updateFilter);

        // Read all documents
        var allDocuments = collection.Find(new BsonDocument()).ToList();
        foreach (var document in allDocuments)
        {
            Console.WriteLine(document);
        }
    }
}
