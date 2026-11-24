namespace Portifolio
{
    partial class FrmProjetos
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
            this.cbProjetos = new System.Windows.Forms.ComboBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.listDescricao = new System.Windows.Forms.ListBox();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProjetos
            // 
            this.cbProjetos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbProjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjetos.FormattingEnabled = true;
            this.cbProjetos.Items.AddRange(new object[] {
            "Numero Primo",
            "Tabuada"});
            this.cbProjetos.Location = new System.Drawing.Point(28, 37);
            this.cbProjetos.Name = "cbProjetos";
            this.cbProjetos.Size = new System.Drawing.Size(197, 21);
            this.cbProjetos.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(242, 37);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(675, 37);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // listDescricao
            // 
            this.listDescricao.FormattingEnabled = true;
            this.listDescricao.Location = new System.Drawing.Point(31, 100);
            this.listDescricao.Name = "listDescricao";
            this.listDescricao.Size = new System.Drawing.Size(197, 329);
            this.listDescricao.TabIndex = 3;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.Location = new System.Drawing.Point(28, 68);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(0, 17);
            this.lblNomeProjeto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projetos";
            // 
            // FrmProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.listDescricao);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.cbProjetos);
            this.Name = "FrmProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProjetos;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox listDescricao;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Label label1;
    }
}