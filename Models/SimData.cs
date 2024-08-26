using System;
using Newtonsoft.Json;  // Make sure to include Newtonsoft.Json or System.Text.Json

public class SimData
{
    public string FullName { get { return $"{FirstName} {LastName}"; } }

    [JsonProperty("hood")]
    public string Hood { get; set; }

    [JsonProperty("Hood Name")]
    public string HoodName { get; set; }

    [JsonProperty("NID")]
    public int NID { get; set; }

    [JsonProperty("First Name")]
    public string FirstName { get; set; }

    [JsonProperty("Last Name")]
    public string LastName { get; set; }

    [JsonProperty("Sim Description")]
    public string SimDescription { get; set; }

    [JsonProperty("FamilyInstance")]
    public int FamilyInstance { get; set; }

    [JsonProperty("Household Name")]
    public string HouseholdName { get; set; }

    [JsonProperty("HouseNumber")]
    public int HouseNumber { get; set; }

    [JsonProperty("AvailableCharacterData")]
    public string AvailableCharacterData { get; set; }

    [JsonProperty("Unlinked")]
    public string Unlinked { get; set; }

    [JsonProperty("ParentA")]
    public string ParentA { get; set; }

    [JsonProperty("ParentB")]
    public string ParentB { get; set; }

    [JsonProperty("Spouse")]
    public string Spouse { get; set; }

    [JsonProperty("Body Condition")]
    public string BodyCondition { get; set; }

    [JsonProperty("NPC Type")]
    public string NPCType { get; set; }

    [JsonProperty("School Type")]
    public string SchoolType { get; set; }

    [JsonProperty("Grade")]
    public string Grade { get; set; }

    [JsonProperty("CareerPerformance")]
    public int CareerPerformance { get; set; }

    [JsonProperty("Career")]
    public string Career { get; set; }

    [JsonProperty("CareerLevel")]
    public int CareerLevel { get; set; }

    [JsonProperty("Zodiac Sign")]
    public string ZodiacSign { get; set; }

    [JsonProperty("Gender")]
    public string Gender { get; set; }

    [JsonProperty("LifeSection")]
    public string LifeSection { get; set; }

    [JsonProperty("AgeDaysLeft")]
    public int AgeDaysLeft { get; set; }

    [JsonProperty("PrevAgeDays")]
    public int PrevAgeDays { get; set; }

    [JsonProperty("AgeDuration")]
    public int AgeDuration { get; set; }

    [JsonProperty("BlizLifelinePoints")]
    public int BlizLifelinePoints { get; set; }

    [JsonProperty("LifelinePoints")]
    public int LifelinePoints { get; set; }

    [JsonProperty("LifelineScore")]
    public int LifelineScore { get; set; }

    [JsonProperty("GenActive")]
    public int GenActive { get; set; }

    [JsonProperty("GenNeat")]
    public int GenNeat { get; set; }

    [JsonProperty("GenNice")]
    public int GenNice { get; set; }

    [JsonProperty("GenOutgoing")]
    public int GenOutgoing { get; set; }

    [JsonProperty("GenPlayful")]
    public int GenPlayful { get; set; }

    [JsonProperty("Active")]
    public int Active { get; set; }

    [JsonProperty("Neat")]
    public int Neat { get; set; }

    [JsonProperty("Nice")]
    public int Nice { get; set; }

    [JsonProperty("Outgoing")]
    public int Outgoing { get; set; }

    [JsonProperty("Playful")]
    public int Playful { get; set; }

    [JsonProperty("Animals")]
    public int Animals { get; set; }

    [JsonProperty("Crime")]
    public int Crime { get; set; }

    [JsonProperty("Culture")]
    public int Culture { get; set; }

    [JsonProperty("Entertainment")]
    public int Entertainment { get; set; }

    [JsonProperty("Environment")]
    public int Environment { get; set; }

    [JsonProperty("Fashion")]
    public int Fashion { get; set; }

    [JsonProperty("Food")]
    public int Food { get; set; }

    [JsonProperty("Health")]
    public int Health { get; set; }

    [JsonProperty("Money")]
    public int Money { get; set; }

    [JsonProperty("Paranormal")]
    public int Paranormal { get; set; }

    [JsonProperty("Politics")]
    public int Politics { get; set; }

    [JsonProperty("School")]
    public int School { get; set; }

