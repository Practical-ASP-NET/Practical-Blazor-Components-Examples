namespace Courses.Demos.Pages.Courseware;

public class CustomerCourses
{
    public IEnumerable<CustomerCourseDetails?> Owns { get; set; }
}

public class CustomerCourseDetails {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Purchased { get; set; }
}