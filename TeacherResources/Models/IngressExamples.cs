namespace TeacherResources.Models;

public class IngressExample
{
    public string Id { get; set; }
    public string Semester { get; set; }
    public string Text { get; set; }
}

public class IngressExampleModel
{
    public List<IngressExample> IngressExamples { get; set; }
}