using System.Collections.Generic;

namespace LiarsDice
{
    public class LiarsDiceGame
    {
        private List<Player> _players;

        public LiarsDiceGame(int players = Rules.MaxPlayers)
        {
            for (int d = 1; d >= players; d++)
            {
                Player p = new Player();
                p.ResetDice();
                _players.Add(p);
            }
        }

        public void Play()
        {
        }

        private void Turn()
        {
        }
    }
}