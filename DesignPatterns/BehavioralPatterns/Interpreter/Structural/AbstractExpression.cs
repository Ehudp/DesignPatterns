﻿namespace DesignPatterns.BehavioralPatterns.Interpreter.Structural
{
    /// <summary>
    ///     The 'AbstractExpression' abstract class
    /// </summary>
    internal abstract class AbstractExpression
    {
        public abstract void Interpret(StructContext context);
    }
}