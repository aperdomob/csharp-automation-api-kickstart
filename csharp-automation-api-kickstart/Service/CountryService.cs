//-----------------------------------------------------------------------
// <copyright file="CountryService.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Service
{
  using System.Collections.Generic;
  using Entities;
  using Request;
  using Rest;

  internal class CountryService
  {
    public static Response<List<Country>> GetAll()
    {
      Arguments arguments = CountryArguments.GetAllCountries();
      return ApiClient.Send<List<Country>>(arguments);
    }
  }
}
