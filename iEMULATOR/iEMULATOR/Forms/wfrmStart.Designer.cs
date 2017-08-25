namespace iEMULATOR.Forms
{
    partial class wfrmStart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.PRIORIDAD_MAX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.PRIORIDAD_MAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tIPODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDPROCESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIEMPOCPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDPROCESODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIEMPOCPUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_PROCESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ID_IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_IO_MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsEmulator = new iEMULATOR.DataSets.dtsEmulator();
            this.ID_PRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRG_MAYOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORIDAD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCPROGRAMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_TIPOL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_PROCESOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPUL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_LLEGADAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORIDADL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCESOSACTUALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TIPOB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_PROCESOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_LLEGADAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBLOQUEOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TIPOE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_PROCESOE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_CPUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_LLEGADAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewEJECUCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRC_IOTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PRC_IOTableAdapter();
            this.pRC_PROGRAMASTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PRC_PROGRAMASTableAdapter();
            this.viewLOTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_LOTESTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.View_LOTESTableAdapter();
            this.pROCESOSEJECUCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCESOS_EJECUCIONTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PROCESOS_EJECUCIONTableAdapter();
            this.pROCESOSBLOQUEOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCESOS_BLOQUEOTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PROCESOS_BLOQUEOTableAdapter();
            this.view_EJECUCIONTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.View_EJECUCIONTableAdapter();
            this.view_BLOQUEOTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.View_BLOQUEOTableAdapter();
            this.pROCESOS_ACTUALESTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.PROCESOS_ACTUALESTableAdapter();
            this.viewPRIORIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_PRIORIDADESTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.View_PRIORIDADESTableAdapter();
            this.viewROUNDROBBINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ROUND_ROBBINTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.View_ROUND_ROBBINTableAdapter();
            this.tMPPRIORIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMP_PRIORIDADESTableAdapter = new iEMULATOR.DataSets.dtsEmulatorTableAdapters.TMP_PRIORIDADESTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRCIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCPROGRAMASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSACTUALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBLOQUEOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEJECUCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLOTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSEJECUCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSBLOQUEOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPRIORIDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewROUNDROBBINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMPPRIORIDADESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas / Salidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_IO,
            this.ID_IO_MAYOR,
            this.NOMBRE,
            this.TIEMPO_CPU,
            this.PRIORIDAD});
            this.dataGridView1.DataSource = this.pRCIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(6, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRG,
            this.ID_PRG_MAYOR,
            this.NOMBRE1,
            this.TIEMPO_CPU1,
            this.PRIORIDAD1});
            this.dataGridView2.DataSource = this.pRCPROGRAMASBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(543, 152);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(6, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 177);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TIPOL,
            this.ID_PROCESOL,
            this.TIEMPO_CPUL,
            this.TIEMPO_LLEGADAL,
            this.PRIORIDADL});
            this.dataGridView3.DataSource = this.pROCESOSACTUALESBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(543, 152);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(589, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 574);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "La Magia";
            // 
            // button4
            // 
            this.button4.Image = global::iEMULATOR.Properties.Resources._1498103493_pause;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(631, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 13;
            this.button4.Text = "Pausar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView6);
            this.groupBox9.Location = new System.Drawing.Point(6, 387);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(568, 177);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Bloqueo";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPOB,
            this.ID_PROCESOB,
            this.NOMBREB,
            this.TIEMPO_CPUB,
            this.TIEMPO_LLEGADAB,
            this.PRIORIDAD_MAX1});
            this.dataGridView6.DataSource = this.viewBLOQUEOBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(6, 19);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(554, 152);
            this.dataGridView6.TabIndex = 5;
            // 
            // PRIORIDAD_MAX1
            // 
            this.PRIORIDAD_MAX1.DataPropertyName = "PRIORIDAD_MAX";
            this.PRIORIDAD_MAX1.HeaderText = "PRIORIDAD_MAX";
            this.PRIORIDAD_MAX1.Name = "PRIORIDAD_MAX1";
            this.PRIORIDAD_MAX1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::iEMULATOR.Properties.Resources._1497907322_epc;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(630, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aplicar\r\nAlgorítmo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.dataGridView5);
            this.groupBox8.Location = new System.Drawing.Point(6, 204);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(618, 177);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ejecución";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Enabled = false;
            this.button6.Image = global::iEMULATOR.Properties.Resources._1498190050_Skull_and_bones;
            this.button6.Location = new System.Drawing.Point(566, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 154);
            this.button6.TabIndex = 2;
            this.button6.Text = "Kill";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPOE,
            this.ID_PROCESOE,
            this.NOMBREE,
            this.TIEMPO_CPUE,
            this.TIEMPO_LLEGADAE,
            this.PRIORIDAD_MAX});
            this.dataGridView5.DataSource = this.viewEJECUCIONBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 19);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(554, 150);
            this.dataGridView5.TabIndex = 4;
            // 
            // PRIORIDAD_MAX
            // 
            this.PRIORIDAD_MAX.DataPropertyName = "PRIORIDAD_MAX";
            this.PRIORIDAD_MAX.HeaderText = "PRIORIDAD_MAX";
            this.PRIORIDAD_MAX.Name = "PRIORIDAD_MAX";
            this.PRIORIDAD_MAX.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(631, 254);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(75, 39);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quantum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.dataGridView4);
            this.groupBox7.Location = new System.Drawing.Point(6, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(618, 177);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Listo";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Enabled = false;
            this.button5.Image = global::iEMULATOR.Properties.Resources._1498190050_Skull_and_bones;
            this.button5.Location = new System.Drawing.Point(566, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 154);
            this.button5.TabIndex = 1;
            this.button5.Text = "Kill";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 19);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(554, 150);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_CellMouseDown);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = global::iEMULATOR.Properties.Resources._1497907492_terminal_emulator;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(631, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 68);
            this.button3.TabIndex = 9;
            this.button3.Text = "Emular";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::iEMULATOR.Properties.Resources._1497907424_Cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(630, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tIPODataGridViewCheckBoxColumn
            // 
            this.tIPODataGridViewCheckBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewCheckBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewCheckBoxColumn.Name = "tIPODataGridViewCheckBoxColumn";
            this.tIPODataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iDPROCESODataGridViewTextBoxColumn
            // 
            this.iDPROCESODataGridViewTextBoxColumn.DataPropertyName = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn.HeaderText = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn.Name = "iDPROCESODataGridViewTextBoxColumn";
            this.iDPROCESODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIEMPOCPUDataGridViewTextBoxColumn
            // 
            this.tIEMPOCPUDataGridViewTextBoxColumn.DataPropertyName = "TIEMPO_CPU";
            this.tIEMPOCPUDataGridViewTextBoxColumn.HeaderText = "TIEMPO_CPU";
            this.tIEMPOCPUDataGridViewTextBoxColumn.Name = "tIEMPOCPUDataGridViewTextBoxColumn";
            this.tIEMPOCPUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODataGridViewCheckBoxColumn1
            // 
            this.tIPODataGridViewCheckBoxColumn1.DataPropertyName = "TIPO";
            this.tIPODataGridViewCheckBoxColumn1.HeaderText = "TIPO";
            this.tIPODataGridViewCheckBoxColumn1.Name = "tIPODataGridViewCheckBoxColumn1";
            this.tIPODataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // iDPROCESODataGridViewTextBoxColumn1
            // 
            this.iDPROCESODataGridViewTextBoxColumn1.DataPropertyName = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn1.HeaderText = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn1.Name = "iDPROCESODataGridViewTextBoxColumn1";
            this.iDPROCESODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn1
            // 
            this.nOMBREDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.Name = "nOMBREDataGridViewTextBoxColumn1";
            this.nOMBREDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tIEMPOCPUDataGridViewTextBoxColumn1
            // 
            this.tIEMPOCPUDataGridViewTextBoxColumn1.DataPropertyName = "TIEMPO_CPU";
            this.tIEMPOCPUDataGridViewTextBoxColumn1.HeaderText = "TIEMPO_CPU";
            this.tIEMPOCPUDataGridViewTextBoxColumn1.Name = "tIEMPOCPUDataGridViewTextBoxColumn1";
            this.tIEMPOCPUDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ID_TIPO
            // 
            this.ID_TIPO.DataPropertyName = "ID_TIPO";
            this.ID_TIPO.HeaderText = "ID_TIPO";
            this.ID_TIPO.Name = "ID_TIPO";
            this.ID_TIPO.ReadOnly = true;
            // 
            // ID_PROCESO
            // 
            this.ID_PROCESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_PROCESO.DataPropertyName = "ID_PROCESO";
            this.ID_PROCESO.HeaderText = "ID_PROCESO";
            this.ID_PROCESO.Name = "ID_PROCESO";
            this.ID_PROCESO.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(571, 574);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Configuración Inicial";
            // 
            // ID_IO
            // 
            this.ID_IO.DataPropertyName = "ID_IO";
            this.ID_IO.HeaderText = "ID_IO";
            this.ID_IO.Name = "ID_IO";
            this.ID_IO.ReadOnly = true;
            // 
            // ID_IO_MAYOR
            // 
            this.ID_IO_MAYOR.DataPropertyName = "ID_IO_MAYOR";
            this.ID_IO_MAYOR.HeaderText = "ID_IO_MAYOR";
            this.ID_IO_MAYOR.Name = "ID_IO_MAYOR";
            this.ID_IO_MAYOR.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // TIEMPO_CPU
            // 
            this.TIEMPO_CPU.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPU.HeaderText = "TIEMPO_CPU";
            this.TIEMPO_CPU.Name = "TIEMPO_CPU";
            this.TIEMPO_CPU.ReadOnly = true;
            // 
            // PRIORIDAD
            // 
            this.PRIORIDAD.DataPropertyName = "PRIORIDAD";
            this.PRIORIDAD.HeaderText = "PRIORIDAD";
            this.PRIORIDAD.Name = "PRIORIDAD";
            this.PRIORIDAD.ReadOnly = true;
            // 
            // pRCIOBindingSource
            // 
            this.pRCIOBindingSource.DataMember = "PRC_IO";
            this.pRCIOBindingSource.DataSource = this.dtsEmulator;
            // 
            // dtsEmulator
            // 
            this.dtsEmulator.DataSetName = "dtsEmulator";
            this.dtsEmulator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_PRG
            // 
            this.ID_PRG.DataPropertyName = "ID_PRG";
            this.ID_PRG.HeaderText = "ID_PRG";
            this.ID_PRG.Name = "ID_PRG";
            this.ID_PRG.ReadOnly = true;
            // 
            // ID_PRG_MAYOR
            // 
            this.ID_PRG_MAYOR.DataPropertyName = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.HeaderText = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.Name = "ID_PRG_MAYOR";
            this.ID_PRG_MAYOR.ReadOnly = true;
            // 
            // NOMBRE1
            // 
            this.NOMBRE1.DataPropertyName = "NOMBRE";
            this.NOMBRE1.HeaderText = "NOMBRE";
            this.NOMBRE1.Name = "NOMBRE1";
            this.NOMBRE1.ReadOnly = true;
            // 
            // TIEMPO_CPU1
            // 
            this.TIEMPO_CPU1.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPU1.HeaderText = "TIEMPO_CPU";
            this.TIEMPO_CPU1.Name = "TIEMPO_CPU1";
            this.TIEMPO_CPU1.ReadOnly = true;
            // 
            // PRIORIDAD1
            // 
            this.PRIORIDAD1.DataPropertyName = "PRIORIDAD";
            this.PRIORIDAD1.HeaderText = "PRIORIDAD";
            this.PRIORIDAD1.Name = "PRIORIDAD1";
            this.PRIORIDAD1.ReadOnly = true;
            // 
            // pRCPROGRAMASBindingSource
            // 
            this.pRCPROGRAMASBindingSource.DataMember = "PRC_PROGRAMAS";
            this.pRCPROGRAMASBindingSource.DataSource = this.dtsEmulator;
            // 
            // ID_TIPOL
            // 
            this.ID_TIPOL.DataPropertyName = "ID_TIPO";
            this.ID_TIPOL.HeaderText = "ID_TIPO";
            this.ID_TIPOL.Name = "ID_TIPOL";
            this.ID_TIPOL.ReadOnly = true;
            // 
            // ID_PROCESOL
            // 
            this.ID_PROCESOL.DataPropertyName = "ID_PROCESO";
            this.ID_PROCESOL.HeaderText = "ID_PROCESO";
            this.ID_PROCESOL.Name = "ID_PROCESOL";
            this.ID_PROCESOL.ReadOnly = true;
            // 
            // TIEMPO_CPUL
            // 
            this.TIEMPO_CPUL.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPUL.HeaderText = "TIEMPO_CPU";
            this.TIEMPO_CPUL.Name = "TIEMPO_CPUL";
            this.TIEMPO_CPUL.ReadOnly = true;
            // 
            // TIEMPO_LLEGADAL
            // 
            this.TIEMPO_LLEGADAL.DataPropertyName = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAL.HeaderText = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAL.Name = "TIEMPO_LLEGADAL";
            this.TIEMPO_LLEGADAL.ReadOnly = true;
            // 
            // PRIORIDADL
            // 
            this.PRIORIDADL.DataPropertyName = "PRIORIDAD";
            this.PRIORIDADL.HeaderText = "PRIORIDAD";
            this.PRIORIDADL.Name = "PRIORIDADL";
            this.PRIORIDADL.ReadOnly = true;
            // 
            // pROCESOSACTUALESBindingSource
            // 
            this.pROCESOSACTUALESBindingSource.DataMember = "PROCESOS_ACTUALES";
            this.pROCESOSACTUALESBindingSource.DataSource = this.dtsEmulator;
            // 
            // TIPOB
            // 
            this.TIPOB.DataPropertyName = "TIPO";
            this.TIPOB.HeaderText = "TIPO";
            this.TIPOB.Name = "TIPOB";
            this.TIPOB.ReadOnly = true;
            this.TIPOB.Visible = false;
            // 
            // ID_PROCESOB
            // 
            this.ID_PROCESOB.DataPropertyName = "ID_PROCESO";
            this.ID_PROCESOB.HeaderText = "ID_PROCESO";
            this.ID_PROCESOB.Name = "ID_PROCESOB";
            this.ID_PROCESOB.ReadOnly = true;
            this.ID_PROCESOB.Visible = false;
            // 
            // NOMBREB
            // 
            this.NOMBREB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBREB.DataPropertyName = "NOMBRE";
            this.NOMBREB.HeaderText = "NOMBRE";
            this.NOMBREB.Name = "NOMBREB";
            this.NOMBREB.ReadOnly = true;
            // 
            // TIEMPO_CPUB
            // 
            this.TIEMPO_CPUB.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPUB.HeaderText = "TIEMPO_CPU";
            this.TIEMPO_CPUB.Name = "TIEMPO_CPUB";
            this.TIEMPO_CPUB.ReadOnly = true;
            // 
            // TIEMPO_LLEGADAB
            // 
            this.TIEMPO_LLEGADAB.DataPropertyName = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAB.HeaderText = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAB.Name = "TIEMPO_LLEGADAB";
            this.TIEMPO_LLEGADAB.ReadOnly = true;
            // 
            // viewBLOQUEOBindingSource
            // 
            this.viewBLOQUEOBindingSource.DataMember = "View_BLOQUEO";
            this.viewBLOQUEOBindingSource.DataSource = this.dtsEmulator;
            // 
            // TIPOE
            // 
            this.TIPOE.DataPropertyName = "TIPO";
            this.TIPOE.HeaderText = "TIPO";
            this.TIPOE.Name = "TIPOE";
            this.TIPOE.ReadOnly = true;
            this.TIPOE.Visible = false;
            // 
            // ID_PROCESOE
            // 
            this.ID_PROCESOE.DataPropertyName = "ID_PROCESO";
            this.ID_PROCESOE.HeaderText = "ID_PROCESO";
            this.ID_PROCESOE.Name = "ID_PROCESOE";
            this.ID_PROCESOE.ReadOnly = true;
            this.ID_PROCESOE.Visible = false;
            // 
            // NOMBREE
            // 
            this.NOMBREE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBREE.DataPropertyName = "NOMBRE";
            this.NOMBREE.HeaderText = "NOMBRE";
            this.NOMBREE.Name = "NOMBREE";
            this.NOMBREE.ReadOnly = true;
            // 
            // TIEMPO_CPUE
            // 
            this.TIEMPO_CPUE.DataPropertyName = "TIEMPO_CPU";
            this.TIEMPO_CPUE.HeaderText = "TIEMPO_CPU";
            this.TIEMPO_CPUE.Name = "TIEMPO_CPUE";
            this.TIEMPO_CPUE.ReadOnly = true;
            // 
            // TIEMPO_LLEGADAE
            // 
            this.TIEMPO_LLEGADAE.DataPropertyName = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAE.HeaderText = "TIEMPO_LLEGADA";
            this.TIEMPO_LLEGADAE.Name = "TIEMPO_LLEGADAE";
            this.TIEMPO_LLEGADAE.ReadOnly = true;
            // 
            // viewEJECUCIONBindingSource
            // 
            this.viewEJECUCIONBindingSource.DataMember = "View_EJECUCION";
            this.viewEJECUCIONBindingSource.DataSource = this.dtsEmulator;
            // 
            // pRC_IOTableAdapter
            // 
            this.pRC_IOTableAdapter.ClearBeforeFill = true;
            // 
            // pRC_PROGRAMASTableAdapter
            // 
            this.pRC_PROGRAMASTableAdapter.ClearBeforeFill = true;
            // 
            // viewLOTESBindingSource
            // 
            this.viewLOTESBindingSource.DataMember = "View_LOTES";
            this.viewLOTESBindingSource.DataSource = this.dtsEmulator;
            // 
            // view_LOTESTableAdapter
            // 
            this.view_LOTESTableAdapter.ClearBeforeFill = true;
            // 
            // pROCESOSEJECUCIONBindingSource
            // 
            this.pROCESOSEJECUCIONBindingSource.DataMember = "PROCESOS_EJECUCION";
            this.pROCESOSEJECUCIONBindingSource.DataSource = this.dtsEmulator;
            // 
            // pROCESOS_EJECUCIONTableAdapter
            // 
            this.pROCESOS_EJECUCIONTableAdapter.ClearBeforeFill = true;
            // 
            // pROCESOSBLOQUEOBindingSource
            // 
            this.pROCESOSBLOQUEOBindingSource.DataMember = "PROCESOS_BLOQUEO";
            this.pROCESOSBLOQUEOBindingSource.DataSource = this.dtsEmulator;
            // 
            // pROCESOS_BLOQUEOTableAdapter
            // 
            this.pROCESOS_BLOQUEOTableAdapter.ClearBeforeFill = true;
            // 
            // view_EJECUCIONTableAdapter
            // 
            this.view_EJECUCIONTableAdapter.ClearBeforeFill = true;
            // 
            // view_BLOQUEOTableAdapter
            // 
            this.view_BLOQUEOTableAdapter.ClearBeforeFill = true;
            // 
            // pROCESOS_ACTUALESTableAdapter
            // 
            this.pROCESOS_ACTUALESTableAdapter.ClearBeforeFill = true;
            // 
            // viewPRIORIDADESBindingSource
            // 
            this.viewPRIORIDADESBindingSource.DataMember = "View_PRIORIDADES";
            this.viewPRIORIDADESBindingSource.DataSource = this.dtsEmulator;
            // 
            // view_PRIORIDADESTableAdapter
            // 
            this.view_PRIORIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // viewROUNDROBBINBindingSource
            // 
            this.viewROUNDROBBINBindingSource.DataMember = "View_ROUND_ROBBIN";
            this.viewROUNDROBBINBindingSource.DataSource = this.dtsEmulator;
            // 
            // view_ROUND_ROBBINTableAdapter
            // 
            this.view_ROUND_ROBBINTableAdapter.ClearBeforeFill = true;
            // 
            // tMPPRIORIDADESBindingSource
            // 
            this.tMPPRIORIDADESBindingSource.DataMember = "TMP_PRIORIDADES";
            this.tMPPRIORIDADESBindingSource.DataSource = this.dtsEmulator;
            // 
            // tMP_PRIORIDADESTableAdapter
            // 
            this.tMP_PRIORIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // wfrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iEMULATOR.Properties.Resources.BK1;
            this.ClientSize = new System.Drawing.Size(1306, 593);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "wfrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iEmulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfrmStart_FormClosing);
            this.Load += new System.EventHandler(this.wfrmStart_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRCIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCPROGRAMASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSACTUALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBLOQUEOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEJECUCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLOTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSEJECUCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOSBLOQUEOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPRIORIDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewROUNDROBBINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMPPRIORIDADESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DataSets.dtsEmulator dtsEmulator;
        private System.Windows.Forms.BindingSource pRCIOBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PRC_IOTableAdapter pRC_IOTableAdapter;
        private System.Windows.Forms.BindingSource pRCPROGRAMASBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PRC_PROGRAMASTableAdapter pRC_PROGRAMASTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource viewLOTESBindingSource;
        private DataSets.dtsEmulatorTableAdapters.View_LOTESTableAdapter view_LOTESTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource pROCESOSEJECUCIONBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PROCESOS_EJECUCIONTableAdapter pROCESOS_EJECUCIONTableAdapter;
        private System.Windows.Forms.BindingSource pROCESOSBLOQUEOBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PROCESOS_BLOQUEOTableAdapter pROCESOS_BLOQUEOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IO_MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRG_MAYOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tIPODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROCESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIEMPOCPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tIPODataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROCESODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIEMPOCPUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource viewEJECUCIONBindingSource;
        private DataSets.dtsEmulatorTableAdapters.View_EJECUCIONTableAdapter view_EJECUCIONTableAdapter;
        private System.Windows.Forms.BindingSource viewBLOQUEOBindingSource;
        private DataSets.dtsEmulatorTableAdapters.View_BLOQUEOTableAdapter view_BLOQUEOTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ID_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROCESO;
        private System.Windows.Forms.BindingSource pROCESOSACTUALESBindingSource;
        private DataSets.dtsEmulatorTableAdapters.PROCESOS_ACTUALESTableAdapter pROCESOS_ACTUALESTableAdapter;
        private System.Windows.Forms.BindingSource viewPRIORIDADESBindingSource;
        private DataSets.dtsEmulatorTableAdapters.View_PRIORIDADESTableAdapter view_PRIORIDADESTableAdapter;
        private System.Windows.Forms.BindingSource viewROUNDROBBINBindingSource;
        private DataSets.dtsEmulatorTableAdapters.View_ROUND_ROBBINTableAdapter view_ROUND_ROBBINTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TIPOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROCESOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_LLEGADAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD_MAX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TIPOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROCESOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_LLEGADAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD_MAX1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ID_TIPOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROCESOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_CPUL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_LLEGADAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDADL;
        private System.Windows.Forms.BindingSource tMPPRIORIDADESBindingSource;
        private DataSets.dtsEmulatorTableAdapters.TMP_PRIORIDADESTableAdapter tMP_PRIORIDADESTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}