//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Sergiu/RiderProjects/PseudocodeInterpreter/PseudocodeInterpreter/src/AntlrFiles\Pseudo.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrGenerated {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class PseudoLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, INT_TYPE=13, FLOAT_TYPE=14, STRING_TYPE=15, 
		CHAR_TYPE=16, BOOL_TYPE=17, READ_BUILTIN=18, WRITE_BUILTIN=19, WRITELN_BUILTIN=20, 
		IF=21, THEN=22, ELSE=23, WHILE=24, EXEC=25, REPEAT=26, UNTIL=27, END=28, 
		AND=29, OR=30, NOT=31, FUNCTION=32, LP=33, RP=34, ASSIGN=35, EQUAL=36, 
		INT=37, FLOAT=38, STRING=39, ID=40, NL=41, LINE_COMMENT=42, COMMENT=43, 
		WS=44;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "INT_TYPE", "FLOAT_TYPE", "STRING_TYPE", "CHAR_TYPE", 
		"BOOL_TYPE", "READ_BUILTIN", "WRITE_BUILTIN", "WRITELN_BUILTIN", "IF", 
		"THEN", "ELSE", "WHILE", "EXEC", "REPEAT", "UNTIL", "END", "AND", "OR", 
		"NOT", "FUNCTION", "LP", "RP", "ASSIGN", "EQUAL", "INT", "FLOAT", "STRING", 
		"ID", "NL", "ESC", "LETTER", "DIGIT", "LINE_COMMENT", "COMMENT", "WS"
	};


	public PseudoLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PseudoLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'<'", "'<='", "'>'", "'>='", "'['", "']'", "'+'", "'-'", 
		"'*'", "'/'", "'%'", "'intreg'", "'real'", "'text'", "'caracter'", "'boolean'", 
		"'citeste'", "'scrie'", "'scrieln'", "'daca'", "'atunci'", "'altfel'", 
		"'cat timp'", "'executa'", "'repeta'", "'pana cand'", "'sfarsit'", "'si'", 
		"'sau'", "'non'", "'fun'", "'('", "')'", "'<-'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "INT_TYPE", "FLOAT_TYPE", "STRING_TYPE", "CHAR_TYPE", "BOOL_TYPE", 
		"READ_BUILTIN", "WRITE_BUILTIN", "WRITELN_BUILTIN", "IF", "THEN", "ELSE", 
		"WHILE", "EXEC", "REPEAT", "UNTIL", "END", "AND", "OR", "NOT", "FUNCTION", 
		"LP", "RP", "ASSIGN", "EQUAL", "INT", "FLOAT", "STRING", "ID", "NL", "LINE_COMMENT", 
		"COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Pseudo.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PseudoLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '.', '\x16B', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', 
		'\x3', '$', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', 
		'\x3', '&', '\x3', '&', '\a', '&', '\x10C', '\n', '&', '\f', '&', '\xE', 
		'&', '\x10F', '\v', '&', '\x5', '&', '\x111', '\n', '&', '\x3', '\'', 
		'\x6', '\'', '\x114', '\n', '\'', '\r', '\'', '\xE', '\'', '\x115', '\x3', 
		'\'', '\x3', '\'', '\a', '\'', '\x11A', '\n', '\'', '\f', '\'', '\xE', 
		'\'', '\x11D', '\v', '\'', '\x3', '\'', '\x3', '\'', '\x6', '\'', '\x121', 
		'\n', '\'', '\r', '\'', '\xE', '\'', '\x122', '\x5', '\'', '\x125', '\n', 
		'\'', '\x3', '(', '\x3', '(', '\x3', '(', '\a', '(', '\x12A', '\n', '(', 
		'\f', '(', '\xE', '(', '\x12D', '\v', '(', '\x3', '(', '\x3', '(', '\x3', 
		')', '\x3', ')', '\x5', ')', '\x133', '\n', ')', '\x3', ')', '\x3', ')', 
		'\x3', ')', '\a', ')', '\x138', '\n', ')', '\f', ')', '\xE', ')', '\x13B', 
		'\v', ')', '\x3', '*', '\x5', '*', '\x13E', '\n', '*', '\x3', '*', '\x3', 
		'*', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', 
		'-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '.', '\a', 
		'.', '\x14D', '\n', '.', '\f', '.', '\xE', '.', '\x150', '\v', '.', '\x3', 
		'.', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', 
		'/', '\x3', '/', '\a', '/', '\x15A', '\n', '/', '\f', '/', '\xE', '/', 
		'\x15D', '\v', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', 
		'/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', '\x5', 
		'\x30', '\x168', '\n', '\x30', '\x3', '\x30', '\x3', '\x30', '\x5', '\x12B', 
		'\x14E', '\x15B', '\x2', '\x31', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', 
		'\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', 
		'\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', 
		'\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', 
		')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', 
		'\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', 
		' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', 
		'&', 'K', '\'', 'M', '(', 'O', ')', 'Q', '*', 'S', '+', 'U', '\x2', 'W', 
		'\x2', 'Y', '\x2', '[', ',', ']', '-', '_', '.', '\x3', '\x2', '\a', '\x3', 
		'\x2', '\x33', ';', '\b', '\x2', '$', '$', '^', '^', '\x64', '\x64', 'p', 
		'p', 't', 't', 'v', 'v', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x3', 
		'\x2', '\x32', ';', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x2', '\x178', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', '\x2', ']', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x61', '\x3', '\x2', '\x2', '\x2', '\x5', '\x63', '\x3', '\x2', '\x2', 
		'\x2', '\a', '\x65', '\x3', '\x2', '\x2', '\x2', '\t', 'h', '\x3', '\x2', 
		'\x2', '\x2', '\v', 'j', '\x3', '\x2', '\x2', '\x2', '\r', 'm', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'o', '\x3', '\x2', '\x2', '\x2', '\x11', 'q', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 's', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'u', '\x3', '\x2', '\x2', '\x2', '\x17', 'w', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'y', '\x3', '\x2', '\x2', '\x2', '\x1B', '{', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x82', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x87', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x8C', '\x3', '\x2', '\x2', '\x2', '#', '\x95', 
		'\x3', '\x2', '\x2', '\x2', '%', '\x9D', '\x3', '\x2', '\x2', '\x2', '\'', 
		'\xA5', '\x3', '\x2', '\x2', '\x2', ')', '\xAB', '\x3', '\x2', '\x2', 
		'\x2', '+', '\xB3', '\x3', '\x2', '\x2', '\x2', '-', '\xB8', '\x3', '\x2', 
		'\x2', '\x2', '/', '\xBF', '\x3', '\x2', '\x2', '\x2', '\x31', '\xC6', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\xCF', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\xD7', '\x3', '\x2', '\x2', '\x2', '\x37', '\xDE', '\x3', '\x2', 
		'\x2', '\x2', '\x39', '\xE8', '\x3', '\x2', '\x2', '\x2', ';', '\xF0', 
		'\x3', '\x2', '\x2', '\x2', '=', '\xF3', '\x3', '\x2', '\x2', '\x2', '?', 
		'\xF7', '\x3', '\x2', '\x2', '\x2', '\x41', '\xFB', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\xFF', '\x3', '\x2', '\x2', '\x2', '\x45', '\x101', '\x3', 
		'\x2', '\x2', '\x2', 'G', '\x103', '\x3', '\x2', '\x2', '\x2', 'I', '\x106', 
		'\x3', '\x2', '\x2', '\x2', 'K', '\x110', '\x3', '\x2', '\x2', '\x2', 
		'M', '\x124', '\x3', '\x2', '\x2', '\x2', 'O', '\x126', '\x3', '\x2', 
		'\x2', '\x2', 'Q', '\x132', '\x3', '\x2', '\x2', '\x2', 'S', '\x13D', 
		'\x3', '\x2', '\x2', '\x2', 'U', '\x141', '\x3', '\x2', '\x2', '\x2', 
		'W', '\x144', '\x3', '\x2', '\x2', '\x2', 'Y', '\x146', '\x3', '\x2', 
		'\x2', '\x2', '[', '\x148', '\x3', '\x2', '\x2', '\x2', ']', '\x155', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x167', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '\x62', '\a', '.', '\x2', '\x2', '\x62', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '\x63', '\x64', '\a', '>', '\x2', '\x2', '\x64', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', '>', '\x2', '\x2', '\x66', 
		'g', '\a', '?', '\x2', '\x2', 'g', '\b', '\x3', '\x2', '\x2', '\x2', 'h', 
		'i', '\a', '@', '\x2', '\x2', 'i', '\n', '\x3', '\x2', '\x2', '\x2', 'j', 
		'k', '\a', '@', '\x2', '\x2', 'k', 'l', '\a', '?', '\x2', '\x2', 'l', 
		'\f', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\a', ']', '\x2', '\x2', 'n', 
		'\xE', '\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', '_', '\x2', '\x2', 
		'p', '\x10', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\a', '-', '\x2', '\x2', 
		'r', '\x12', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', '/', '\x2', '\x2', 
		't', '\x14', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', ',', '\x2', '\x2', 
		'v', '\x16', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', '\x31', '\x2', 
		'\x2', 'x', '\x18', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', '\'', 
		'\x2', '\x2', 'z', '\x1A', '\x3', '\x2', '\x2', '\x2', '{', '|', '\a', 
		'k', '\x2', '\x2', '|', '}', '\a', 'p', '\x2', '\x2', '}', '~', '\a', 
		'v', '\x2', '\x2', '~', '\x7F', '\a', 't', '\x2', '\x2', '\x7F', '\x80', 
		'\a', 'g', '\x2', '\x2', '\x80', '\x81', '\a', 'i', '\x2', '\x2', '\x81', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', 't', '\x2', 
		'\x2', '\x83', '\x84', '\a', 'g', '\x2', '\x2', '\x84', '\x85', '\a', 
		'\x63', '\x2', '\x2', '\x85', '\x86', '\a', 'n', '\x2', '\x2', '\x86', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\a', 'v', '\x2', 
		'\x2', '\x88', '\x89', '\a', 'g', '\x2', '\x2', '\x89', '\x8A', '\a', 
		'z', '\x2', '\x2', '\x8A', '\x8B', '\a', 'v', '\x2', '\x2', '\x8B', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', '\x65', '\x2', '\x2', 
		'\x8D', '\x8E', '\a', '\x63', '\x2', '\x2', '\x8E', '\x8F', '\a', 't', 
		'\x2', '\x2', '\x8F', '\x90', '\a', '\x63', '\x2', '\x2', '\x90', '\x91', 
		'\a', '\x65', '\x2', '\x2', '\x91', '\x92', '\a', 'v', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'g', '\x2', '\x2', '\x93', '\x94', '\a', 't', '\x2', '\x2', 
		'\x94', '\"', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\a', '\x64', 
		'\x2', '\x2', '\x96', '\x97', '\a', 'q', '\x2', '\x2', '\x97', '\x98', 
		'\a', 'q', '\x2', '\x2', '\x98', '\x99', '\a', 'n', '\x2', '\x2', '\x99', 
		'\x9A', '\a', 'g', '\x2', '\x2', '\x9A', '\x9B', '\a', '\x63', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', 'p', '\x2', '\x2', '\x9C', '$', '\x3', '\x2', 
		'\x2', '\x2', '\x9D', '\x9E', '\a', '\x65', '\x2', '\x2', '\x9E', '\x9F', 
		'\a', 'k', '\x2', '\x2', '\x9F', '\xA0', '\a', 'v', '\x2', '\x2', '\xA0', 
		'\xA1', '\a', 'g', '\x2', '\x2', '\xA1', '\xA2', '\a', 'u', '\x2', '\x2', 
		'\xA2', '\xA3', '\a', 'v', '\x2', '\x2', '\xA3', '\xA4', '\a', 'g', '\x2', 
		'\x2', '\xA4', '&', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', 
		'u', '\x2', '\x2', '\xA6', '\xA7', '\a', '\x65', '\x2', '\x2', '\xA7', 
		'\xA8', '\a', 't', '\x2', '\x2', '\xA8', '\xA9', '\a', 'k', '\x2', '\x2', 
		'\xA9', '\xAA', '\a', 'g', '\x2', '\x2', '\xAA', '(', '\x3', '\x2', '\x2', 
		'\x2', '\xAB', '\xAC', '\a', 'u', '\x2', '\x2', '\xAC', '\xAD', '\a', 
		'\x65', '\x2', '\x2', '\xAD', '\xAE', '\a', 't', '\x2', '\x2', '\xAE', 
		'\xAF', '\a', 'k', '\x2', '\x2', '\xAF', '\xB0', '\a', 'g', '\x2', '\x2', 
		'\xB0', '\xB1', '\a', 'n', '\x2', '\x2', '\xB1', '\xB2', '\a', 'p', '\x2', 
		'\x2', '\xB2', '*', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\a', 
		'\x66', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x63', '\x2', '\x2', '\xB5', 
		'\xB6', '\a', '\x65', '\x2', '\x2', '\xB6', '\xB7', '\a', '\x63', '\x2', 
		'\x2', '\xB7', ',', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\a', 
		'\x63', '\x2', '\x2', '\xB9', '\xBA', '\a', 'v', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', 'w', '\x2', '\x2', '\xBB', '\xBC', '\a', 'p', '\x2', '\x2', 
		'\xBC', '\xBD', '\a', '\x65', '\x2', '\x2', '\xBD', '\xBE', '\a', 'k', 
		'\x2', '\x2', '\xBE', '.', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', 
		'\a', '\x63', '\x2', '\x2', '\xC0', '\xC1', '\a', 'n', '\x2', '\x2', '\xC1', 
		'\xC2', '\a', 'v', '\x2', '\x2', '\xC2', '\xC3', '\a', 'h', '\x2', '\x2', 
		'\xC3', '\xC4', '\a', 'g', '\x2', '\x2', '\xC4', '\xC5', '\a', 'n', '\x2', 
		'\x2', '\xC5', '\x30', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', 
		'\x65', '\x2', '\x2', '\xC7', '\xC8', '\a', '\x63', '\x2', '\x2', '\xC8', 
		'\xC9', '\a', 'v', '\x2', '\x2', '\xC9', '\xCA', '\a', '\"', '\x2', '\x2', 
		'\xCA', '\xCB', '\a', 'v', '\x2', '\x2', '\xCB', '\xCC', '\a', 'k', '\x2', 
		'\x2', '\xCC', '\xCD', '\a', 'o', '\x2', '\x2', '\xCD', '\xCE', '\a', 
		'r', '\x2', '\x2', '\xCE', '\x32', '\x3', '\x2', '\x2', '\x2', '\xCF', 
		'\xD0', '\a', 'g', '\x2', '\x2', '\xD0', '\xD1', '\a', 'z', '\x2', '\x2', 
		'\xD1', '\xD2', '\a', 'g', '\x2', '\x2', '\xD2', '\xD3', '\a', '\x65', 
		'\x2', '\x2', '\xD3', '\xD4', '\a', 'w', '\x2', '\x2', '\xD4', '\xD5', 
		'\a', 'v', '\x2', '\x2', '\xD5', '\xD6', '\a', '\x63', '\x2', '\x2', '\xD6', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', '\a', 't', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', 'g', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'r', '\x2', '\x2', '\xDA', '\xDB', '\a', 'g', '\x2', '\x2', '\xDB', '\xDC', 
		'\a', 'v', '\x2', '\x2', '\xDC', '\xDD', '\a', '\x63', '\x2', '\x2', '\xDD', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', 'r', '\x2', 
		'\x2', '\xDF', '\xE0', '\a', '\x63', '\x2', '\x2', '\xE0', '\xE1', '\a', 
		'p', '\x2', '\x2', '\xE1', '\xE2', '\a', '\x63', '\x2', '\x2', '\xE2', 
		'\xE3', '\a', '\"', '\x2', '\x2', '\xE3', '\xE4', '\a', '\x65', '\x2', 
		'\x2', '\xE4', '\xE5', '\a', '\x63', '\x2', '\x2', '\xE5', '\xE6', '\a', 
		'p', '\x2', '\x2', '\xE6', '\xE7', '\a', '\x66', '\x2', '\x2', '\xE7', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', '\a', 'u', '\x2', 
		'\x2', '\xE9', '\xEA', '\a', 'h', '\x2', '\x2', '\xEA', '\xEB', '\a', 
		'\x63', '\x2', '\x2', '\xEB', '\xEC', '\a', 't', '\x2', '\x2', '\xEC', 
		'\xED', '\a', 'u', '\x2', '\x2', '\xED', '\xEE', '\a', 'k', '\x2', '\x2', 
		'\xEE', '\xEF', '\a', 'v', '\x2', '\x2', '\xEF', ':', '\x3', '\x2', '\x2', 
		'\x2', '\xF0', '\xF1', '\a', 'u', '\x2', '\x2', '\xF1', '\xF2', '\a', 
		'k', '\x2', '\x2', '\xF2', '<', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF4', 
		'\a', 'u', '\x2', '\x2', '\xF4', '\xF5', '\a', '\x63', '\x2', '\x2', '\xF5', 
		'\xF6', '\a', 'w', '\x2', '\x2', '\xF6', '>', '\x3', '\x2', '\x2', '\x2', 
		'\xF7', '\xF8', '\a', 'p', '\x2', '\x2', '\xF8', '\xF9', '\a', 'q', '\x2', 
		'\x2', '\xF9', '\xFA', '\a', 'p', '\x2', '\x2', '\xFA', '@', '\x3', '\x2', 
		'\x2', '\x2', '\xFB', '\xFC', '\a', 'h', '\x2', '\x2', '\xFC', '\xFD', 
		'\a', 'w', '\x2', '\x2', '\xFD', '\xFE', '\a', 'p', '\x2', '\x2', '\xFE', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\a', '*', '\x2', 
		'\x2', '\x100', '\x44', '\x3', '\x2', '\x2', '\x2', '\x101', '\x102', 
		'\a', '+', '\x2', '\x2', '\x102', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x103', '\x104', '\a', '>', '\x2', '\x2', '\x104', '\x105', '\a', '/', 
		'\x2', '\x2', '\x105', 'H', '\x3', '\x2', '\x2', '\x2', '\x106', '\x107', 
		'\a', '?', '\x2', '\x2', '\x107', 'J', '\x3', '\x2', '\x2', '\x2', '\x108', 
		'\x111', '\a', '\x32', '\x2', '\x2', '\x109', '\x10D', '\t', '\x2', '\x2', 
		'\x2', '\x10A', '\x10C', '\x5', 'Y', '-', '\x2', '\x10B', '\x10A', '\x3', 
		'\x2', '\x2', '\x2', '\x10C', '\x10F', '\x3', '\x2', '\x2', '\x2', '\x10D', 
		'\x10B', '\x3', '\x2', '\x2', '\x2', '\x10D', '\x10E', '\x3', '\x2', '\x2', 
		'\x2', '\x10E', '\x111', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x10D', 
		'\x3', '\x2', '\x2', '\x2', '\x110', '\x108', '\x3', '\x2', '\x2', '\x2', 
		'\x110', '\x109', '\x3', '\x2', '\x2', '\x2', '\x111', 'L', '\x3', '\x2', 
		'\x2', '\x2', '\x112', '\x114', '\x5', 'Y', '-', '\x2', '\x113', '\x112', 
		'\x3', '\x2', '\x2', '\x2', '\x114', '\x115', '\x3', '\x2', '\x2', '\x2', 
		'\x115', '\x113', '\x3', '\x2', '\x2', '\x2', '\x115', '\x116', '\x3', 
		'\x2', '\x2', '\x2', '\x116', '\x117', '\x3', '\x2', '\x2', '\x2', '\x117', 
		'\x11B', '\a', '\x30', '\x2', '\x2', '\x118', '\x11A', '\x5', 'Y', '-', 
		'\x2', '\x119', '\x118', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x11D', 
		'\x3', '\x2', '\x2', '\x2', '\x11B', '\x119', '\x3', '\x2', '\x2', '\x2', 
		'\x11B', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x11C', '\x125', '\x3', 
		'\x2', '\x2', '\x2', '\x11D', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\x120', '\a', '\x30', '\x2', '\x2', '\x11F', '\x121', '\x5', 'Y', '-', 
		'\x2', '\x120', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x121', '\x122', 
		'\x3', '\x2', '\x2', '\x2', '\x122', '\x120', '\x3', '\x2', '\x2', '\x2', 
		'\x122', '\x123', '\x3', '\x2', '\x2', '\x2', '\x123', '\x125', '\x3', 
		'\x2', '\x2', '\x2', '\x124', '\x113', '\x3', '\x2', '\x2', '\x2', '\x124', 
		'\x11E', '\x3', '\x2', '\x2', '\x2', '\x125', 'N', '\x3', '\x2', '\x2', 
		'\x2', '\x126', '\x12B', '\a', '$', '\x2', '\x2', '\x127', '\x12A', '\x5', 
		'U', '+', '\x2', '\x128', '\x12A', '\v', '\x2', '\x2', '\x2', '\x129', 
		'\x127', '\x3', '\x2', '\x2', '\x2', '\x129', '\x128', '\x3', '\x2', '\x2', 
		'\x2', '\x12A', '\x12D', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12C', 
		'\x3', '\x2', '\x2', '\x2', '\x12B', '\x129', '\x3', '\x2', '\x2', '\x2', 
		'\x12C', '\x12E', '\x3', '\x2', '\x2', '\x2', '\x12D', '\x12B', '\x3', 
		'\x2', '\x2', '\x2', '\x12E', '\x12F', '\a', '$', '\x2', '\x2', '\x12F', 
		'P', '\x3', '\x2', '\x2', '\x2', '\x130', '\x133', '\a', '\x61', '\x2', 
		'\x2', '\x131', '\x133', '\x5', 'W', ',', '\x2', '\x132', '\x130', '\x3', 
		'\x2', '\x2', '\x2', '\x132', '\x131', '\x3', '\x2', '\x2', '\x2', '\x133', 
		'\x139', '\x3', '\x2', '\x2', '\x2', '\x134', '\x138', '\a', '\x61', '\x2', 
		'\x2', '\x135', '\x138', '\x5', 'W', ',', '\x2', '\x136', '\x138', '\x5', 
		'Y', '-', '\x2', '\x137', '\x134', '\x3', '\x2', '\x2', '\x2', '\x137', 
		'\x135', '\x3', '\x2', '\x2', '\x2', '\x137', '\x136', '\x3', '\x2', '\x2', 
		'\x2', '\x138', '\x13B', '\x3', '\x2', '\x2', '\x2', '\x139', '\x137', 
		'\x3', '\x2', '\x2', '\x2', '\x139', '\x13A', '\x3', '\x2', '\x2', '\x2', 
		'\x13A', 'R', '\x3', '\x2', '\x2', '\x2', '\x13B', '\x139', '\x3', '\x2', 
		'\x2', '\x2', '\x13C', '\x13E', '\a', '\xF', '\x2', '\x2', '\x13D', '\x13C', 
		'\x3', '\x2', '\x2', '\x2', '\x13D', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'\x13E', '\x13F', '\x3', '\x2', '\x2', '\x2', '\x13F', '\x140', '\a', 
		'\f', '\x2', '\x2', '\x140', 'T', '\x3', '\x2', '\x2', '\x2', '\x141', 
		'\x142', '\a', '^', '\x2', '\x2', '\x142', '\x143', '\t', '\x3', '\x2', 
		'\x2', '\x143', 'V', '\x3', '\x2', '\x2', '\x2', '\x144', '\x145', '\t', 
		'\x4', '\x2', '\x2', '\x145', 'X', '\x3', '\x2', '\x2', '\x2', '\x146', 
		'\x147', '\t', '\x5', '\x2', '\x2', '\x147', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x148', '\x149', '\a', '\x31', '\x2', '\x2', '\x149', '\x14A', 
		'\a', '\x31', '\x2', '\x2', '\x14A', '\x14E', '\x3', '\x2', '\x2', '\x2', 
		'\x14B', '\x14D', '\v', '\x2', '\x2', '\x2', '\x14C', '\x14B', '\x3', 
		'\x2', '\x2', '\x2', '\x14D', '\x150', '\x3', '\x2', '\x2', '\x2', '\x14E', 
		'\x14F', '\x3', '\x2', '\x2', '\x2', '\x14E', '\x14C', '\x3', '\x2', '\x2', 
		'\x2', '\x14F', '\x151', '\x3', '\x2', '\x2', '\x2', '\x150', '\x14E', 
		'\x3', '\x2', '\x2', '\x2', '\x151', '\x152', '\a', '\f', '\x2', '\x2', 
		'\x152', '\x153', '\x3', '\x2', '\x2', '\x2', '\x153', '\x154', '\b', 
		'.', '\x2', '\x2', '\x154', '\\', '\x3', '\x2', '\x2', '\x2', '\x155', 
		'\x156', '\a', '\x31', '\x2', '\x2', '\x156', '\x157', '\a', ',', '\x2', 
		'\x2', '\x157', '\x15B', '\x3', '\x2', '\x2', '\x2', '\x158', '\x15A', 
		'\v', '\x2', '\x2', '\x2', '\x159', '\x158', '\x3', '\x2', '\x2', '\x2', 
		'\x15A', '\x15D', '\x3', '\x2', '\x2', '\x2', '\x15B', '\x15C', '\x3', 
		'\x2', '\x2', '\x2', '\x15B', '\x159', '\x3', '\x2', '\x2', '\x2', '\x15C', 
		'\x15E', '\x3', '\x2', '\x2', '\x2', '\x15D', '\x15B', '\x3', '\x2', '\x2', 
		'\x2', '\x15E', '\x15F', '\a', ',', '\x2', '\x2', '\x15F', '\x160', '\a', 
		'\x31', '\x2', '\x2', '\x160', '\x161', '\x3', '\x2', '\x2', '\x2', '\x161', 
		'\x162', '\b', '/', '\x2', '\x2', '\x162', '^', '\x3', '\x2', '\x2', '\x2', 
		'\x163', '\x168', '\t', '\x6', '\x2', '\x2', '\x164', '\x165', '\a', '\xF', 
		'\x2', '\x2', '\x165', '\x168', '\a', '\f', '\x2', '\x2', '\x166', '\x168', 
		'\a', '\f', '\x2', '\x2', '\x167', '\x163', '\x3', '\x2', '\x2', '\x2', 
		'\x167', '\x164', '\x3', '\x2', '\x2', '\x2', '\x167', '\x166', '\x3', 
		'\x2', '\x2', '\x2', '\x168', '\x169', '\x3', '\x2', '\x2', '\x2', '\x169', 
		'\x16A', '\b', '\x30', '\x2', '\x2', '\x16A', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x2', '\x10D', '\x110', '\x115', '\x11B', '\x122', '\x124', 
		'\x129', '\x12B', '\x132', '\x137', '\x139', '\x13D', '\x14E', '\x15B', 
		'\x167', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AntlrGenerated
