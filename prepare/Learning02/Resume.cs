
public class Resume 
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        System.Console.WriteLine($"{_name}");
        System.Console.WriteLine("Jobs:");
        foreach (Job job in _jobs){
           job.DisplayJob();
        }
    }
}