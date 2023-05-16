\ A convenient memory dump helper

\  : u.4 ( u -- ) 0 <# # # # # #> type ;
\  : u.2 ( u -- ) 0 <# # # #> type ;

: dump16 ( addr -- ) \ Print 16 bytes memory
  base @ >r hex
  $F bic
  dup hex. ." :  "

  dup 16 + over do
    i c@ u.2 space \ Print data with 2 digits
    i $F and 7 = if 2 spaces then
  loop

  ."  | "

  dup 16 + swap do
        i c@ 32 u>= i c@ 127 u< and if i c@ emit else [char] . emit then
        i $F and 7 = if 2 spaces then
      loop

  ."  |" cr
  r> base !
;

: dump ( addr len -- ) \ Print a memory region
  cr
  over 15 and if 16 + then \ One more line if not aligned on 16
  begin
    swap ( len addr )
    dup dump16
    16 + ( len addr+16 )
    swap 16 - ( addr+16 len-16 )
    dup 0<
  until
  2drop
;

10 variable wordsNcols

: wordsN ( cols -- ) cr  \ A columnar Word list printer. Width = 20 characters, handles overlength Words neatly
   0                                \ column counter
   dictionarystart
      begin
         dup 6 + dup
         ctype                      \ dup before 6 is for dictionarynext input
         count nip                  \ get number of characters in the word and drop the address of the word
             20 swap - dup 0 > if   \ if Word is less than 20 chars
                   spaces swap      \ pad with spaces to equal 20 chars
                   else drop cr     \ issue immediate carriage return and drop negative number
                   nip -1           \ and reset to column -1
                   then
                      dup wordsNcols @ 1- = if wordsNcols @ 1- - cr \ if at 4th column, zero column counter
                      else 1 +
                      then
         swap
         dictionarynext             \   ( a-addr - - a-addr flag )
      until
   2drop
;

: cls ( -- )
  65
  begin
  cr
  1- dup
  0= until
;

: clear-stack begin . depth 0= until ;

: fill-words ( addr nwords value --   )
    begin
        dup     ( addr nwords value value )
        3 pick  ( addr nwords value value addr )
        !       ( addr nwords   value   )
        \ cr ." fill @" 2 pick hex.
        swap    ( addr value    nwords  )
        1- swap ( addr nwords-1 value   )
        rot     ( nwords-1 value addr   )
        4 +     ( nwords-1 value addr+4 )
        -rot    ( addr+4 nwords-1 value )
        over    ( addr+4 nwords-1 value nwords-1 )
    0= until    ( addr+4 nwords-1 value )
    drop
    drop
    drop ( -- )
;

