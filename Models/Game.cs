namespace GameLibrary.Models;

public class Game 
{
    //Identification
    public int Id {get; set;} //Convenção PascalCase para propriedades públicas
    public string Title {get; set;} = string.Empty;

    //Metadata
    public string Platform {get; set;} = string.Empty;
    public string Genre {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public string Developer {get; set;} = string.Empty;
    public string Publisher {get; set;} = string.Empty;
    public string? CoverImageUrl {get; set;} 
    public int ReleaseYear {get; set;}
    public int? UserRating {get; set;}
    public bool IsCompleted {get; set;}
    public bool IsFavorite {get; set;}
   
    //Collection information
    public DateTime DateAdded {get; set;} = DateTime.Now;
}