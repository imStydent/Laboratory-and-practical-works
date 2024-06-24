using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;

            var document = wordApp.Documents.Add(Path.Combine(Environment.CurrentDirectory, "״אבכמם.docx"));

            for (int i = 0; i < inputTextBox.Text.Length; i += 255)
            {
                string text = inputTextBox.Text.Substring(255);
                document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: text,
                    Replace: Word.WdReplace.wdReplaceAll);
            }

            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now,
                Replace: Word.WdReplace.wdReplaceAll);

            var table = document.Tables[1];
            int taskAmount = Convert.ToInt32(taskTextBox.Text);

            for (int i = 1; i < taskAmount; i++)
            {
                table.Rows.Add();
                var range = table.Cell(i + 1, 1).Range.Text = i.ToString();
            }
            table.Cell(taskAmount + 1, 1).Range.Text = taskAmount.ToString();
        }
    }
}
