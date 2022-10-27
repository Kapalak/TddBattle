namespace Bowling
{
    public class Game
    {
        private readonly int[] rolls = new int[21];
        private int currentRoll;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public void Roll(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }

        public int Score()
        {
            throw new NotImplementedException();
        }
    }
}