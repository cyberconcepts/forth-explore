\ *
\ * interaction with foreign caller via stdin/stdout
\ *

2050 constant xi_bufsize
xi_bufsize 2 - constant xi_stringsize

create xi_buffer xi_bufsize allot

: repl
    begin
        xi_buffer dup xi_stringsize stdin read-line 
        throw   \ return code
        while   \ not-eof
        evaluate
    repeat
    bye
    ;
