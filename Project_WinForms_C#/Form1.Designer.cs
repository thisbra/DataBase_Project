namespace Project_BD
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbNif = new System.Windows.Forms.TextBox();
            this.dtpUsuario = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNif = new System.Windows.Forms.Label();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbNot = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNifDelete = new System.Windows.Forms.Button();
            this.txtbNifDelete = new System.Windows.Forms.TextBox();
            this.lblNifDelete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVehicType = new System.Windows.Forms.Label();
            this.cboVtype = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.txtbKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtHonda = new System.Windows.Forms.RadioButton();
            this.rbtFiat = new System.Windows.Forms.RadioButton();
            this.rbtNissan = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVehicleReg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUserNif = new System.Windows.Forms.ComboBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRegMechanic = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoMMechanic = new System.Windows.Forms.RadioButton();
            this.rdoOMechanic = new System.Windows.Forms.RadioButton();
            this.rdoFMechanic = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dttMechanic = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbNameMechanic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbNifMechanic = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cboVehicleReg2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNifMecanico = new System.Windows.Forms.ComboBox();
            this.txtbDescriptionInterv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRequestInterv = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dtgInterv = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cboSortUsAcc = new System.Windows.Forms.ComboBox();
            this.dttUsAcc = new System.Windows.Forms.DataGridView();
            this.grpGender.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInterv)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dttUsAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(6, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(245, 303);
            this.lb1.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(443, 319);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 36);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(340, 10);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(178, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbNif
            // 
            this.txbNif.Location = new System.Drawing.Point(340, 56);
            this.txbNif.Name = "txbNif";
            this.txbNif.Size = new System.Drawing.Size(178, 20);
            this.txbNif.TabIndex = 7;
            // 
            // dtpUsuario
            // 
            this.dtpUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUsuario.Location = new System.Drawing.Point(414, 132);
            this.dtpUsuario.Name = "dtpUsuario";
            this.dtpUsuario.Size = new System.Drawing.Size(104, 20);
            this.dtpUsuario.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(276, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Location = new System.Drawing.Point(276, 63);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(24, 13);
            this.labelNif.TabIndex = 13;
            this.labelNif.Text = "NIF";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(50, 29);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 14;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(50, 52);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 15;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbNot
            // 
            this.rdbNot.AutoSize = true;
            this.rdbNot.Location = new System.Drawing.Point(50, 75);
            this.rdbNot.Name = "rdbNot";
            this.rdbNot.Size = new System.Drawing.Size(102, 17);
            this.rdbNot.TabIndex = 16;
            this.rdbNot.TabStop = true;
            this.rdbNot.Text = "Prefer not to say";
            this.rdbNot.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbM);
            this.grpGender.Controls.Add(this.rdbNot);
            this.grpGender.Controls.Add(this.rdbF);
            this.grpGender.Location = new System.Drawing.Point(318, 192);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 100);
            this.grpGender.TabIndex = 17;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(276, 139);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date of Birth";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboSort);
            this.tabPage1.Controls.Add(this.lb1);
            this.tabPage1.Controls.Add(this.btnAddUser);
            this.tabPage1.Controls.Add(this.grpGender);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.dtpUsuario);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.txbName);
            this.tabPage1.Controls.Add(this.labelNif);
            this.tabPage1.Controls.Add(this.txbNif);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNifDelete);
            this.groupBox2.Controls.Add(this.txtbNifDelete);
            this.groupBox2.Controls.Add(this.lblNifDelete);
            this.groupBox2.Location = new System.Drawing.Point(552, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 157);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete User by NIF";
            // 
            // btnNifDelete
            // 
            this.btnNifDelete.Location = new System.Drawing.Point(58, 101);
            this.btnNifDelete.Name = "btnNifDelete";
            this.btnNifDelete.Size = new System.Drawing.Size(106, 31);
            this.btnNifDelete.TabIndex = 2;
            this.btnNifDelete.Text = "Delete User";
            this.btnNifDelete.UseVisualStyleBackColor = true;
            this.btnNifDelete.Click += new System.EventHandler(this.btnNifDelete_Click);
            // 
            // txtbNifDelete
            // 
            this.txtbNifDelete.Location = new System.Drawing.Point(37, 41);
            this.txtbNifDelete.Name = "txtbNifDelete";
            this.txtbNifDelete.Size = new System.Drawing.Size(146, 20);
            this.txtbNifDelete.TabIndex = 1;
            // 
            // lblNifDelete
            // 
            this.lblNifDelete.AutoSize = true;
            this.lblNifDelete.Location = new System.Drawing.Point(7, 44);
            this.lblNifDelete.Name = "lblNifDelete";
            this.lblNifDelete.Size = new System.Drawing.Size(24, 13);
            this.lblNifDelete.TabIndex = 0;
            this.lblNifDelete.Text = "NIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sort By";
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Name",
            "Reverse name"});
            this.cboSort.Location = new System.Drawing.Point(69, 337);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(166, 21);
            this.cboSort.TabIndex = 19;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblVehicType);
            this.tabPage2.Controls.Add(this.cboVtype);
            this.tabPage2.Controls.Add(this.dgv1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicle Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVehicType
            // 
            this.lblVehicType.AutoSize = true;
            this.lblVehicType.Location = new System.Drawing.Point(558, 34);
            this.lblVehicType.Name = "lblVehicType";
            this.lblVehicType.Size = new System.Drawing.Size(69, 13);
            this.lblVehicType.TabIndex = 2;
            this.lblVehicType.Text = "Vehicle Type";
            // 
            // cboVtype
            // 
            this.cboVtype.FormattingEnabled = true;
            this.cboVtype.Items.AddRange(new object[] {
            "Vehicle",
            "Scooter",
            "Bike",
            "Patinete"});
            this.cboVtype.Location = new System.Drawing.Point(641, 31);
            this.cboVtype.Name = "cboVtype";
            this.cboVtype.Size = new System.Drawing.Size(121, 21);
            this.cboVtype.TabIndex = 1;
            this.cboVtype.SelectedIndexChanged += new System.EventHandler(this.cboVtype_SelectedIndexChanged);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(32, 22);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(520, 350);
            this.dgv1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddVehicle);
            this.tabPage3.Controls.Add(this.txtbKm);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtbMatricula);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vehicle Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(202, 345);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 32;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // txtbKm
            // 
            this.txtbKm.Location = new System.Drawing.Point(160, 119);
            this.txtbKm.Name = "txtbKm";
            this.txtbKm.Size = new System.Drawing.Size(100, 20);
            this.txtbKm.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "KM";
            // 
            // txtbMatricula
            // 
            this.txtbMatricula.Location = new System.Drawing.Point(160, 44);
            this.txtbMatricula.Name = "txtbMatricula";
            this.txtbMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtbMatricula.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Matricula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtHonda);
            this.groupBox1.Controls.Add(this.rbtFiat);
            this.groupBox1.Controls.Add(this.rbtNissan);
            this.groupBox1.Location = new System.Drawing.Point(72, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand";
            // 
            // rbtHonda
            // 
            this.rbtHonda.AutoSize = true;
            this.rbtHonda.Location = new System.Drawing.Point(50, 29);
            this.rbtHonda.Name = "rbtHonda";
            this.rbtHonda.Size = new System.Drawing.Size(57, 17);
            this.rbtHonda.TabIndex = 14;
            this.rbtHonda.TabStop = true;
            this.rbtHonda.Text = "Honda";
            this.rbtHonda.UseVisualStyleBackColor = true;
            // 
            // rbtFiat
            // 
            this.rbtFiat.AutoSize = true;
            this.rbtFiat.Location = new System.Drawing.Point(50, 75);
            this.rbtFiat.Name = "rbtFiat";
            this.rbtFiat.Size = new System.Drawing.Size(42, 17);
            this.rbtFiat.TabIndex = 16;
            this.rbtFiat.TabStop = true;
            this.rbtFiat.Text = "Fiat";
            this.rbtFiat.UseVisualStyleBackColor = true;
            // 
            // rbtNissan
            // 
            this.rbtNissan.AutoSize = true;
            this.rbtNissan.Location = new System.Drawing.Point(50, 52);
            this.rbtNissan.Name = "rbtNissan";
            this.rbtNissan.Size = new System.Drawing.Size(57, 17);
            this.rbtNissan.TabIndex = 15;
            this.rbtNissan.TabStop = true;
            this.rbtNissan.Text = "Nissan";
            this.rbtNissan.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnOrder);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.cboVehicleReg);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.cboUserNif);
            this.tabPage4.Controls.Add(this.txtbDescription);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(303, 194);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(122, 46);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Request Vehicle";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vehicle Registration";
            // 
            // cboVehicleReg
            // 
            this.cboVehicleReg.FormattingEnabled = true;
            this.cboVehicleReg.Location = new System.Drawing.Point(466, 101);
            this.cboVehicleReg.Name = "cboVehicleReg";
            this.cboVehicleReg.Size = new System.Drawing.Size(121, 21);
            this.cboVehicleReg.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "User NIF";
            // 
            // cboUserNif
            // 
            this.cboUserNif.FormattingEnabled = true;
            this.cboUserNif.Location = new System.Drawing.Point(156, 98);
            this.cboUserNif.Name = "cboUserNif";
            this.cboUserNif.Size = new System.Drawing.Size(121, 21);
            this.cboUserNif.TabIndex = 2;
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(136, 39);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(201, 20);
            this.txtbDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRegMechanic);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.dttMechanic);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txtbNameMechanic);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txtbNifMechanic);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Register Mechanic";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRegMechanic
            // 
            this.btnRegMechanic.Location = new System.Drawing.Point(430, 337);
            this.btnRegMechanic.Name = "btnRegMechanic";
            this.btnRegMechanic.Size = new System.Drawing.Size(75, 36);
            this.btnRegMechanic.TabIndex = 19;
            this.btnRegMechanic.Text = "Register Mechanic";
            this.btnRegMechanic.UseVisualStyleBackColor = true;
            this.btnRegMechanic.Click += new System.EventHandler(this.btnRegMechanic_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoMMechanic);
            this.groupBox3.Controls.Add(this.rdoOMechanic);
            this.groupBox3.Controls.Add(this.rdoFMechanic);
            this.groupBox3.Location = new System.Drawing.Point(305, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            // 
            // rdoMMechanic
            // 
            this.rdoMMechanic.AutoSize = true;
            this.rdoMMechanic.Location = new System.Drawing.Point(50, 29);
            this.rdoMMechanic.Name = "rdoMMechanic";
            this.rdoMMechanic.Size = new System.Drawing.Size(34, 17);
            this.rdoMMechanic.TabIndex = 14;
            this.rdoMMechanic.TabStop = true;
            this.rdoMMechanic.Text = "M";
            this.rdoMMechanic.UseVisualStyleBackColor = true;
            // 
            // rdoOMechanic
            // 
            this.rdoOMechanic.AutoSize = true;
            this.rdoOMechanic.Location = new System.Drawing.Point(50, 75);
            this.rdoOMechanic.Name = "rdoOMechanic";
            this.rdoOMechanic.Size = new System.Drawing.Size(51, 17);
            this.rdoOMechanic.TabIndex = 16;
            this.rdoOMechanic.TabStop = true;
            this.rdoOMechanic.Text = "Other";
            this.rdoOMechanic.UseVisualStyleBackColor = true;
            // 
            // rdoFMechanic
            // 
            this.rdoFMechanic.AutoSize = true;
            this.rdoFMechanic.Location = new System.Drawing.Point(50, 52);
            this.rdoFMechanic.Name = "rdoFMechanic";
            this.rdoFMechanic.Size = new System.Drawing.Size(31, 17);
            this.rdoFMechanic.TabIndex = 15;
            this.rdoFMechanic.TabStop = true;
            this.rdoFMechanic.Text = "F";
            this.rdoFMechanic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date of Birth";
            // 
            // dttMechanic
            // 
            this.dttMechanic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttMechanic.Location = new System.Drawing.Point(401, 150);
            this.dttMechanic.Name = "dttMechanic";
            this.dttMechanic.Size = new System.Drawing.Size(104, 20);
            this.dttMechanic.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Name";
            // 
            // txtbNameMechanic
            // 
            this.txtbNameMechanic.Location = new System.Drawing.Point(327, 28);
            this.txtbNameMechanic.Name = "txtbNameMechanic";
            this.txtbNameMechanic.Size = new System.Drawing.Size(178, 20);
            this.txtbNameMechanic.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "NIF";
            // 
            // txtbNifMechanic
            // 
            this.txtbNifMechanic.Location = new System.Drawing.Point(327, 74);
            this.txtbNifMechanic.Name = "txtbNifMechanic";
            this.txtbNifMechanic.Size = new System.Drawing.Size(178, 20);
            this.txtbNifMechanic.TabIndex = 21;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnRequestInterv);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.cboVehicleReg2);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.cboNifMecanico);
            this.tabPage6.Controls.Add(this.txtbDescriptionInterv);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(768, 400);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Request Intervention";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vehicle Registration";
            // 
            // cboVehicleReg2
            // 
            this.cboVehicleReg2.FormattingEnabled = true;
            this.cboVehicleReg2.Location = new System.Drawing.Point(536, 162);
            this.cboVehicleReg2.Name = "cboVehicleReg2";
            this.cboVehicleReg2.Size = new System.Drawing.Size(121, 21);
            this.cboVehicleReg2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mechanic";
            // 
            // cboNifMecanico
            // 
            this.cboNifMecanico.FormattingEnabled = true;
            this.cboNifMecanico.Location = new System.Drawing.Point(226, 159);
            this.cboNifMecanico.Name = "cboNifMecanico";
            this.cboNifMecanico.Size = new System.Drawing.Size(121, 21);
            this.cboNifMecanico.TabIndex = 9;
            // 
            // txtbDescriptionInterv
            // 
            this.txtbDescriptionInterv.Location = new System.Drawing.Point(206, 100);
            this.txtbDescriptionInterv.Name = "txtbDescriptionInterv";
            this.txtbDescriptionInterv.Size = new System.Drawing.Size(201, 20);
            this.txtbDescriptionInterv.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Description";
            // 
            // btnRequestInterv
            // 
            this.btnRequestInterv.Location = new System.Drawing.Point(347, 256);
            this.btnRequestInterv.Name = "btnRequestInterv";
            this.btnRequestInterv.Size = new System.Drawing.Size(134, 60);
            this.btnRequestInterv.TabIndex = 13;
            this.btnRequestInterv.Text = "Request Intervention";
            this.btnRequestInterv.UseVisualStyleBackColor = true;
            this.btnRequestInterv.Click += new System.EventHandler(this.btnRequestInterv_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dtgInterv);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(768, 400);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Maintenances";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dtgInterv
            // 
            this.dtgInterv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInterv.Location = new System.Drawing.Point(19, 25);
            this.dtgInterv.Name = "dtgInterv";
            this.dtgInterv.Size = new System.Drawing.Size(727, 350);
            this.dtgInterv.TabIndex = 3;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label13);
            this.tabPage8.Controls.Add(this.cboSortUsAcc);
            this.tabPage8.Controls.Add(this.dttUsAcc);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(768, 400);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "User Accounts";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sort By";
            // 
            // cboSortUsAcc
            // 
            this.cboSortUsAcc.FormattingEnabled = true;
            this.cboSortUsAcc.Items.AddRange(new object[] {
            "Nome",
            "Account ID",
            "NIF"});
            this.cboSortUsAcc.Location = new System.Drawing.Point(628, 34);
            this.cboSortUsAcc.Name = "cboSortUsAcc";
            this.cboSortUsAcc.Size = new System.Drawing.Size(121, 21);
            this.cboSortUsAcc.TabIndex = 4;
            this.cboSortUsAcc.SelectedIndexChanged += new System.EventHandler(this.cboSortUsAcc_SelectedIndexChanged);
            // 
            // dttUsAcc
            // 
            this.dttUsAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttUsAcc.Location = new System.Drawing.Point(19, 25);
            this.dttUsAcc.Name = "dttUsAcc";
            this.dttUsAcc.Size = new System.Drawing.Size(520, 350);
            this.dttUsAcc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MyTransport";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInterv)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dttUsAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbNif;
        private System.Windows.Forms.DateTimePicker dtpUsuario;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbNot;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lblVehicType;
        private System.Windows.Forms.ComboBox cboVtype;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtHonda;
        private System.Windows.Forms.RadioButton rbtFiat;
        private System.Windows.Forms.RadioButton rbtNissan;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox txtbKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNifDelete;
        private System.Windows.Forms.TextBox txtbNifDelete;
        private System.Windows.Forms.Label lblNifDelete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVehicleReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUserNif;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnRegMechanic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoMMechanic;
        private System.Windows.Forms.RadioButton rdoOMechanic;
        private System.Windows.Forms.RadioButton rdoFMechanic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dttMechanic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbNameMechanic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbNifMechanic;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboVehicleReg2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboNifMecanico;
        private System.Windows.Forms.TextBox txtbDescriptionInterv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRequestInterv;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dtgInterv;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboSortUsAcc;
        private System.Windows.Forms.DataGridView dttUsAcc;
    }
}

