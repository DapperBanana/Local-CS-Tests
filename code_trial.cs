
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("testdb");
        var collection = database.GetCollection<BsonDocument>("testcollection");

        // Create operation
        var document = new BsonDocument
        {
            {"name", "John Doe"},
            {"age", 30},
            {"city", "New York"}
        };
        collection.InsertOne(document);
        Console.WriteLine("Document inserted.");

        // Read operation
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Found document: " + result.ToJson());

        // Update operation
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 35);
        collection.UpdateOne(updateFilter, update);
        Console.WriteLine("Document updated.");

        // Delete operation
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted.");

        Console.ReadLine();
    }
}
