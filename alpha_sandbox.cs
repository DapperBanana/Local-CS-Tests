
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        // Connect to MongoDB
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("test");
        var collection = database.GetCollection<BsonDocument>("users");

        // Create
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(document);

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(result);

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 40);
        collection.UpdateOne(updateFilter, update);

        // Read updated document
        var updatedResult = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(updatedResult);

        // Delete
        collection.DeleteOne(filter);

        // Verify deletion
        var deletedResult = collection.Find(filter).FirstOrDefault();
        if (deletedResult == null)
        {
            Console.WriteLine("Document deleted successfully");
        }
    }
}
