
namespace ProjetoCarlosEduardo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCadastroPaciente = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.radioButtonCanal = new System.Windows.Forms.RadioButton();
            this.radioButtonObturacao = new System.Windows.Forms.RadioButton();
            this.labelQtd = new System.Windows.Forms.Label();
            this.labelValor_Pagar = new System.Windows.Forms.Label();
            this.textBoxValorPagar = new System.Windows.Forms.TextBox();
            this.buttonCalculadora = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastroPaciente
            // 
            this.labelCadastroPaciente.AutoSize = true;
            this.labelCadastroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroPaciente.Location = new System.Drawing.Point(283, 22);
            this.labelCadastroPaciente.Name = "labelCadastroPaciente";
            this.labelCadastroPaciente.Size = new System.Drawing.Size(239, 25);
            this.labelCadastroPaciente.TabIndex = 0;
            this.labelCadastroPaciente.Text = "Cadastro do Paciente";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(26, 79);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 18);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(125, 79);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(300, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(258, 241);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 3;
            // 
            // radioButtonCanal
            // 
            this.radioButtonCanal.AutoSize = true;
            this.radioButtonCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCanal.Location = new System.Drawing.Point(22, 32);
            this.radioButtonCanal.Name = "radioButtonCanal";
            this.radioButtonCanal.Size = new System.Drawing.Size(64, 22);
            this.radioButtonCanal.TabIndex = 4;
            this.radioButtonCanal.TabStop = true;
            this.radioButtonCanal.Text = "Canal";
            this.radioButtonCanal.UseVisualStyleBackColor = true;
            this.radioButtonCanal.CheckedChanged += new System.EventHandler(this.radioButtonCanal_CheckedChanged);
            // 
            // radioButtonObturacao
            // 
            this.radioButtonObturacao.AutoSize = true;
            this.radioButtonObturacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonObturacao.Location = new System.Drawing.Point(19, 60);
            this.radioButtonObturacao.Name = "radioButtonObturacao";
            this.radioButtonObturacao.Size = new System.Drawing.Size(96, 22);
            this.radioButtonObturacao.TabIndex = 5;
            this.radioButtonObturacao.TabStop = true;
            this.radioButtonObturacao.Text = "Obturação";
            this.radioButtonObturacao.UseVisualStyleBackColor = true;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtd.Location = new System.Drawing.Point(204, 244);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(35, 18);
            this.labelQtd.TabIndex = 7;
            this.labelQtd.Text = "Qtd";
            // 
            // labelValor_Pagar
            // 
            this.labelValor_Pagar.AutoSize = true;
            this.labelValor_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor_Pagar.Location = new System.Drawing.Point(189, 320);
            this.labelValor_Pagar.Name = "labelValor_Pagar";
            this.labelValor_Pagar.Size = new System.Drawing.Size(117, 20);
            this.labelValor_Pagar.TabIndex = 8;
            this.labelValor_Pagar.Text = "Valor a pagar";
            // 
            // textBoxValorPagar
            // 
            this.textBoxValorPagar.Location = new System.Drawing.Point(326, 319);
            this.textBoxValorPagar.Name = "textBoxValorPagar";
            this.textBoxValorPagar.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPagar.TabIndex = 9;
            // 
            // buttonCalculadora
            // 
            this.buttonCalculadora.Location = new System.Drawing.Point(611, 195);
            this.buttonCalculadora.Name = "buttonCalculadora";
            this.buttonCalculadora.Size = new System.Drawing.Size(128, 56);
            this.buttonCalculadora.TabIndex = 10;
            this.buttonCalculadora.Text = "CALCULADORA";
            this.buttonCalculadora.UseVisualStyleBackColor = true;
            this.buttonCalculadora.Click += new System.EventHandler(this.buttonCalculadora_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(611, 270);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(128, 69);
            this.buttonCalcular.TabIndex = 11;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCanal);
            this.groupBox1.Controls.Add(this.radioButtonObturacao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(171, 408);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(447, 30);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 450);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonCalculadora);
            this.Controls.Add(this.textBoxValorPagar);
            this.Controls.Add(this.labelValor_Pagar);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCadastroPaciente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastroPaciente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.RadioButton radioButtonCanal;
        private System.Windows.Forms.RadioButton radioButtonObturacao;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label labelValor_Pagar;
        private System.Windows.Forms.TextBox textBoxValorPagar;
        private System.Windows.Forms.Button buttonCalculadora;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

