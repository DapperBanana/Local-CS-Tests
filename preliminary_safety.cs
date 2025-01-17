
using System;
using MongoDB.Driver;
using MongoDB.Bson;

class Program
{
    static MongoClient client = new MongoClient("mongodb://localhost:27017");
    static IMongoDatabase database = client.GetDatabase("test");
    static IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("users");

    static void Main(string[] args)
    {
        CreateDocument();
        ReadDocument();
        UpdateDocument();
        DeleteDocument();
    }

    static void CreateDocument()
    {
        var document = new BsonDocument
        {
            { "name", "John" },
            { "age", 30 },
            { "city", "New York" }
        };

        collection.InsertOne(document);
        Console.WriteLine("Document created successfully.");
    }

    static void ReadDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John");
        var document = collection.Find(filter).FirstOrDefault();

        Console.WriteLine("Read document:");
        Console.WriteLine(document);
    }

    static void UpdateDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John");
        var update = Builders<BsonDocument>.Update.Set("age", 31);

        collection.UpdateOne(filter, update);
        Console.WriteLine("Document updated successfully.");
    }

    static void DeleteDocument()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John");
        
        collection.DeleteOne(filter);
        Console.WriteLine("Document deleted successfully.");
    }
}
