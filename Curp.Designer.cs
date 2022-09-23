
namespace Calculadora_del_Curp
{
    partial class Curp
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
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_appat = new System.Windows.Forms.TextBox();
            this.tbx_apmat = new System.Windows.Forms.TextBox();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.tbx_fechanac = new System.Windows.Forms.TextBox();
            this.cbx_edonac = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.cbx_edonac);
            this.groupBox1.Controls.Add(this.tbx_fechanac);
            this.groupBox1.Controls.Add(this.cbx_sexo);
            this.groupBox1.Controls.Add(this.tbx_apmat);
            this.groupBox1.Controls.Add(this.tbx_appat);
            this.groupBox1.Controls.Add(this.tbx_nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese la siguiente información para generar tu curp:";
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(214, 51);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(298, 30);
            this.tbx_nombre.TabIndex = 0;
            // 
            // tbx_appat
            // 
            this.tbx_appat.Location = new System.Drawing.Point(214, 87);
            this.tbx_appat.Name = "tbx_appat";
            this.tbx_appat.Size = new System.Drawing.Size(298, 30);
            this.tbx_appat.TabIndex = 1;
            // 
            // tbx_apmat
            // 
            this.tbx_apmat.Location = new System.Drawing.Point(214, 123);
            this.tbx_apmat.Name = "tbx_apmat";
            this.tbx_apmat.Size = new System.Drawing.Size(298, 30);
            this.tbx_apmat.TabIndex = 2;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Location = new System.Drawing.Point(214, 160);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(298, 33);
            this.cbx_sexo.TabIndex = 3;
            // 
            // tbx_fechanac
            // 
            this.tbx_fechanac.Location = new System.Drawing.Point(214, 199);
            this.tbx_fechanac.Name = "tbx_fechanac";
            this.tbx_fechanac.Size = new System.Drawing.Size(298, 30);
            this.tbx_fechanac.TabIndex = 4;
            // 
            // cbx_edonac
            // 
            this.cbx_edonac.FormattingEnabled = true;
            this.cbx_edonac.Location = new System.Drawing.Point(214, 235);
            this.cbx_edonac.Name = "cbx_edonac";
            this.cbx_edonac.Size = new System.Drawing.Size(298, 33);
            this.cbx_edonac.TabIndex = 5;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(214, 285);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(125, 40);
            this.btn_generar.TabIndex = 6;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(345, 285);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(167, 40);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado de nacimiento:";
            // 
            // Curp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "Curp";
            this.Text = "Curp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cbx_edonac;
        private System.Windows.Forms.TextBox tbx_fechanac;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.TextBox tbx_apmat;
        private System.Windows.Forms.TextBox tbx_appat;
        private System.Windows.Forms.TextBox tbx_nombre;
    }
}

