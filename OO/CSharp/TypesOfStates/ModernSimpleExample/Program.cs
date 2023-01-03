using ModernSimpleExample.Classes;

var cell = new Cellphone();
cell.ActualStatusCellphone = EStatusCellphone.Online;

CellphoneHandler.ExecuteTransition(cell, ETriggerCellphone.ReceiveCall);