using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task3
{
    public partial class MainForm : Form
    {
        public delegate void DataSendHandler(string data);
        public static event DataSendHandler OnDataRecive;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ReceiveData(string data)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            OnDataRecive += searchForm.SendData;
            searchForm.ShowDialog();
        }
    }
}
