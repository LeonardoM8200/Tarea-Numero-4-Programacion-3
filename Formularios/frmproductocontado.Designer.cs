namespace Tarea4_EdwinLeonardoMolina.Formularios
{
    partial class frmproductocontado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtprecioalcontado = new System.Windows.Forms.TextBox();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.txtaumento = new System.Windows.Forms.TextBox();
            this.txtplazoanual = new System.Windows.Forms.TextBox();
            this.txtcuotamensual = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtcuotamensual);
            this.groupBox1.Controls.Add(this.txtplazoanual);
            this.groupBox1.Controls.Add(this.txtaumento);
            this.groupBox1.Controls.Add(this.txtporcentaje);
            this.groupBox1.Controls.Add(this.txtprecioalcontado);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Al Contado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plazo Anual + Aumento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cuota Mensual";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(173, 62);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(153, 25);
            this.txtproducto.TabIndex = 6;
            // 
            // txtprecioalcontado
            // 
            this.txtprecioalcontado.Location = new System.Drawing.Point(24, 130);
            this.txtprecioalcontado.Name = "txtprecioalcontado";
            this.txtprecioalcontado.Size = new System.Drawing.Size(108, 25);
            this.txtprecioalcontado.TabIndex = 7;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(177, 127);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(53, 25);
            this.txtporcentaje.TabIndex = 8;
            // 
            // txtaumento
            // 
            this.txtaumento.Location = new System.Drawing.Point(258, 127);
            this.txtaumento.Name = "txtaumento";
            this.txtaumento.Size = new System.Drawing.Size(68, 25);
            this.txtaumento.TabIndex = 9;
            // 
            // txtplazoanual
            // 
            this.txtplazoanual.Location = new System.Drawing.Point(353, 127);
            this.txtplazoanual.Name = "txtplazoanual";
            this.txtplazoanual.Size = new System.Drawing.Size(108, 25);
            this.txtplazoanual.TabIndex = 10;
            // 
            // txtcuotamensual
            // 
            this.txtcuotamensual.Location = new System.Drawing.Point(190, 190);
            this.txtcuotamensual.Name = "txtcuotamensual";
            this.txtcuotamensual.Size = new System.Drawing.Size(119, 25);
            this.txtcuotamensual.TabIndex = 11;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(38, 233);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(209, 233);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 31);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(386, 233);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 31);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmproductocontado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 307);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmproductocontado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto Al Contado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtcuotamensual;
        private System.Windows.Forms.TextBox txtplazoanual;
        private System.Windows.Forms.TextBox txtaumento;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.TextBox txtprecioalcontado;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}