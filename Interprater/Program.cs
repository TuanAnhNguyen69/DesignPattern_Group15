using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {

        private string input;
        private int output;

        public Context(string input)
        {
            this.input = input;
        }

        public string getInput()
        {
            return input;
        }

        public void setInput(string input)
        {
            this.input = input;
        }

        public int getOutput()
        {
            return output;
        }

        public void setOutput(int output)
        {
            this.output = output;
        }

    }

    public abstract class Expression
    {

        public void interpret(Context context)
        {
            if (context.getInput().Length == 0)
                return;

            if (context.getInput().StartsWith(nine()))
            {
                context.setOutput(context.getOutput() + (9 * multiplier()));
                context.setInput(context.getInput().Substring(2));
            }
            else if (context.getInput().StartsWith(four()))
            {
                context.setOutput(context.getOutput() + (4 * multiplier()));
                context.setInput(context.getInput().Substring(2));
            }
            else if (context.getInput().StartsWith(five()))
            {
                context.setOutput(context.getOutput() + (5 * multiplier()));
                context.setInput(context.getInput().Substring(1));
            }

            while (context.getInput().StartsWith(one()))
            {
                context.setOutput(context.getOutput() + (1 * multiplier()));
                context.setInput(context.getInput().Substring(1));
            }
        }

        public abstract string one();
        public abstract string four();
        public abstract string five();
        public abstract string nine();
        public abstract int multiplier();

    }

    public class ThousandExpression : Expression
    {

        public override string one() { return "M"; }
        public override string four() { return " "; }
        public override string five() { return " "; }
        public override string nine() { return " "; }
        public override int multiplier() { return 1000; }
    }

    public class HundredExpression : Expression
    {
        public override string one() { return "C"; }
        public override string four() { return "CD"; }
        public override string five() { return "D"; }
        public override string nine() { return "CM"; }
        public override int multiplier() { return 100; }
    }

    public class TenExpression : Expression
    {
        public override string one() { return "X"; }
        public override string four() { return "XL"; }
        public override string five() { return "L"; }
        public override string nine() { return "XC"; }
        public override int multiplier() { return 10; }
    }

    public class OneExpression : Expression
    {
        public override string one() { return "I"; }
        public override string four() { return "IV"; }
        public override string five() { return "V"; }
        public override string nine() { return "IX"; }
        public override int multiplier() { return 1; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree' 
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret 
            foreach (var it in tree)
            {
                Expression exp = (Expression)it;
                exp.interpret(context);
            }

            Console.WriteLine(roman + " = " + context.getOutput().ToString());
        }
    }
}
