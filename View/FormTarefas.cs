using admtarefas.Controller;
using System.Data;
using admtarefas.View;
namespace admtarefas
{
    public partial class FormTarefas : FormMenu
    {
        // Tabela em memória para guardar as tarefas
        DataTable tabelaTarefas = new DataTable();
        //Instanciando controller
        TarefaController tarefaController = new TarefaController();

        public FormTarefas()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            // Cria as colunas da tabela
            tabelaTarefas.Columns.Add("Tarefa");
            tabelaTarefas.Columns.Add("Data");
            tabelaTarefas.Columns.Add("Status");

            // Liga o DataGridView à tabela
            dataGridView1.DataSource = tabelaTarefas;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(60, 60, 60);

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = selectStatus.Text;
            string data = dateTime.Value.ToShortDateString(); // ou dateTime.Text
            string nomeTarefa = textBoxTarefa.Text;

            if (string.IsNullOrWhiteSpace(nomeTarefa))
            {
                MessageBox.Show("Informe o nome da tarefa.");
                return;
            }
            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Informe o status da tarefa.");
                return;
            }

            try
            {
                tarefaController.cadastrarTarefa(nomeTarefa, data, status);
                // Mensagem (corrigindo interpolação)
                MessageBox.Show($"Demanda {nomeTarefa}, com a data {data}. Criada com sucesso.");

            }
            catch (Exception ex) {
                // Mensagem (corrigindo interpolação)
                MessageBox.Show($"Error ao cadastrar {ex}");
            }

            tabelaTarefas.Clear();
            var listagem = tarefaController.listarTarefa();
            foreach (var item in listagem) {
                tabelaTarefas.Rows.Add(item.nomeTarefa, item.data, item.status);
            }

            // Limpa campos
            textBoxTarefa.Clear();
            selectStatus.SelectedIndex = -1;
        }
    }
}
