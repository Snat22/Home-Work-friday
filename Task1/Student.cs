namespace Task1;

public class Student : Person
{
    int numCourses = 0;
    List<string> _courses = new List<string>();
    List<int> _grades = new List<int>();
    public Student(string name, string address) : base(name, address)
    {

    }


    public override string toString()
    {
            return $"{toString()} {numCourses} {_courses} {_grades}";
    }
    public void addCourseGrade(string course,int grade)
    {
            _courses.Add(course);
            _grades.Add(grade);
    }

    public void printGrade(){}

    // public double getAverageGrade()
    // {

    // }

    // public string toString() 
    // {
    //     toString();
    // }
}
