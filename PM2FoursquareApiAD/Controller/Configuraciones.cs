using System;
namespace PM2FoursquareApiAD.Controller
{
    public class Configuraciones
    {
        public Configuraciones()
        {
        }

        public const String IDFoursquare = "LW5FZWEP25BKT1TB3PPWFPGDV5ZX3KWJYBYEZ5TWX5C2CQDR";
        public const String SecretFoursquare = "4FLDQQF3RKHDWGLQHOFWVZIM3VLR0CCWNL2RY240KIJH0LHG";
        public const String EndPointFoursquare = "https://api.foursquare.com/v2/venues/search?ll={0},{1}&client_id={2}&client_secret={3}&v={4}";

        public class Sitios
        {
            public static String getUrl(Double lat, Double lng)
            {
                return String.Format(Configuraciones.EndPointFoursquare, lat, lng,
                    Configuraciones.IDFoursquare, Configuraciones.SecretFoursquare, DateTime.Now.ToString("yyyMMdd"));
            }
        }
    }
}
