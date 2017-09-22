using LiarsDice.UIInterface;
using System.Text.RegularExpressions;

namespace LiarsDice.PlayerTypes
{
    internal class Human : Player
    {
        public override void Turn(Bet bet, UI ui)
        {
            // If there's not currently an open bet, we place one.
            while (bet.Face == 0)
            {
                ui.Send("Choose a die face to bet on.");

                var tmp = ui.GetInput();
                var pattern = @"^(1-6)$";

                if (Regex.IsMatch(tmp, pattern))
                {
                    var face = Regex.Split(tmp, pattern)[0];
                    bet.Face = (DieFace)int.Parse(face);
                }
                else
                {
                    ui.Send("Nope. It's a number between 1 and 6.");
                }
            }

            while (bet.Quantity == 0)
            {
                ui.Send(string.Format("How many {0}'s?", bet.Face.ToString()));

                var tmp = ui.GetInput();
                var pattern = string.Format("^(1-{0})$", Rules.DicePerPlayer);

                if (Regex.IsMatch(tmp, pattern))
                {
                    var quantity = Regex.Split(tmp, pattern)[0];
                    bet.Quantity = int.Parse(quantity);
                }
                else
                {
                    ui.Send(string.Format("Nope. It's a number between 1 and {0}.", Rules.DicePerPlayer));
                }
            }
        }
    }
}