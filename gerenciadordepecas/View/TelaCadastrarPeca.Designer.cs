namespace gerenciadordepecas.View
{
    partial class TelaCadastrarPeca
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
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.textBoxCapacidade = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxpecas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPecas.Location = new System.Drawing.Point(49, 333);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(276, 53);
            this.btnCadastrarPecas.TabIndex = 18;
            this.btnCadastrarPecas.Text = "Cadastrar Peça";
            this.btnCadastrarPecas.UseVisualStyleBackColor = true;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // textBoxCapacidade
            // 
            this.textBoxCapacidade.Location = new System.Drawing.Point(48, 270);
            this.textBoxCapacidade.Name = "textBoxCapacidade";
            this.textBoxCapacidade.Size = new System.Drawing.Size(277, 23);
            this.textBoxCapacidade.TabIndex = 17;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(48, 195);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(153, 23);
            this.textBoxMarca.TabIndex = 16;
            // 
            // textBoxpecas
            // 
            this.textBoxpecas.Location = new System.Drawing.Point(48, 123);
            this.textBoxpecas.Name = "textBoxpecas";
            this.textBoxpecas.Size = new System.Drawing.Size(277, 23);
            this.textBoxpecas.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Capacidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Peças";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "CADASTRAR PEÇA";
            // 
            // TelaCadastrarPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.textBoxCapacidade);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxpecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPeca";
            this.Text = "TelaCadastrarPeca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCadastrarPecas;
        private TextBox textBoxCapacidade;
        private TextBox textBoxMarca;
        private TextBox textBoxpecas;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}