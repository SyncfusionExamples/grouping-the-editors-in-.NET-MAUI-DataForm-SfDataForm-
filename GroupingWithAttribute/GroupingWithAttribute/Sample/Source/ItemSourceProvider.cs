using Syncfusion.Maui.DataForm;

namespace GroupingWithAttribute
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Country")
            {
                List<string> country = new List<string>() { "USA", "Italy", "India", "Indonesia", "Ireland" };
                return country;
            }
            
            if (sourceName == "City")
            {
                List<string> city = new List<string>() { "Chennai", "California", "Calabria", "India", "Qatar" };
                return city;
            }

            return new List<string>();
        }
    }
}