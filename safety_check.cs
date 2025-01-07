
using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace MongoDBCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("students");

            // Create
            var document = new BsonDocument
            {
                { "name", "John Doe" },
                { "age", 25 },
                { "email", "johndoe@example.com" }
            };
            collection.InsertOne(document);
            Console.WriteLine("Document inserted successfully.");

            // Read
            var foundDocument = collection.Find(new BsonDocument()).FirstOrDefault();
            if (foundDocument != null)
            {
                Console.WriteLine("Found document: " + foundDocument);
            }

            // Update
            var filter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
            var update = Builders<BsonDocument>.Update.Set("age", 26);
            collection.UpdateOne(filter, update);
            Console.WriteLine("Document updated successfully.");

            // Delete
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("name", "John Doe");
            collection.DeleteOne(deleteFilter);
            Console.WriteLine("Document deleted successfully.");
        }
    }
}
