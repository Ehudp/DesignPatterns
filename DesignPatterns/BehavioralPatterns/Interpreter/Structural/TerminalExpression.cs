using Logger;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Structural
{
    /// <summary>
    /// The 'TerminalExpression' class
    /// </summary>
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(StructContext context)
        {
            Log.WriteLine("Called Terminal.Interpret()");
        }
    }
}