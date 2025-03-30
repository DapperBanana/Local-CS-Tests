
using MongoDB.Driver;
using MongoDB.Bson;
using System;

class Program
{
    static IMongoDatabase database;

    static void Main()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        database = client.GetDatabase("test");

        // Insert
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };
        InsertDocument("users", document);

        // Find
        var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
        var result = FindDocument("users", filter);
        Console.WriteLine(result.ToJson());

        // Update
        var update = Builders<BsonDocument>.Update.Set("city", "Chicago");
        UpdateDocument("users", filter, update);

        // Find updated document
        result = FindDocument("users", filter);
        Console.WriteLine(result.ToJson());

        // Delete
        DeleteDocument("users", filter);
    }

    static void InsertDocument(string collectionName, BsonDocument document)
    {
        var collection = database.GetCollection<BsonDocument>(collectionName);
        collection.InsertOne(document);
    }

    static BsonDocument FindDocument(string collectionName, FilterDefinition<BsonDocument> filter)
    {
        var collection = database.GetCollection<BsonDocument>(collectionName);
        return collection.Find(filter).FirstOrDefault();
    }

    static void UpdateDocument(string collectionName, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
    {
        var collection = database.GetCollection<BsonDocument>(collectionName);
        collection.UpdateOne(filter, update);
    }

    static void DeleteDocument(string collectionName, FilterDefinition<BsonDocument> filter)
    {
        var collection = database.GetCollection<BsonDocument>(collectionName);
        collection.DeleteOne(filter);
    }
}
