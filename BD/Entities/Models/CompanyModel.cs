namespace BD.Entities.Models;

public class CompanyModel
{
    public int? Id { get; set; }

    public string Name { get; set; }

    public List<FilmDTO>? Films { get; set; }
}