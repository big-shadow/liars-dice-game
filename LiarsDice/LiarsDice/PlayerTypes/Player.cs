using LiarsDice.UIInterface;
using System.Collections.Generic;
using System.Linq;

namespace LiarsDice.PlayerTypes
{
    public abstract class Player
    {
        private List<Die> _dice;

        public int DiceCount
        {
            get { return _dice.Count; }
        }

        public List<Die> Dice
        {
            get
            {
                return _dice;
            }
        }

        public Player()
        {
            ResetDice();
        }

        public void ResetDice()
        {
            _dice = Enumerable.Range(0, Rules.DicePerPlayer).Select(i => new Die()).ToList();
        }

        public void RollDice()
        {
            foreach (Die die in _dice)
            {
                die.Roll();
            }
        }

        public void ForfeitDice()
        {
            _dice.RemoveAt(0);
        }

        public abstract void Turn(Bet bet, UI ui);
    }
}