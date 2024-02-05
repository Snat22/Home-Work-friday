namespace Task1;

public class Teacher : Person
{
    int numCourses = 0;
    List<string> _courses = new List<string>();
    public Teacher(string name, string address) : base(name, address)
    {
    }
    public string toString() 
    {
        toString();
        return $"{numCourses} {_courses}";
    }
    public Boolean addCourse(string course)
    {
        foreach (var it in _courses)
        {
            if(it == course)
            {
                return false;
            }else
            {
                _courses.Add(course);
            }
        }
        return true;
        
    }
    // public Boolean removeCourse(string course)
    // {
    //  _courses.Remove(course);
    //     foreach (var i in _courses)
    //     {
    //         if()
    //     }
    //     return true;
    // }
    
}
