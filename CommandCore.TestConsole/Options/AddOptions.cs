using CommandCore.Library.Attributes;
using CommandCore.Library.PublicBase;

namespace CommandCore.TestConsole.Options
{
    public class AddOptions : VerbOptionsBase
    {
        [OptionName("firstname", Description = "First name of the person provided.")]
        [OptionName("fn", Description = "First name of the person provided.")]
        public string? FirstName { get; set; }

        [OptionName("lastname", Description = "Last name of the person provided.")]
        public string? LastName { get; set; }

        [OptionName("haslicense", Alias = "hs", Description = "Indicates whether the person has a driver license")]
        public bool? HasLicense { get; set; }

        [OptionName("age", Alias = "a")]
        [OptionName("old", Alias = "o")]
        public int Age { get; set; }
    }
}