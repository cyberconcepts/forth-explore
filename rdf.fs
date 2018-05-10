

: node ( "name" -- addr )
    ( todo: check if name exists and is a node )
    ( todo: store namespace instead of 0 )
    parse-name here dup { addr }
    0 , 0 , $!
    addr dup $@ nextname create here swap , ;
    \ does> ;

: getname ( addr1 -- addr2 u )
    @ $@ ;

: triple { subject predicate object -- addr }
    ( todo: put in searchable collection )
    here subject , predicate , 0 , object , ;
