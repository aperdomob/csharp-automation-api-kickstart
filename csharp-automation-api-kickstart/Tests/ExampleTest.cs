//-----------------------------------------------------------------------
// <copyright file="ExampleTest.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Tests
{
  using System.Collections.Generic;
  using Entities;
  using NUnit.Framework;
  using Rest;

  [TestFixture]
  public class ExampleTest
  {
    [Test]
    public void GetAllCountries()
    {
      Client client = Client.Session;

      Response<List<Country>> response = client.Country.All;

      Assert.AreEqual(250, response.Body.Count);
      Assert.AreEqual(200, response.Status);
      Assert.AreEqual("OK", response.StatusDescription);
    }
  }
}
