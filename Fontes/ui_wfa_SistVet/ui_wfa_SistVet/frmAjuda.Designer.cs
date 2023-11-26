namespace ui_wfa_SistVet
{
    partial class frmAjuda
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
            label1 = new Label();
            linkLabelVideo = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 0;
            label1.Text = "Instruções de uso: ";
            // 
            // linkLabelVideo
            // 
            linkLabelVideo.AutoSize = true;
            linkLabelVideo.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelVideo.Location = new Point(174, 44);
            linkLabelVideo.Name = "linkLabelVideo";
            linkLabelVideo.Size = new Size(94, 17);
            linkLabelVideo.TabIndex = 1;
            linkLabelVideo.TabStop = true;
            linkLabelVideo.Text = "Video Tutorial";
            linkLabelVideo.LinkClicked += linkLabelVideo_LinkClicked;
            // 
            // frmAjuda
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 101);
            Controls.Add(linkLabelVideo);
            Controls.Add(label1);
            Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAjuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Video Tutorial :::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabelVideo;
    }
}