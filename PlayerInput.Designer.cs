
namespace ConnectX
{
    partial class PlayerInput
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
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerColourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cancelPIButton = new System.Windows.Forms.Button();
            this.okPIButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(187, 36);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(312, 20);
            this.playerNameTextBox.TabIndex = 0;
            // 
            // playerColourTextBox
            // 
            this.playerColourTextBox.Location = new System.Drawing.Point(187, 86);
            this.playerColourTextBox.Name = "playerColourTextBox";
            this.playerColourTextBox.Size = new System.Drawing.Size(312, 20);
            this.playerColourTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // cancelPIButton
            // 
            this.cancelPIButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelPIButton.Location = new System.Drawing.Point(569, 171);
            this.cancelPIButton.Name = "cancelPIButton";
            this.cancelPIButton.Size = new System.Drawing.Size(64, 29);
            this.cancelPIButton.TabIndex = 4;
            this.cancelPIButton.Text = "Cancel";
            this.cancelPIButton.UseVisualStyleBackColor = true;
            // 
            // okPIButton
            // 
            this.okPIButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okPIButton.Location = new System.Drawing.Point(499, 171);
            this.okPIButton.Name = "okPIButton";
            this.okPIButton.Size = new System.Drawing.Size(64, 29);
            this.okPIButton.TabIndex = 5;
            this.okPIButton.Text = "OK";
            this.okPIButton.UseVisualStyleBackColor = true;
            // 
            // PlayerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 212);
            this.Controls.Add(this.okPIButton);
            this.Controls.Add(this.cancelPIButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerColourTextBox);
            this.Controls.Add(this.playerNameTextBox);
            this.Name = "PlayerInput";
            this.Text = "PlayerInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.TextBox playerColourTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cancelPIButton;
        private System.Windows.Forms.Button okPIButton;
    }
}