﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Morcado\Desktop\Progra de sistemas\practica2\WindowsFormsApp1\WindowsFormsApp1\Combined1.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace WindowsFormsApp1 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Combined1Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICombined1Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] Combined1Parser.ProgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] Combined1Parser.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnd([NotNull] Combined1Parser.EndContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] Combined1Parser.InputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.propositions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropositions([NotNull] Combined1Parser.PropositionsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.proposition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposition([NotNull] Combined1Parser.PropositionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruction([NotNull] Combined1Parser.InstructionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective([NotNull] Combined1Parser.DirectiveContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] Combined1Parser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.instr_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstr_args([NotNull] Combined1Parser.Instr_argsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.directive_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective_args([NotNull] Combined1Parser.Directive_argsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Combined1Parser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] Combined1Parser.CompileUnitContext context);
}
} // namespace WindowsFormsApp1
