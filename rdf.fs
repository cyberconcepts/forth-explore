

: node ( "name" -- addr )
    \ todo: check if name exists (use 'defined') - and is a node?
    \ todo: store namespace instead of 0
    here { namep }  \ remember name address
    0 , 0 ,         \ alloc and initialize node
    parse-name 2dup namep $!        \ get name, store name address in node
    nextname create here namep , ;  \ create and set variable, keep address
    \ does> ;

: getname ( addr1 -- addr2 u )
    @ $@ ;

: triple { subject predicate object -- addr }
    ( todo: put in searchable collection )
    here subject , predicate , 0 , object , ;
