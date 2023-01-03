namespace HouseCommands.cs.Classes
{
    public class SmartLightOnOffCommand : CommandBase
    {
        private readonly SmartLight _bulb;

        public SmartLightOnOffCommand(SmartLight bulb)
        {
            _bulb = bulb;
        }
        public override void Execute()
        {
            _bulb.TurnOn();

            base.Execute();
        }

        public override void Undo()
        {
            _bulb.TurnOff();

            base.Undo();
        }
    }
}
