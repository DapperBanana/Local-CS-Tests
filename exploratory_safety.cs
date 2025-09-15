
using MongoDB.Driver;
using MongoDB.Bson;
using System;

class Program
{
    static IMongoCollection<BsonDocument> collection;

    static void Main(string[] args)
    {
        var connectionString = "mongodb://localhost:27017";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("mydatabase");
        collection = database.GetCollection<BsonDocument>("mycollection");

        // Create operation
        CreateDocument();

        // Read operation
        ReadDocument();

        // Update operation
        UpdateDocument();

        // Delete operation
        DeleteDocument();
    }

    static void CreateDocument()
    {
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "email", "john.doe@example.com" }
        };

        collection.InsertOne(document);
        Console.WriteLine("Document created successfully");
    }

    static void ReadDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var document = collection.Find(filter).FirstOrDefault();
        if (document != null)
        {
            Console.WriteLine("Found document: " + document.ToJson());
        }
        else
        {
            Console.WriteLine("Document not found");
        }
    }

    static void UpdateDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("age", 31);
        var result = collection.UpdateOne(filter, update);
        if (result.ModifiedCount > 0)
        {
            Console.WriteLine("Document updated successfully");
        }
        else
        {
            Console.WriteLine("Document not found");
        }
    }

    static void DeleteDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = collection.DeleteOne(filter);
        if (result.DeletedCount > 0)
        {
            Console.WriteLine("Document deleted successfully");
        }
        else
        {
            Console.WriteLine("Document not found");
        }
    }
}
