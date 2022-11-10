namespace BowlingGameCore
{
    public class Game
    {
        public Game()
        {
        }

        private int _selectedFrameIndex = 0;

        public int Id { get; set; }

        public bool IsClosed { get; set; }

        public Frame[] Frames { get; set; } = new Frame[10]
        {
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
        };

        public void Reset()
        {
            IsClosed = false;
            Frames = new Frame[10];
            _selectedFrameIndex = 0;
        }

        public void Rolls(int pins)
        {
            if (IsClosed)
            {
                throw new Exception("Game already closed.");
            }
            if (pins < 0 || pins > 10)
            {
                throw new Exception("Impossible Rolls nbre");
            }

            if (_selectedFrameIndex < 9)
            {
                RollsFirstFrames(pins);
            }
            else if (_selectedFrameIndex == 9)
            {
                RollsLastFrame(pins);
            }
            else
            {
                throw new Exception("Frame Out of games");
            }
        }

        public void Rolls(int[] listPins)
        {
            foreach (var pins in listPins)
            {
                Rolls(pins);
            }
        }

        public int Score()
        {
            int sum = 0;
            foreach(var frame in this.Frames)
            {
               sum += frame.Rolls.Sum();
            }
            return sum;
        }

        private void RollsFirstFrames(int nbr)
        {
            if (Frames[_selectedFrameIndex].Rolls.Count() == 0)
            {
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
            }
            else if (Frames[_selectedFrameIndex].Rolls.Count() == 1)
            {
                if (Frames[_selectedFrameIndex].Rolls[0] + nbr > 10)
                {
                    throw new Exception("Impossible Rolls nbre");
                }
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
            }
            else
            {
                throw new Exception("Roll Out of games");
            }
            if (nbr == 10 || Frames[_selectedFrameIndex].Rolls.Count == 2)
            {
                _selectedFrameIndex++;
            }
        }

        private void RollsLastFrame(int nbr)
        {
            if (Frames[_selectedFrameIndex].Rolls.Count() == 0)
            {
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
            }
            else if (Frames[_selectedFrameIndex].Rolls.Count() == 1)
            {
                if (Frames[_selectedFrameIndex].Rolls[0] != 10 &&
                    Frames[_selectedFrameIndex].Rolls[0] + nbr > 10)
                {
                    throw new Exception("Impossible Rolls nbre");
                }
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
                if (Frames[_selectedFrameIndex].Rolls.Sum() < 10)
                {
                    IsClosed = true;
                }
                if (Frames[_selectedFrameIndex].Rolls[0] == 10)
                {
                    IsClosed = true;
                }
            }
            else if (Frames[_selectedFrameIndex].Rolls.Count() == 2)
            {
                if (Frames[_selectedFrameIndex].Rolls.Sum() < 10)
                {
                    throw new Exception("Third rolls is not permitted");
                }
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
                IsClosed = true;
            }
        }
    }
}