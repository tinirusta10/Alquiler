using System.Text.Json;

namespace Alquiler.Client.Servicios
{
    //public class HttpService
    //{
        //private readonly HttpClient http;

        //public HttpService(HttpClient http)
        //{
          //  this.http = http;
        //}

        //public async Task<Httprespuesta<T>> Get<T>(string url)
        //{
            //var response = await http.GetAsync(url);
            //if (response.IsSuccessStatusCode)
            //{
                //var respuesta = await deserealizarRespuesta<T>(response);
              //  return new Httprespuesta<T>(respuesta, false, response);
            //}
            //else
            //{

          //  }
        //}

        //private async Task<T> deserealizarRespuesta<T>(HttpResponseMessage response)
       // {
            //var respuestaStr = await response.Content.ReadAsStringAsync();
          //  return JsonSerializer.Deserialize<T>(respuestaStr,
        //        new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
      //  }
  //  }
}
