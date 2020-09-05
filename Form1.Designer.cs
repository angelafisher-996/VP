namespace GameSudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnnewgame = new System.Windows.Forms.Button();
            this.lblevel = new System.Windows.Forms.Label();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(69, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 371);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "СУДОКУ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(581, 250);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(110, 39);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "ПРОВЕРКА";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(581, 192);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(110, 41);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "РЕСЕТИРАЈ";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnnewgame
            // 
            this.btnnewgame.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewgame.Location = new System.Drawing.Point(580, 131);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(110, 41);
            this.btnnewgame.TabIndex = 4;
            this.btnnewgame.Text = "НОВА ИГРА";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // lblevel
            // 
            this.lblevel.AutoSize = true;
            this.lblevel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevel.Location = new System.Drawing.Point(520, 48);
            this.lblevel.Name = "lblevel";
            this.lblevel.Size = new System.Drawing.Size(52, 20);
            this.lblevel.TabIndex = 6;
            this.lblevel.Text = "Ниво:";
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(581, 94);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(58, 17);
            this.radioButtonHard.TabIndex = 7;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Тешко";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(581, 71);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 8;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Средно";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(581, 48);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(57, 17);
            this.radioButtonEasy.TabIndex = 9;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Лесно";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonEasy);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonHard);
            this.Controls.Add(this.lblevel);
            this.Controls.Add(this.btnnewgame);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.Label lblevel;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
    }
}

