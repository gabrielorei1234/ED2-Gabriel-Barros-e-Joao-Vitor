using AV1;
using System.IO;
using System.Windows.Forms;

namespace ED2___Gabriel_Barros_e_João_Vitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string palavrasExcluidasInput = txtPalavrasExcluidas.Text;

            var arvoreAVL = new ArvoreAVL();
            var listaExclusao = new ListaDeExclusao(palavrasExcluidasInput);
            var processadorArquivos = new ProcessadorDeArquivos(arvoreAVL, listaExclusao);

            // Abre um diálogo para selecionar a pasta
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = folderBrowserDialog.SelectedPath;
                txtFilePath.Text = directoryPath;

                var txtFiles = Directory.GetFiles(directoryPath, "*.txt");

                foreach (var file in txtFiles)
                {
                    processadorArquivos.ProcessarArquivo(file);
                }

                var resultados = arvoreAVL.ObterResultadosInOrder();
                dataGridView1.DataSource = resultados;
            }
        }

        private void btnAtualizarExclusao_Click(object sender, EventArgs e)
        {
            string directoryPath = txtFilePath.Text;

            if (string.IsNullOrEmpty(directoryPath))
            {
                MessageBox.Show("Erro: Nenhum caminho de diretório fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string palavrasExcluidasInput = txtPalavrasExcluidas.Text;

            var arvoreAVL = new ArvoreAVL();
            var listaExclusao = new ListaDeExclusao(palavrasExcluidasInput);
            var processadorArquivos = new ProcessadorDeArquivos(arvoreAVL, listaExclusao);

            var txtFiles = Directory.GetFiles(directoryPath, "*.txt");

            foreach (var file in txtFiles)
            {
                processadorArquivos.ProcessarArquivo(file);
            }

            var resultados = arvoreAVL.ObterResultadosInOrder();
            dataGridView1.DataSource = resultados;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}