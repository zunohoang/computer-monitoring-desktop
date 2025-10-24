namespace computer_monitoring_desktop.Views
{
    partial class MainForm
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
            pnlMain = new AntdUI.Panel();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(27, 26);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(737, 394);
            pnlMain.TabIndex = 0;
            pnlMain.Text = "panel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Name = "MainForm";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnlMain;
    }
}