
using System;
using MongoDB.Driver;

class Program
{
    static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("test");
        var collection = database.GetCollection<BsonDocument>("people");

        // Create
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 }
        };
        collection.InsertOne(document);

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).First();
        Console.WriteLine(result);

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var updateDefinition = Builders<BsonDocument>.Update.Set("age", 31);
        collection.UpdateOne(updateFilter, updateDefinition);

        // Read updated document
        result = collection.Find(filter).First();
        Console.WriteLine(result);

        // Delete
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);

        // Check if document is deleted
        var count = collection.CountDocuments(deleteFilter);
        if (count == 0)
        {
            Console.WriteLine("Document deleted successfully");
        }
        else
        {
            Console.WriteLine("Failed to delete document");
        }
    }
}
