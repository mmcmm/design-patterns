

namespace Rules.Rules
{
    public interface IRule
    {
        ScoreResult Eval(int[] dice);
    }
}