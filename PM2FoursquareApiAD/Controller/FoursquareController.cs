using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Xamarin.Forms;
using System.IO;

namespace PM2FoursquareApiAD.Controller
{
    public class FoursquareController
    {
        public FoursquareController()
        {}

        public async static Task<List<Models.ApiFoursquare.Venue>> getListSite(Double latitud, Double longitud)
        {

            List<Models.ApiFoursquare.Venue> sitioscerca = new List<Models.ApiFoursquare.Venue>();

            using (HttpClient cliente = new HttpClient())
            {
                var respuesta = await cliente.GetAsync(Controller.Configuraciones.Sitios.getUrl(latitud, longitud));

                if (respuesta.IsSuccessStatusCode)
                {
                    var contenido = respuesta.Content.ReadAsStringAsync().Result;

                    var lugares = JsonConvert.DeserializeObject<Models.ApiFoursquare.VenuesRest>(contenido);

                    foreach (var item in lugares.response.venues)
                    {
                        var distancia = item.location.distance;

                        if(distancia < 100)
                            sitioscerca.Add(new Models.ApiFoursquare.Venue(
                                item.id, item.name, item.contact, item.location, item.canonicalUrl,
                                item.canonicalPath, item.categories, item.verified, item.stats, item.beenHere, item.specials,
                                item.hereNow, item.referralId, item.venueChains, item.hasPerk, item.allowMenuUrlEdit, item.venueRatingBlacklisted)
                            );
                    }

                    //sitioscerca = lugares.response.venues as List<Models.ApiFoursquare.Venue>;
                }
            }
            return sitioscerca;
        }
    }
}
