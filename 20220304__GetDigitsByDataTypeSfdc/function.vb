=IF(LEFT(F2,4)="テキスト",IFERROR(MID(F2,FIND("(",F2)+1,FIND(")",F2)-FIND("(",F2)-1),10),IF(LEFT(F2,4)="日付",10,IF(LEFT(F2,2)="数値",LEFT(MID(F2,FIND("(",F2)+1,FIND(")",F2)-FIND("(",F2)-1),1)+RIGHT(MID(F2,FIND("(",F2)+1,FIND(")",F2)-FIND("(",F2)-1),1)+1,FALSE)))