grammar Gramatica;

options {							
    language=CSharp2;								
}

/*
 * Parser Rules
 */

prog:
	start|propositions|end
;

start:
	label START NUM ENDL|proposition
;

end:
	END input ENDL|END input
;

input:
	LABEL?
;

propositions:
	propositions proposition|proposition
;

proposition:
	instruction|directive
;

instruction:
	label INSTR instr_args ENDL
;

directive:
	label DIRECTIVE directive_args ENDL
;

label:
	LABEL?
;

instr_args:
	LABEL', X'|LABEL',X'|LABEL?
;

directive_args:
	NUM|'X\'' NUM '\''|'C\'' LABEL '\''
;

compileUnit
	:	EOF
	;

/*
 * Lexer Rules
 */

INSTR:		'ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'
			|'MUL'|'OR'|'RD'|'RSUB'|'STA'|'STCH'
			|'STL'|'STSW'|'STX'|'SUB'|'TD'|'TIX'|'WD';
DIRECTIVE:	'BYTE'|'WORD'|'RESB'|'RESW';
START:		'START';
END:		'END';
LABEL:		[A-Z]+;
NUM:		NUM_CHAR+('h'|'H')?;
NUM_CHAR:	[a-f]|[A-F]|[0-9];
EMPTY:		' ';
ENDL:		'\n';			//final de la expresion.
WS:			(' '|'\r'|'\n'|'\t') -> channel(HIDDEN);	//tokens que identifican las secuencias de escape.