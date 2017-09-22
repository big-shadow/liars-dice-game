using LiarsDice.PlayerTypes;
using LiarsDice.UIInterface;
using System.Collections.Generic;
using System.Linq;

namespace LiarsDice
{
    public struct Bet
    {
        internal DieFace Face;
        internal int Quantity;
    }

    public class LiarsDiceGame
    {
        private List<Player> _players;
        private UI _ui;

        public LiarsDiceGame(UI ui, int players = Rules.MaxPlayers)
        {
            _players = Enumerable.Range(0, players - 1).Select(i =>
            {
                Player p = new ArtificialIntelligence();
                p.ResetDice();
                return p;
            }).ToList();

            _players.Insert(0, new Human());

            _ui = ui;
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return _players;
            }
        }

        public void Play()
        {
            Bet bet = new Bet();

            while (_players.Count > 0)
            {
                foreach (Player p in _players)
                {
                    p.Turn(bet, _ui);
                }
            }

            _ui.Send("Game over!");
        }
    }
}