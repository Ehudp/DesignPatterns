using Logger;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Structural
{
    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(StructContext context)
        {
            Log.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}