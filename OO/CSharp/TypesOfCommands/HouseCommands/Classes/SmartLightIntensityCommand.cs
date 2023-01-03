namespace HouseCommands.cs.Classes
{
    internal class SmartLightIntensityCommand : CommandBase
    {
        private readonly SmartLight _bulb;

        public SmartLightIntensityCommand(SmartLight bulb)
        {
            _bulb = bulb;
        }

        public override void Execute()
        {
            _bulb.IncreaseIntensity();

            base.Execute();
        }

        public override void Undo()
        {
            _bulb.DecreaseIntensity();

            base.Undo();
        }
    }
}
