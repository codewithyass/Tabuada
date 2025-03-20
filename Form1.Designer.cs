namespace TrabalhoTabuada
{
    partial class Tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuada));
            this.lblNumInicial = new System.Windows.Forms.Label();
            this.lblNumFinal = new System.Windows.Forms.Label();
            this.txtNumInicial = new System.Windows.Forms.TextBox();
            this.txtNumFinal = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumInicial
            // 
            this.lblNumInicial.AutoSize = true;
            this.lblNumInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInicial.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInicial.ForeColor = System.Drawing.Color.White;
            this.lblNumInicial.Location = new System.Drawing.Point(9, 13);
            this.lblNumInicial.Name = "lblNumInicial";
            this.lblNumInicial.Size = new System.Drawing.Size(107, 16);
            this.lblNumInicial.TabIndex = 0;
            this.lblNumInicial.Text = "Número Inicial";
            // 
            // lblNumFinal
            // 
            this.lblNumFinal.AutoSize = true;
            this.lblNumFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblNumFinal.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFinal.ForeColor = System.Drawing.Color.White;
            this.lblNumFinal.Location = new System.Drawing.Point(128, 12);
            this.lblNumFinal.Name = "lblNumFinal";
            this.lblNumFinal.Size = new System.Drawing.Size(100, 16);
            this.lblNumFinal.TabIndex = 1;
            this.lblNumFinal.Text = "Número Final";
            // 
            // txtNumInicial
            // 
            this.txtNumInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.txtNumInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumInicial.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumInicial.ForeColor = System.Drawing.Color.IndianRed;
            this.txtNumInicial.Location = new System.Drawing.Point(13, 34);
            this.txtNumInicial.Name = "txtNumInicial";
            this.txtNumInicial.Size = new System.Drawing.Size(100, 16);
            this.txtNumInicial.TabIndex = 2;
            this.txtNumInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumInicial_KeyDown);
            this.txtNumInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumInicial_KeyPress);
            // 
            // txtNumFinal
            // 
            this.txtNumFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.txtNumFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumFinal.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumFinal.ForeColor = System.Drawing.Color.IndianRed;
            this.txtNumFinal.Location = new System.Drawing.Point(131, 34);
            this.txtNumFinal.Name = "txtNumFinal";
            this.txtNumFinal.Size = new System.Drawing.Size(100, 16);
            this.txtNumFinal.TabIndex = 3;
            this.txtNumFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumFinal_KeyDown);
            this.txtNumFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFinal_KeyPress);
            // 
            // lstResultado
            // 
            this.lstResultado.BackColor = System.Drawing.Color.LightCoral;
            this.lstResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstResultado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstResultado.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Italic);
            this.lstResultado.ForeColor = System.Drawing.Color.White;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(12, 160);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(307, 277);
            this.lstResultado.TabIndex = 4;
            this.lstResultado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstResultado_DrawItem);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(8, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(116, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(244, 34);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCalcular_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(244, 63);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 451);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtNumFinal);
            this.Controls.Add(this.txtNumInicial);
            this.Controls.Add(this.lblNumFinal);
            this.Controls.Add(this.lblNumInicial);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Tabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tabuada_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumInicial;
        private System.Windows.Forms.Label lblNumFinal;
        private System.Windows.Forms.TextBox txtNumInicial;
        private System.Windows.Forms.TextBox txtNumFinal;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

