using Rules.Rules;

namespace Rules
{
    public class ScoreResult
    {
        public ScoreResult()
        {
            
        }

        public ScoreResult(int[] diceUsed, int score, IRule ruleUsed)
        {
            DiceUsed = diceUsed;
            Score = score;
            RuleUsed = ruleUsed;
        }
        public int[] DiceUsed;
        public int Score;
        public IRule RuleUsed;
    }
}