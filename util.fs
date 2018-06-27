\ *
\ * forth utilities
\ *

: untuck ( x3 x1 x2 -- x1 x2 ) rot drop ;

: 2untuck_ ( x3 y3 x1 y1 x2 y2 -- x1 y1 x2 y2 ) 2rot 2drop ;

: 2untuck { x3 y3 x1 y1 x2 y2 -- x1 y1 x2 y2 }
    x1 y1 x2 y2 ;

: less ( n1 n2 -- n ) 2dup > if swap then drop ;

: more ( n1 n2 -- n ) 2dup < if swap then drop ;

: clst begin depth 0> while drop repeat ;

: fillstack { n -- 1 2 ... n }
    1 begin dup n <= while dup 1+ repeat drop ;


\ factorial

: facstep ( n1 n2 -- n3 n4 ) 1 + dup rot * swap ;

: fact { n -- n1 }
    1 1 begin dup n < while facstep repeat drop ;
