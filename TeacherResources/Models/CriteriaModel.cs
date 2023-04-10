namespace TeacherResources.Models;

public class CriteriaModel
{
    public int QID { get; set; }
    public string Question { get; set; }
    public List<CriteriaAlternative> Alternatives { get; set; }
    public string SelectedDescription { get; set; }
}

public class CriteriaAlternative
{
    public int AID { get; set; }
    public string Alternative { get; set; }
    public string Description { get; set; }
}