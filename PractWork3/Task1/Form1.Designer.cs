namespace Task1
{
    partial class Form1
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
            inputTextBox = new TextBox();
            textLabel = new Label();
            taskAmountLabel = new Label();
            taskTextBox = new TextBox();
            createDocumentButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 27);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(776, 336);
            inputTextBox.TabIndex = 1;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(12, 9);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(156, 15);
            textLabel.TabIndex = 2;
            textLabel.Text = "Текст для ввода в документ";
            // 
            // taskAmountLabel
            // 
            taskAmountLabel.AutoSize = true;
            taskAmountLabel.Location = new Point(12, 366);
            taskAmountLabel.Name = "taskAmountLabel";
            taskAmountLabel.Size = new Size(119, 15);
            taskAmountLabel.TabIndex = 3;
            taskAmountLabel.Text = "Количество заданий";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(12, 384);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(100, 23);
            taskTextBox.TabIndex = 4;
            // 
            // createDocumentButton
            // 
            createDocumentButton.AutoSize = true;
            createDocumentButton.Location = new Point(12, 413);
            createDocumentButton.Name = "createDocumentButton";
            createDocumentButton.Size = new Size(186, 25);
            createDocumentButton.TabIndex = 5;
            createDocumentButton.Text = "Создать документ по шаблону";
            createDocumentButton.UseVisualStyleBackColor = true;
            createDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createDocumentButton);
            Controls.Add(taskTextBox);
            Controls.Add(taskAmountLabel);
            Controls.Add(textLabel);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Label textLabel;
        private Label taskAmountLabel;
        private TextBox taskTextBox;
        private Button createDocumentButton;
        private SaveFileDialog saveFileDialog1;
    }
}
