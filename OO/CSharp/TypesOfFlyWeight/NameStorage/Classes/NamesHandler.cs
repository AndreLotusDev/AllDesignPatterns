using System.Linq;
using static NameStorage.Classes.NamesGenerator;

namespace NameStorage.Classes
{
    public class NamesHandler
    {
        public Dictionary<string, List<int>> SameNamesPositions { get; private set; } = new();
        public Dictionary<string, string> names { get; private set; } = new();
        private int actualPosition = 0;

        public NamesHandler()
        {
            
        }

        public void GenerateName()
        {
            var tempName = Generate(5);

            var foundNameInDictionary = names.TryGetValue(tempName, out var _);

            if (foundNameInDictionary is false)
            {
                names.Add(tempName, tempName);
            }

            if (foundNameInDictionary is true)
            {
                var foundNameInPositionDictionary = SameNamesPositions.TryGetValue(tempName, out var _);

                if (foundNameInPositionDictionary)
                {
                    SameNamesPositions[tempName].Add(actualPosition);
                }

                if (foundNameInPositionDictionary is false)
                {
                    SameNamesPositions.Add(tempName, new List<int>() {actualPosition});
                }
            }

            actualPosition++;
        }

        public void ShowRepeatedNames()
        {
            foreach (var sameNamesPosition in SameNamesPositions)
            {
                Console.WriteLine($"This name was found repeated {sameNamesPosition.Key}, {sameNamesPosition.Value.Count} times");
            }
        }
    }
}
