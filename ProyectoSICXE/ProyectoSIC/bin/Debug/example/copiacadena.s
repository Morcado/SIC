COPIAC	START	28H
	LDX	ZERO
MOVECH	LDCH	STR1,X
	STCH	STR2,X
	TIX	TAM
	JLT	MOVECH
STR1	BYTE	C'Probando2015'
STR2	RESB	11
ZERO	WORD	0
TAM	WORD	12
	END
