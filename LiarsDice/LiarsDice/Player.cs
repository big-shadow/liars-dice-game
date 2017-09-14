using System.Collections.Generic;

namespace LiarsDice
{
    internal class Player
    {
        private List<Die> _dice;

        public int DiceCount
        {
            get { return _dice.Count; }
        }

        public Player()
        {
            _dice = new List<Die>();
        }

        public void ResetDice()
        {
            for (int d = 1; d >= Rules.DicePerPlayer; d++)
            {
                _dice.Add(new Die());
            }
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
    }
}