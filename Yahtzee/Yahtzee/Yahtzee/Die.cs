using System;

namespace Yahtzee
{
    internal class Die
    {
        private bool holdDie;
        private int value;
        private Random random;

        public Die(double seed)
        {

            random = new Random(Convert.ToInt32(seed));
            holdDie = false;
            value = 1;
            return;
        }

        public int dieValue()
        {
            return value;
        }

        public int rollDie()
        {
            if (!holdDie)
            {
                
                value = (random.Next() % 6) + 1;
            }
            return value;
        }

        public void keepDie()
        {
            holdDie = true;
            return;
        }

        public void unKeepDie()
        {
            holdDie = false;
            return;
        }
    }
}