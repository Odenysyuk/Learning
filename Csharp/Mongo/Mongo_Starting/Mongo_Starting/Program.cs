using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo_Starting
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();

        }

        static async Task MainAsyncStarting(string[] args)
        {
            // var connectionString = "mongodb://localhost:27017";
            //var client = new MongoClient(connectionString);
            //

            var doc = new BsonDocument
            {
                { "name", "Jones"}
            };

            doc.Add("age", 30);
   
            doc["proffection"] = "hacker";

            var Array = new BsonArray();
            Array.Add(new BsonDocument("color", "red"));
            doc.Add("array", Array);

            Console.WriteLine(doc);
        }

        static async Task MainAsync_Insert(string[] args)
        {

            var client = new MongoClient();
            var db = client.GetDatabase("test");

            var col = db.GetCollection<BsonDocument>("people");

            var doc = new BsonDocument()
            {
                {"Name", "Smith"},
                { "Age", 30},
                { "Profection", "hacker"},
            };
          

            var doc2 = new BsonDocument()
            {
                {"Namestaff", "Alex"}
            };


            await col.InsertManyAsync(new[] {doc, doc2 });

            var col_class = db.GetCollection<Person>("people");

            var pers = new Person
            {
                Name = "Oly",
                Age = 30,
                Profection = "IT"
            };

            await col_class.InsertOneAsync(pers);
        }

        static async Task MainAsyncFind(string[] args)
        {

            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("test");
            var col = db.GetCollection<BsonDocument>("people");

            Console.WriteLine("Way 1: ");
            using (var cursor = await col.Find(new BsonDocument()).ToCursorAsync())
            {
                while(await cursor.MoveNextAsync())
                {
                    foreach (var doc in cursor.Current)
                        Console.WriteLine(doc);
                }

            }

            Console.WriteLine("Way 2: ");

            var list = await col.Find(new BsonDocument()).ToListAsync();
            foreach (var doc in list) {
                Console.WriteLine(doc);
            }

            Console.WriteLine("Way 3:");
            await col.Find(new BsonDocument()).ForEachAsync(doc => Console.WriteLine(doc));

        }


        static async Task MainAsync(string[] args)
        {

            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("test");
            var col = db.GetCollection<BsonDocument>("people");

            var filter = new BsonDocument("name", "Cat");


            var list = await col.Find(filter).ToListAsync();
            foreach (var doc in list)
            {
               Console.WriteLine(doc);
            }


            var list1 = await col.Find("{name: 'Cat'}").ToListAsync();
            foreach (var doc in list1)
            {
                Console.WriteLine(doc);
            }



            var filter1= new BsonDocument("Age", new BsonDocument("$lte", 10));
            var list2 = await col.Find(filter1).ToListAsync();
            foreach (var doc in list2)
            {
                Console.WriteLine(doc);
            }

            var builder = Builders<BsonDocument>.Filter;
            var filter2 = builder.Lt("Age", 10);
            var list3 = await col.Find(filter1).ToListAsync();
            foreach (var doc in list3)
            {
                Console.WriteLine(doc);
            }


            var col1 = db.GetCollection<Person>("people");
            var list4 = await col1.Find(x=> x.Age <30 && x.Name != "Smith").ToListAsync();
            foreach (var doc in list4)
            {
                Console.WriteLine(doc);
            }




        }

        class Person
        {
            public ObjectId Id { get; set; }
            public string Name { get; set;}
            public int Age { get; set; }
            public string Profection { get; set; }
        }
    }
}
