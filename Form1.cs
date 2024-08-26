using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace Sims2HTMLExporter
{
    public partial class Form1 : Form
    {
        public static List<SimData> simData;
        public static string neighborhoodName;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "ExportedSims.csv",
                Filter = "Comma Seperated Values (*.csv)|*.csv",
                Title = "Open csv file"
            };
            label1.Text = "Click browse to load csv";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    simData = SimData.ParseCsvToSimData(filePath);
                    label1.Text = "Neighborhood parsed!";
                    CleanSimData();
                    neighborhoodName = simData.First().HoodName;
                    textBox1.Text = neighborhoodName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"An error has occured! \n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                    label1.Text = "An error has occurred, try again.";
                    simData = null;
                    textBox1.Text = "";
                }
            }
        }

        private void CleanSimData()
        {
            //removes unplayables
            simData = simData.Where(x => x.HouseholdName != "Default" && !string.IsNullOrEmpty(x.LastName) && x.SimDescription != "(NPC)" && x.NPCType == "Normal Sim").ToList();

            foreach(SimData sim in simData)
            {

                sim.HoodName = sim.HoodName.Trim('\"');
                sim.FirstName = sim.FirstName.Trim('\"');
                sim.LastName = sim.LastName.Trim('\"');
                sim.HouseholdName = sim.HouseholdName.Trim('\"');
                sim.SimDescription = sim.SimDescription.Trim('\"');
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            neighborhoodName = textBox1.Text;
            if (string.IsNullOrEmpty(neighborhoodName))
            {
                MessageBox.Show("Neighborhood Name is empty!");
                return;
            }
            if (simData == null)
            {
                MessageBox.Show("No Sims have been loaded!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must select where to export!");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("You must select where the SimImages folder is!");
                return;
            }
            if (!Directory.Exists(textBox2.Text))
            {
                MessageBox.Show("Chosen output folder does not exist!");
                return;
            }
            if (!Directory.Exists(textBox2.Text + "\\sims\\"))
            {
                Directory.CreateDirectory(textBox2.Text + "\\sims\\");
                Directory.CreateDirectory(textBox2.Text + "\\sims\\img");
            }
            foreach (var file in Directory.GetFiles(textBox3.Text))
                if(!File.Exists(Path.Combine(textBox2.Text + "\\sims\\img", Path.GetFileName(file))))
                File.Copy(file, Path.Combine(textBox2.Text + "\\sims\\img", Path.GetFileName(file)));

            GenerateSimsPages();
            GenerateIndex();
            MessageBox.Show("File saved successfully!");

        }

        private void GenerateSimsPages()
        {
            TextReader tr = new StreamReader(@"HTMLTemplate/sim/sim.html");
            string simText = tr.ReadToEnd();
            foreach (SimData s in simData)
            {
                var sTextFile = simText;
                var isAlive = s.BodyCondition.Equals("Deceased") ? "Deceased" : "Alive";

                string miscDescription = "";
                miscDescription += $"<img src=\"img\\{s.Hood}_{s.NID}.jpg\" >\n";
                if (!string.IsNullOrEmpty(s.SimDescription))
                {
                    miscDescription += $"<p><i>\"{s.SimDescription}\"</i></p>\n";
                }

                miscDescription += $"<p>Age: {s.LifeSection}</p>\n";
                miscDescription += $"<p>Gender: {s.Gender}</p>\n";
                miscDescription += $"<p>Aspiration: {s.PrimaryAspiration}</p>\n";
                if (s.SecondaryAspiration != "Nothing")
                {
                    miscDescription += $"<p>Secondary Aspiration: {s.SecondaryAspiration}</p>\n";

                }
                miscDescription += $"<p>Zodiac Sign: {s.ZodiacSign}</p>\n";
                miscDescription += $"<p>Career: {s.Career}</p>\n";
                if (s.SchoolType != "Not at School")
                {
                    miscDescription += $"<p>Schooling: {s.SchoolType} (getting grades of {s.Grade})</p>\n";

                }
                miscDescription += $"<p>Body Condition: {s.BodyCondition}</p>\n";


                if (!string.IsNullOrEmpty(s.Spouse))
                {
                    miscDescription += $"<p>Married to : <a href=\"..\\sims\\{s.Spouse.Split('(', ')')[0].Trim()}.html\">{s.Spouse.Split('(', ')')[1]}</a></p>\n";

                }


                if (!string.IsNullOrEmpty(s.ParentA) || !string.IsNullOrEmpty(s.ParentB))
                {
                    miscDescription += $"<p>Child of: <a href=\"..\\sims\\{s.ParentA.Split('(', ')')[0].Trim()}.html\">{s.ParentA.Split('(', ')')[1]}</a> & <a href=\"..\\sims\\{s.ParentB.Split('(', ')')[0].Trim()}.html\">{s.ParentB.Split('(', ')')[1]}</a></p>\n";

                }

                string personalityText = "";
                string skillsText = "";
                string interestsText = "";



                sTextFile = string.Format(sTextFile, neighborhoodName, neighborhoodName, s.FullName, s.FullName, s.Species, s.HoodName, s.HouseholdName, isAlive, miscDescription, personalityText, skillsText, interestsText);
                try
                {

                    File.WriteAllText(textBox2.Text + $"\\sims\\{s.NID}.html", sTextFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured! \n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void GenerateIndex()
        {
            TextReader tr = new StreamReader(@"HTMLTemplate/index.html");
            string indexText = tr.ReadToEnd();
            string playablesList = "", towniesList = "";
            foreach (SimData s in simData.Where(x => x.HouseNumber == 0))
            {
                var isAlive = s.BodyCondition.Equals("Deceased") ?  false : true;
                towniesList += $"<li><a href=\"sims\\{s.NID}.html\">{s.FullName}</a>{((!isAlive) ? "💀" : "")}</li>\n";
            }
            foreach (SimData s in simData.Where(x => x.HouseNumber != 0))
            {
                playablesList += $"<li><a href=\"sims\\{s.NID}.html\">{s.FullName}</a></li>\n";
            }
            indexText = string.Format(indexText, neighborhoodName, neighborhoodName, playablesList, towniesList);

            try
            {
                File.WriteAllText(textBox2.Text + "\\index.html", indexText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured! \n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
