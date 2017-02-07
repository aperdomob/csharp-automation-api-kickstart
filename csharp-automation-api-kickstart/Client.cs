//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart
{
  using System;
  using Namespace;

  internal sealed class Client
  {
    private static readonly Lazy<Client> Lazy = new Lazy<Client>(() => new Client());

    private Client()
    {
      this.Country = new CountryNamespace();
    }

    public static Client Session
    {
      get
      {
        return Lazy.Value;
      }
    }

    public CountryNamespace Country { get; }
  }
}
