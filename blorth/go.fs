: empty 	s" ---marker--- marker ---marker---" evaluate ;
( marker is a defining work whos purpose is to checkpoint a current state of the dictionary )
: edit 		s" vim blorth.fs" system ;
: run		s" blorth.fs" included ;
: ecr 		edit run ;

( <-- empty execute restores dictionary here )
marker ---marker---
