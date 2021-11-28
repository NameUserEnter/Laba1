//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from E:\WinFormsApp1\LabCalculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace WinFormsApp1 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="LabCalculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ILabCalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpr([NotNull] LabCalculatorParser.MultiplicativeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpr([NotNull] LabCalculatorParser.MultiplicativeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponentialExpr([NotNull] LabCalculatorParser.ExponentialExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponentialExpr([NotNull] LabCalculatorParser.ExponentialExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryPExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryPExpr([NotNull] LabCalculatorParser.UnaryPExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryPExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryPExpr([NotNull] LabCalculatorParser.UnaryPExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] LabCalculatorParser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] LabCalculatorParser.AdditiveExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MmaxMminExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMmaxMminExpr([NotNull] LabCalculatorParser.MmaxMminExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MmaxMminExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMmaxMminExpr([NotNull] LabCalculatorParser.MmaxMminExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpr([NotNull] LabCalculatorParser.NumberExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpr([NotNull] LabCalculatorParser.NumberExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpr([NotNull] LabCalculatorParser.IdentifierExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpr([NotNull] LabCalculatorParser.IdentifierExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryMExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMExpr([NotNull] LabCalculatorParser.UnaryMExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryMExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMExpr([NotNull] LabCalculatorParser.UnaryMExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpr([NotNull] LabCalculatorParser.ParenthesizedExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpr([NotNull] LabCalculatorParser.ParenthesizedExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MaxMinExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxMinExpr([NotNull] LabCalculatorParser.MaxMinExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MaxMinExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxMinExpr([NotNull] LabCalculatorParser.MaxMinExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="LabCalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] LabCalculatorParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LabCalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] LabCalculatorParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] LabCalculatorParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LabCalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] LabCalculatorParser.ExpressionContext context);
}
} // namespace WinFormsApp1
