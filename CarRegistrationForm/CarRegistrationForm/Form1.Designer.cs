namespace CarRegistrationForm
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
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioOwner = new System.Windows.Forms.RadioButton();
            this.grpBoxCar = new System.Windows.Forms.GroupBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.grpBoxOwner = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.grpBoxCar.SuspendLayout();
            this.grpBoxOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(175, 99);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(41, 17);
            this.radioCar.TabIndex = 0;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Car";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioCar_CheckedChanged);
            // 
            // radioOwner
            // 
            this.radioOwner.AutoSize = true;
            this.radioOwner.Location = new System.Drawing.Point(453, 99);
            this.radioOwner.Name = "radioOwner";
            this.radioOwner.Size = new System.Drawing.Size(56, 17);
            this.radioOwner.TabIndex = 1;
            this.radioOwner.TabStop = true;
            this.radioOwner.Text = "Owner";
            this.radioOwner.UseVisualStyleBackColor = true;
            this.radioOwner.CheckedChanged += new System.EventHandler(this.radioOwner_CheckedChanged);
            // 
            // grpBoxCar
            // 
            this.grpBoxCar.Controls.Add(this.comboBoxYear);
            this.grpBoxCar.Controls.Add(this.comboBoxModel);
            this.grpBoxCar.Controls.Add(this.comboBoxMake);
            this.grpBoxCar.Controls.Add(this.lblYear);
            this.grpBoxCar.Controls.Add(this.lblModel);
            this.grpBoxCar.Controls.Add(this.lblMake);
            this.grpBoxCar.Location = new System.Drawing.Point(70, 183);
            this.grpBoxCar.Name = "grpBoxCar";
            this.grpBoxCar.Size = new System.Drawing.Size(269, 241);
            this.grpBoxCar.TabIndex = 2;
            this.grpBoxCar.TabStop = false;
            this.grpBoxCar.Text = "Car Registration";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(105, 153);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 5;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(105, 93);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 4;
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(105, 23);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMake.TabIndex = 3;
            this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.comboBoxMake_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(28, 156);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(28, 96);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(28, 26);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // grpBoxOwner
            // 
            this.grpBoxOwner.Controls.Add(this.textBoxPhone);
            this.grpBoxOwner.Controls.Add(this.textBoxLName);
            this.grpBoxOwner.Controls.Add(this.textBoxFName);
            this.grpBoxOwner.Controls.Add(this.lblPhone);
            this.grpBoxOwner.Controls.Add(this.lblLName);
            this.grpBoxOwner.Controls.Add(this.lblFName);
            this.grpBoxOwner.Location = new System.Drawing.Point(372, 183);
            this.grpBoxOwner.Name = "grpBoxOwner";
            this.grpBoxOwner.Size = new System.Drawing.Size(251, 241);
            this.grpBoxOwner.TabIndex = 3;
            this.grpBoxOwner.TabStop = false;
            this.grpBoxOwner.Text = "Owner";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 155);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telephone";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(24, 95);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(21, 25);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(175, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(108, 24);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 3;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(108, 92);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(108, 153);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 591);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpBoxOwner);
            this.Controls.Add(this.grpBoxCar);
            this.Controls.Add(this.radioOwner);
            this.Controls.Add(this.radioCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxCar.ResumeLayout(false);
            this.grpBoxCar.PerformLayout();
            this.grpBoxOwner.ResumeLayout(false);
            this.grpBoxOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioOwner;
        private System.Windows.Forms.GroupBox grpBoxCar;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.GroupBox grpBoxOwner;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
    }
}

