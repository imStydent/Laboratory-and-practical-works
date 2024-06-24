
namespace Task1
{
    partial class FilesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilesDataGridView = new DataGridView();
            Task2Button = new Button();
            Task1Button = new Button();
            Task3Button = new Button();
            DirectoryTextBox = new TextBox();
            DirectoryLabel = new Label();
            Task4Button = new Button();
            FileNameLabel = new Label();
            FileNameTextBox = new TextBox();
            Task5Button = new Button();
            Task6Button = new Button();
            ((System.ComponentModel.ISupportInitialize)FilesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FilesDataGridView
            // 
            FilesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FilesDataGridView.BackgroundColor = Color.White;
            FilesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesDataGridView.GridColor = Color.Black;
            FilesDataGridView.Location = new Point(12, 43);
            FilesDataGridView.Name = "FilesDataGridView";
            FilesDataGridView.Size = new Size(752, 372);
            FilesDataGridView.TabIndex = 0;
            // 
            // Task2Button
            // 
            Task2Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task2Button.Location = new Point(93, 423);
            Task2Button.Name = "Task2Button";
            Task2Button.Size = new Size(75, 23);
            Task2Button.TabIndex = 1;
            Task2Button.Text = "Задание 2";
            Task2Button.UseVisualStyleBackColor = true;
            Task2Button.Click += Task2Button_Click;
            // 
            // Task1Button
            // 
            Task1Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task1Button.Location = new Point(12, 423);
            Task1Button.Name = "Task1Button";
            Task1Button.Size = new Size(75, 23);
            Task1Button.TabIndex = 2;
            Task1Button.Text = "Задание 1";
            Task1Button.UseVisualStyleBackColor = true;
            Task1Button.Click += Task1Button_Click;
            // 
            // Task3Button
            // 
            Task3Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task3Button.Location = new Point(174, 423);
            Task3Button.Name = "Task3Button";
            Task3Button.Size = new Size(75, 23);
            Task3Button.TabIndex = 3;
            Task3Button.Text = "Задание 3";
            Task3Button.UseVisualStyleBackColor = true;
            Task3Button.Click += Task3Button_Click;
            // 
            // DirectoryTextBox
            // 
            DirectoryTextBox.Location = new Point(107, 12);
            DirectoryTextBox.Name = "DirectoryTextBox";
            DirectoryTextBox.Size = new Size(100, 23);
            DirectoryTextBox.TabIndex = 4;
            DirectoryTextBox.Text = "V:\\\\ispp21";
            // 
            // DirectoryLabel
            // 
            DirectoryLabel.AutoSize = true;
            DirectoryLabel.Location = new Point(12, 15);
            DirectoryLabel.Name = "DirectoryLabel";
            DirectoryLabel.Size = new Size(89, 15);
            DirectoryLabel.TabIndex = 5;
            DirectoryLabel.Text = "Путь к файлам";
            // 
            // Task4Button
            // 
            Task4Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task4Button.Location = new Point(255, 423);
            Task4Button.Name = "Task4Button";
            Task4Button.Size = new Size(75, 23);
            Task4Button.TabIndex = 6;
            Task4Button.Text = "Задание 4";
            Task4Button.UseVisualStyleBackColor = true;
            Task4Button.Click += Task4Button_Click;
            // 
            // FileNameLabel
            // 
            FileNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(589, 15);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(69, 15);
            FileNameLabel.TabIndex = 7;
            FileNameLabel.Text = "Имя файла";
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileNameTextBox.Location = new Point(664, 12);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(100, 23);
            FileNameTextBox.TabIndex = 8;
            // 
            // Task5Button
            // 
            Task5Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task5Button.Location = new Point(336, 423);
            Task5Button.Name = "Task5Button";
            Task5Button.Size = new Size(75, 23);
            Task5Button.TabIndex = 9;
            Task5Button.Text = "Задание 5";
            Task5Button.UseVisualStyleBackColor = true;
            Task5Button.Click += Task5Button_Click;
            // 
            // Task6Button
            // 
            Task6Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task6Button.Location = new Point(417, 423);
            Task6Button.Name = "Task6Button";
            Task6Button.Size = new Size(75, 23);
            Task6Button.TabIndex = 10;
            Task6Button.Text = "Задание 6";
            Task6Button.UseVisualStyleBackColor = true;
            Task6Button.Click += Task6Button_Click;
            // 
            // FilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 458);
            Controls.Add(Task6Button);
            Controls.Add(Task5Button);
            Controls.Add(FileNameTextBox);
            Controls.Add(FileNameLabel);
            Controls.Add(Task4Button);
            Controls.Add(DirectoryLabel);
            Controls.Add(DirectoryTextBox);
            Controls.Add(Task3Button);
            Controls.Add(Task1Button);
            Controls.Add(Task2Button);
            Controls.Add(FilesDataGridView);
            Name = "FilesForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FilesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FilesDataGridView;
        private Button Task2Button;
        private Button Task1Button;
        private Button Task3Button;
        private TextBox DirectoryTextBox;
        private Label DirectoryLabel;
        private Button Task4Button;
        private Label FileNameLabel;
        private TextBox FileNameTextBox;
        private Button Task5Button;
        private Button Task6Button;
    }
}
