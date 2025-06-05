
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main(string[] args)
    {
        // Connect to the MongoDB database
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("test");
        var collection = database.GetCollection<BsonDocument>("data");

        // Create operation
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(document);

        // Read operation
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        if (result != null)
        {
            Console.WriteLine(result.ToJson());
        }

        // Update operation
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 31);
        collection.UpdateOne(updateFilter, update);

        // Read again after update
        result = collection.Find(filter).FirstOrDefault();
        if (result != null)
        {
            Console.WriteLine(result.ToJson());
        }

        // Delete operation
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);

        // Confirm deletion
        result = collection.Find(filter).FirstOrDefault();
        if (result == null)
        {
            Console.WriteLine("Document deleted successfully.");
        }
    }
}
