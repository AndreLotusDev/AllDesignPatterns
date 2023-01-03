using System.Text;

namespace SimpleBuilder.Classes;

public class Email
{
    public string To { get; set; }
    public string From { get; set; }
    public string Body { get; set; }
    public List<string> Attachment { get; set; } = new List<string>();

    public override string ToString()
    {
        var attachment = String.Concat(Attachment.Select(s => " - " + s ).ToArray());
        
        return $"To {To} | From {From} | Attachments {attachment} | Body {Body}";
    }

    public static string LoremIpsum(int minWords, int maxWords,
        int minSentences, int maxSentences,
        int numParagraphs) {

        var words = new[]{"lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
            "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
            "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"};

        var rand = new Random();
        int numSentences = rand.Next(maxSentences - minSentences)
                           + minSentences + 1;
        int numWords = rand.Next(maxWords - minWords) + minWords + 1;

        StringBuilder result = new StringBuilder();

        for(int p = 0; p < numParagraphs; p++) {
            result.Append("<p>");
            for(int s = 0; s < numSentences; s++) {
                for(int w = 0; w < numWords; w++) {
                    if (w > 0) { result.Append(" "); }
                    result.Append(words[rand.Next(words.Length)]);
                }
                result.Append(". ");
            }
            result.Append("</p>");
        }

        return result.ToString();
    }
}

