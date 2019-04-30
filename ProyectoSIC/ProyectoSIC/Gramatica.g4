grammar Gramatica;

options {							
    language=CSharp2;								
}

/*
 * Parser Rules
 */
 
/* llamada del programa principal, se compone de la sentencia de inicio, un numero de proposiciones y la linea final */
prog:  
	start|propositions|end
;

 /* estructura basica de una sentencia*/
start:
	label START NUM ENDL|proposition
;

/* Indica la oracion final que se tiene que escribir */
end:
	END input ENDL|END input
;

/* Define si la directiva de END tiene una etiqueta o no*/
input:
	LABEL?
;

/* Estructura de una instrucción en general */
propositions:
	propositions proposition|proposition
;

/* Estructura de una instrución o una directiva*/
proposition:
	instruction|directive
;

/* Estructura de una instrucción. En los argumentos puede
	llevar una etiqueta direccionada o indexada */
instruction:
	label INSTR instr_args ENDL
;

/* Estructura de la directiva*/
directive:
	label DIRECTIVE directive_args ENDL
;

/*Define si existe o no la etiqueta para una instruccion*/
label:
	LABEL?
;

/* Estructura de una etiqueta, que puede ser direccionada o indexada, o no tenerla */
instr_args:
	LABEL', X'|LABEL',X'|LABEL?
;

/* Estructura del argumento para una directiva: indica si es hexadecimal o cadena*/
directive_args:
	NUM|'X\''NUM'\''|'C\''LABEL'\''
;

compileUnit
	:	EOF
	;

/*
 * Lexer Rules
 */


/* Palabras reservadas para los codigos de operación */
INSTR:		'ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'
			|'MUL'|'OR'|'RD'|'RSUB'|'STA'|'STCH'
			|'STL'|'STSW'|'STX'|'SUB'|'TD'|'TIX'|'WD';
/* Palabras reservadas para las directivas */
DIRECTIVE:	'BYTE'|'WORD'|'RESB'|'RESW';

/* Palabra resrvada para start y end */
START:		'START';
END:		'END';

/* Define una etiqueta de por lo menos un caracter */
LABEL:		[A-Z]+[0-9]*|[a-zA-Z]+[0-9]*;

/* Define un numero hexdecimal */
NUM:		NUM_CHAR+('h'|'H')?;
NUM_CHAR:	[a-f]|[A-F]|[0-9];

/* Define una linea vacia y saltos de linea*/
EMPTY:		' ';
ENDL:		'\n';			//final de la expresion.
WS:			(' '|'\r'|'\n'|'\t') -> channel(HIDDEN);	//tokens que identifican las secuencias de escape.