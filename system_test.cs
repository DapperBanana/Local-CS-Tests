
using System;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("mydatabase");
        var collection = database.GetCollection<BsonDocument>("mycollection");

        // Create operation
        var document = new BsonDocument
        {
            { "name", "Alice" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document inserted");

        // Read operation
        var filter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(result);

        // Update operation
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
        var update = Builders<BsonDocument>.Update.Set("age", 31);
        collection.UpdateOne(updateFilter, update);
        Console.WriteLine("Document updated");

        // Read updated document
        result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(result);

        // Delete operation
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted");

        // Check if document is deleted
        result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(result);
    }
}
