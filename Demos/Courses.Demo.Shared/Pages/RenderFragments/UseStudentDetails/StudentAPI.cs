namespace Courses.Demo.Shared.Pages.RenderFragments.UseStudentDetails;

public static class StudentAPI
{
    public static async Task<StudentDetails> GetStudentDetails()
    {
        // simulate the network call (so we'll see the loading state)
        await Task.Delay(500);
        
        // randomly generate an error, so we'll see the error UI
        RandomlyThrowException();

        return new StudentDetails("Alice", new DateTime(2021, 1, 2));
    }

    private static void RandomlyThrowException()
    {
        var rand = new Random();
        var num = rand.Next(100);

        if (num < 40)
        {
            throw new Exception("This is a randomly thrown exception.");
        }
    }
}