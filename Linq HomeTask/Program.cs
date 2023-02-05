namespace Linq_HomeTask
{
        public class Student

        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }

        //class StudentComparer : IEqualityComparer<Student>
        //{
        //    public bool Equals(Student x, Student y)
        //    {
        //        if (x.Age == y.Age)
        //            return true;
        //        return false;
        //    }
        //    public int GetHashCode(Student obj)
        //    {
        //        return obj.Age.GetHashCode();
        //    }
        //}


        public class Program
        {
            static void Main(string[] args)
            {

                List<Student> studentList = new List<Student>()
            {
                new Student(){StudentId = 1, StudentName = "Shein", Age = 23},
                new Student(){StudentId = 2, StudentName = "George", Age = 19},
                new Student(){StudentId = 3, StudentName = "Victoria", Age = 29},
                new Student(){StudentId = 4, StudentName = "Anne", Age = 17}
            };
                List<Student> studentlist2 = new List<Student>()
            {
                 new Student(){StudentId = 3, StudentName = "Victoria", Age = 29},
                new Student(){StudentId = 4, StudentName = "Anne", Age = 17}
            };
         

                IEnumerable<Student> selectResult = studentList
                .GetWhereCondition(s => s.Age > 16 && s.Age < 24)
                .ToList<Student>();  //Where

                foreach (var item in selectResult)
                {
                    Console.WriteLine($"Student whose age >17 and <24 is: {item.StudentName}-{item.Age}");

                }

                Console.WriteLine();
                IEnumerable<Student> selectone = studentList
                .MySkipWhile(o => o.StudentId == 1)
                .ToList();  //SkipWhile

                foreach (Student item1 in selectone)
                {
                    Console.WriteLine($"Student, whose id != 1: {item1.StudentName}-{item1.StudentId}");
                }

            Console.WriteLine();
            //IEnumerable<Student> res = studentList
            //.Except(studentlist2, new StudentComparer())
            //.ToList<Student>();  //Except
            
            var res = studentList
            .MyExcept(studentlist2)
            .ToList<Student>();

                foreach (var item2 in res)        
                {
                    Console.WriteLine($"Here are our students: {item2.StudentName}");
                }
               

                Console.WriteLine();
                var result = studentList
                .MySingle(r => r.StudentId == 2);   //Single

            foreach(var item in result)
            {
                Console.WriteLine($"Student's name with id = 2:{item.StudentName}");
            }

                Console.WriteLine();

              
                var result1 = studentList.MyAll(x => x.Age == 23);     //All

                Console.WriteLine($"Everbody's ages = 23: {result1}");



                Console.WriteLine();

                var result2 = studentList
                .MyAny(e => e.StudentName == "Shein"); //Any

                Console.WriteLine(result2);


            }
        }
}