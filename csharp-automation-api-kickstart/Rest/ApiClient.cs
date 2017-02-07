//-----------------------------------------------------------------------
// <copyright file="ApiClient.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Rest
{
  using System.Linq;
  using RestSharp;

  internal class ApiClient
  {
    public static Response<T> Send<T>(Arguments arguments)
    {
      RestClient client = new RestClient(arguments.Url);
      RestRequest request = new RestRequest(arguments.GetMethod());

      for (int index = 0; index < arguments.Headers.Count; index++)
      {
        request.AddHeader(arguments.Headers.Keys.ElementAt(index), arguments.Headers.Values.ElementAt(index));
      }

      IRestResponse response = client.Execute(request);
      return Response<T>.Create(response);
    }
  }
}
