using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitHub_Gist_Gui
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            personalAcessToken = string.Empty; // Initialize the field to avoid CS8618
            gistName = string.Empty; // Initialize the field to avoid CS8618
            gistDesc = string.Empty; // Initialize the field to avoid CS8618
        }

        public bool isPrivateGist;
        public string personalAcessToken;
        public string gistName;
        public string gistDesc;

        private void addFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            foreach (string file in openFileDialog1.FileNames)
            {
                filesList.Items.Add(file);
            }
        }

        private void isPublic_CheckedChanged(object sender, EventArgs e)
        {
            if (isPublic.Checked)
            {
                isPrivateGist = false;
            }
            else
            {
                isPrivateGist = true;
            }
        }

        private void pat_TextChanged(object sender, EventArgs e)
        {
            personalAcessToken = pat.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gistName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            gistDesc = textBox2.Text;
        }

        private async void createGist_Click(object sender, EventArgs e)
        {
            var files = new Dictionary<string, object>();
            foreach (string file in filesList.Items)
            {
                files.Add(Path.GetFileName(file), new { content = File.ReadAllText(file) });
            }

            var gist = new
            {
                description = gistDesc,
                name = gistName,
                @public = !isPrivateGist,
                files = files
            };
            string json = JsonSerializer.Serialize(gist);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Set up the HTTP request
            client.DefaultRequestHeaders.UserAgent.ParseAdd("GistCreatorGui");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", personalAcessToken);
            HttpResponseMessage response = await client.PostAsync("https://api.github.com/gists", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Gist created successfully");
            }
            else
            {
                MessageBox.Show("Failed to create Gist, " + response);
            }
        }
    }
}
