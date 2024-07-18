using System;

namespace ScreenSound.Model
{
    internal class Rating
    {
        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                if (!IsValidRating(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 0 and 9.");
                }
                score = value;
            }
        }

        public string Reviewer { get; set; }

        public Rating(int score, string reviewer)
        {
            Score = score;
            Reviewer = reviewer;
        }

        private bool IsValidRating(int score)
        {
            return score >= 0 && score <= 9;
        }
    }
}
