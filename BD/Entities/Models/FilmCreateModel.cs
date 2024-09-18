namespace BD.Entities.Models;

public class FilmCreateModel
{
    public string Name { get; set; }

    public int CompanyId { get; set; }

    public List<int> ActorIds { get; set; }
}