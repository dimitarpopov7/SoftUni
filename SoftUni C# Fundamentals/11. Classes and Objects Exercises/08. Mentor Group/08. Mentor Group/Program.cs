namespace _08.Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    public class Program
    {
        public static void Main()
        {
            var studentsList = new Dictionary<string, Student>();
            while (true)
            {
                string StudentDates = Console.ReadLine();
                if (StudentDates == "end of dates")
                {
                    break;
                }
                else
                {
                    var datesInfo = StudentDates.Split(' ', ',').ToList();
                    string name = datesInfo[0];
                    var datesList = new List<string>();
                    for (int i = 1; i < datesInfo.Count; i++)
                    {
                        datesList.Add(datesInfo[i]);
                    }
                    Student currentStudent = new Student();
                    currentStudent.Dates = datesList;
                    if (!studentsList.ContainsKey(name))
                    {
                        studentsList[name] = currentStudent;
                    }
                    else
                    {
                        var combinationOfDates = new List<string>();
                        combinationOfDates = currentStudent.Dates;
                        combinationOfDates.AddRange(studentsList[name].Dates);
                        currentStudent.Dates = combinationOfDates;
                        studentsList[name] = currentStudent;
                    }
                }
            }
            while (true)
            {
                string comments = Console.ReadLine();
                if (comments == "end of comments")
                {
                    break;
                }
                else
                {
                    var commentsInfo = comments.Split('-').ToList();
                    string name = commentsInfo[0];
                    string commentMade = commentsInfo[1];
                    Student currentStudent = new Student();
                    var currentCommentList = new List<string>();
                    currentCommentList.Add(commentMade);
                    currentStudent.Comments=currentCommentList;
                    if (studentsList.ContainsKey(name))
                    {                        
                        currentStudent.Dates = studentsList[name].Dates;
                        if (studentsList[name].Comments!= null)
                        {
                            var addComments = new List<string>();
                            addComments.AddRange(studentsList[name].Comments);
                            addComments.Add(commentMade);
                            currentStudent.Comments = addComments;
                            studentsList[name] = currentStudent;
                        }                           
                        else
                        {
                            studentsList[name] = currentStudent;
                        }
                    }
                }
            }
            foreach (var student in studentsList.OrderBy(x=>x.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                if (student.Value.Comments != null)
                {
                    foreach (var comment in student.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (student.Value.Dates != null)
                {
                    foreach (var date in student.Value.Dates.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date}");
                    }
                }
            }            
        }
    }
}

