using System;

class Program
{
    static void Main(string[] args)
    {
        Course course = new Course();
        course.CourseName = "C#";
        course.CourseTeacher = "Engin Demirog";
        course.CourseAttendies = 68;

        Course course1 = new Course();
        course1.CourseName = "Java";
        course1.CourseTeacher = "Engin Demirog";
        course1.CourseAttendies = 86;

        Course course2 = new Course();
        course2.CourseName = "Python";
        course2.CourseTeacher = "Engin Demirog";
        course2.CourseAttendies = 34;

        Course course3 = new Course();
        course3.CourseName = "C++";
        course3.CourseTeacher = "Engin Demirog";
        course3.CourseAttendies = 172;

        Console.WriteLine(course.CourseName + ": " + course.CourseTeacher);

        Course[] courses = new Course[]{course, course1, course2, course3};
        foreach (Course eachCourse in courses)
            Console.WriteLine(eachCourse.CourseName + ": " + eachCourse.CourseTeacher + " - " + eachCourse.CourseAttendies);
    }
}


class Course {
    public string CourseName { get; set; }
    public string CourseTeacher { get; set; }
    public int CourseAttendies { get; set; }
}