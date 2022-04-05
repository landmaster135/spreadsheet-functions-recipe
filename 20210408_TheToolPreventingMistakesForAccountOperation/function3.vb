=IF(AM3<>"",IF(COUNTIF(AM3,"*（消○○○○○○ター）*")+COUNTIF(AM3,"*（消○○○○○○○○（○○GWAN経○○））*")>0,AF3="",IF(COUNTIF(AM3,"*99996*")+COUNTIF(AM3,"*99997*")+COUNTIF(AM3,"*99998*")>0,AF3<>"",AF3=AI3)),"")
