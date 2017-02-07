//-----------------------------------------------------------------------
// <copyright file="Response.cs" company="AgileTestingColombia">
//     Copyleft (c) AgileTestingColombia. Free used.
// </copyright>
//-----------------------------------------------------------------------

namespace CsharpAutomationApiKickstart.Rest
{
  using Newtonsoft.Json;
  using RestSharp;

  internal class Response<T>
  {
    public T Body { get; set; }

    public int Status { get; set; }

    public string StatusDescription { get; set; }

    public static Response<T> Create(IRestResponse response)
    {
      T entity = JsonConvert.DeserializeObject<T>(response.Content);

      return new Response<T>
      {
        Body = entity,
        Status = (int)response.StatusCode,
        StatusDescription = response.StatusDescription
      };
    }
  }
}
