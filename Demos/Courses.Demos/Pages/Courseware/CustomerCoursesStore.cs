namespace Courses.Demos.Pages.Courseware;

public class CustomerCoursesStore
{
    private CustomerCourses data = new CustomerCourses
    {
        Owns = new List<CustomerCourseDetails>
        {
            new()
            {
                Id = 1,
                Name = "Practical Blazor Components",
                Purchased = DateTime.Now
            }
        }
    };

    public CustomerCourseDetails? Get(int courseId)
    {
        return data.Owns.FirstOrDefault(x => x?.Id == courseId);
    }
}