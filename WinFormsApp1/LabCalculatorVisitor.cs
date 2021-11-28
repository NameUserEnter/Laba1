using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WinFormsApp1
{
    class LabCalculatorVisitor : LabCalculatorBaseVisitor<double>
    {
        public static Dictionary<string, double> tableIdentifier = new Dictionary<string, double>();

        public override double VisitCompileUnit(LabCalculatorParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitNumberExpr(LabCalculatorParser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            Debug.WriteLine(result);

            return result;
        }
        //IdentifierExpr
        public override double VisitIdentifierExpr(LabCalculatorParser.IdentifierExprContext context)
        {
            var result = context.GetText();
            double value;
            //видобути значення змінної з таблиці
            Table.list.Add(result.ToString());
            if (tableIdentifier.TryGetValue(result.ToString(), out value))
            {
                return value;
            }
            else
            {
                return 0.0;
            }
        }

        public override double VisitParenthesizedExpr(LabCalculatorParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitExponentialExpr(LabCalculatorParser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);

            Debug.WriteLine("{0}^{1}", left, right);
            return System.Math.Pow(left, right);
        }

        private double WalkLeft(LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(0));
        }

        private double WalkRight(LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(1));
        }

        public override double VisitUnaryPExpr(LabCalculatorParser.UnaryPExprContext context)
        {
            var number = WalkLeft(context);
            return number + 1;
        }

        public override double VisitUnaryMExpr(LabCalculatorParser.UnaryMExprContext context)
        {
            var number = WalkLeft(context);
            return number - 1;
        }
        public override double VisitMaxMinExpr(LabCalculatorParser.MaxMinExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == LabCalculatorLexer.MIN)
            {
                return Math.Min(left, right);
            }
            if (context.operatorToken.Type == LabCalculatorLexer.MAX)
            {
                return Math.Max(left, right);
            }
            else
                return 0.0;
        }

        public override double VisitMmaxMminExpr(LabCalculatorParser.MmaxMminExprContext context)
        {
            var expression = context.GetText();
            expression = expression.Substring(expression.IndexOf('(') + 1, expression.LastIndexOf(')') - expression.IndexOf('(') - 1);
            string str = expression.Substring(0, expression.Length);
            List<string> results = str.Split(',').ToList();
            List<double> numbers = new List<double>();
            foreach (var result in results)
            {
                double number = Calculator.Evaluate(result);
                numbers.Add(number);
            }
            if (context.operatorToken.Type == LabCalculatorLexer.MMIN)
            {
                Debug.WriteLine(expression);
                return numbers.Min();
            }
            else //ExcelApplicationLexer.MMAX
            {
                Debug.WriteLine(expression);
                return numbers.Max();
            }
        }

    }
}
