using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

           
        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            
            List<Course> courses = new List<Course>()
            {
                new Course { CourseId=1, Name="Math 101", Students=new List<Student>() {
                    new Student() { StudentId=1, Name="Dustin" },
                    new Student() {StudentId=2,Name="Joe" },
                    new Student() {StudentId=3,Name="Jane" },
                    new Student() {StudentId=4,Name="Crystal" }} },
                new Course { CourseId=2, Name="English",Students=new List<Student>() {
                    new Student() {StudentId=5, Name="Lisa" },
                    new Student() {StudentId=6,Name="Greg" },
                    new Student() {StudentId=7,Name="Cindy" }} },
                new Course{CourseId=3,Name="Science", Students=new List<Student>() {
                    new Student() {StudentId=8,Name="Riley" },
                    new Student() {StudentId=9,Name="Brian" },
                    new Student() {StudentId=10,Name="Eric" } } },
                new Course {CourseId=4,Name="Spanish",Students=new List<Student>() {
                    new Student() {StudentId=11,Name="Olga" },
                    new Student() {StudentId=12,Name="Allison" },
                    new Student() {StudentId=13,Name="Megan" }} }
            };
            
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("</br>Course:{0} - {1}",course.Name,course.CourseId);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("</br>&nbsp;&nbsp;Student:{0}-{1}", student.Name, student.StudentId);
                }

            };
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseId=1, Name="Band"};
            Course course2 = new Course() { CourseId = 2, Name = "PE" };
            Course course3 = new Course() { CourseId = 3, Name = "Biology" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student{StudentId=1, Name="Dustin Vandehey", Courses=new List<Course> { course1, course2} } },
                {2, new Student {StudentId=2, Name="Bob", Courses=new List<Course> {course2,course3 } } },
                {3, new Student {StudentId=3, Name="Lisa", Courses=new List<Course> {course3, course1 } } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/> Student: {0}-{1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>Course: {0}-{1}", course.CourseId, course.Name);
                }
            }
           /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */ 


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student = new Student();
            student.StudentId = 10;
            student.Name = "Dustin Vandehey";
            student.Enrollments = new List<Enrollment>
            {
                new Enrollment {Grade=90, Course= new Course { CourseId=1, Name="Psychology" } },
                new Enrollment{Grade=95, Course=new Course {CourseId=2,Name="Biology"}},
            };
            resultLabel.Text += String.Format("Student:{0}-{1}", student.StudentId, student.Name);
            foreach (var Enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("Enrolled In: {0}-Grade:{1}", Enrollment.Course.Name,Enrollment.Grade);
            }
        }
    }
}