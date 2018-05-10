\ old (obsolete) version - delete after archiving

: 3dup 2 pick 2 pick 2 pick ;

: savestring ( addr1 u -- addr2 u )
    dup allocate throw swap 3dup move rot drop ;

: node ( "name" -- addr )
    ( todo: check if name exists and is a node )
    parse-name savestring
    2dup nextname create here rot , swap , ;
    \ does> ;

: getname ( addr -- )
    dup @ swap cell + @ ;

: triple { subject predicate object -- addr }
    ( todo: put in searchable collection )
    here subject , predicate , 0 , object , ;

