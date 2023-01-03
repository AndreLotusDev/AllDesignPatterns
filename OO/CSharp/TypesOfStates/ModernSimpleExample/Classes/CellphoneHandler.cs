namespace ModernSimpleExample.Classes
{
    public class CellphoneHandler
    {
        private static Dictionary<EStatusCellphone, List<(ETriggerCellphone, EStatusCellphone)>> Rules { get; } = new()
        {
            [EStatusCellphone.Offline] = new()
            {
                (ETriggerCellphone.TurnOn, EStatusCellphone.Online)
            },
            [EStatusCellphone.Online] = new()
            {
                (ETriggerCellphone.TurnOf, EStatusCellphone.Offline),
                (ETriggerCellphone.ReceiveCall, EStatusCellphone.Talking)
            },
            [EStatusCellphone.Talking] = new()
            {
                (ETriggerCellphone.TurnOf, EStatusCellphone.Offline),
                (ETriggerCellphone.ShutDownCall, EStatusCellphone.Online)
            }
        };

        public static void ExecuteTransition(Cellphone cell, ETriggerCellphone trigger)
        {
            var actualRuleToBeApplied = Rules[cell.ActualStatusCellphone];
            var found = actualRuleToBeApplied.FirstOrDefault(a => a.Item1 == trigger);

            if (found.Item1 != null && found.Item2 != null)
            {
                Console.WriteLine("is possible to change");
                Console.WriteLine($"Actual status is: {cell.ActualStatusCellphone}");
                cell.ActualStatusCellphone = found.Item2;
                Console.WriteLine($"New status is: {cell.ActualStatusCellphone}");
            }
            else
            {
                Console.WriteLine("Is not possible to perform this trigger now");

                var message =
                    actualRuleToBeApplied.Select(s => $"{s.Item1.ToString()} trigger changes to status: {s.Item2}");

                var formattedMessage = string.Join(" ", message);

                Console.WriteLine($"The possible changes are: {formattedMessage}");
            }
        }
    }
}
