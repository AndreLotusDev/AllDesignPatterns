using HouseCommands.cs.Classes;

var lampRoom = new SmartLight("lamp room");
var turnOnOffLampRoomCommand = new SmartLightOnOffCommand(lampRoom);

var lampBathroom = new SmartLight("lamp bathroom");
var turnOnOffLampBathroomCommand = new SmartLightOnOffCommand(lampBathroom);
var increaseDecreaseLampBathroomCommand = new SmartLightIntensityCommand(lampBathroom);

var controller = new SmartLightDictionaryController();
controller.ConfigureCommandPerLight(lampBathroom.Name, new List<CommandBase>() { turnOnOffLampBathroomCommand, increaseDecreaseLampBathroomCommand });
controller.ConfigureCommandPerLight(lampRoom.Name, new List<CommandBase>() { turnOnOffLampRoomCommand });
controller.ExecuteAll(lampBathroom.Name);
controller.ExecuteAll(lampRoom.Name);
controller.UndoAll(lampBathroom.Name);
controller.UndoAll(lampRoom.Name);