    [JsonProperty("Scifi")]
    public int Scifi { get; set; }

    [JsonProperty("Sports")]
    public int Sports { get; set; }

    [JsonProperty("Toys")]
    public int Toys { get; set; }

    [JsonProperty("Travel")]
    public int Travel { get; set; }

    [JsonProperty("Weather")]
    public int Weather { get; set; }

    [JsonProperty("Work")]
    public int Work { get; set; }

    [JsonProperty("FemalePreference")]
    public int FemalePreference { get; set; }

    [JsonProperty("MalePreference")]
    public int MalePreference { get; set; }

    [JsonProperty("Body")]
    public int Body { get; set; }

    [JsonProperty("Charisma")]
    public int Charisma { get; set; }

    [JsonProperty("Cleaning")]
    public int Cleaning { get; set; }

    [JsonProperty("Cooking")]
    public int Cooking { get; set; }

    [JsonProperty("Creativity")]
    public int Creativity { get; set; }

    [JsonProperty("Fatness")]
    public int Fatness { get; set; }

    [JsonProperty("Logic")]
    public int Logic { get; set; }

    [JsonProperty("Mechanical")]
    public int Mechanical { get; set; }

    [JsonProperty("IsAtUniversity")]
    public string IsAtUniversity { get; set; }

    [JsonProperty("UniEffort")]
    public int UniEffort { get; set; }

    [JsonProperty("UniGrade")]
    public int UniGrade { get; set; }

    [JsonProperty("UniTime")]
    public int UniTime { get; set; }

    [JsonProperty("UniSemester")]
    public int UniSemester { get; set; }

    [JsonProperty("UniInfluence")]
    public int UniInfluence { get; set; }

    [JsonProperty("UniMajor")]
    public string UniMajor { get; set; }

    [JsonProperty("Species")]
    public string Species { get; set; }

    [JsonProperty("Job Assignment")]
    public string JobAssignment { get; set; }

    [JsonProperty("Lot ID")]
    public string LotID { get; set; }

    [JsonProperty("Salary")]
    public string Salary { get; set; }

    [JsonProperty("PrimaryAspiration")]
    public string PrimaryAspiration { get; set; }

    [JsonProperty("SecondaryAspiration")]
    public string SecondaryAspiration { get; set; }

    [JsonProperty("Natural Talent")]
    public string NaturalTalent { get; set; }

    [JsonProperty("LongtermAspiration")]
    public string LongtermAspiration { get; set; }

    [JsonProperty("Reputation")]
    public int Reputation { get; set; }

    [JsonProperty("Title")]
    public string Title { get; set; }



    public static List<SimData> ParseCsvToSimData(string filePath)
    {
        var simsData = new List<SimData>();
        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    var sim = ParseSimData(values);

                    simsData.Add(sim);
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }

