
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("Document created: " + document);

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Document retrieved: " + result);

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var updateDefinition = Builders<BsonDocument>.Update.Set("age", 35);
        collection.UpdateOne(updateFilter, updateDefinition);
        Console.WriteLine("Document updated");

        // Read updated document
        result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Updated document: " + result);

        // Delete
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted");

        // Check if document is deleted
        result = collection.Find(filter).FirstOrDefault();
        if (result == null)
        {
            Console.WriteLine("Document not found");
        }
    }
}
