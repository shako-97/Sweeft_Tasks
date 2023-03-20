using Tasks.Sweeft.CountriesAPI.Models;


namespace Tasks.Sweeft.CountriesAPI
{
    public class FileHelper
    {
        public static void WriteCountriesInFile(List<Country> countries)
        {
            for (int i = 0; i < countries.Count; i++)
            {
                using (StreamWriter writer = File.CreateText(@$"E:\Countries\{countries[i].name.common}.txt"))
                {
                    string latlngs = "";
                    foreach (var l in countries[i].latlng) latlngs += $"{l}, ";

                    writer.Write($"Region: {countries[i].region}\nSubregion: {countries[i].subregion}\n" +
                                 $"Latlng: {latlngs.Remove(latlngs.Length - 2)}\n" +
                                 $"Area: {countries[i].area}\nPopulation: {countries[i].population}");
                }
            }
        }
    }
}