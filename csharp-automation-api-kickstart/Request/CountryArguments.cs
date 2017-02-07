//-----------------------------------------------------------------------
// <copyright file="CountryArguments.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Request
{
  using Rest;

  internal class CountryArguments
  {
    public static Arguments GetAllCountries()
    {
      return new Arguments
      {
        Url = "https://restcountries.eu/rest/v1/all",
        Method = "GET"
      };
    }
  }
}
