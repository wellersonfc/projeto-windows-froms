namespace admtarefas
{
    partial class FormTarefas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dateTime = new DateTimePicker();
            textBoxTarefa = new TextBox();
            selectStatus = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(431, 61);
            label1.Name = "label1";
            label1.Size = new Size(664, 96);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Tarefas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(86, 184);
            label2.Name = "label2";
            label2.Size = new Size(97, 38);
            label2.TabIndex = 1;
            label2.Text = "Tarefa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(490, 185);
            label3.Name = "label3";
            label3.Size = new Size(80, 38);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(848, 185);
            label4.Name = "label4";
            label4.Size = new Size(97, 38);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(1178, 181);
            button1.Name = "button1";
            button1.Size = new Size(264, 50);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar Tarefa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(576, 191);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(226, 31);
            dateTime.TabIndex = 5;
            // 
            // textBoxTarefa
            // 
            textBoxTarefa.Location = new Point(189, 191);
            textBoxTarefa.Name = "textBoxTarefa";
            textBoxTarefa.Size = new Size(246, 31);
            textBoxTarefa.TabIndex = 6;
            // 
            // selectStatus
            // 
            selectStatus.FormattingEnabled = true;
            selectStatus.Items.AddRange(new object[] { "Em Andamento", "Parada", "Concluida" });
            selectStatus.Location = new Point(951, 193);
            selectStatus.Name = "selectStatus";
            selectStatus.Size = new Size(182, 33);
            selectStatus.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1460, 547);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1600, 830);
            Controls.Add(dataGridView1);
            Controls.Add(selectStatus);
            Controls.Add(textBoxTarefa);
            Controls.Add(dateTime);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Cadastro de Tarefas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DateTimePicker dateTime;
        private TextBox textBoxTarefa;
        private ComboBox selectStatus;
        private DataGridView dataGridView1;
    }
}
