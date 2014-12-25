using System;

namespace DesignPatterns.BehavioralPatterns.Command.RealWorld
{
    /// <summary>
    ///     The 'ConcreteCommand' class
    /// </summary>
    internal class CalculatorCommand : Command
    {
        private int _operand;
        private char _operator;
        private readonly Calculator _calculator;
        // Constructor
        public CalculatorCommand(Calculator calculator,
            char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        // Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand
        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new
                        ArgumentException("@operator");
            }
        }
    }
}