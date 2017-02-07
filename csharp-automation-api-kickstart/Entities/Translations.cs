//-----------------------------------------------------------------------
// <copyright file="Translations.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Entities
{
  using Newtonsoft.Json;

  internal class Translations
  {
    [JsonProperty("de")]
    public string De { get; set; }

    [JsonProperty("es")]
    public string Es { get; set; }

    [JsonProperty("fr")]
    public string Fr { get; set; }

    [JsonProperty("ja")]
    public string Ja { get; set; }

    [JsonProperty("it")]
    public string It { get; set; }
  }
}
