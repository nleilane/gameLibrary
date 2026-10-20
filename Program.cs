
using GameLibrary.Models;
using GameLibrary.Services;

GameService gameService = new();

Game game = new()
{
    Title = "The Witcher 3",
    Platform = "PC",
    Genre = "RPG",
    ReleaseYear = 2015,
    UserRating = 10,
    IsCompleted = true,
    IsFavorite = true
};

gameService.Add(game);

foreach (Game savedGame in gameService.GetAll())
{
    Console.WriteLine(
        $"{savedGame.Id} - {savedGame.Title} ({savedGame.ReleaseYear})");
}
