
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("test");
        var collection = database.GetCollection<BsonDocument>("users");

        // Create
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "email", "john.doe@example.com" }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document added successfully.");

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(result);

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 31);
        collection.UpdateOne(updateFilter, update);
        Console.WriteLine("Document updated successfully.");

        // Delete
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted successfully.");
    }
}
