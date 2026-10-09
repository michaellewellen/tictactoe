using System.Security.Cryptography.X509Certificates;

namespace tictoe;

public class ActiveGames
{
    private readonly HashSet<int> open = new();
    private readonly object gate = new();

    public int Claim()
    {
        lock(gate)
        {
            int gameId = 1;
            while (open.Contains(gameId))
            {
                gameId ++;
            }
            open.Add(gameId);
            return gameId;
        }
    }
    public void Open(int id)
    {
        lock (gate) { open.Add(id);}        
    }

    public void Release(int id)
    {
        lock (gate) { open.Remove(id);}
    }        
}
