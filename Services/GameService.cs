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

    public bool Update(Game updateGame)
    {
       int index = _games.FindIndex(g => g.Id == updateGame.Id);

    if(index == -1)
    {
          return false;
    } 
    
    _games[index] = updateGame;
    return true;

    }

    public bool Delete(int id)
    {
        int index = _games.FindIndex(g => g.Id == id);

    if(index == -1)
    {
        return false;
    }
    _games.RemoveAt(index);
    return true;
    }

}