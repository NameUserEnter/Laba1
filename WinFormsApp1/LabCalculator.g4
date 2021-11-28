grammar LabCalculator;


/*
 * Parser Rules
 */

compileUnit : expression EOF;

expression :
  LPAREN expression RPAREN #ParenthesizedExpr
  |expression EXPONENT expression #ExponentialExpr
    | expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
  | expression UNARYPLUS expression #UnaryPExpr
  | expression UNARYMINUS expression #UnaryMExpr
  | expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
  | operatorToken=(MMAX | MMIN) LPAREN expression (COMA expression)* RPAREN #MmaxMminExpr
  | operatorToken=(MAX | MIN) LPAREN expression COMA expression RPAREN #MaxMinExpr
  | NUMBER #NumberExpr
  | IDENTIFIER #IdentifierExpr
  ; 
/*
 * Lexer Rules
 */

NUMBER : INT ('.' INT)?; 
IDENTIFIER : [a-zA-Z]+ ('1'..'9')+;

INT : ('0'..'9')+;

MOD: 'mod';
DIV: 'div';
COMA: ',';
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';
MAX : 'MAX';
MIN : 'MIN';
MMAX : 'MMAX';
MMIN : 'MMIN';
UNARYPLUS : '++';
UNARYMINUS : '--';

WS : [ \t\r\n] -> channel(HIDDEN);