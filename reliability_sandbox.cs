
using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("testdb");
            var collection = database.GetCollection<BsonDocument>("testcollection");

            // Create
            var document = new BsonDocument
            {
                {"name", "John"},
                {"age", 30},
                {"city", "New York"}
            };
            collection.InsertOne(document);
            Console.WriteLine("Document inserted successfully.");

            // Read
            var filter = Builders<BsonDocument>.Filter.Eq("name", "John");
            var result = collection.Find(filter).FirstOrDefault();
            Console.WriteLine("Read document: " + result);

            // Update
            var updateFilter = Builders<BsonDocument>.Filter.Eq("name", "John");
            var update = Builders<BsonDocument>.Update.Set("age", 35);
            collection.UpdateOne(updateFilter, update);
            Console.WriteLine("Document updated successfully.");

            // Read updated document
            var updatedResult = collection.Find(filter).FirstOrDefault();
            Console.WriteLine("Updated document: " + updatedResult);

            // Delete
            collection.DeleteOne(filter);
            Console.WriteLine("Document deleted successfully.");

            // Verify deletion
            var deletedResult = collection.Find(filter).FirstOrDefault();
            if (deletedResult == null)
            {
                Console.WriteLine("Document deleted.");
            }
            else
            {
                Console.WriteLine("Failed to delete document.");
            }
        }
    }
}
