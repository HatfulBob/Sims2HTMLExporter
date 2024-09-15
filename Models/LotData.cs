public class LotData
{
    public string Hood { get; set; }
    public string HoodName { get; set; }
    public string HoodType { get; set; }
    public int HouseNumber { get; set; }
    public string HouseName { get; set; }
    public string LotType { get; set; }
    public string Family { get; set; }
    public string LotFlags { get; set; }

    public void CleanupQuotations()
    {
        var properties = this.GetType().GetProperties();

        foreach (var property in properties)
        {
            if (property.PropertyType == typeof(string))
            {
                string value = property.GetValue(this) as string;
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Trim('\"');

                    property.SetValue(this, value);
                }
            }
        }
    }

    public static List<LotData> ParseCsvToLotData(string filePath)
    {
        var lotDataList = new List<LotData>();

        using (var reader = new StreamReader(filePath))
        {
            string headerLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                var lotData = new LotData
                {
                    Hood = values[0],
                    HoodName = values[1],
                    HoodType = values[2],
                    HouseNumber = int.TryParse(values[3], out int houseNumber) ? houseNumber : 0,
                    HouseName = values[4],
                    LotType = values[5],
                    Family = values.Length > 6 ? values[6] : string.Empty,
                    LotFlags = values.Length > 7 ? values[7] : string.Empty
                };

                //cleanup
                lotData.CleanupQuotations();
                lotDataList.Add(lotData);
            }
        }

        return lotDataList;
    }
}
