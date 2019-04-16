namespace WindowsFormsApp2
{
    partial class frmAnimais
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.btnPatas = new System.Windows.Forms.Button();
            this.pctAnimais = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Items.AddRange(new object[] {
            "Cachorro ",
            "Cavalo ",
            "Centopeia",
            "Cobra",
            "Gato ",
            "Pássaro"});
            this.cboAnimais.Location = new System.Drawing.Point(41, 21);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(153, 21);
            this.cboAnimais.Sorted = true;
            this.cboAnimais.TabIndex = 0;
            this.cboAnimais.SelectedIndexChanged += new System.EventHandler(this.cboAnimais_SelectedIndexChanged);
            // 
            // btnPatas
            // 
            this.btnPatas.Location = new System.Drawing.Point(60, 48);
            this.btnPatas.Name = "btnPatas";
            this.btnPatas.Size = new System.Drawing.Size(110, 23);
            this.btnPatas.TabIndex = 1;
            this.btnPatas.Text = "Mostra Patas";
            this.btnPatas.UseVisualStyleBackColor = true;
            this.btnPatas.Click += new System.EventHandler(this.btnPatas_Click);
            // 
            // pctAnimais
            // 
            this.pctAnimais.Location = new System.Drawing.Point(16, 77);
            this.pctAnimais.Name = "pctAnimais";
            this.pctAnimais.Size = new System.Drawing.Size(198, 146);
            this.pctAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimais.TabIndex = 3;
            this.pctAnimais.TabStop = false;
            this.pctAnimais.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 276);
            this.Controls.Add(this.pctAnimais);
            this.Controls.Add(this.btnPatas);
            this.Controls.Add(this.cboAnimais);
            this.Name = "frmAnimais";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.cboAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Button btnPatas;
        private System.Windows.Forms.PictureBox pctAnimais;
    }
}

