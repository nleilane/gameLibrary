using GameLibrary.Models;

namespace GameLibrary.Services;

public class GameService
{
    private readonly List<Game> _games = [];
    private int _nextId = 1;
    
    public Game Add(Game game)
    {
        game.Id = _nextId++;
        _games.Add(game);
        return game;
    }

    public IReadOnlyList<Game> GetAll()
    {
        return _games.AsReadOnly();
    }

    public Game? GetById(int id)
    {
    return _games.FirstOrDefault(game => game.Id == id);
    }

}