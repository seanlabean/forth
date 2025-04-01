( blorth - custom text to html parser )
( Credit: Sean C. Lewis 2025, Samual A Falvo II 2008 )
( CC Share Alike: https://creativecommons.org/licenses/by-sa/4.0/deed.en )

( configuration )
: srcfile	s" a.bth" ;

( input buffer )
variable 'src
variable #src

: start     here 'src ! ;
: finish    here 'src @ - #src ! ;
: slurp     start 100 allot finish ;
