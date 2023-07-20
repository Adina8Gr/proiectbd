namespace InterfataUtilizator
{
    partial class FormaAfisare
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFormAdaugare = new System.Windows.Forms.Button();
            this.buttonStergereFizica = new System.Windows.Forms.Button();
            this.labelAfiseaza = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdPacient = new System.Windows.Forms.Label();
            this.buttonActualizeazaPacient = new System.Windows.Forms.Button();
            this.textBoxTelefonPacient = new System.Windows.Forms.TextBox();
            this.textBoxAdresaPacient = new System.Windows.Forms.TextBox();
            this.textBoxSexPacient = new System.Windows.Forms.TextBox();
            this.textBoxDataPacient = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxPrenumePacient = new System.Windows.Forms.TextBox();
            this.textBoxNumePacient = new System.Windows.Forms.TextBox();
            this.labelTelefonPacient = new System.Windows.Forms.Label();
            this.labelAdresaPacient = new System.Windows.Forms.Label();
            this.labelSexPacient = new System.Windows.Forms.Label();
            this.labelDataPacient = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelPrenumePacient = new System.Windows.Forms.Label();
            this.labelNumePacient = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdBuletin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDataRezultate = new System.Windows.Forms.TextBox();
            this.textDataRecoltarii = new System.Windows.Forms.TextBox();
            this.comboIdPacientBuletin = new System.Windows.Forms.ComboBox();
            this.comboMedic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIdRezultat = new System.Windows.Forms.Label();
            this.buttonAdaugaAnaliza = new System.Windows.Forms.Button();
            this.textBoxComentariiAnaliza = new System.Windows.Forms.TextBox();
            this.textBoxRezultatAnaliza = new System.Windows.Forms.TextBox();
            this.comboBoxAnaliza = new System.Windows.Forms.ComboBox();
            this.comboBoxIDBuletinAnaliza = new System.Windows.Forms.ComboBox();
            this.labelComentariiAnaliza = new System.Windows.Forms.Label();
            this.labelRezultatAnaliza = new System.Windows.Forms.Label();
            this.labelAnaliza = new System.Windows.Forms.Label();
            this.labelIDBuletinAnaliza = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelnrpacienti = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonFormAdaugare
            // 
            this.buttonFormAdaugare.Location = new System.Drawing.Point(783, 15);
            this.buttonFormAdaugare.Name = "buttonFormAdaugare";
            this.buttonFormAdaugare.Size = new System.Drawing.Size(157, 34);
            this.buttonFormAdaugare.TabIndex = 1;
            this.buttonFormAdaugare.Text = "Formulare Adaugare";
            this.buttonFormAdaugare.UseVisualStyleBackColor = true;
            this.buttonFormAdaugare.Click += new System.EventHandler(this.buttonFormAdaugare_Click);
            // 
            // buttonStergereFizica
            // 
            this.buttonStergereFizica.Location = new System.Drawing.Point(221, 273);
            this.buttonStergereFizica.Name = "buttonStergereFizica";
            this.buttonStergereFizica.Size = new System.Drawing.Size(157, 34);
            this.buttonStergereFizica.TabIndex = 2;
            this.buttonStergereFizica.Text = "Delete";
            this.buttonStergereFizica.UseVisualStyleBackColor = true;
            this.buttonStergereFizica.Click += new System.EventHandler(this.buttonStergereFizica_Click);
            // 
            // labelAfiseaza
            // 
            this.labelAfiseaza.AutoSize = true;
            this.labelAfiseaza.Location = new System.Drawing.Point(42, 30);
            this.labelAfiseaza.Name = "labelAfiseaza";
            this.labelAfiseaza.Size = new System.Drawing.Size(59, 16);
            this.labelAfiseaza.TabIndex = 3;
            this.labelAfiseaza.Text = "Afiseaza";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "dupa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblIdPacient);
            this.groupBox1.Controls.Add(this.buttonActualizeazaPacient);
            this.groupBox1.Controls.Add(this.textBoxTelefonPacient);
            this.groupBox1.Controls.Add(this.textBoxAdresaPacient);
            this.groupBox1.Controls.Add(this.textBoxSexPacient);
            this.groupBox1.Controls.Add(this.textBoxDataPacient);
            this.groupBox1.Controls.Add(this.textBoxCNP);
            this.groupBox1.Controls.Add(this.textBoxPrenumePacient);
            this.groupBox1.Controls.Add(this.textBoxNumePacient);
            this.groupBox1.Controls.Add(this.labelTelefonPacient);
            this.groupBox1.Controls.Add(this.labelAdresaPacient);
            this.groupBox1.Controls.Add(this.labelSexPacient);
            this.groupBox1.Controls.Add(this.labelDataPacient);
            this.groupBox1.Controls.Add(this.labelCNP);
            this.groupBox1.Controls.Add(this.labelPrenumePacient);
            this.groupBox1.Controls.Add(this.labelNumePacient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 300);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizare informatii pacient";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIdPacient
            // 
            this.lblIdPacient.AutoSize = true;
            this.lblIdPacient.Location = new System.Drawing.Point(23, 262);
            this.lblIdPacient.Name = "lblIdPacient";
            this.lblIdPacient.Size = new System.Drawing.Size(0, 16);
            this.lblIdPacient.TabIndex = 15;
            // 
            // buttonActualizeazaPacient
            // 
            this.buttonActualizeazaPacient.Location = new System.Drawing.Point(218, 262);
            this.buttonActualizeazaPacient.Name = "buttonActualizeazaPacient";
            this.buttonActualizeazaPacient.Size = new System.Drawing.Size(103, 32);
            this.buttonActualizeazaPacient.TabIndex = 14;
            this.buttonActualizeazaPacient.Text = "Actualizeaza";
            this.buttonActualizeazaPacient.UseVisualStyleBackColor = true;
            this.buttonActualizeazaPacient.Click += new System.EventHandler(this.buttonAdaugaPacient_Click);
            // 
            // textBoxTelefonPacient
            // 
            this.textBoxTelefonPacient.Location = new System.Drawing.Point(132, 236);
            this.textBoxTelefonPacient.Name = "textBoxTelefonPacient";
            this.textBoxTelefonPacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxTelefonPacient.TabIndex = 13;
            // 
            // textBoxAdresaPacient
            // 
            this.textBoxAdresaPacient.Location = new System.Drawing.Point(132, 203);
            this.textBoxAdresaPacient.Name = "textBoxAdresaPacient";
            this.textBoxAdresaPacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxAdresaPacient.TabIndex = 12;
            // 
            // textBoxSexPacient
            // 
            this.textBoxSexPacient.Location = new System.Drawing.Point(132, 167);
            this.textBoxSexPacient.Name = "textBoxSexPacient";
            this.textBoxSexPacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxSexPacient.TabIndex = 11;
            // 
            // textBoxDataPacient
            // 
            this.textBoxDataPacient.Location = new System.Drawing.Point(132, 130);
            this.textBoxDataPacient.Name = "textBoxDataPacient";
            this.textBoxDataPacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxDataPacient.TabIndex = 10;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(132, 99);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(189, 22);
            this.textBoxCNP.TabIndex = 9;
            // 
            // textBoxPrenumePacient
            // 
            this.textBoxPrenumePacient.Location = new System.Drawing.Point(132, 62);
            this.textBoxPrenumePacient.Name = "textBoxPrenumePacient";
            this.textBoxPrenumePacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxPrenumePacient.TabIndex = 8;
            // 
            // textBoxNumePacient
            // 
            this.textBoxNumePacient.Location = new System.Drawing.Point(132, 28);
            this.textBoxNumePacient.Name = "textBoxNumePacient";
            this.textBoxNumePacient.Size = new System.Drawing.Size(189, 22);
            this.textBoxNumePacient.TabIndex = 7;
            // 
            // labelTelefonPacient
            // 
            this.labelTelefonPacient.AutoSize = true;
            this.labelTelefonPacient.Location = new System.Drawing.Point(20, 236);
            this.labelTelefonPacient.Name = "labelTelefonPacient";
            this.labelTelefonPacient.Size = new System.Drawing.Size(53, 16);
            this.labelTelefonPacient.TabIndex = 6;
            this.labelTelefonPacient.Text = "Telefon";
            // 
            // labelAdresaPacient
            // 
            this.labelAdresaPacient.AutoSize = true;
            this.labelAdresaPacient.Location = new System.Drawing.Point(20, 206);
            this.labelAdresaPacient.Name = "labelAdresaPacient";
            this.labelAdresaPacient.Size = new System.Drawing.Size(51, 16);
            this.labelAdresaPacient.TabIndex = 5;
            this.labelAdresaPacient.Text = "Adresa";
            // 
            // labelSexPacient
            // 
            this.labelSexPacient.AutoSize = true;
            this.labelSexPacient.Location = new System.Drawing.Point(20, 173);
            this.labelSexPacient.Name = "labelSexPacient";
            this.labelSexPacient.Size = new System.Drawing.Size(30, 16);
            this.labelSexPacient.TabIndex = 4;
            this.labelSexPacient.Text = "Sex";
            // 
            // labelDataPacient
            // 
            this.labelDataPacient.AutoSize = true;
            this.labelDataPacient.Location = new System.Drawing.Point(20, 130);
            this.labelDataPacient.Name = "labelDataPacient";
            this.labelDataPacient.Size = new System.Drawing.Size(82, 16);
            this.labelDataPacient.TabIndex = 3;
            this.labelDataPacient.Text = "Data nasterii";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(20, 99);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(35, 16);
            this.labelCNP.TabIndex = 2;
            this.labelCNP.Text = "CNP";
            // 
            // labelPrenumePacient
            // 
            this.labelPrenumePacient.AutoSize = true;
            this.labelPrenumePacient.Location = new System.Drawing.Point(20, 62);
            this.labelPrenumePacient.Name = "labelPrenumePacient";
            this.labelPrenumePacient.Size = new System.Drawing.Size(61, 16);
            this.labelPrenumePacient.TabIndex = 1;
            this.labelPrenumePacient.Text = "Prenume";
            // 
            // labelNumePacient
            // 
            this.labelNumePacient.AutoSize = true;
            this.labelNumePacient.Location = new System.Drawing.Point(20, 28);
            this.labelNumePacient.Name = "labelNumePacient";
            this.labelNumePacient.Size = new System.Drawing.Size(43, 16);
            this.labelNumePacient.TabIndex = 0;
            this.labelNumePacient.Text = "Nume";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lblIdBuletin);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxDataRezultate);
            this.groupBox2.Controls.Add(this.textDataRecoltarii);
            this.groupBox2.Controls.Add(this.comboIdPacientBuletin);
            this.groupBox2.Controls.Add(this.comboMedic);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(405, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 300);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editare informatii buletin de analize";
            // 
            // lblIdBuletin
            // 
            this.lblIdBuletin.AutoSize = true;
            this.lblIdBuletin.Location = new System.Drawing.Point(19, 269);
            this.lblIdBuletin.Name = "lblIdBuletin";
            this.lblIdBuletin.Size = new System.Drawing.Size(0, 16);
            this.lblIdBuletin.TabIndex = 16;
            this.lblIdBuletin.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Actualizeaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDataRezultate
            // 
            this.textBoxDataRezultate.Location = new System.Drawing.Point(121, 81);
            this.textBoxDataRezultate.Name = "textBoxDataRezultate";
            this.textBoxDataRezultate.Size = new System.Drawing.Size(179, 22);
            this.textBoxDataRezultate.TabIndex = 7;
            // 
            // textDataRecoltarii
            // 
            this.textDataRecoltarii.Location = new System.Drawing.Point(121, 42);
            this.textDataRecoltarii.Name = "textDataRecoltarii";
            this.textDataRecoltarii.Size = new System.Drawing.Size(179, 22);
            this.textDataRecoltarii.TabIndex = 6;
            // 
            // comboIdPacientBuletin
            // 
            this.comboIdPacientBuletin.FormattingEnabled = true;
            this.comboIdPacientBuletin.Location = new System.Drawing.Point(121, 121);
            this.comboIdPacientBuletin.Name = "comboIdPacientBuletin";
            this.comboIdPacientBuletin.Size = new System.Drawing.Size(179, 24);
            this.comboIdPacientBuletin.TabIndex = 5;
            // 
            // comboMedic
            // 
            this.comboMedic.FormattingEnabled = true;
            this.comboMedic.Location = new System.Drawing.Point(121, 161);
            this.comboMedic.Name = "comboMedic";
            this.comboMedic.Size = new System.Drawing.Size(179, 24);
            this.comboMedic.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Pacient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data rezultate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Recoltarii";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.lblIdRezultat);
            this.groupBox3.Controls.Add(this.buttonAdaugaAnaliza);
            this.groupBox3.Controls.Add(this.textBoxComentariiAnaliza);
            this.groupBox3.Controls.Add(this.textBoxRezultatAnaliza);
            this.groupBox3.Controls.Add(this.comboBoxAnaliza);
            this.groupBox3.Controls.Add(this.comboBoxIDBuletinAnaliza);
            this.groupBox3.Controls.Add(this.labelComentariiAnaliza);
            this.groupBox3.Controls.Add(this.labelRezultatAnaliza);
            this.groupBox3.Controls.Add(this.labelAnaliza);
            this.groupBox3.Controls.Add(this.labelIDBuletinAnaliza);
            this.groupBox3.Location = new System.Drawing.Point(757, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 300);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizare informatii rezultat analiza";
            // 
            // lblIdRezultat
            // 
            this.lblIdRezultat.AutoSize = true;
            this.lblIdRezultat.Location = new System.Drawing.Point(26, 268);
            this.lblIdRezultat.Name = "lblIdRezultat";
            this.lblIdRezultat.Size = new System.Drawing.Size(0, 16);
            this.lblIdRezultat.TabIndex = 9;
            // 
            // buttonAdaugaAnaliza
            // 
            this.buttonAdaugaAnaliza.Location = new System.Drawing.Point(219, 261);
            this.buttonAdaugaAnaliza.Name = "buttonAdaugaAnaliza";
            this.buttonAdaugaAnaliza.Size = new System.Drawing.Size(102, 33);
            this.buttonAdaugaAnaliza.TabIndex = 8;
            this.buttonAdaugaAnaliza.Text = "Actualizeaza";
            this.buttonAdaugaAnaliza.UseVisualStyleBackColor = true;
            this.buttonAdaugaAnaliza.Click += new System.EventHandler(this.buttonAdaugaAnaliza_Click);
            // 
            // textBoxComentariiAnaliza
            // 
            this.textBoxComentariiAnaliza.Location = new System.Drawing.Point(132, 138);
            this.textBoxComentariiAnaliza.Name = "textBoxComentariiAnaliza";
            this.textBoxComentariiAnaliza.Size = new System.Drawing.Size(189, 22);
            this.textBoxComentariiAnaliza.TabIndex = 7;
            // 
            // textBoxRezultatAnaliza
            // 
            this.textBoxRezultatAnaliza.Location = new System.Drawing.Point(132, 105);
            this.textBoxRezultatAnaliza.Name = "textBoxRezultatAnaliza";
            this.textBoxRezultatAnaliza.Size = new System.Drawing.Size(189, 22);
            this.textBoxRezultatAnaliza.TabIndex = 6;
            // 
            // comboBoxAnaliza
            // 
            this.comboBoxAnaliza.FormattingEnabled = true;
            this.comboBoxAnaliza.Location = new System.Drawing.Point(132, 67);
            this.comboBoxAnaliza.Name = "comboBoxAnaliza";
            this.comboBoxAnaliza.Size = new System.Drawing.Size(189, 24);
            this.comboBoxAnaliza.TabIndex = 5;
            // 
            // comboBoxIDBuletinAnaliza
            // 
            this.comboBoxIDBuletinAnaliza.FormattingEnabled = true;
            this.comboBoxIDBuletinAnaliza.Location = new System.Drawing.Point(132, 32);
            this.comboBoxIDBuletinAnaliza.Name = "comboBoxIDBuletinAnaliza";
            this.comboBoxIDBuletinAnaliza.Size = new System.Drawing.Size(189, 24);
            this.comboBoxIDBuletinAnaliza.TabIndex = 4;
            // 
            // labelComentariiAnaliza
            // 
            this.labelComentariiAnaliza.AutoSize = true;
            this.labelComentariiAnaliza.Location = new System.Drawing.Point(23, 145);
            this.labelComentariiAnaliza.Name = "labelComentariiAnaliza";
            this.labelComentariiAnaliza.Size = new System.Drawing.Size(71, 16);
            this.labelComentariiAnaliza.TabIndex = 3;
            this.labelComentariiAnaliza.Text = "Comentarii";
            // 
            // labelRezultatAnaliza
            // 
            this.labelRezultatAnaliza.AutoSize = true;
            this.labelRezultatAnaliza.Location = new System.Drawing.Point(23, 105);
            this.labelRezultatAnaliza.Name = "labelRezultatAnaliza";
            this.labelRezultatAnaliza.Size = new System.Drawing.Size(55, 16);
            this.labelRezultatAnaliza.TabIndex = 2;
            this.labelRezultatAnaliza.Text = "Rezultat";
            // 
            // labelAnaliza
            // 
            this.labelAnaliza.AutoSize = true;
            this.labelAnaliza.Location = new System.Drawing.Point(23, 67);
            this.labelAnaliza.Name = "labelAnaliza";
            this.labelAnaliza.Size = new System.Drawing.Size(51, 16);
            this.labelAnaliza.TabIndex = 1;
            this.labelAnaliza.Text = "Analiza";
            // 
            // labelIDBuletinAnaliza
            // 
            this.labelIDBuletinAnaliza.AutoSize = true;
            this.labelIDBuletinAnaliza.Location = new System.Drawing.Point(23, 32);
            this.labelIDBuletinAnaliza.Name = "labelIDBuletinAnaliza";
            this.labelIDBuletinAnaliza.Size = new System.Drawing.Size(63, 16);
            this.labelIDBuletinAnaliza.TabIndex = 0;
            this.labelIDBuletinAnaliza.Text = "ID Buletin";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Actualizari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(596, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Asc";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(654, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 20);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Dsc";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // labelnrpacienti
            // 
            this.labelnrpacienti.AutoSize = true;
            this.labelnrpacienti.Location = new System.Drawing.Point(103, 30);
            this.labelnrpacienti.Name = "labelnrpacienti";
            this.labelnrpacienti.Size = new System.Drawing.Size(0, 16);
            this.labelnrpacienti.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(667, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::proiectbd.Properties.Resources._237_2376860_icon_dna_microscope_medical_laboratory_microscope_logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(783, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormaAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelnrpacienti);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAfiseaza);
            this.Controls.Add(this.buttonStergereFizica);
            this.Controls.Add(this.buttonFormAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormaAfisare";
            this.Text = "Centru de analize medicale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFormAdaugare;
        private System.Windows.Forms.Button buttonStergereFizica;
        private System.Windows.Forms.Label labelAfiseaza;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonActualizeazaPacient;
        private System.Windows.Forms.TextBox textBoxTelefonPacient;
        private System.Windows.Forms.TextBox textBoxAdresaPacient;
        private System.Windows.Forms.TextBox textBoxSexPacient;
        private System.Windows.Forms.TextBox textBoxDataPacient;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxPrenumePacient;
        private System.Windows.Forms.TextBox textBoxNumePacient;
        private System.Windows.Forms.Label labelTelefonPacient;
        private System.Windows.Forms.Label labelAdresaPacient;
        private System.Windows.Forms.Label labelSexPacient;
        private System.Windows.Forms.Label labelDataPacient;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelPrenumePacient;
        private System.Windows.Forms.Label labelNumePacient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDataRezultate;
        private System.Windows.Forms.TextBox textDataRecoltarii;
        private System.Windows.Forms.ComboBox comboIdPacientBuletin;
        private System.Windows.Forms.ComboBox comboMedic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAdaugaAnaliza;
        private System.Windows.Forms.TextBox textBoxComentariiAnaliza;
        private System.Windows.Forms.TextBox textBoxRezultatAnaliza;
        private System.Windows.Forms.ComboBox comboBoxAnaliza;
        private System.Windows.Forms.ComboBox comboBoxIDBuletinAnaliza;
        private System.Windows.Forms.Label labelComentariiAnaliza;
        private System.Windows.Forms.Label labelRezultatAnaliza;
        private System.Windows.Forms.Label labelAnaliza;
        private System.Windows.Forms.Label labelIDBuletinAnaliza;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblIdPacient;
        private System.Windows.Forms.Label lblIdBuletin;
        private System.Windows.Forms.Label lblIdRezultat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelnrpacienti;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

