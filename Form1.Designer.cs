namespace Intel8086
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AH = new System.Windows.Forms.TextBox();
            this.BH = new System.Windows.Forms.MaskedTextBox();
            this.CH = new System.Windows.Forms.MaskedTextBox();
            this.DH = new System.Windows.Forms.MaskedTextBox();
            this.BP = new System.Windows.Forms.MaskedTextBox();
            this.SP = new System.Windows.Forms.MaskedTextBox();
            this.SI = new System.Windows.Forms.MaskedTextBox();
            this.DI = new System.Windows.Forms.MaskedTextBox();
            this.CS = new System.Windows.Forms.MaskedTextBox();
            this.SS = new System.Windows.Forms.MaskedTextBox();
            this.DS = new System.Windows.Forms.MaskedTextBox();
            this.ES = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AX_Hex = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BX_Hex = new System.Windows.Forms.TextBox();
            this.CX_Hex = new System.Windows.Forms.TextBox();
            this.DX_Hex = new System.Windows.Forms.TextBox();
            this.BP_Hex = new System.Windows.Forms.TextBox();
            this.SP_Hex = new System.Windows.Forms.TextBox();
            this.SI_Hex = new System.Windows.Forms.TextBox();
            this.DI_Hex = new System.Windows.Forms.TextBox();
            this.CS_Hex = new System.Windows.Forms.TextBox();
            this.SS_Hex = new System.Windows.Forms.TextBox();
            this.DS_Hex = new System.Windows.Forms.TextBox();
            this.ES_Hex = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.binarne = new System.Windows.Forms.RadioButton();
            this.dziesietne = new System.Windows.Forms.RadioButton();
            this.hexa = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.wykonaj = new System.Windows.Forms.Button();
            this.Losuj = new System.Windows.Forms.Button();
            this.Zeruj = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.pole = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AH
            // 
            this.AH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.AH.Location = new System.Drawing.Point(375, 25);
            this.AH.Name = "AH";
            this.AH.ReadOnly = true;
            this.AH.Size = new System.Drawing.Size(50, 20);
            this.AH.TabIndex = 0;
            this.AH.Text = "0000";
            this.AH.TextChanged += new System.EventHandler(this.AH_Update);
            // 
            // BH
            // 
            this.BH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.BH.Location = new System.Drawing.Point(375, 65);
            this.BH.Name = "BH";
            this.BH.ReadOnly = true;
            this.BH.Size = new System.Drawing.Size(50, 20);
            this.BH.TabIndex = 1;
            this.BH.Text = "0000";
            this.BH.TextChanged += new System.EventHandler(this.BH_Update);
            // 
            // CH
            // 
            this.CH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.CH.Location = new System.Drawing.Point(375, 105);
            this.CH.Name = "CH";
            this.CH.ReadOnly = true;
            this.CH.Size = new System.Drawing.Size(50, 20);
            this.CH.TabIndex = 2;
            this.CH.Text = "0000";
            this.CH.TextChanged += new System.EventHandler(this.CH_Update);
            // 
            // DH
            // 
            this.DH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DH.Location = new System.Drawing.Point(375, 145);
            this.DH.Name = "DH";
            this.DH.ReadOnly = true;
            this.DH.Size = new System.Drawing.Size(50, 20);
            this.DH.TabIndex = 3;
            this.DH.Text = "0000";
            this.DH.TextChanged += new System.EventHandler(this.DH_Update);
            // 
            // BP
            // 
            this.BP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.BP.Location = new System.Drawing.Point(375, 185);
            this.BP.Name = "BP";
            this.BP.ReadOnly = true;
            this.BP.Size = new System.Drawing.Size(105, 20);
            this.BP.TabIndex = 4;
            this.BP.Text = "00000000";
            this.BP.TextChanged += new System.EventHandler(this.BP_Update);
            // 
            // SP
            // 
            this.SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SP.Location = new System.Drawing.Point(375, 210);
            this.SP.Name = "SP";
            this.SP.ReadOnly = true;
            this.SP.Size = new System.Drawing.Size(105, 20);
            this.SP.TabIndex = 5;
            this.SP.Text = "00000000";
            this.SP.TextChanged += new System.EventHandler(this.SP_Update);
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SI.Location = new System.Drawing.Point(375, 235);
            this.SI.Name = "SI";
            this.SI.ReadOnly = true;
            this.SI.Size = new System.Drawing.Size(105, 20);
            this.SI.TabIndex = 6;
            this.SI.Text = "00000000";
            this.SI.TextChanged += new System.EventHandler(this.SI_Update);
            // 
            // DI
            // 
            this.DI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DI.Location = new System.Drawing.Point(375, 260);
            this.DI.Name = "DI";
            this.DI.ReadOnly = true;
            this.DI.Size = new System.Drawing.Size(105, 20);
            this.DI.TabIndex = 7;
            this.DI.Text = "00000000";
            this.DI.TextChanged += new System.EventHandler(this.DI_Update);
            // 
            // CS
            // 
            this.CS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.CS.Location = new System.Drawing.Point(375, 285);
            this.CS.Name = "CS";
            this.CS.ReadOnly = true;
            this.CS.Size = new System.Drawing.Size(105, 20);
            this.CS.TabIndex = 8;
            this.CS.Text = "00000000";
            this.CS.TextChanged += new System.EventHandler(this.CS_Update);
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SS.Location = new System.Drawing.Point(375, 310);
            this.SS.Name = "SS";
            this.SS.ReadOnly = true;
            this.SS.Size = new System.Drawing.Size(105, 20);
            this.SS.TabIndex = 9;
            this.SS.Text = "00000000";
            this.SS.TextChanged += new System.EventHandler(this.SS_Update);
            // 
            // DS
            // 
            this.DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DS.Location = new System.Drawing.Point(375, 335);
            this.DS.Name = "DS";
            this.DS.ReadOnly = true;
            this.DS.Size = new System.Drawing.Size(105, 20);
            this.DS.TabIndex = 10;
            this.DS.Text = "00000000";
            this.DS.TextChanged += new System.EventHandler(this.DS_Update);
            // 
            // ES
            // 
            this.ES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.ES.Location = new System.Drawing.Point(375, 360);
            this.ES.Name = "ES";
            this.ES.ReadOnly = true;
            this.ES.Size = new System.Drawing.Size(105, 20);
            this.ES.TabIndex = 11;
            this.ES.Text = "00000000";
            this.ES.TextChanged += new System.EventHandler(this.ES_Update);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(350, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "AX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(350, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label3.Location = new System.Drawing.Point(350, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label4.Location = new System.Drawing.Point(350, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(350, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(350, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(350, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(350, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(350, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "SS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(350, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(350, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "ES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(350, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "BP";
            // 
            // DL
            // 
            this.DL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DL.Location = new System.Drawing.Point(430, 145);
            this.DL.Name = "DL";
            this.DL.ReadOnly = true;
            this.DL.Size = new System.Drawing.Size(50, 20);
            this.DL.TabIndex = 24;
            this.DL.Text = "0000";
            this.DL.TextChanged += new System.EventHandler(this.DL_Update);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label13.Location = new System.Drawing.Point(375, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "DH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label14.Location = new System.Drawing.Point(430, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "DL";
            // 
            // CL
            // 
            this.CL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.CL.Location = new System.Drawing.Point(430, 105);
            this.CL.Name = "CL";
            this.CL.ReadOnly = true;
            this.CL.Size = new System.Drawing.Size(50, 20);
            this.CL.TabIndex = 27;
            this.CL.Text = "0000";
            this.CL.TextChanged += new System.EventHandler(this.CL_Update);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label15.Location = new System.Drawing.Point(375, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "CH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label16.Location = new System.Drawing.Point(430, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "CL";
            // 
            // BL
            // 
            this.BL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.BL.Location = new System.Drawing.Point(430, 65);
            this.BL.Name = "BL";
            this.BL.ReadOnly = true;
            this.BL.Size = new System.Drawing.Size(50, 20);
            this.BL.TabIndex = 30;
            this.BL.Text = "0000";
            this.BL.TextChanged += new System.EventHandler(this.BL_Update);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label17.Location = new System.Drawing.Point(375, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "BH";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label18.Location = new System.Drawing.Point(429, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "BL";
            // 
            // AL
            // 
            this.AL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.AL.Location = new System.Drawing.Point(430, 25);
            this.AL.Name = "AL";
            this.AL.ReadOnly = true;
            this.AL.Size = new System.Drawing.Size(50, 20);
            this.AL.TabIndex = 33;
            this.AL.Text = "0000";
            this.AL.TextChanged += new System.EventHandler(this.AL_Update);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label19.Location = new System.Drawing.Point(430, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "AL";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label20.Location = new System.Drawing.Point(375, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "AH";
            // 
            // AX_Hex
            // 
            this.AX_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.AX_Hex.Location = new System.Drawing.Point(290, 25);
            this.AX_Hex.Name = "AX_Hex";
            this.AX_Hex.ReadOnly = true;
            this.AX_Hex.Size = new System.Drawing.Size(50, 20);
            this.AX_Hex.TabIndex = 36;
            this.AX_Hex.Text = "00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label21.Location = new System.Drawing.Point(290, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "HEX";
            // 
            // BX_Hex
            // 
            this.BX_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.BX_Hex.Location = new System.Drawing.Point(290, 65);
            this.BX_Hex.Name = "BX_Hex";
            this.BX_Hex.ReadOnly = true;
            this.BX_Hex.Size = new System.Drawing.Size(50, 20);
            this.BX_Hex.TabIndex = 38;
            this.BX_Hex.Text = "00";
            // 
            // CX_Hex
            // 
            this.CX_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.CX_Hex.Location = new System.Drawing.Point(290, 105);
            this.CX_Hex.Name = "CX_Hex";
            this.CX_Hex.ReadOnly = true;
            this.CX_Hex.Size = new System.Drawing.Size(50, 20);
            this.CX_Hex.TabIndex = 39;
            this.CX_Hex.Text = "00";
            // 
            // DX_Hex
            // 
            this.DX_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DX_Hex.Location = new System.Drawing.Point(290, 145);
            this.DX_Hex.Name = "DX_Hex";
            this.DX_Hex.ReadOnly = true;
            this.DX_Hex.Size = new System.Drawing.Size(50, 20);
            this.DX_Hex.TabIndex = 40;
            this.DX_Hex.Text = "00";
            // 
            // BP_Hex
            // 
            this.BP_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.BP_Hex.Location = new System.Drawing.Point(290, 185);
            this.BP_Hex.Name = "BP_Hex";
            this.BP_Hex.ReadOnly = true;
            this.BP_Hex.Size = new System.Drawing.Size(50, 20);
            this.BP_Hex.TabIndex = 41;
            this.BP_Hex.Text = "00";
            // 
            // SP_Hex
            // 
            this.SP_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SP_Hex.Location = new System.Drawing.Point(290, 210);
            this.SP_Hex.Name = "SP_Hex";
            this.SP_Hex.ReadOnly = true;
            this.SP_Hex.Size = new System.Drawing.Size(50, 20);
            this.SP_Hex.TabIndex = 42;
            this.SP_Hex.Text = "00";
            // 
            // SI_Hex
            // 
            this.SI_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SI_Hex.Location = new System.Drawing.Point(290, 235);
            this.SI_Hex.Name = "SI_Hex";
            this.SI_Hex.ReadOnly = true;
            this.SI_Hex.Size = new System.Drawing.Size(50, 20);
            this.SI_Hex.TabIndex = 43;
            this.SI_Hex.Text = "00";
            // 
            // DI_Hex
            // 
            this.DI_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DI_Hex.Location = new System.Drawing.Point(290, 260);
            this.DI_Hex.Name = "DI_Hex";
            this.DI_Hex.ReadOnly = true;
            this.DI_Hex.Size = new System.Drawing.Size(50, 20);
            this.DI_Hex.TabIndex = 44;
            this.DI_Hex.Text = "00";
            // 
            // CS_Hex
            // 
            this.CS_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.CS_Hex.Location = new System.Drawing.Point(290, 285);
            this.CS_Hex.Name = "CS_Hex";
            this.CS_Hex.ReadOnly = true;
            this.CS_Hex.Size = new System.Drawing.Size(50, 20);
            this.CS_Hex.TabIndex = 45;
            this.CS_Hex.Text = "00";
            // 
            // SS_Hex
            // 
            this.SS_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.SS_Hex.Location = new System.Drawing.Point(290, 310);
            this.SS_Hex.Name = "SS_Hex";
            this.SS_Hex.ReadOnly = true;
            this.SS_Hex.Size = new System.Drawing.Size(50, 20);
            this.SS_Hex.TabIndex = 46;
            this.SS_Hex.Text = "00";
            // 
            // DS_Hex
            // 
            this.DS_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.DS_Hex.Location = new System.Drawing.Point(290, 335);
            this.DS_Hex.Name = "DS_Hex";
            this.DS_Hex.ReadOnly = true;
            this.DS_Hex.Size = new System.Drawing.Size(50, 20);
            this.DS_Hex.TabIndex = 47;
            this.DS_Hex.Text = "00";
            // 
            // ES_Hex
            // 
            this.ES_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.ES_Hex.Location = new System.Drawing.Point(290, 360);
            this.ES_Hex.Name = "ES_Hex";
            this.ES_Hex.ReadOnly = true;
            this.ES_Hex.Size = new System.Drawing.Size(50, 20);
            this.ES_Hex.TabIndex = 48;
            this.ES_Hex.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.pictureBox1.Location = new System.Drawing.Point(255, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 477);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 477);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.label22.Location = new System.Drawing.Point(108, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "MOV";
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.White;
            this.input1.Location = new System.Drawing.Point(10, 25);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(240, 20);
            this.input1.TabIndex = 52;
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.Color.White;
            this.input2.Location = new System.Drawing.Point(10, 50);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(240, 20);
            this.input2.TabIndex = 53;
            // 
            // binarne
            // 
            this.binarne.AutoSize = true;
            this.binarne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.binarne.Checked = true;
            this.binarne.Location = new System.Drawing.Point(15, 75);
            this.binarne.Name = "binarne";
            this.binarne.Size = new System.Drawing.Size(93, 17);
            this.binarne.TabIndex = 54;
            this.binarne.TabStop = true;
            this.binarne.Tag = "typ";
            this.binarne.Text = "Liczby binarne";
            this.binarne.UseVisualStyleBackColor = false;
            this.binarne.CheckedChanged += new System.EventHandler(this.numbertype);
            // 
            // dziesietne
            // 
            this.dziesietne.AutoSize = true;
            this.dziesietne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.dziesietne.Location = new System.Drawing.Point(15, 95);
            this.dziesietne.Name = "dziesietne";
            this.dziesietne.Size = new System.Drawing.Size(105, 17);
            this.dziesietne.TabIndex = 55;
            this.dziesietne.Tag = "typ";
            this.dziesietne.Text = "Liczby dziesiętne";
            this.dziesietne.UseVisualStyleBackColor = false;
            this.dziesietne.CheckedChanged += new System.EventHandler(this.numbertype);
            // 
            // hexa
            // 
            this.hexa.AutoSize = true;
            this.hexa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.hexa.Location = new System.Drawing.Point(15, 115);
            this.hexa.Name = "hexa";
            this.hexa.Size = new System.Drawing.Size(138, 17);
            this.hexa.TabIndex = 56;
            this.hexa.Tag = "typ";
            this.hexa.Text = "Liczby heksadecymalne";
            this.hexa.UseVisualStyleBackColor = false;
            this.hexa.CheckedChanged += new System.EventHandler(this.numbertype);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.label23.Location = new System.Drawing.Point(130, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "Wybierz format dla liczb";
            // 
            // wykonaj
            // 
            this.wykonaj.Location = new System.Drawing.Point(15, 180);
            this.wykonaj.Name = "wykonaj";
            this.wykonaj.Size = new System.Drawing.Size(80, 25);
            this.wykonaj.TabIndex = 58;
            this.wykonaj.Text = "Commit";
            this.wykonaj.UseVisualStyleBackColor = true;
            this.wykonaj.Click += new System.EventHandler(this.Submit);
            // 
            // Losuj
            // 
            this.Losuj.Location = new System.Drawing.Point(15, 210);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(80, 25);
            this.Losuj.TabIndex = 59;
            this.Losuj.Text = "Randomize";
            this.Losuj.UseVisualStyleBackColor = true;
            this.Losuj.Click += new System.EventHandler(this.randomize);
            // 
            // Zeruj
            // 
            this.Zeruj.Location = new System.Drawing.Point(15, 240);
            this.Zeruj.Name = "Zeruj";
            this.Zeruj.Size = new System.Drawing.Size(80, 25);
            this.Zeruj.TabIndex = 60;
            this.Zeruj.Text = "Clear";
            this.Zeruj.UseVisualStyleBackColor = true;
            this.Zeruj.Click += new System.EventHandler(this.clear);
            // 
            // error
            // 
            this.error.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(12, 406);
            this.error.Name = "error";
            this.error.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.error.Size = new System.Drawing.Size(237, 32);
            this.error.TabIndex = 61;
            this.error.Text = "Zrobione przez Marcin Jasica - nr 12272";
            // 
            // pole
            // 
            this.pole.AutoSize = true;
            this.pole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(194)))));
            this.pole.Location = new System.Drawing.Point(15, 135);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(76, 17);
            this.pole.TabIndex = 62;
            this.pole.Tag = "typ";
            this.pole.Text = "Inny rejestr";
            this.pole.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 447);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.error);
            this.Controls.Add(this.Zeruj);
            this.Controls.Add(this.Losuj);
            this.Controls.Add(this.wykonaj);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.hexa);
            this.Controls.Add(this.dziesietne);
            this.Controls.Add(this.binarne);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ES_Hex);
            this.Controls.Add(this.DS_Hex);
            this.Controls.Add(this.SS_Hex);
            this.Controls.Add(this.CS_Hex);
            this.Controls.Add(this.DI_Hex);
            this.Controls.Add(this.SI_Hex);
            this.Controls.Add(this.SP_Hex);
            this.Controls.Add(this.BP_Hex);
            this.Controls.Add(this.DX_Hex);
            this.Controls.Add(this.CX_Hex);
            this.Controls.Add(this.BX_Hex);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.AX_Hex);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.AL);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ES);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.DI);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.DH);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.BH);
            this.Controls.Add(this.AH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 486);
            this.MinimumSize = new System.Drawing.Size(516, 486);
            this.Name = "Form1";
            this.Text = "Intel 8086";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AH;
        private System.Windows.Forms.MaskedTextBox BH;
        private System.Windows.Forms.MaskedTextBox CH;
        private System.Windows.Forms.MaskedTextBox DH;
        private System.Windows.Forms.MaskedTextBox BP;
        private System.Windows.Forms.MaskedTextBox SP;
        private System.Windows.Forms.MaskedTextBox SI;
        private System.Windows.Forms.MaskedTextBox DI;
        private System.Windows.Forms.MaskedTextBox CS;
        private System.Windows.Forms.MaskedTextBox SS;
        private System.Windows.Forms.MaskedTextBox DS;
        private System.Windows.Forms.MaskedTextBox ES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox DL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox CL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox BL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AX_Hex;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox BX_Hex;
        private System.Windows.Forms.TextBox CX_Hex;
        private System.Windows.Forms.TextBox DX_Hex;
        private System.Windows.Forms.TextBox BP_Hex;
        private System.Windows.Forms.TextBox SP_Hex;
        private System.Windows.Forms.TextBox SI_Hex;
        private System.Windows.Forms.TextBox DI_Hex;
        private System.Windows.Forms.TextBox CS_Hex;
        private System.Windows.Forms.TextBox SS_Hex;
        private System.Windows.Forms.TextBox DS_Hex;
        private System.Windows.Forms.TextBox ES_Hex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.RadioButton binarne;
        private System.Windows.Forms.RadioButton dziesietne;
        private System.Windows.Forms.RadioButton hexa;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button wykonaj;
        private System.Windows.Forms.Button Losuj;
        private System.Windows.Forms.Button Zeruj;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.RadioButton pole;
    }
}

