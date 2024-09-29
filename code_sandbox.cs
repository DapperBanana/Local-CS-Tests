
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("mydatabase");
        var collection = database.GetCollection<BsonDocument>("mycollection");

        // Create
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document inserted successfully.");

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Read document: {0}", result);

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 35);
        collection.UpdateOne(updateFilter, update);
        Console.WriteLine("Document updated successfully.");

        // Read updated document
        result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Updated document: {0}", result);

        // Delete
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted successfully.");

        // Verify deletion
        result = collection.Find(filter).FirstOrDefault();
        if (result == null)
        {
            Console.WriteLine("Document not found.");
        }
        else
        {
            Console.WriteLine("Document still exists: {0}", result);
        }
    }
}
