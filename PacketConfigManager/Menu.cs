namespace PacketConfigManager
{
    public partial class Menu : Form
    {
        private static string AppDir = AppDomain.CurrentDomain.BaseDirectory;
        private static string ConfigFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages", "Microsoft.MinecraftUWP_8wekyb3d8bbwe", "RoamingState", "Packet Client", "Configs");

        private void RefreshConfigList()
        {
            CfgDataGrid.Rows.Clear();
            foreach (string file in Directory.GetFiles(AppDir, "*.txt"))
            {
                CfgDataGrid.Rows.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        public Menu()
        {
            InitializeComponent();
            RefreshConfigList();
        }

        private void SaveBtn_Click(object obj, EventArgs args)
        {
            string defaultConfigPath = Path.Combine(ConfigFolder, "Default.txt");
            if (!File.Exists(defaultConfigPath))
            {
                MessageBox.Show("The default config file is not present. Make sure you have ran Packet Client at least once before.");
                return;
            }
            if (string.IsNullOrEmpty(CfgNameBox.Text))
            {
                MessageBox.Show("You must first set a Config name.");
                return;
            }

            if (File.Exists(Path.Combine(AppDir, CfgNameBox.Text)))
            {
                DialogResult choice = MessageBox.Show("A saved config file already exists with this name. If you press 'Ok' the saved config will be replaced with the new one.", "Confirmation", MessageBoxButtons.OKCancel);
                if (choice == DialogResult.Cancel)
                    return;
            }

            File.Copy(defaultConfigPath, Path.Combine(AppDir, CfgNameBox.Text + ".txt"), true);
            RefreshConfigList();
        }

        private void LoadBtn_Click(object obj, EventArgs args)
        {
            string configNameToUse = CfgDataGrid.SelectedCells[0].Value.ToString();

            DialogResult choice = MessageBox.Show($"This will override your current config with the one selected ({configNameToUse}). Press 'Ok' to continue.", "Confirmation", MessageBoxButtons.OKCancel);
            if (choice == DialogResult.Cancel)
                return;

            File.Copy(Path.Combine(AppDir, configNameToUse + ".txt"), Path.Combine(ConfigFolder, "Default.txt"), true);

            RefreshConfigList();
        }
    }
}
