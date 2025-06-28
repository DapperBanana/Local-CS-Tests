
using System;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        // Connect to MongoDB server
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("mydatabase");
        var collection = database.GetCollection<BsonDocument>("mycollection");

        // Create
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document added successfully");

        // Read
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.Find(filter).FirstOrDefault();
        Console.WriteLine($"Name: {result.GetValue("name")}, Age: {result.GetValue("age")}, City: {result.GetValue("city")}");

        // Update
        var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 35);
        collection.UpdateOne(updateFilter, update);
        Console.WriteLine("Document updated successfully");

        // Delete
        var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(deleteFilter);
        Console.WriteLine("Document deleted successfully");
    }
}
