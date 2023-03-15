namespace Lantz_GUIFarmerGame
{
    partial class FormGameLogic
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSouthBank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxNorthBank = new System.Windows.Forms.TextBox();
            this.txtBxSouthBank = new System.Windows.Forms.TextBox();
            this.lblFarmerLocation = new System.Windows.Forms.Label();
            this.lblGetFarmerLocation = new System.Windows.Forms.Label();
            this.lblSecFarmerLocation = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.btnOkGameScreen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLeaveBlank = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitle.Location = new System.Drawing.Point(294, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Farmer Game";
            // 
            // lblSouthBank
            // 
            this.lblSouthBank.AutoSize = true;
            this.lblSouthBank.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouthBank.Location = new System.Drawing.Point(88, 224);
            this.lblSouthBank.Name = "lblSouthBank";
            this.lblSouthBank.Size = new System.Drawing.Size(133, 29);
            this.lblSouthBank.TabIndex = 1;
            this.lblSouthBank.Text = "South Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "North Bank";
            // 
            // txtBxNorthBank
            // 
            this.txtBxNorthBank.Location = new System.Drawing.Point(94, 165);
            this.txtBxNorthBank.Name = "txtBxNorthBank";
            this.txtBxNorthBank.ReadOnly = true;
            this.txtBxNorthBank.Size = new System.Drawing.Size(189, 26);
            this.txtBxNorthBank.TabIndex = 2;
            this.txtBxNorthBank.Text = " Fox Chicken Grain";
            // 
            // txtBxSouthBank
            // 
            this.txtBxSouthBank.Location = new System.Drawing.Point(94, 256);
            this.txtBxSouthBank.Name = "txtBxSouthBank";
            this.txtBxSouthBank.ReadOnly = true;
            this.txtBxSouthBank.Size = new System.Drawing.Size(189, 26);
            this.txtBxSouthBank.TabIndex = 2;
            // 
            // lblFarmerLocation
            // 
            this.lblFarmerLocation.AutoSize = true;
            this.lblFarmerLocation.Location = new System.Drawing.Point(90, 329);
            this.lblFarmerLocation.Name = "lblFarmerLocation";
            this.lblFarmerLocation.Size = new System.Drawing.Size(157, 22);
            this.lblFarmerLocation.TabIndex = 3;
            this.lblFarmerLocation.Text = "The farmer is on the";
            // 
            // lblGetFarmerLocation
            // 
            this.lblGetFarmerLocation.AutoSize = true;
            this.lblGetFarmerLocation.ForeColor = System.Drawing.Color.Red;
            this.lblGetFarmerLocation.Location = new System.Drawing.Point(242, 329);
            this.lblGetFarmerLocation.Name = "lblGetFarmerLocation";
            this.lblGetFarmerLocation.Size = new System.Drawing.Size(50, 22);
            this.lblGetFarmerLocation.TabIndex = 4;
            this.lblGetFarmerLocation.Text = "North";
            // 
            // lblSecFarmerLocation
            // 
            this.lblSecFarmerLocation.AutoSize = true;
            this.lblSecFarmerLocation.Location = new System.Drawing.Point(288, 329);
            this.lblSecFarmerLocation.Name = "lblSecFarmerLocation";
            this.lblSecFarmerLocation.Size = new System.Drawing.Size(136, 22);
            this.lblSecFarmerLocation.TabIndex = 5;
            this.lblSecFarmerLocation.Text = "bank of the river.";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(90, 366);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(287, 22);
            this.lblChoose.TabIndex = 6;
            this.lblChoose.Text = "Choose the next item for the farmer.  ";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Items.AddRange(new object[] {
            "Chicken",
            "Grain",
            "Fox"});
            this.comboBoxChoose.Location = new System.Drawing.Point(94, 468);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(162, 30);
            this.comboBoxChoose.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comboBoxChoose, "You can delete your choice if \r\nyou want to leave it blank");
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // btnOkGameScreen
            // 
            this.btnOkGameScreen.Location = new System.Drawing.Point(362, 468);
            this.btnOkGameScreen.Name = "btnOkGameScreen";
            this.btnOkGameScreen.Size = new System.Drawing.Size(128, 30);
            this.btnOkGameScreen.TabIndex = 8;
            this.btnOkGameScreen.Text = "Ok";
            this.btnOkGameScreen.UseVisualStyleBackColor = true;
            this.btnOkGameScreen.Click += new System.EventHandler(this.btnOkGameScreen_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lblLeaveBlank
            // 
            this.lblLeaveBlank.AutoSize = true;
            this.lblLeaveBlank.Location = new System.Drawing.Point(90, 411);
            this.lblLeaveBlank.Name = "lblLeaveBlank";
            this.lblLeaveBlank.Size = new System.Drawing.Size(527, 22);
            this.lblLeaveBlank.TabIndex = 9;
            this.lblLeaveBlank.Text = "If you want to move the farmer, just leave the form blank and press \'Ok\'";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(94, 527);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(127, 39);
            this.btnPlayAgain.TabIndex = 10;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(362, 527);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(127, 39);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            // 
            // FormGameLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(936, 593);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLeaveBlank);
            this.Controls.Add(this.btnOkGameScreen);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblSecFarmerLocation);
            this.Controls.Add(this.lblGetFarmerLocation);
            this.Controls.Add(this.lblFarmerLocation);
            this.Controls.Add(this.txtBxSouthBank);
            this.Controls.Add(this.txtBxNorthBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSouthBank);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGameLogic";
            this.Text = "Form Game Logic";
            this.Load += new System.EventHandler(this.FormGameLogic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSouthBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNorthBank;
        private System.Windows.Forms.TextBox txtBxSouthBank;
        private System.Windows.Forms.Label lblFarmerLocation;
        private System.Windows.Forms.Label lblGetFarmerLocation;
        private System.Windows.Forms.Label lblSecFarmerLocation;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Button btnOkGameScreen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLeaveBlank;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
    }
}

