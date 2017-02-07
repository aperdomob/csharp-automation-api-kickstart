//-----------------------------------------------------------------------
// <copyright file="CountryNamespace.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Namespace
{
  using System.Collections.Generic;
  using Entities;
  using Rest;
  using Service;

  internal class CountryNamespace
  {
    public Response<List<Country>> All
    {
      get
      {
        return CountryService.GetAll();
      }
    }
  }
}
