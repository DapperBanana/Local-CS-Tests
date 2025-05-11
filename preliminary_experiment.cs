
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static void Main()
    {
        // Connect to the MongoDB database
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("mydatabase");
        var collection = database.GetCollection<BsonDocument>("mycollection");

        // Create a document to insert
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };

        // Insert document into the collection
        collection.InsertOne(document);
        Console.WriteLine("Document inserted successfully.");

        // Find document by name
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine("Found document: {0}", result);

        // Update document
        var update = Builders<BsonDocument>.Update.Set("age", 35);
        collection.UpdateOne(filter, update);
        Console.WriteLine("Document updated successfully.");

        // Delete document
        collection.DeleteOne(filter);
        Console.WriteLine("Document deleted successfully.");

        // Clean up
        client.DropDatabase("mydatabase");
    }
}
