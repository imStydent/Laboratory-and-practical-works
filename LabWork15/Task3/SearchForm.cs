using System;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task3
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public void SendData(string data)
        {
            //OnDataRecive?.Invoke(data);
        }
        private void replaceButton_Click(object sender, EventArgs e)
        {

        }

        private void replaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
