namespace Lab_Trabajo_Final
{
    partial class Multados
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
            this.lbMultados = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btVer = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMultados
            // 
            this.lbMultados.FormattingEnabled = true;
            this.lbMultados.Location = new System.Drawing.Point(9, 19);
            this.lbMultados.Name = "lbMultados";
            this.lbMultados.Size = new System.Drawing.Size(170, 238);
            this.lbMultados.TabIndex = 0;
            this.lbMultados.SelectedIndexChanged += new System.EventHandler(this.lbMultados_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(208, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btVer
            // 
            this.btVer.Enabled = false;
            this.btVer.Location = new System.Drawing.Point(208, 63);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 122);
            this.btVer.TabIndex = 2;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbMultados);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(185, 260);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // Multados
            // 
            this.ClientSize = new System.Drawing.Size(286, 277);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btnSalir);
            this.Name = "Multados";
            this.Text = "Lista de Vehiculos Multados";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbMultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btVer;
        public System.Windows.Forms.GroupBox groupBox;
    }
    }