SINTAX	START	2020H
FIRST	LDX	ZERO
	BYTE	C'PRUEBA'
	LDA	ZERO
LOOP	ADD	TABLE,X
	TIX	COUNT
	JLT	LOOP
	STA	TOTAL,X
	RSUB
TABLE	RESW	10
VALOR	BYTE	X'23C'
COUNT	RESW	1
ZERO	WORD	10
TOTAL	RESW	2
	END
