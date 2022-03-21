using LinqExample.Entity;
using LinqExample.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    public class Program
    {
        #region where
        // method syntax
        static void WhereExampleMethodSyntax(List<Student> list)
        {
            // select * from Students where address = 'Jaunpur'
            var students = list.Where(x => x.Address == "Jaunpur");
            PrintStudentList(students.ToList());
        }
        // query syntax like we wrote query in sql
        static void WhereExampleQuerySyntax(List<Student> list)
        {
            var students = from student in list
                           where student.Address == "Jaunpur"
                           select student;
            PrintStudentList(students.ToList());

        }
        // without linq, iterative method
        static void WhereExampleInterative(List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.Address == "Jaunpur")
                {
                    Console.WriteLine(student.ToString());
                }
            }

        }
        #endregion

        #region OfType
        static void OfTypeExample()
        {
            IList mixedList = new ArrayList();

            mixedList.Add(100);
            mixedList.Add("Rahul");
            mixedList.Add("Rahul");
            mixedList.Add(true);
            mixedList.Add(false);
            mixedList.Add(10.3);
            mixedList.Add("Yash");
            mixedList.Add(200);

            var list = mixedList.OfType<string>().ToList();

            //foreach (var mixed in mixedList) {

            //    if (mixed.GetType().ToString() == "System.Int32")
            //    {
            //        sum += (int)mixed;
            //    }
            //}
            //Console.WriteLine($"sum is: {sum}");

        }
        #endregion

        #region OrderBy
        public static void OrderByMethodSyntax(List<Student> list)
        {
            var students = list.OrderBy(student => student.Name).ToList();
            PrintStudentList(students);

            var students1 = list.OrderByDescending(student => student.Name).ToList();
            PrintStudentList(students1);

        }
        #endregion

        #region GroupBy
        public static void GroupByMethodSyntax(List<Student> list)
        {
            var groupedStudents = list.GroupBy(x => x.Address);

            foreach (var gs in groupedStudents)
            {
                Console.WriteLine($"\nAddress - {gs.Key}");
                foreach (var student in gs)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
        #endregion

        #region Select
        static void SelectMethodSyntax(List<Student> list)
        {
            var selectElements = list.Select(student => new StudentSelectListItem { Id = student.Id, Name = student.Name });
            foreach (var ss in selectElements)
            {
                Console.WriteLine($"id: {ss.Id}, name: {ss.Name}");
            }
        }
        #endregion

        #region AllMethodSyntax
        public static void AllMethodSyntax(List<Student> list)
        {
            var isSatisfied = list.All(std => std.Id > 10);
            if (isSatisfied)
            {
                Console.WriteLine("Yes, your condition is matched");
            }
            else
            {
                Console.WriteLine("Yes, your condition is not matched");
            }
        }
        #endregion

        #region AnyMethodSyntax
        public static void AnyMethodSyntax(List<Student> list)
        {
            var isSatisfied = list.Any(std => std.Id > 4);
            if (isSatisfied)
            {
                Console.WriteLine("Yes, your condition is matched");
            }
            else
            {
                Console.WriteLine("Yes, your condition is not matched");
            }
        }
        #endregion

        #region ContainMethodSyntax
        public static void ContainMethodSyntax(List<Student> list)
        {
            var Ids = list.Select(std => std.Id);

            var isSatisfied = Ids.Contains(4);

            if (isSatisfied)
            {
                Console.WriteLine("Yes, your condition is matched");
            }
            else
            {
                Console.WriteLine("Yes, your condition is not matched");
            }
        }
        #endregion

        #region AggregateMethodSyntax
        public static void AggregateMethodSyntax(List<Student> list)
        {
            var studentNames = list.Select(std => std.Name);
            var stringNames = studentNames.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(stringNames);
        }
        #endregion

        #region AverageMethodSyntax
        public static void AverageMethodSyntax(List<Student> list)
        {
            var RollNumbers = list.Select(std => std.RollNumber);
            var average = RollNumbers.Average();

            Console.WriteLine($"Average of roll number is: {average}");
        }
        #endregion

        #region CountMethodSyntax
        public static void CountMethodSyntax(List<Student> list)
        {
            var studentCount = list.Count(x => x.Address == "Jaunpur");
            Console.WriteLine($"Total Number of students: {studentCount}");
        }
        #endregion

        #region MaxMethodSyntax
        public static void MaxMethodSyntax(List<Student> list)
        {
            var rollNumbers = list.Select(x => x.RollNumber);
            var maxRollNumber = rollNumbers.Max();
            Console.WriteLine($"Max roll number is: {maxRollNumber}");
        }
        #endregion

        #region SumMethodSyntax
        public static void SumMethodSyntax(List<Student> list)
        {
            var rollNumbers = list.Select(x => x.RollNumber);
            var sumOfRollNumber = rollNumbers.Sum();
            Console.WriteLine($"Sum of roll number is: {sumOfRollNumber}");
        }
        #endregion

        #region ElementAt
        public static void ElementAtMethodSyntax(List<Student> list)
        {
            var student = list.ElementAt(0);
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        public static void ElementAtOrDefaultMethodSyntax(List<Student> list)
        {
            var student = list.ElementAtOrDefault(10);
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        #endregion

        #region FirstOrDefault
        public static void FirstMethodSyntax(List<Student> list)
        {
            var student = list.First();
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        public static void FirstOrDefaultMethodSyntax(List<Student> list)
        {
            var student = list.FirstOrDefault();
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        #endregion

        #region LastOrDefault
        public static void LastMethodSyntax(List<Student> list)
        {
            var student = list.Last();
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        public static void LastOrDefaultMethodSyntax(List<Student> list)
        {
            var student = list.LastOrDefault();
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Unable to find student");
        }
        #endregion

        #region SingleOrDefault
        public static void SingleMethodSyntax(List<Student> list)
        {
            var student = list.Single(x => x.Address == "London");
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("More than one student in the list");
        }
        public static void SingleOrDefaultMethodSyntax(List<Student> list)
        {
            var student = list.SingleOrDefault(x => x.Address == "London");
            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Student is found in the list");
        }
        #endregion

        #region SequenceEqual
        public static void SequenceEqualMethodSyntax(List<Student> list)
        {
            var list1 = list.Select(x => x.Name);
            var list2 = list.OrderByDescending(x => x.Name)
                            .Select(x => x.Name);

            var isEqual = list1.SequenceEqual(list2);
            if (isEqual)
                Console.WriteLine("Yes, both are equal");
            else
                Console.WriteLine("No, both are not equal");
        }

        #endregion

        #region Concat
        public static void ConcatMethodSyntax(List<Student> list)
        {
            var list1 = list.Select(x => x.Name);
            var list2 = list.OrderByDescending(x => x.Name)
                            .Select(x => "Mr. " + x.Name);

            var list3 = list1.Concat(list2);
            foreach (var name in list3)
            {
                Console.WriteLine($"Name is: {name}");
            }
        }

        #endregion

        #region DefaultIfEmpty
        public static void DefaultIfEmpty(List<Student> list)
        {
            list.Clear();
            var list1 = list.DefaultIfEmpty();
            var list2 = list.DefaultIfEmpty<Student>(new Student()
            {
                Id = 6,
                RollNumber = 140,
                Name = "Vishal Yadav",
                Address = "Jaunpur"
            });

            Console.WriteLine($"Count of list 1 is: {list1.Count()}");
            PrintStudentList(list1.ToList());
            Console.WriteLine($"Count of list 2 is: {list2.Count()}");
            PrintStudentList(list2.ToList());
        }

        #endregion
        // Immediate and deffered
        static void Execution(List<Student> students)
        {
            var immediate = students.ToList();

            var deffered = students.AsEnumerable();

            var newstudent = new Student()
            {
                Id = 1000,
                Name = "Ram",
                RollNumber = 0,
                Address = "Meeru"
            };

            students.Add(newstudent);

            //immediate
            Console.WriteLine($"------Immediate - {immediate.Count}-------");
            foreach (var student in immediate)
            {
                Console.WriteLine(student.ToString());
            }

            //deffered
            Console.WriteLine($"------Deffered - {deffered.Count()}-------");
            foreach (var student in deffered)
            {
                Console.WriteLine(student.ToString());
            }

        }
        //print list of students
        static void PrintStudentList(List<Student> students)
        {
            Console.WriteLine("----------------------------------");
            foreach (var student in students)
            {
                if (student != null)
                    Console.WriteLine(student.ToString());
            }
        }

        static void Main(string[] args)
        {
            var students = new Student().GetStudents();
            Console.WriteLine("Hello World!");
        }
    }
}
