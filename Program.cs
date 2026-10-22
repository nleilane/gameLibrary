
using GameLibrary.Models;
using GameLibrary.Services;

GameService gameService = new();

Game game = new()
{
    Title = "The Witcher 3",
    Platform = "PC",
    Genre = "RPG",
    CoverImageUrl = "https://pt.wikipedia.org/wiki/The_Witcher_3:_Wild_Hunt",
    ReleaseYear = 2015,
    UserRating = 10,
    IsCompleted = true,
    IsFavorite = true,
    DateAdded = DateTime.Now
};

gameService.Add(game);

foreach (Game savedGame in gameService.GetAll())
{
    Console.WriteLine(
        $"{savedGame.Id} - {savedGame.Title} ({savedGame.ReleaseYear})");
}

Game? foundGame = gameService.GetById(1);

if (foundGame is not null) //verifica se o jogo foi encontrado antes de acessar as propriedades
{
    Console.WriteLine(
        $"Encontrado: {foundGame.Title} ({foundGame.ReleaseYear}) - Avaliação: {foundGame.UserRating}");
}
else
{
    Console.WriteLine("Jogo não encontrado.");
}

Game? existingGame = gameService.GetById(1);

if (existingGame is not null)
{
    Game updateGame = new()
    {
        Id = existingGame.Id,
        Title = existingGame.Title,
        Platform = existingGame.Platform,
        Genre = existingGame.Genre,
        CoverImageUrl = existingGame.CoverImageUrl,
        ReleaseYear = existingGame.ReleaseYear,
        UserRating = 9,
        IsCompleted = existingGame.IsCompleted,
        IsFavorite = existingGame.IsFavorite,
        DateAdded = existingGame.DateAdded
    };
    bool success = gameService.Update(updateGame);

    if (success)
    {
        Console.WriteLine("Jogo atualizado com sucesso!");
    } 
    else
    {
        Console.WriteLine("A atualizaçao falhou.");
    }
}

Game? deletingGame = gameService.GetById(1); 

if(deletingGame is not null)
{
    bool deleted = gameService.Delete(1);

    if (deleted)
    {
        Console.WriteLine("Jogo removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Não foi possível excluir o jogo");
    }
}
else
{
    Console.WriteLine("Jogo não encontrado");
}

Game? deletedGame = gameService.GetById(1);

if (deletedGame is null)
{
    Console.WriteLine("Confirmação: o jogo não está mais na lista.");
}
else
{
    Console.WriteLine("O jogo ainda está na lista.");
}