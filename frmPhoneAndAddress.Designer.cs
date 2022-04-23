
namespace BMICalc
{
    partial class frmPhoneAndAddress
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.msktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddPhoneAndAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 34);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // msktxtPhone
            // 
            this.msktxtPhone.Location = new System.Drawing.Point(63, 31);
            this.msktxtPhone.Mask = "(999) 000-0000";
            this.msktxtPhone.Name = "msktxtPhone";
            this.msktxtPhone.Size = new System.Drawing.Size(100, 20);
            this.msktxtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(63, 69);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // btnAddPhoneAndAddress
            // 
            this.btnAddPhoneAndAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddPhoneAndAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoneAndAddress.Location = new System.Drawing.Point(262, 31);
            this.btnAddPhoneAndAddress.Name = "btnAddPhoneAndAddress";
            this.btnAddPhoneAndAddress.Size = new System.Drawing.Size(102, 54);
            this.btnAddPhoneAndAddress.TabIndex = 4;
            this.btnAddPhoneAndAddress.Text = "ADD";
            this.btnAddPhoneAndAddress.UseVisualStyleBackColor = false;
            // 
            // frmPhoneAndAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 117);
            this.Controls.Add(this.btnAddPhoneAndAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.msktxtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Name = "frmPhoneAndAddress";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.MaskedTextBox msktxtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddPhoneAndAddress;
    }
}