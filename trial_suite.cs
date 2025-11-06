
using MongoDB.Driver;
using MongoDB.Bson;
using System;

class Program
{
    static IMongoClient client;
    static IMongoDatabase database;
    static IMongoCollection<BsonDocument> collection;

    static void Main(string[] args)
    {
        // Connect to MongoDB
        string connectionString = "mongodb://localhost:27017";
        client = new MongoClient(connectionString);
        database = client.GetDatabase("testDatabase");
        collection = database.GetCollection<BsonDocument>("testCollection");

        // Perform CRUD operations
        CreateData();
        ReadData();
        UpdateData();
        DeleteData();

        Console.ReadLine();
    }

    static void CreateData()
    {
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document created successfully.");
    }

    static void ReadData()
    {
        var filter = Builders<BsonDocument>.Filter.Empty;
        var documents = collection.Find(filter).ToList();
        foreach(var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }

    static void UpdateData()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var update = Builders<BsonDocument>.Update.Set("city", "Los Angeles");
        collection.UpdateOne(filter, update);
        Console.WriteLine("Document updated successfully.");
    }

    static void DeleteData()
    {
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        collection.DeleteOne(filter);
        Console.WriteLine("Document deleted successfully.");
    }
}
