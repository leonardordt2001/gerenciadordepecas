namespace gerenciadordepecas.View
{
    partial class TelaAlterarPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodalterar = new System.Windows.Forms.TextBox();
            this.textBoxpecas = new System.Windows.Forms.TextBox();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxcapacidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código que deseja  alterar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // textBoxCodalterar
            // 
            this.textBoxCodalterar.Location = new System.Drawing.Point(113, 76);
            this.textBoxCodalterar.Name = "textBoxCodalterar";
            this.textBoxCodalterar.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodalterar.TabIndex = 4;
            // 
            // textBoxpecas
            // 
            this.textBoxpecas.Location = new System.Drawing.Point(29, 138);
            this.textBoxpecas.Name = "textBoxpecas";
            this.textBoxpecas.Size = new System.Drawing.Size(277, 23);
            this.textBoxpecas.TabIndex = 5;
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(29, 210);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(153, 23);
            this.textBoxmarca.TabIndex = 6;
            // 
            // textBoxcapacidade
            // 
            this.textBoxcapacidade.Location = new System.Drawing.Point(29, 285);
            this.textBoxcapacidade.Name = "textBoxcapacidade";
            this.textBoxcapacidade.Size = new System.Drawing.Size(277, 23);
            this.textBoxcapacidade.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(30, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Alterar Peça";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaAlterarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxcapacidade);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.textBoxpecas);
            this.Controls.Add(this.textBoxCodalterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlterarPecas";
            this.Text = "TelaAlterarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCodalterar;
        private TextBox textBoxpecas;
        private TextBox textBoxmarca;
        private TextBox textBoxcapacidade;
        private Button button1;
        private Button button2;
    }
}