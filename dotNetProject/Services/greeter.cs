namespace dotNetProject.Services
{
    public class greeter
    {
        public string SayHello(string name)
        {
            return "Hello, " +name;
        }

        public bool IsEligibleToVote(int age)
        {
            return age >= 18;
        }
    }
}
