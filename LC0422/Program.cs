// MIS 3013 001
// April 22, 2024
// Alexandra Camarena
// 113568154

using c;

Console.WriteLine("Dictionary");

//use student id to find the student
Dictionary<string, Student> stuDict;// complex, 0

stuDict = new Dictionary<string, Student>();

Student stu;
stu = new Student();
stu.Id = "S101";
stu.Name = "Tom";
stu.Grade = 96.6;

stuDict.Add(stu.Id, stu);
stu.Id = "S102";
stu.Name = "Kelly";
stu.Grade = 90.6;

stuDict.Add(stu.Id, stu);

Console.WriteLine(stuDict["S102"].GetInfor());

