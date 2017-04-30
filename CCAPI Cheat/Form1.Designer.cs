namespace CCAPI_Cheat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.gbCheats = new System.Windows.Forms.GroupBox();
            this.butApplyCheat = new System.Windows.Forms.Button();
            this.labelChea = new System.Windows.Forms.Label();
            this.comboCheats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGames = new System.Windows.Forms.ComboBox();
            this.groupConnect = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BoxIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbCheats.SuspendLayout();
            this.groupConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbCheats
            // 
            this.gbCheats.Controls.Add(this.label8);
            this.gbCheats.Controls.Add(this.butApplyCheat);
            this.gbCheats.Controls.Add(this.labelChea);
            this.gbCheats.Controls.Add(this.comboCheats);
            this.gbCheats.Controls.Add(this.label1);
            this.gbCheats.Controls.Add(this.comboGames);
            this.gbCheats.Enabled = false;
            this.gbCheats.Location = new System.Drawing.Point(12, 150);
            this.gbCheats.Name = "gbCheats";
            this.gbCheats.Size = new System.Drawing.Size(521, 235);
            this.gbCheats.TabIndex = 12;
            this.gbCheats.TabStop = false;
            this.gbCheats.Text = "Cheats";
            this.gbCheats.Enter += new System.EventHandler(this.gbCheats_Enter);
            // 
            // butApplyCheat
            // 
            this.butApplyCheat.Location = new System.Drawing.Point(368, 158);
            this.butApplyCheat.Name = "butApplyCheat";
            this.butApplyCheat.Size = new System.Drawing.Size(138, 23);
            this.butApplyCheat.TabIndex = 5;
            this.butApplyCheat.Text = "Apply Selected Cheat";
            this.butApplyCheat.UseVisualStyleBackColor = true;
            this.butApplyCheat.Click += new System.EventHandler(this.butApplyCheat_Click);
            // 
            // labelChea
            // 
            this.labelChea.AutoSize = true;
            this.labelChea.Location = new System.Drawing.Point(38, 119);
            this.labelChea.Name = "labelChea";
            this.labelChea.Size = new System.Drawing.Size(38, 13);
            this.labelChea.TabIndex = 4;
            this.labelChea.Text = "Cheat:";
            // 
            // comboCheats
            // 
            this.comboCheats.FormattingEnabled = true;
            this.comboCheats.Location = new System.Drawing.Point(82, 116);
            this.comboCheats.Name = "comboCheats";
            this.comboCheats.Size = new System.Drawing.Size(424, 21);
            this.comboCheats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game:";
            // 
            // comboGames
            // 
            this.comboGames.FormattingEnabled = true;
            this.comboGames.Location = new System.Drawing.Point(82, 69);
            this.comboGames.Name = "comboGames";
            this.comboGames.Size = new System.Drawing.Size(424, 21);
            this.comboGames.TabIndex = 1;
            this.comboGames.SelectedIndexChanged += new System.EventHandler(this.comboGames_SelectedIndexChanged);
            // 
            // groupConnect
            // 
            this.groupConnect.Controls.Add(this.label7);
            this.groupConnect.Controls.Add(this.label6);
            this.groupConnect.Controls.Add(this.label5);
            this.groupConnect.Controls.Add(this.label4);
            this.groupConnect.Controls.Add(this.label3);
            this.groupConnect.Controls.Add(this.label2);
            this.groupConnect.Controls.Add(this.btnConnect);
            this.groupConnect.Controls.Add(this.BoxIP);
            this.groupConnect.Controls.Add(this.lblIP);
            this.groupConnect.Location = new System.Drawing.Point(12, 12);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Size = new System.Drawing.Size(520, 132);
            this.groupConnect.TabIndex = 11;
            this.groupConnect.TabStop = false;
            this.groupConnect.Text = "Connection (CCAPI 2.7)";
            this.groupConnect.Enter += new System.EventHandler(this.groupConnect_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(258, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BoxIP
            // 
            this.BoxIP.Location = new System.Drawing.Point(74, 19);
            this.BoxIP.Name = "BoxIP";
            this.BoxIP.Size = new System.Drawing.Size(178, 20);
            this.BoxIP.TabIndex = 1;
            this.BoxIP.Text = "192.168.1.91";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(22, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(46, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "PS3 IP :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Credits: Barthen for Original Code.\r\nXex for Update Code to CCAPI 2.7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbCheats);
            this.Controls.Add(this.groupConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CCCheaterX for CCApi 2.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCheats.ResumeLayout(false);
            this.gbCheats.PerformLayout();
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbCheats;
        private System.Windows.Forms.Button butApplyCheat;
        private System.Windows.Forms.Label labelChea;
        private System.Windows.Forms.ComboBox comboCheats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGames;
        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox BoxIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

