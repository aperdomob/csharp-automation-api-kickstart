//-----------------------------------------------------------------------
// <copyright file="Arguments.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Rest
{
  using System;
  using System.Collections.Generic;
  using RestSharp;

  internal class Arguments
  {
    public Arguments()
    {
      this.Headers = new Dictionary<string, string>();
    }

    public string Url { get; set; }

    public string Method { get; set; }

    public Dictionary<string, string> Headers { get; set; }

    public Method GetMethod()
    {
      if (this.Method.Equals("GET"))
      {
        return RestSharp.Method.GET;
      }

      throw new NotImplementedException();
    }

    public void AddHeader(string key, string value)
    {
      this.Headers.Add(key, value);
    }
  }
}
