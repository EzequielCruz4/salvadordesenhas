namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            Salvar = new Button();
            dgNomes = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgNomes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 109);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 156);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(492, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(492, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(520, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Salvar
            // 
            Salvar.Location = new Point(520, 228);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(75, 23);
            Salvar.TabIndex = 5;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += bsalvar_Click;
            // 
            // dgNomes
            // 
            dgNomes.AllowUserToAddRows = false;
            dgNomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNomes.Location = new Point(40, 211);
            dgNomes.MultiSelect = false;
            dgNomes.Name = "dgNomes";
            dgNomes.ReadOnly = true;
            dgNomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNomes.Size = new Size(455, 210);
            dgNomes.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 40);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 7;
            label3.Text = "Gambiarra Funcional";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(label3);
            Controls.Add(dgNomes);
            Controls.Add(Salvar);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgNomes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button Salvar;
        private DataGridView dgNomes;
        private Label label3;
    }
}
