namespace Task1
{
    public partial class FilesForm : Form
    {
        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }

        public FilesForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text)
                .Select(file => new { file.Name, file.FullName, file.CreationTime, file.Length })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime);

            FilesDataGridView.DataSource = files.ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text)
                .Select(file => new { file.Extension })
                .Distinct();

            FilesDataGridView.DataSource = files.ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text)
                .GroupBy(file => file.Extension)
                .Select(extensionGroup => new
                {
                    ExtensionName = extensionGroup.Key,
                    Count = extensionGroup.Count()
                });

            FilesDataGridView.DataSource = files.ToList();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text)
                .Where(file => file.Name.Contains(FileNameTextBox.Text));

            FilesDataGridView.DataSource = files.ToList();
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text)
                .Where(file => file.CreationTime.Day == DateTime.Now.Date.Day)
                .OrderByDescending(file => file.CreationTime)
                .Take(5);

            FilesDataGridView.DataSource = files.ToList();
        }

        private void Task6Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(DirectoryTextBox.Text);

            FilesDataGridView.DataSource = files.ToList();
        }
    }
}
