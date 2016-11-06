using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
            Console.WriteLine("Press Enter");
            Console.ReadLine();

        }
        static async Task MainAsync(string[] args)
        {
            //var student = new Homework {

            //};
           var client = new MongoClient("mongodb://localhost:27017");
           var db = client.GetDatabase("students");

            var col = db.GetCollection<Grade>("grades");

           var counter = await col.CountAsync(new BsonDocument());
           Console.WriteLine(counter);

            int currentStudentId = -1;

            // Find all the homeworks, sort by StudentId and then Score.
            await col
                .Find(x => x.Type == GradeType.homework)
                .SortBy(x => x.StudentId).ThenBy(x => x.Score)
                .ForEachAsync(async grade =>
                {
                    if (grade.StudentId != currentStudentId)
                    {
                        currentStudentId = grade.StudentId;

                                    // The first grade for each student will always be their lowest,
                                    // so delete it...
                                    await col.DeleteOneAsync(x => x.Id == grade.Id);
                    }
                });


            var result = await col.Aggregate()
                .Group(x => x.StudentId, g => new { StudentId = g.Key, Average = g.Average(x => x.Score) })
                .SortByDescending(x => x.Average)
                .FirstAsync();

            Console.WriteLine(result);


        }

        private class Grade
        {
            public ObjectId Id { get; set; }

            [BsonElement("student_id")]
            public int StudentId { get; set; }

            [BsonElement("type")]
            [BsonRepresentation(BsonType.String)]
            public GradeType Type { get; set; }

            [BsonElement("score")]
            public double Score { get; set; }
        }

        public enum GradeType
        {
            // I don't like needing to use lowercase here, but we don't have a built-in solution
            // for changing the case of enum values.
            homework,
            exam,
            quiz
        }
    }
}


//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Driver;

//namespace Playground
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MainAsync(args).Wait();
//            Console.ReadKey();
//        }

//        static async Task MainAsync(string[] args)
//        {
//            var client = new MongoClient();
//            var db = client.GetDatabase("m101");
//            var collection = db.GetCollection<Grade>("hw22");

//            // no student has a negative id, so we'll use that as a safe starting
//            // point
//            int currentStudentId = -1;

//            // Find all the homeworks, sort by StudentId and then Score.
//            await collection
//                .Find(x => x.Type == GradeType.homework)
//                .SortBy(x => x.StudentId).ThenBy(x => x.Score)
//                .ForEachAsync(async grade =>
//                {
//                    if (grade.StudentId != currentStudentId)
//                    {
//                        currentStudentId = grade.StudentId;

//                        // The first grade for each student will always be their lowest,
//                        // so delete it...
//                        await collection.DeleteOneAsync(x => x.Id == grade.Id);
//                    }
//                });

//            // We haven't gotten to this part in the class yet, but it's the
//            // translation of the aggregation query from the instructions into .NET.
//            var result = await collection.Aggregate()
//                .Group(x => x.StudentId, g => new { StudentId = g.Key, Average = g.Average(x => x.Score) })
//                .SortByDescending(x => x.Average)
//                .FirstAsync();

//            Console.WriteLine(result);
//        }

//        private class Grade
//        {
//            public ObjectId Id { get; set; }

//            [BsonElement("student_id")]
//            public int StudentId { get; set; }

//            [BsonElement("type")]
//            [BsonRepresentation(BsonType.String)]
//            public GradeType Type { get; set; }

//            [BsonElement("score")]
//            public double Score { get; set; }
//        }

//        public enum GradeType
//        {
//            // I don't like needing to use lowercase here, but we don't have a built-in solution
//            // for changing the case of enum values.
//            homework,
//            exam,
//            quiz
//        }
//    }
//}
