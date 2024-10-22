namespace ArbolBinarioBusqueda
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
            txtValor = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnPreorden = new Button();
            btnInOrden = new Button();
            btnPostOrden = new Button();
            picArbol = new PictureBox();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)picArbol).BeginInit();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(580, 38);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(599, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnPreorden
            // 
            btnPreorden.Location = new Point(599, 126);
            btnPreorden.Name = "btnPreorden";
            btnPreorden.Size = new Size(112, 34);
            btnPreorden.TabIndex = 3;
            btnPreorden.Text = "PreOrden";
            btnPreorden.UseVisualStyleBackColor = true;
            btnPreorden.Click += btnPreorden_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(599, 166);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(112, 34);
            btnInOrden.TabIndex = 4;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.Location = new Point(599, 206);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(112, 34);
            btnPostOrden.TabIndex = 5;
            btnPostOrden.Text = "PostOrden";
            btnPostOrden.UseVisualStyleBackColor = true;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // picArbol
            // 
            picArbol.Location = new Point(12, 25);
            picArbol.Name = "picArbol";
            picArbol.Size = new Size(464, 291);
            picArbol.TabIndex = 6;
            picArbol.TabStop = false;
            picArbol.Paint += picArbol_Paint;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 351);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(picArbol);
            Controls.Add(btnPostOrden);
            Controls.Add(btnInOrden);
            Controls.Add(btnPreorden);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)picArbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private Label label1;
        private Button btnAgregar;
        private Button btnPreorden;
        private Button btnInOrden;
        private Button btnPostOrden;
        private PictureBox picArbol;
        private Label lblResultado;
    }
}
