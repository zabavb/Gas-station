namespace Fourth_lesson_csh_wf
{
    partial class Form1
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
            this.splitContainerTopRight = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.groupBoxGasStation = new System.Windows.Forms.GroupBox();
            this.labelGrn1 = new System.Windows.Forms.Label();
            this.groupBoxToPayOrToIssue = new System.Windows.Forms.GroupBox();
            this.labelGrnOrL = new System.Windows.Forms.Label();
            this.labelToPay = new System.Windows.Forms.Label();
            this.groupBoxNumberSum = new System.Windows.Forms.GroupBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.labelGrn2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelL = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelFuel = new System.Windows.Forms.Label();
            this.groupBoxMiniCafe = new System.Windows.Forms.GroupBox();
            this.textBoxFrenchFriesNumber = new System.Windows.Forms.TextBox();
            this.textBoxCocaColaNumber = new System.Windows.Forms.TextBox();
            this.textBoxHamburgerNumber = new System.Windows.Forms.TextBox();
            this.textBoxHotDogNumber = new System.Windows.Forms.TextBox();
            this.textBoxFrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.textBoxCocaColaPrice = new System.Windows.Forms.TextBox();
            this.textBoxHamburgerPrice = new System.Windows.Forms.TextBox();
            this.textBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.groupBoxToPay2 = new System.Windows.Forms.GroupBox();
            this.labelGrn3 = new System.Windows.Forms.Label();
            this.labelToPay2 = new System.Windows.Forms.Label();
            this.checkBoxCocaCola = new System.Windows.Forms.CheckBox();
            this.checkBoxFrenchFries = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBoxAllDue = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelGrn4 = new System.Windows.Forms.Label();
            this.labelAllDue = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopRight)).BeginInit();
            this.splitContainerTopRight.Panel1.SuspendLayout();
            this.splitContainerTopRight.Panel2.SuspendLayout();
            this.splitContainerTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.groupBoxGasStation.SuspendLayout();
            this.groupBoxToPayOrToIssue.SuspendLayout();
            this.groupBoxNumberSum.SuspendLayout();
            this.groupBoxMiniCafe.SuspendLayout();
            this.groupBoxToPay2.SuspendLayout();
            this.groupBoxAllDue.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerTopRight
            // 
            this.splitContainerTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTopRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTopRight.Name = "splitContainerTopRight";
            this.splitContainerTopRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTopRight.Panel1
            // 
            this.splitContainerTopRight.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainerTopRight.Panel2
            // 
            this.splitContainerTopRight.Panel2.Controls.Add(this.groupBoxAllDue);
            this.splitContainerTopRight.Size = new System.Drawing.Size(827, 515);
            this.splitContainerTopRight.SplitterDistance = 347;
            this.splitContainerTopRight.TabIndex = 0;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.groupBoxGasStation);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainerTop.Panel2.Controls.Add(this.groupBoxMiniCafe);
            this.splitContainerTop.Size = new System.Drawing.Size(851, 344);
            this.splitContainerTop.SplitterDistance = 315;
            this.splitContainerTop.SplitterWidth = 6;
            this.splitContainerTop.TabIndex = 0;
            // 
            // groupBoxGasStation
            // 
            this.groupBoxGasStation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxGasStation.Controls.Add(this.labelGrn1);
            this.groupBoxGasStation.Controls.Add(this.groupBoxToPayOrToIssue);
            this.groupBoxGasStation.Controls.Add(this.groupBoxNumberSum);
            this.groupBoxGasStation.Controls.Add(this.textBoxPrice);
            this.groupBoxGasStation.Controls.Add(this.labelPrice);
            this.groupBoxGasStation.Controls.Add(this.comboBoxFuel);
            this.groupBoxGasStation.Controls.Add(this.labelFuel);
            this.groupBoxGasStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxGasStation.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGasStation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGasStation.Name = "groupBoxGasStation";
            this.groupBoxGasStation.Size = new System.Drawing.Size(456, 344);
            this.groupBoxGasStation.TabIndex = 0;
            this.groupBoxGasStation.TabStop = false;
            this.groupBoxGasStation.Text = "Gas station";
            // 
            // labelGrn1
            // 
            this.labelGrn1.AutoSize = true;
            this.labelGrn1.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelGrn1.Location = new System.Drawing.Point(328, 77);
            this.labelGrn1.Name = "labelGrn1";
            this.labelGrn1.Size = new System.Drawing.Size(57, 25);
            this.labelGrn1.TabIndex = 9;
            this.labelGrn1.Text = "UAH";
            // 
            // groupBoxToPayOrToIssue
            // 
            this.groupBoxToPayOrToIssue.Controls.Add(this.labelGrnOrL);
            this.groupBoxToPayOrToIssue.Controls.Add(this.labelToPay);
            this.groupBoxToPayOrToIssue.Location = new System.Drawing.Point(27, 243);
            this.groupBoxToPayOrToIssue.Name = "groupBoxToPayOrToIssue";
            this.groupBoxToPayOrToIssue.Size = new System.Drawing.Size(354, 91);
            this.groupBoxToPayOrToIssue.TabIndex = 0;
            this.groupBoxToPayOrToIssue.TabStop = false;
            this.groupBoxToPayOrToIssue.Text = "To pay";
            // 
            // labelGrnOrL
            // 
            this.labelGrnOrL.AutoSize = true;
            this.labelGrnOrL.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelGrnOrL.Location = new System.Drawing.Point(301, 34);
            this.labelGrnOrL.Name = "labelGrnOrL";
            this.labelGrnOrL.Size = new System.Drawing.Size(57, 25);
            this.labelGrnOrL.TabIndex = 9;
            this.labelGrnOrL.Text = "UAH";
            // 
            // labelToPay
            // 
            this.labelToPay.Font = new System.Drawing.Font("Verdana", 24.2F);
            this.labelToPay.Location = new System.Drawing.Point(21, 24);
            this.labelToPay.Name = "labelToPay";
            this.labelToPay.Size = new System.Drawing.Size(280, 50);
            this.labelToPay.TabIndex = 0;
            this.labelToPay.Text = "0";
            this.labelToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxNumberSum
            // 
            this.groupBoxNumberSum.Controls.Add(this.radioButtonSum);
            this.groupBoxNumberSum.Controls.Add(this.radioButtonNumber);
            this.groupBoxNumberSum.Controls.Add(this.labelGrn2);
            this.groupBoxNumberSum.Controls.Add(this.textBoxNumber);
            this.groupBoxNumberSum.Controls.Add(this.labelL);
            this.groupBoxNumberSum.Controls.Add(this.textBoxSum);
            this.groupBoxNumberSum.Location = new System.Drawing.Point(27, 118);
            this.groupBoxNumberSum.Name = "groupBoxNumberSum";
            this.groupBoxNumberSum.Size = new System.Drawing.Size(354, 105);
            this.groupBoxNumberSum.TabIndex = 4;
            this.groupBoxNumberSum.TabStop = false;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.radioButtonSum.Location = new System.Drawing.Point(30, 62);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(70, 24);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Sum";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.radioButtonNumber.Location = new System.Drawing.Point(30, 22);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(99, 24);
            this.radioButtonNumber.TabIndex = 0;
            this.radioButtonNumber.TabStop = true;
            this.radioButtonNumber.Text = "Number";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            this.radioButtonNumber.CheckedChanged += new System.EventHandler(this.radioButtonNumber_CheckedChanged);
            // 
            // labelGrn2
            // 
            this.labelGrn2.AutoSize = true;
            this.labelGrn2.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelGrn2.Location = new System.Drawing.Point(301, 61);
            this.labelGrn2.Name = "labelGrn2";
            this.labelGrn2.Size = new System.Drawing.Size(57, 25);
            this.labelGrn2.TabIndex = 8;
            this.labelGrn2.Text = "UAH";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxNumber.Location = new System.Drawing.Point(187, 18);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(114, 28);
            this.textBoxNumber.TabIndex = 5;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelL.Location = new System.Drawing.Point(301, 21);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(18, 25);
            this.labelL.TabIndex = 7;
            this.labelL.Text = "l";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(187, 58);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(114, 28);
            this.textBoxSum.TabIndex = 6;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxPrice.Location = new System.Drawing.Point(89, 74);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(239, 28);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(22, 77);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 25);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxFuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(89, 36);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(292, 28);
            this.comboBoxFuel.TabIndex = 1;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenzin_SelectedIndexChanged);
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuel.Location = new System.Drawing.Point(22, 39);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(55, 25);
            this.labelFuel.TabIndex = 0;
            this.labelFuel.Text = "Fuel";
            // 
            // groupBoxMiniCafe
            // 
            this.groupBoxMiniCafe.Controls.Add(this.textBoxFrenchFriesNumber);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxCocaColaNumber);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHamburgerNumber);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHotDogNumber);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxFrenchFriesPrice);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxCocaColaPrice);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHamburgerPrice);
            this.groupBoxMiniCafe.Controls.Add(this.textBoxHotDogPrice);
            this.groupBoxMiniCafe.Controls.Add(this.labelNumber2);
            this.groupBoxMiniCafe.Controls.Add(this.labelPrice2);
            this.groupBoxMiniCafe.Controls.Add(this.groupBoxToPay2);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxCocaCola);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxFrenchFries);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxHamburger);
            this.groupBoxMiniCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxMiniCafe.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMiniCafe.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBoxMiniCafe.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMiniCafe.Name = "groupBoxMiniCafe";
            this.groupBoxMiniCafe.Size = new System.Drawing.Size(425, 344);
            this.groupBoxMiniCafe.TabIndex = 0;
            this.groupBoxMiniCafe.TabStop = false;
            this.groupBoxMiniCafe.Text = "Mini cafe";
            // 
            // textBoxFrenchFriesNumber
            // 
            this.textBoxFrenchFriesNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxFrenchFriesNumber.Enabled = false;
            this.textBoxFrenchFriesNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxFrenchFriesNumber.Location = new System.Drawing.Point(302, 143);
            this.textBoxFrenchFriesNumber.Name = "textBoxFrenchFriesNumber";
            this.textBoxFrenchFriesNumber.Size = new System.Drawing.Size(90, 28);
            this.textBoxFrenchFriesNumber.TabIndex = 21;
            this.textBoxFrenchFriesNumber.TextChanged += new System.EventHandler(this.textBoxFrenchFriesNumber_TextChanged);
            // 
            // textBoxCocaColaNumber
            // 
            this.textBoxCocaColaNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxCocaColaNumber.Enabled = false;
            this.textBoxCocaColaNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxCocaColaNumber.Location = new System.Drawing.Point(302, 176);
            this.textBoxCocaColaNumber.Name = "textBoxCocaColaNumber";
            this.textBoxCocaColaNumber.Size = new System.Drawing.Size(90, 28);
            this.textBoxCocaColaNumber.TabIndex = 20;
            this.textBoxCocaColaNumber.TextChanged += new System.EventHandler(this.textBoxCocaColaNumber_TextChanged);
            // 
            // textBoxHamburgerNumber
            // 
            this.textBoxHamburgerNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxHamburgerNumber.Enabled = false;
            this.textBoxHamburgerNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxHamburgerNumber.Location = new System.Drawing.Point(302, 110);
            this.textBoxHamburgerNumber.Name = "textBoxHamburgerNumber";
            this.textBoxHamburgerNumber.Size = new System.Drawing.Size(90, 28);
            this.textBoxHamburgerNumber.TabIndex = 19;
            this.textBoxHamburgerNumber.TextChanged += new System.EventHandler(this.textBoxHamburgerNumber_TextChanged);
            // 
            // textBoxHotDogNumber
            // 
            this.textBoxHotDogNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxHotDogNumber.Enabled = false;
            this.textBoxHotDogNumber.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxHotDogNumber.Location = new System.Drawing.Point(302, 78);
            this.textBoxHotDogNumber.Name = "textBoxHotDogNumber";
            this.textBoxHotDogNumber.Size = new System.Drawing.Size(90, 28);
            this.textBoxHotDogNumber.TabIndex = 18;
            this.textBoxHotDogNumber.TextChanged += new System.EventHandler(this.textBoxHotDogNumber_TextChanged);
            // 
            // textBoxFrenchFriesPrice
            // 
            this.textBoxFrenchFriesPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFrenchFriesPrice.Enabled = false;
            this.textBoxFrenchFriesPrice.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxFrenchFriesPrice.Location = new System.Drawing.Point(192, 143);
            this.textBoxFrenchFriesPrice.Name = "textBoxFrenchFriesPrice";
            this.textBoxFrenchFriesPrice.ReadOnly = true;
            this.textBoxFrenchFriesPrice.Size = new System.Drawing.Size(90, 28);
            this.textBoxFrenchFriesPrice.TabIndex = 17;
            // 
            // textBoxCocaColaPrice
            // 
            this.textBoxCocaColaPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCocaColaPrice.Enabled = false;
            this.textBoxCocaColaPrice.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxCocaColaPrice.Location = new System.Drawing.Point(192, 176);
            this.textBoxCocaColaPrice.Name = "textBoxCocaColaPrice";
            this.textBoxCocaColaPrice.ReadOnly = true;
            this.textBoxCocaColaPrice.Size = new System.Drawing.Size(90, 28);
            this.textBoxCocaColaPrice.TabIndex = 16;
            // 
            // textBoxHamburgerPrice
            // 
            this.textBoxHamburgerPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHamburgerPrice.Enabled = false;
            this.textBoxHamburgerPrice.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxHamburgerPrice.Location = new System.Drawing.Point(192, 110);
            this.textBoxHamburgerPrice.Name = "textBoxHamburgerPrice";
            this.textBoxHamburgerPrice.ReadOnly = true;
            this.textBoxHamburgerPrice.Size = new System.Drawing.Size(90, 28);
            this.textBoxHamburgerPrice.TabIndex = 13;
            // 
            // textBoxHotDogPrice
            // 
            this.textBoxHotDogPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHotDogPrice.Enabled = false;
            this.textBoxHotDogPrice.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBoxHotDogPrice.Location = new System.Drawing.Point(192, 78);
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.ReadOnly = true;
            this.textBoxHotDogPrice.Size = new System.Drawing.Size(90, 28);
            this.textBoxHotDogPrice.TabIndex = 9;
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Font = new System.Drawing.Font("Verdana", 11F);
            this.labelNumber2.Location = new System.Drawing.Point(304, 52);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(85, 23);
            this.labelNumber2.TabIndex = 11;
            this.labelNumber2.Text = "Number";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Verdana", 11F);
            this.labelPrice2.Location = new System.Drawing.Point(207, 52);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(56, 23);
            this.labelPrice2.TabIndex = 10;
            this.labelPrice2.Text = "Price";
            // 
            // groupBoxToPay2
            // 
            this.groupBoxToPay2.Controls.Add(this.labelGrn3);
            this.groupBoxToPay2.Controls.Add(this.labelToPay2);
            this.groupBoxToPay2.Location = new System.Drawing.Point(38, 243);
            this.groupBoxToPay2.Name = "groupBoxToPay2";
            this.groupBoxToPay2.Size = new System.Drawing.Size(354, 91);
            this.groupBoxToPay2.TabIndex = 10;
            this.groupBoxToPay2.TabStop = false;
            this.groupBoxToPay2.Text = "To pay";
            // 
            // labelGrn3
            // 
            this.labelGrn3.AutoSize = true;
            this.labelGrn3.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelGrn3.Location = new System.Drawing.Point(301, 34);
            this.labelGrn3.Name = "labelGrn3";
            this.labelGrn3.Size = new System.Drawing.Size(57, 25);
            this.labelGrn3.TabIndex = 9;
            this.labelGrn3.Text = "UAH";
            // 
            // labelToPay2
            // 
            this.labelToPay2.Font = new System.Drawing.Font("Verdana", 24.2F);
            this.labelToPay2.Location = new System.Drawing.Point(21, 24);
            this.labelToPay2.Name = "labelToPay2";
            this.labelToPay2.Size = new System.Drawing.Size(280, 50);
            this.labelToPay2.TabIndex = 0;
            this.labelToPay2.Text = "0";
            this.labelToPay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxCocaCola
            // 
            this.checkBoxCocaCola.AutoSize = true;
            this.checkBoxCocaCola.Font = new System.Drawing.Font("Verdana", 11.2F);
            this.checkBoxCocaCola.Location = new System.Drawing.Point(38, 176);
            this.checkBoxCocaCola.Name = "checkBoxCocaCola";
            this.checkBoxCocaCola.Size = new System.Drawing.Size(124, 27);
            this.checkBoxCocaCola.TabIndex = 3;
            this.checkBoxCocaCola.Text = "Coca cola";
            this.checkBoxCocaCola.UseVisualStyleBackColor = true;
            this.checkBoxCocaCola.CheckedChanged += new System.EventHandler(this.checkBoxCocaCola_CheckedChanged);
            // 
            // checkBoxFrenchFries
            // 
            this.checkBoxFrenchFries.AutoSize = true;
            this.checkBoxFrenchFries.Font = new System.Drawing.Font("Verdana", 11.2F);
            this.checkBoxFrenchFries.Location = new System.Drawing.Point(38, 143);
            this.checkBoxFrenchFries.Name = "checkBoxFrenchFries";
            this.checkBoxFrenchFries.Size = new System.Drawing.Size(145, 27);
            this.checkBoxFrenchFries.TabIndex = 2;
            this.checkBoxFrenchFries.Text = "French fries";
            this.checkBoxFrenchFries.UseVisualStyleBackColor = true;
            this.checkBoxFrenchFries.CheckedChanged += new System.EventHandler(this.checkBoxFrenchFries_CheckedChanged);
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Font = new System.Drawing.Font("Verdana", 11.2F);
            this.checkBoxHamburger.Location = new System.Drawing.Point(38, 110);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(138, 27);
            this.checkBoxHamburger.TabIndex = 1;
            this.checkBoxHamburger.Text = "Hamburger";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            this.checkBoxHamburger.CheckedChanged += new System.EventHandler(this.checkBoxHamburger_CheckedChanged);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Font = new System.Drawing.Font("Verdana", 11.2F);
            this.checkBoxHotDog.Location = new System.Drawing.Point(38, 77);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(108, 27);
            this.checkBoxHotDog.TabIndex = 0;
            this.checkBoxHotDog.Text = "Hot dog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // groupBoxAllDue
            // 
            this.groupBoxAllDue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxAllDue.Controls.Add(this.buttonExit);
            this.groupBoxAllDue.Controls.Add(this.labelGrn4);
            this.groupBoxAllDue.Controls.Add(this.labelAllDue);
            this.groupBoxAllDue.Controls.Add(this.buttonCount);
            this.groupBoxAllDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAllDue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBoxAllDue.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAllDue.Name = "groupBoxAllDue";
            this.groupBoxAllDue.Size = new System.Drawing.Size(827, 164);
            this.groupBoxAllDue.TabIndex = 0;
            this.groupBoxAllDue.TabStop = false;
            this.groupBoxAllDue.Text = "All due";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExit.Location = new System.Drawing.Point(683, 57);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 64);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelGrn4
            // 
            this.labelGrn4.AutoSize = true;
            this.labelGrn4.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.labelGrn4.Location = new System.Drawing.Point(583, 75);
            this.labelGrn4.Name = "labelGrn4";
            this.labelGrn4.Size = new System.Drawing.Size(57, 25);
            this.labelGrn4.TabIndex = 10;
            this.labelGrn4.Text = "UAH";
            // 
            // labelAllDue
            // 
            this.labelAllDue.Font = new System.Drawing.Font("Verdana", 24.2F);
            this.labelAllDue.Location = new System.Drawing.Point(297, 47);
            this.labelAllDue.Name = "labelAllDue";
            this.labelAllDue.Size = new System.Drawing.Size(280, 84);
            this.labelAllDue.TabIndex = 10;
            this.labelAllDue.Text = "0";
            this.labelAllDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCount.Location = new System.Drawing.Point(27, 47);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(264, 84);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "COUNT";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 515);
            this.Controls.Add(this.splitContainerTopRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerTopRight.Panel1.ResumeLayout(false);
            this.splitContainerTopRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopRight)).EndInit();
            this.splitContainerTopRight.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.groupBoxGasStation.ResumeLayout(false);
            this.groupBoxGasStation.PerformLayout();
            this.groupBoxToPayOrToIssue.ResumeLayout(false);
            this.groupBoxToPayOrToIssue.PerformLayout();
            this.groupBoxNumberSum.ResumeLayout(false);
            this.groupBoxNumberSum.PerformLayout();
            this.groupBoxMiniCafe.ResumeLayout(false);
            this.groupBoxMiniCafe.PerformLayout();
            this.groupBoxToPay2.ResumeLayout(false);
            this.groupBoxToPay2.PerformLayout();
            this.groupBoxAllDue.ResumeLayout(false);
            this.groupBoxAllDue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTopRight;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.GroupBox groupBoxGasStation;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBoxNumberSum;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.Label labelGrn2;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.GroupBox groupBoxToPayOrToIssue;
        private System.Windows.Forms.Label labelToPay;
        private System.Windows.Forms.Label labelGrn1;
        private System.Windows.Forms.Label labelGrnOrL;
        private System.Windows.Forms.GroupBox groupBoxMiniCafe;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.CheckBox checkBoxHamburger;
        private System.Windows.Forms.CheckBox checkBoxFrenchFries;
        private System.Windows.Forms.CheckBox checkBoxCocaCola;
        private System.Windows.Forms.GroupBox groupBoxToPay2;
        private System.Windows.Forms.Label labelGrn3;
        private System.Windows.Forms.Label labelToPay2;
        private System.Windows.Forms.TextBox textBoxHotDogPrice;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.TextBox textBoxFrenchFriesPrice;
        private System.Windows.Forms.TextBox textBoxCocaColaPrice;
        private System.Windows.Forms.TextBox textBoxHamburgerPrice;
        private System.Windows.Forms.TextBox textBoxFrenchFriesNumber;
        private System.Windows.Forms.TextBox textBoxCocaColaNumber;
        private System.Windows.Forms.TextBox textBoxHamburgerNumber;
        private System.Windows.Forms.TextBox textBoxHotDogNumber;
        private System.Windows.Forms.GroupBox groupBoxAllDue;
        private System.Windows.Forms.Label labelGrn4;
        private System.Windows.Forms.Label labelAllDue;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonExit;
    }
}

