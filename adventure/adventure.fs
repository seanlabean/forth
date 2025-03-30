: PATH1 121 = IF ." Adventuring is fun. " cr  THEN ;

: INTRO 97 = IF ." good choice. " cr ." I take it you're on an adventure? (y/n) " cr KEY PATH1 THEN ." see you " .s ;

." Press (a) if you want to live. " cr  KEY INTRO bye
