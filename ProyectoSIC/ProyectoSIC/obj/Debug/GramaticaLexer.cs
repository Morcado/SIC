﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Becarios\Documents\SIC\ProyectoSIC\ProyectoSIC\Gramatica.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ProyectoSIC {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GramaticaLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, INSTR=6, DIRECTIVE=7, START=8, 
		END=9, LABEL=10, NUM=11, NUM_CHAR=12, EMPTY=13, ENDL=14, WS=15;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "INSTR", "DIRECTIVE", "START", 
		"END", "LABEL", "NUM", "NUM_CHAR", "EMPTY", "ENDL", "WS"
	};


	public GramaticaLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "', X'", "',X'", "'X''", "'''", "'C''", null, null, "'START'", "'END'", 
		null, null, null, "' '", "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "INSTR", "DIRECTIVE", "START", "END", 
		"LABEL", "NUM", "NUM_CHAR", "EMPTY", "ENDL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Gramatica.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x11\xB4\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x5\a\x7F\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x5\b\x91\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n"+
		"\x3\n\x3\n\x3\n\x3\v\x6\v\x9E\n\v\r\v\xE\v\x9F\x3\f\x6\f\xA3\n\f\r\f\xE"+
		"\f\xA4\x3\f\x5\f\xA8\n\f\x3\r\x5\r\xAB\n\r\x3\xE\x3\xE\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x10\x3\x10\x2\x2\x2\x11\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2"+
		"\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE"+
		"\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11\x3\x2\x6\x3\x2\x43\\\x4\x2JJjj\x5\x2"+
		"\x32;\x43H\x63h\x5\x2\v\f\xF\xF\"\"\xD2\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2"+
		"\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2"+
		"\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3"+
		"\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2"+
		"\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x3!\x3\x2\x2\x2\x5%\x3\x2\x2\x2\a"+
		"(\x3\x2\x2\x2\t+\x3\x2\x2\x2\v-\x3\x2\x2\x2\r~\x3\x2\x2\x2\xF\x90\x3\x2"+
		"\x2\x2\x11\x92\x3\x2\x2\x2\x13\x98\x3\x2\x2\x2\x15\x9D\x3\x2\x2\x2\x17"+
		"\xA2\x3\x2\x2\x2\x19\xAA\x3\x2\x2\x2\x1B\xAC\x3\x2\x2\x2\x1D\xAE\x3\x2"+
		"\x2\x2\x1F\xB0\x3\x2\x2\x2!\"\a.\x2\x2\"#\a\"\x2\x2#$\aZ\x2\x2$\x4\x3"+
		"\x2\x2\x2%&\a.\x2\x2&\'\aZ\x2\x2\'\x6\x3\x2\x2\x2()\aZ\x2\x2)*\a)\x2\x2"+
		"*\b\x3\x2\x2\x2+,\a)\x2\x2,\n\x3\x2\x2\x2-.\a\x45\x2\x2./\a)\x2\x2/\f"+
		"\x3\x2\x2\x2\x30\x31\a\x43\x2\x2\x31\x32\a\x46\x2\x2\x32\x7F\a\x46\x2"+
		"\x2\x33\x34\a\x43\x2\x2\x34\x35\aP\x2\x2\x35\x7F\a\x46\x2\x2\x36\x37\a"+
		"\x45\x2\x2\x37\x38\aQ\x2\x2\x38\x39\aO\x2\x2\x39\x7F\aR\x2\x2:;\a\x46"+
		"\x2\x2;<\aK\x2\x2<\x7F\aX\x2\x2=\x7F\aL\x2\x2>?\aL\x2\x2?@\aG\x2\x2@\x7F"+
		"\aS\x2\x2\x41\x42\aL\x2\x2\x42\x43\aI\x2\x2\x43\x7F\aV\x2\x2\x44\x45\a"+
		"L\x2\x2\x45\x46\aN\x2\x2\x46\x7F\aV\x2\x2GH\aL\x2\x2HI\aU\x2\x2IJ\aW\x2"+
		"\x2J\x7F\a\x44\x2\x2KL\aN\x2\x2LM\a\x46\x2\x2M\x7F\a\x43\x2\x2NO\aN\x2"+
		"\x2OP\a\x46\x2\x2PQ\a\x45\x2\x2Q\x7F\aJ\x2\x2RS\aN\x2\x2ST\a\x46\x2\x2"+
		"T\x7F\aN\x2\x2UV\aN\x2\x2VW\a\x46\x2\x2W\x7F\aZ\x2\x2XY\aO\x2\x2YZ\aW"+
		"\x2\x2Z\x7F\aN\x2\x2[\\\aQ\x2\x2\\\x7F\aT\x2\x2]^\aT\x2\x2^\x7F\a\x46"+
		"\x2\x2_`\aT\x2\x2`\x61\aU\x2\x2\x61\x62\aW\x2\x2\x62\x7F\a\x44\x2\x2\x63"+
		"\x64\aU\x2\x2\x64\x65\aV\x2\x2\x65\x7F\a\x43\x2\x2\x66g\aU\x2\x2gh\aV"+
		"\x2\x2hi\a\x45\x2\x2i\x7F\aJ\x2\x2jk\aU\x2\x2kl\aV\x2\x2l\x7F\aN\x2\x2"+
		"mn\aU\x2\x2no\aV\x2\x2op\aU\x2\x2p\x7F\aY\x2\x2qr\aU\x2\x2rs\aV\x2\x2"+
		"s\x7F\aZ\x2\x2tu\aU\x2\x2uv\aW\x2\x2v\x7F\a\x44\x2\x2wx\aV\x2\x2x\x7F"+
		"\a\x46\x2\x2yz\aV\x2\x2z{\aK\x2\x2{\x7F\aZ\x2\x2|}\aY\x2\x2}\x7F\a\x46"+
		"\x2\x2~\x30\x3\x2\x2\x2~\x33\x3\x2\x2\x2~\x36\x3\x2\x2\x2~:\x3\x2\x2\x2"+
		"~=\x3\x2\x2\x2~>\x3\x2\x2\x2~\x41\x3\x2\x2\x2~\x44\x3\x2\x2\x2~G\x3\x2"+
		"\x2\x2~K\x3\x2\x2\x2~N\x3\x2\x2\x2~R\x3\x2\x2\x2~U\x3\x2\x2\x2~X\x3\x2"+
		"\x2\x2~[\x3\x2\x2\x2~]\x3\x2\x2\x2~_\x3\x2\x2\x2~\x63\x3\x2\x2\x2~\x66"+
		"\x3\x2\x2\x2~j\x3\x2\x2\x2~m\x3\x2\x2\x2~q\x3\x2\x2\x2~t\x3\x2\x2\x2~"+
		"w\x3\x2\x2\x2~y\x3\x2\x2\x2~|\x3\x2\x2\x2\x7F\xE\x3\x2\x2\x2\x80\x81\a"+
		"\x44\x2\x2\x81\x82\a[\x2\x2\x82\x83\aV\x2\x2\x83\x91\aG\x2\x2\x84\x85"+
		"\aY\x2\x2\x85\x86\aQ\x2\x2\x86\x87\aT\x2\x2\x87\x91\a\x46\x2\x2\x88\x89"+
		"\aT\x2\x2\x89\x8A\aG\x2\x2\x8A\x8B\aU\x2\x2\x8B\x91\a\x44\x2\x2\x8C\x8D"+
		"\aT\x2\x2\x8D\x8E\aG\x2\x2\x8E\x8F\aU\x2\x2\x8F\x91\aY\x2\x2\x90\x80\x3"+
		"\x2\x2\x2\x90\x84\x3\x2\x2\x2\x90\x88\x3\x2\x2\x2\x90\x8C\x3\x2\x2\x2"+
		"\x91\x10\x3\x2\x2\x2\x92\x93\aU\x2\x2\x93\x94\aV\x2\x2\x94\x95\a\x43\x2"+
		"\x2\x95\x96\aT\x2\x2\x96\x97\aV\x2\x2\x97\x12\x3\x2\x2\x2\x98\x99\aG\x2"+
		"\x2\x99\x9A\aP\x2\x2\x9A\x9B\a\x46\x2\x2\x9B\x14\x3\x2\x2\x2\x9C\x9E\t"+
		"\x2\x2\x2\x9D\x9C\x3\x2\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F\x9D\x3\x2\x2\x2"+
		"\x9F\xA0\x3\x2\x2\x2\xA0\x16\x3\x2\x2\x2\xA1\xA3\x5\x19\r\x2\xA2\xA1\x3"+
		"\x2\x2\x2\xA3\xA4\x3\x2\x2\x2\xA4\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2"+
		"\xA5\xA7\x3\x2\x2\x2\xA6\xA8\t\x3\x2\x2\xA7\xA6\x3\x2\x2\x2\xA7\xA8\x3"+
		"\x2\x2\x2\xA8\x18\x3\x2\x2\x2\xA9\xAB\t\x4\x2\x2\xAA\xA9\x3\x2\x2\x2\xAB"+
		"\x1A\x3\x2\x2\x2\xAC\xAD\a\"\x2\x2\xAD\x1C\x3\x2\x2\x2\xAE\xAF\a\f\x2"+
		"\x2\xAF\x1E\x3\x2\x2\x2\xB0\xB1\t\x5\x2\x2\xB1\xB2\x3\x2\x2\x2\xB2\xB3"+
		"\b\x10\x2\x2\xB3 \x3\x2\x2\x2\t\x2~\x90\x9F\xA4\xA7\xAA\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ProyectoSIC
