namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");
            
            var cells = line.Split(',');
            
            if (cells.Length < 3)
            {
                return null; 
            }

            // TODO: Grab the latitude from your array at index 0, longitude index 1, name index 2
            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var nameAndCity = cells[2];

            // TODO: Create a TacoBell class
            // that conforms to ITrackable
            
            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 

            // TODO: Create an instance of the TacoBell class
            // TODO: Set the values of the class correctly (Name and Location)

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return null;
        }
    }
}
