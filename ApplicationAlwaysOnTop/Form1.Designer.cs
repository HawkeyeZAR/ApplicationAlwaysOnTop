
namespace ActiveProcessWindowUtils
{
    partial class updateCEWindowForm
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
            this.radioButtonSetTop = new System.Windows.Forms.RadioButton();
            this.radioButtonSetNotTop = new System.Windows.Forms.RadioButton();
            this.trackBarOpaque = new System.Windows.Forms.TrackBar();
            this.opaqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpaque)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonSetTop
            // 
            this.radioButtonSetTop.AutoSize = true;
            this.radioButtonSetTop.Location = new System.Drawing.Point(16, 59);
            this.radioButtonSetTop.Name = "radioButtonSetTop";
            this.radioButtonSetTop.Size = new System.Drawing.Size(105, 20);
            this.radioButtonSetTop.TabIndex = 0;
            this.radioButtonSetTop.Text = "Set TopMost";
            this.radioButtonSetTop.UseVisualStyleBackColor = true;
            this.radioButtonSetTop.CheckedChanged += new System.EventHandler(this.radioButtonSetTop_CheckedChanged);
            // 
            // radioButtonSetNotTop
            // 
            this.radioButtonSetNotTop.AutoSize = true;
            this.radioButtonSetNotTop.Location = new System.Drawing.Point(148, 58);
            this.radioButtonSetNotTop.Name = "radioButtonSetNotTop";
            this.radioButtonSetNotTop.Size = new System.Drawing.Size(120, 20);
            this.radioButtonSetNotTop.TabIndex = 1;
            this.radioButtonSetNotTop.Text = "Unset TopMost";
            this.radioButtonSetNotTop.UseVisualStyleBackColor = true;
            this.radioButtonSetNotTop.CheckedChanged += new System.EventHandler(this.radioButtonSetNotTop_CheckedChanged);
            // 
            // trackBarOpaque
            // 
            this.trackBarOpaque.Location = new System.Drawing.Point(12, 101);
            this.trackBarOpaque.Maximum = 225;
            this.trackBarOpaque.Name = "trackBarOpaque";
            this.trackBarOpaque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarOpaque.Size = new System.Drawing.Size(348, 56);
            this.trackBarOpaque.TabIndex = 2;
            this.trackBarOpaque.Scroll += new System.EventHandler(this.trackBarOpaque_Scroll);
            // 
            // opaqueLabel
            // 
            this.opaqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueLabel.Location = new System.Drawing.Point(9, 91);
            this.opaqueLabel.Name = "opaqueLabel";
            this.opaqueLabel.Size = new System.Drawing.Size(348, 16);
            this.opaqueLabel.TabIndex = 3;
            this.opaqueLabel.Text = "Transparency";
            this.opaqueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateCEWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(373, 141);
            this.Controls.Add(this.opaqueLabel);
            this.Controls.Add(this.trackBarOpaque);
            this.Controls.Add(this.radioButtonSetNotTop);
            this.Controls.Add(this.radioButtonSetTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "updateCEWindowForm";
            this.Text = "Change Apps Window Property";
            this.Load += new System.EventHandler(this.updateCEWindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSetTop;
        private System.Windows.Forms.RadioButton radioButtonSetNotTop;
        private System.Windows.Forms.TrackBar trackBarOpaque;
        private System.Windows.Forms.Label opaqueLabel;
    }
}

