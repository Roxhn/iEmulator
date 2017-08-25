namespace iEMULATOR.Forms
{
    partial class wfrmMainPrgs
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pRCPROGRAMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsEmulator = new iEMULATOR.DataSets.dtsEmulator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRG_MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWPRCPROGRAMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRC_PROGRAMASTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PRC_PROGRAMASTableAdapter();
            this.vIEW_PRCPROGRAMASTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.VIEW_PRCPROGRAMASTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRCPROGRAMASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmulator)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRCPROGRAMASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Proceso";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Image = global::iEMULATOR.Properties.Resources._1497907424_Cancel;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(485, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 71);
            this.button5.TabIndex = 13;
            this.button5.Text = "Cancelar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = global::iEMULATOR.Properties.Resources._1497907646_floppy;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(404, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 71);
            this.button4.TabIndex = 12;
            this.button4.Text = "Guardar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Image = global::iEMULATOR.Properties.Resources._1497907866_icon_81_document_add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(323, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(254, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Primario";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(219, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prioridad\r\nProceso:\r\n";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiempo\r\nCPU:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mayor:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pRCPROGRAMASBindingSource;
            this.comboBox1.DisplayMember = "NOMBRE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_PRG";
            // 
            // pRCPROGRAMASBindingSource
            // 
            this.pRCPROGRAMASBindingSource.DataMember = "PRC_PROGRAMAS";
            this.pRCPROGRAMASBindingSource.DataSource = this.dtsEmulator;
            // 
            // dtsEmulator
            // 
            this.dtsEmulator.DataSetName = "dtsEmulator";
            this.dtsEmulator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos Existentes";
            // 
            // button3
            // 
            this.button3.Image = global::iEMULATOR.Properties.Resources._1497908028_edit_find_replace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(485, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 71);
            this.button3.TabIndex = 1;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::iEMULATOR.Properties.Resources._1497908137_edit_delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(485, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 71);
            this.button2.TabIndex = 0;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRG,
            this.ID_PRG_MAYOR,
            this.MAYOR,
            this.NOMBRE,
            this.TIEMPO_CPU,
            this.PRIORIDAD});
            this.dataGridView1.DataSource = this.vIEWPRCPROGRAMASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(470, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_PRG
            // 
            this.ID_PRG.DataPropertyName = "ID_PRG";
            this.ID_PRG.HeaderText = "ID_PRG";
            this.ID_PRG.Name = "ID_PRG";
            this.ID_PRG.ReadOnly = true;
            this.ID_PRG.Visible = false;
            // 
            // ID_PRG_MAYOR
            // 
            this.ID_PRG_MAYOR.DataPropertyName = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.HeaderText = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.Name = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.ReadOnly = true;
            this.ID_PRG_MAYOR.Visible = false;
            // 
            // MAYOR
            // 
            this.MAYOR.DataPropertyName = "MAYOR";
            this.MAYOR.HeaderText = "Mayor";
            this.MAYOR.Name = "MAYOR";
            this.MAYOR.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // TIEMPO_CPU
            // 
            this.TIEMPO_CPU.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPU.HeaderText = "Tiempo de CPU";
            this.TIEMPO_CPU.Name = "TIEMPO_CPU";
            this.TIEMPO_CPU.ReadOnly = true;
            // 
            // PRIORIDAD
            // 
            this.PRIORIDAD.DataPropertyName = "PRIORIDAD";
            this.PRIORIDAD.HeaderText = "Prioridad";
            this.PRIORIDAD.Name = "PRIORIDAD";
            this.PRIORIDAD.ReadOnly = true;
            // 
            // vIEWPRCPROGRAMASBindingSource
            // 
            this.vIEWPRCPROGRAMASBindingSource.DataMember = "VIEW_PRCPROGRAMAS";
            this.vIEWPRCPROGRAMASBindingSource.DataSource = this.dtsEmulator;
            // 
            // pRC_PROGRAMASTableAdapter
            // 
            this.pRC_PROGRAMASTableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_PRCPROGRAMASTableAdapter
            // 
            this.vIEW_PRCPROGRAMASTableAdapter.ClearBeforeFill = true;
            // 
            // wfrmMainPrgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iEMULATOR.Properties.Resources.BACK__1_;
            this.ClientSize = new System.Drawing.Size(593, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "wfrmMainPrgs";
            this.Text = "Mantenimiento de Programas";
            this.Load += new System.EventHandler(this.wfrmMainPrgs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRCPROGRAMASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmulator)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRCPROGRAMASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DataSets.dtsEmulator dtsEmulator;
        private System.Windows.Forms.BindingSource pRCPROGRAMASBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PRC_PROGRAMASTableAdapter pRC_PROGRAMASTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource vIEWPRCPROGRAMASBindingSource;
        private DataSets.dtsEmulatorTableAdapters.VIEW_PRCPROGRAMASTableAdapter vIEW_PRCPROGRAMASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRG_MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD;
    }
}