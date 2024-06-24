namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var fileContent = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "logins.csv"));

            foreach (var line in fileContent)
            {
                line.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (loginTextBox.Text == line || loginTextBox.Text == ""
                    || passwordTextBox.Text == "")
                {
                    MessageBox.Show("������������ � ����� ������ ����������/" +
                        "������� ������������ ������");
                    loginTextBox.Clear();
                    break;
                }
                else
                {
                    MessageBox.Show("����������� ������ �������");
                    File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "logins.csv"),
                        $"\n{loginTextBox.Text};" +
                        $"{passwordTextBox.Text};" +
                        $"{DateTime.Now.ToShortDateString()}");
                    break;
                }
            }
        }
    }
}
