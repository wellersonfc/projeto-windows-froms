namespace admtarefas.View
{
    public partial class FormMenu : Form
    {
        private Form? formAtivo; // guarda o form que está aberto no painel

        public FormMenu()
        {
            InitializeComponent();
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is FormTarefas) return;
            FormTarefas formTarefas = new FormTarefas();
            formTarefas.Show();
            this.Hide();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is FormFuncionarios) return;
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.Show();
            this.Hide();
        }
    }
}
