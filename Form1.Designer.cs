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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPalavrasExcluidas = new TextBox();
            lblPalavrasExcluidas = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.AutoSize = true;
            txtFilePath.Location = new Point(12, 174);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(173, 15);
            txtFilePath.TabIndex = 0;
            txtFilePath.Text = "Nenhum caminho selecionado.";
            txtFilePath.Click += label1_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 192);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(169, 23);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Selecionar caminho";
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
            dataGridView1.Location = new Point(12, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 310);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(498, 32);
            label1.TabIndex = 3;
            label1.Text = "Arvore AVL Leitor de Palavras de Arquivos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(738, 21);
            label2.TabIndex = 4;
            label2.Text = "Selecione um diretório abaixo para listar todas as palavras e quantas vezes se repetiram em cada arquivo.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 5;
            label3.Text = "Somente arquivos .txt serão lidos*";
            label3.Click += label3_Click;
            // 
            // txtPalavrasExcluidas
            // 
            txtPalavrasExcluidas.Location = new Point(12, 138);
            txtPalavrasExcluidas.Name = "txtPalavrasExcluidas";
            txtPalavrasExcluidas.Size = new Size(776, 23);
            txtPalavrasExcluidas.TabIndex = 6;
            // 
            // lblPalavrasExcluidas
            // 
            lblPalavrasExcluidas.AutoSize = true;
            lblPalavrasExcluidas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPalavrasExcluidas.Location = new Point(12, 102);
            lblPalavrasExcluidas.Name = "lblPalavrasExcluidas";
            lblPalavrasExcluidas.Size = new Size(555, 21);
            lblPalavrasExcluidas.TabIndex = 7;
            lblPalavrasExcluidas.Text = "Lista de palavras a serem ignoradas (separe por virgula, Ex: casa,carro,moeda...)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(lblPalavrasExcluidas);
            Controls.Add(txtPalavrasExcluidas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnOpenFile);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "Leitor de Palavras Arvore AVl";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtFilePath;
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPalavrasExcluidas;
        private Label lblPalavrasExcluidas;
    }
}