        return simsData;
    }

    private static SimData ParseSimData(string[] values)
    {
        try
        {
            return new SimData
            {
                Hood = values[0],
                HoodName = values[1],
                NID = int.TryParse(values[2], out int nid) ? nid : 0,
                FirstName = values[3],
                LastName = values[4],
                SimDescription = values[5],
                FamilyInstance = int.TryParse(values[6], out int familyInstance) ? familyInstance : 0,
                HouseholdName = values[7],
                HouseNumber = int.TryParse(values[8], out int houseNumber) ? houseNumber : 0,
                AvailableCharacterData = values[9],
                Unlinked = values[10],
                ParentA = values[11],
                ParentB = values[12],
                Spouse = values[13],
                BodyCondition = values[14],
                NPCType = values[15],
                SchoolType = values[16],
                Grade = values[17],
                CareerPerformance = int.TryParse(values[18], out int careerPerformance) ? careerPerformance : 0,
                Career = values[19],
                CareerLevel = int.TryParse(values[20], out int careerLevel) ? careerLevel : 0,
                ZodiacSign = values[21],
                Gender = values[22],
                LifeSection = values[23],
                AgeDaysLeft = int.TryParse(values[24], out int ageDaysLeft) ? ageDaysLeft : 0,
                PrevAgeDays = int.TryParse(values[25], out int prevAgeDays) ? prevAgeDays : 0,
                AgeDuration = int.TryParse(values[26], out int ageDuration) ? ageDuration : 0,
                BlizLifelinePoints = int.TryParse(values[27], out int blizLifelinePoints) ? blizLifelinePoints : 0,
                LifelinePoints = int.TryParse(values[28], out int lifelinePoints) ? lifelinePoints : 0,
                LifelineScore = int.TryParse(values[29], out int lifelineScore) ? lifelineScore : 0,
                GenActive = int.TryParse(values[30], out int genActive) ? genActive : 0,
                GenNeat = int.TryParse(values[31], out int genNeat) ? genNeat : 0,
                GenNice = int.TryParse(values[32], out int genNice) ? genNice : 0,
                GenOutgoing = int.TryParse(values[33], out int genOutgoing) ? genOutgoing : 0,
                GenPlayful = int.TryParse(values[34], out int genPlayful) ? genPlayful : 0,
                Active = int.TryParse(values[35], out int active) ? active : 0,
                Neat = int.TryParse(values[36], out int neat) ? neat : 0,
                Nice = int.TryParse(values[37], out int nice) ? nice : 0,
                Outgoing = int.TryParse(values[38], out int outgoing) ? outgoing : 0,
                Playful = int.TryParse(values[39], out int playful) ? playful : 0,
                Animals = int.TryParse(values[40], out int animals) ? animals : 0,
                Crime = int.TryParse(values[41], out int crime) ? crime : 0,
                Culture = int.TryParse(values[42], out int culture) ? culture : 0,
                Entertainment = int.TryParse(values[43], out int entertainment) ? entertainment : 0,
                Environment = int.TryParse(values[44], out int environment) ? environment : 0,
                Fashion = int.TryParse(values[45], out int fashion) ? fashion : 0,
                Food = int.TryParse(values[46], out int food) ? food : 0,
                Health = int.TryParse(values[47], out int health) ? health : 0,
                Money = int.TryParse(values[48], out int money) ? money : 0,
                Paranormal = int.TryParse(values[49], out int paranormal) ? paranormal : 0,
                Politics = int.TryParse(values[50], out int politics) ? politics : 0,
                School = int.TryParse(values[51], out int school) ? school : 0,
                Scifi = int.TryParse(values[52], out int scifi) ? scifi : 0,
                Sports = int.TryParse(values[53], out int sports) ? sports : 0,
                Toys = int.TryParse(values[54], out int toys) ? toys : 0,
                Travel = int.TryParse(values[55], out int travel) ? travel : 0,
                Weather = int.TryParse(values[56], out int weather) ? weather : 0,
                Work = int.TryParse(values[57], out int work) ? work : 0,
                FemalePreference = int.TryParse(values[58], out int femalePreference) ? femalePreference : 0,
                MalePreference = int.TryParse(values[59], out int malePreference) ? malePreference : 0,
                Body = int.TryParse(values[60], out int body) ? body : 0,
                Charisma = int.TryParse(values[61], out int charisma) ? charisma : 0,
                Cleaning = int.TryParse(values[62], out int cleaning) ? cleaning : 0,
                Cooking = int.TryParse(values[63], out int cooking) ? cooking : 0,
                Creativity = int.TryParse(values[64], out int creativity) ? creativity : 0,
                Fatness = int.TryParse(values[65], out int fatness) ? fatness : 0,
                Logic = int.TryParse(values[66], out int logic) ? logic : 0,
                Mechanical = int.TryParse(values[67], out int mechanical) ? mechanical : 0,
                IsAtUniversity = values[68],
                UniEffort = int.TryParse(values[69], out int uniEffort) ? uniEffort : 0,
                UniGrade = int.TryParse(values[70], out int uniGrade) ? uniGrade : 0,
                UniTime = int.TryParse(values[71], out int uniTime) ? uniTime : 0,
                UniSemester = int.TryParse(values[72], out int uniSemester) ? uniSemester : 0,
                UniInfluence = int.TryParse(values[73], out int uniInfluence) ? uniInfluence : 0,
                UniMajor = values[74],
                Species = values[75],
                JobAssignment = values[76],
                LotID = values[77],
                Salary = values[78],
                PrimaryAspiration = values[79],
                SecondaryAspiration = values[80],
                NaturalTalent = values[81],
                LongtermAspiration = values[82],
                Reputation = int.TryParse(values[83], out int reputation) ? reputation : 0,
                Title = values[84]
            };
        }
        catch { throw; }
    }

}
