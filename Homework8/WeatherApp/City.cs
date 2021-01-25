namespace WeatherApp
{
    public class City
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string CityId { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
