namespace crud_sqlite
{
    partial class Form_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_funcionarios = new System.Windows.Forms.Button();
            this.button_produtos = new System.Windows.Forms.Button();
            this.button_compras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_clientes = new System.Windows.Forms.Button();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_funcionarios
            // 
            this.button_funcionarios.Location = new System.Drawing.Point(3, 117);
            this.button_funcionarios.Name = "button_funcionarios";
            this.button_funcionarios.Size = new System.Drawing.Size(168, 32);
            this.button_funcionarios.TabIndex = 1;
            this.button_funcionarios.Text = "Funcionarios";
            this.button_funcionarios.UseVisualStyleBackColor = true;
            this.button_funcionarios.Click += new System.EventHandler(this.button_funcionarios_Click);
            // 
            // button_produtos
            // 
            this.button_produtos.Location = new System.Drawing.Point(3, 41);
            this.button_produtos.Name = "button_produtos";
            this.button_produtos.Size = new System.Drawing.Size(168, 32);
            this.button_produtos.TabIndex = 2;
            this.button_produtos.Text = "Produtos";
            this.button_produtos.UseVisualStyleBackColor = true;
            // 
            // button_compras
            // 
            this.button_compras.Location = new System.Drawing.Point(3, 79);
            this.button_compras.Name = "button_compras";
            this.button_compras.Size = new System.Drawing.Size(168, 32);
            this.button_compras.TabIndex = 3;
            this.button_compras.Text = "Compras";
            this.button_compras.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encerrarSessãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // encerrarSessãoToolStripMenuItem
            // 
            this.encerrarSessãoToolStripMenuItem.Name = "encerrarSessãoToolStripMenuItem";
            this.encerrarSessãoToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.encerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão";
            this.encerrarSessãoToolStripMenuItem.Click += new System.EventHandler(this.encerrarSessãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_clientes
            // 
            this.button_clientes.Location = new System.Drawing.Point(3, 3);
            this.button_clientes.Name = "button_clientes";
            this.button_clientes.Size = new System.Drawing.Size(168, 32);
            this.button_clientes.TabIndex = 0;
            this.button_clientes.Text = "Clientes";
            this.button_clientes.UseVisualStyleBackColor = true;
            this.button_clientes.Click += new System.EventHandler(this.button_clientes_Click);
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.button_clientes);
            this.panel_sidebar.Controls.Add(this.button_produtos);
            this.panel_sidebar.Controls.Add(this.button_funcionarios);
            this.panel_sidebar.Controls.Add(this.button_compras);
            this.panel_sidebar.Location = new System.Drawing.Point(12, 31);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(174, 429);
            this.panel_sidebar.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 428);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 472);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_principal";
            this.Text = "Form_principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_principal_FormClosed);
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_funcionarios;
        private System.Windows.Forms.Button button_produtos;
        private System.Windows.Forms.Button button_compras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_clientes;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}