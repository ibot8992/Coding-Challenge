namespace WeatherApi.Models
{
    public class WeatherDataResp
    {
        public class WindData
        {
            public float speed { get; set; }
            public float deg { get; set; }
        }

        public class WeatherDetailed
        {
            public float temp { get; set; }
            public float feels_like { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public float pressure { get; set; }
            public float humidity { get; set; }
        }


        public int Id { get; set; }
        public string name { get; set; }
        public WeatherDetailed main { get; set; }
        public WindData wind { get; set; }

        public WeatherDataResp()
        {
            main = new WeatherDetailed();
            wind = new WindData();
        }

    }
}
