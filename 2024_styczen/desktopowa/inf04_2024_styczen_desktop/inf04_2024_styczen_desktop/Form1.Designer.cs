namespace inf04_2024_styczen_desktop
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.groupBoxEyeColor = new System.Windows.Forms.GroupBox();
            this.radioButtonPiwne = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.pictureBoxObraz = new System.Windows.Forms.PictureBox();
            this.pictureBoxOdcisk = new System.Windows.Forms.PictureBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxEyeColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdcisk)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(31, 53);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(38, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Numer";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Imie";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(31, 130);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Nazwisko";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.Azure;
            this.textBoxNumber.Location = new System.Drawing.Point(114, 50);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(252, 20);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.Leave += new System.EventHandler(this.textBoxNumber_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Azure;
            this.textBoxName.Location = new System.Drawing.Point(114, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.Azure;
            this.textBoxSurname.Location = new System.Drawing.Point(114, 127);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(252, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // groupBoxEyeColor
            // 
            this.groupBoxEyeColor.Controls.Add(this.radioButtonPiwne);
            this.groupBoxEyeColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxEyeColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxEyeColor.Location = new System.Drawing.Point(34, 183);
            this.groupBoxEyeColor.Name = "groupBoxEyeColor";
            this.groupBoxEyeColor.Size = new System.Drawing.Size(352, 155);
            this.groupBoxEyeColor.TabIndex = 6;
            this.groupBoxEyeColor.TabStop = false;
            this.groupBoxEyeColor.Text = "Kolor oczu";
            // 
            // radioButtonPiwne
            // 
            this.radioButtonPiwne.AutoSize = true;
            this.radioButtonPiwne.Location = new System.Drawing.Point(7, 68);
            this.radioButtonPiwne.Name = "radioButtonPiwne";
            this.radioButtonPiwne.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPiwne.TabIndex = 2;
            this.radioButtonPiwne.Text = "piwne";
            this.radioButtonPiwne.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 44);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(58, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.Text = "zielone";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Checked = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 20);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(72, 17);
            this.radioButtonBlue.TabIndex = 0;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "niebieskie";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // pictureBoxObraz
            // 
            this.pictureBoxObraz.Image = global::inf04_2024_styczen_desktop.Properties.Resources._000_zdjecie;
            this.pictureBoxObraz.Location = new System.Drawing.Point(419, 50);
            this.pictureBoxObraz.Name = "pictureBoxObraz";
            this.pictureBoxObraz.Size = new System.Drawing.Size(150, 180);
            this.pictureBoxObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObraz.TabIndex = 7;
            this.pictureBoxObraz.TabStop = false;
            // 
            // pictureBoxOdcisk
            // 
            this.pictureBoxOdcisk.Image = global::inf04_2024_styczen_desktop.Properties.Resources._000_odcisk;
            this.pictureBoxOdcisk.Location = new System.Drawing.Point(615, 50);
            this.pictureBoxOdcisk.Name = "pictureBoxOdcisk";
            this.pictureBoxOdcisk.Size = new System.Drawing.Size(150, 180);
            this.pictureBoxOdcisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdcisk.TabIndex = 8;
            this.pictureBoxOdcisk.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Azure;
            this.buttonSubmit.Location = new System.Drawing.Point(461, 267);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(269, 42);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "OK";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.pictureBoxOdcisk);
            this.Controls.Add(this.pictureBoxObraz);
            this.Controls.Add(this.groupBoxEyeColor);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNumber);
            this.Name = "Form1";
            this.Text = "Wprowadzenie danych do paszportu. Wykonał: 000000001";
            this.groupBoxEyeColor.ResumeLayout(false);
            this.groupBoxEyeColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdcisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.GroupBox groupBoxEyeColor;
        private System.Windows.Forms.PictureBox pictureBoxObraz;
        private System.Windows.Forms.PictureBox pictureBoxOdcisk;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RadioButton radioButtonPiwne;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
    }
}

