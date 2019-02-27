grammar Combined1;

/*
*opciones de compilacion de la gramatica
*/

options {							
    language=CSharp2;								
}

/*
 * Parser Rules
 */

stat returns[int value]:							//la expresion retornara un valor entero al programa.
	c = exp NEWLINE	{ 
		System.Console.Write($c.value); }	//Se imprime el valor adquirido.
	|NEWLINE				//no se hace nada.
;			

exp returns[int value]:						//El valor calculado por la expresion sera regresado como un entero.

	a = exp2{$value = $a.value;} (		//Se asina el valor que se retornara en la regla.
		ADD b = exp2 { $value = $value + $b.value; }				//El valor se suma con el actual en la expresion.
		|SUB b = exp2 { $value = $value - $b.value; }
	)*{System.Console.WriteLine($value);}	
;
	
exp2 returns[int value]:					//La regla retorna un entero.	
	a = num { $value = $a.value; } (				//Se asigna el valor que se regresara.
		MUL b = num {	$value = $value * $b.value; }		
		|
		DIV b = num {	if($b.value != 0){
							$value = $value / $b.value;
						}
						else{
							System.Console.WriteLine("Error: division entre ");
							$value = 0;
						}
					}
	)*
;
			
num returns[int value]:							
	INT	{ $value = int.Parse($INT.text); }			
|	PARENI exp PAREND	{ $value = $exp.value; }		
;

compileUnit
	:	EOF
	;

/*
 * Lexer Rules
 */

PARENI:		'(';			//parentesis derecho
PAREND:		')';			//parentesis izquierdo.
ADD:		'+';			//signo mas
SUB:		'-';			//signo menos
MUL:		'*';			//signo por
INT:		('0'..'9')+|SUB('0'..'9')+;	//numeros
DIV:		'/';			//signo entre
NEWLINE:	'\n';			//final de la expresion.
WS:			(' '|'\r'|'\n'|'\t') -> channel(HIDDEN);	//tokens que identifican las secuencas de escape.
