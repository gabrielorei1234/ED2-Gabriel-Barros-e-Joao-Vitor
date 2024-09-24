namespace ED2___Gabriel_Barros_e_João_Vitor
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
            txtFilePath = new Label();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.AutoSize = true;
            txtFilePath.Location = new Point(21, 32);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(173, 15);
            txtFilePath.TabIndex = 0;
            txtFilePath.Text = "Nenhum caminho selecionado.";
            txtFilePath.Click += label1_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(25, 66);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(169, 23);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Selecionar arquivo";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 310);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnOpenFile);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtFilePath;
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
    }
}
