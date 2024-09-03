
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace MongoDBCRUD
{
    class Program
    {
        static IMongoCollection<BsonDocument> collection;

        static void Main(string[] args)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "test";
            string collectionName = "users";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<BsonDocument>(collectionName);

            CreateDocument();
            ReadDocument();
            UpdateDocument();
            DeleteDocument();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void CreateDocument()
        {
            var document = new BsonDocument
            {
                { "name", "Alice" },
                { "age", 30 },
                { "city", "New York" }
            };

            collection.InsertOne(document);

            Console.WriteLine("Document created successfully:");
            Console.WriteLine(document);
        }

        static void ReadDocument()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
            var document = collection.Find(filter).FirstOrDefault();

            Console.WriteLine("Document read successfully:");
            Console.WriteLine(document);
        }

        static void UpdateDocument()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
            var update = Builders<BsonDocument>.Update.Set("age", 31);
            collection.FindOneAndUpdate(filter, update);

            var updatedDocument = collection.Find(filter).FirstOrDefault();

            Console.WriteLine("Document updated successfully:");
            Console.WriteLine(updatedDocument);
        }

        static void DeleteDocument()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Alice");
            collection.DeleteOne(filter);

            Console.WriteLine("Document deleted successfully");
        }
    }
}
