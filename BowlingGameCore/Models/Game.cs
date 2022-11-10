namespace BowlingGameCore
{
    public class Game
    {
        public Game()
        {
        }

        private int _selectedFrameIndex = 0;

        public int Id { get; set; }

        public Frame[] Frames { get; set; } = new Frame[10];

        public void Reset()
        {
            Frames = new Frame[10];
            _selectedFrameIndex = 0;
        }

        public void Rolls(int pins)
        {
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
            throw new NotImplementedException();
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
                if (Frames[_selectedFrameIndex].Rolls[0] + nbr > 10)
                {
                    throw new Exception("Impossible Rolls nbre");
                }
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
            }
            else if (Frames[_selectedFrameIndex].Rolls.Count() == 2)
            {
                if (Frames[_selectedFrameIndex].Rolls.Sum() < 10)
                {
                    throw new Exception("Third rolls is not permitted");
                }
                Frames[_selectedFrameIndex].Rolls.Add(nbr);
            }
        }
    }
}