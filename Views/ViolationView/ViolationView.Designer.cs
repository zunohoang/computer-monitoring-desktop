namespace computer_monitoring_desktop.Views
{
    partial class ViolationView
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
            pnl_main = new AntdUI.Panel();
            pnl_content = new AntdUI.Panel();
            tbl_violation = new AntdUI.Table();
            pgnViolations = new AntdUI.Pagination();
            slt_allLevel = new AntdUI.Select();
            slt_allStatus = new AntdUI.Select();
            pnl_notification = new AntdUI.Panel();
            pnl_totalviolations = new AntdUI.Panel();
            lbl_violationNumber = new AntdUI.Label();
            lbl_violation = new AntdUI.Label();
            pnl_condition = new AntdUI.Panel();
            lbl_conditionNumber = new AntdUI.Label();
            lbl_condition = new AntdUI.Label();
            pnl_level = new AntdUI.Panel();
            lbl_levelNumber = new AntdUI.Label();
            lbl_level = new AntdUI.Label();
            phd_title = new AntdUI.PageHeader();
            pnl_main.SuspendLayout();
            pnl_content.SuspendLayout();
            pnl_notification.SuspendLayout();
            pnl_totalviolations.SuspendLayout();
            pnl_condition.SuspendLayout();
            pnl_level.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(pnl_content);
            pnl_main.Controls.Add(pnl_notification);
            pnl_main.Controls.Add(phd_title);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1888, 992);
            pnl_main.TabIndex = 0;
            pnl_main.Text = "panel1";
            // 
            // pnl_content
            // 
            pnl_content.Controls.Add(tbl_violation);
            pnl_content.Controls.Add(pgnViolations);
            pnl_content.Controls.Add(slt_allLevel);
            pnl_content.Controls.Add(slt_allStatus);
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(0, 454);
            pnl_content.Margin = new Padding(3, 4, 3, 4);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(1888, 538);
            pnl_content.TabIndex = 8;
            pnl_content.Text = "panel2";
            // 
            // tbl_violation
            // 
            tbl_violation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_violation.Gap = 12;
            tbl_violation.Location = new Point(58, 142);
            tbl_violation.Name = "tbl_violation";
            tbl_violation.Size = new Size(1770, 299);
            tbl_violation.TabIndex = 2;
            tbl_violation.Text = "table1";
            tbl_violation.CellClick += table_violation_CellClick;
            // 
            // pgnViolations
            // 
            pgnViolations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pgnViolations.Location = new Point(1400, 450);
            pgnViolations.Name = "pgnViolations";
            pgnViolations.PageSize = 10;
            pgnViolations.RightToLeft = RightToLeft.Yes;
            pgnViolations.ShowSizeChanger = true;
            pgnViolations.SizeChangerWidth = 50;
            pgnViolations.Size = new Size(428, 40);
            pgnViolations.TabIndex = 3;
            // 
            // slt_allLevel
            // 
            slt_allLevel.Items.AddRange(new object[] { "Tất cả mức độ", "Cao", "Trung bình", "Thấp" });
            slt_allLevel.Location = new Point(493, 21);
            slt_allLevel.Margin = new Padding(3, 4, 3, 4);
            slt_allLevel.Name = "slt_allLevel";
            slt_allLevel.Size = new Size(384, 105);
            slt_allLevel.TabIndex = 1;
            slt_allLevel.Text = "Tất cả mức độ";
            // 
            // slt_allStatus
            // 
            slt_allStatus.Items.AddRange(new object[] { "Tất cả trạng thái", "Đã xử lý", "Chưa xử lý" });
            slt_allStatus.Location = new Point(23, 21);
            slt_allStatus.Margin = new Padding(3, 4, 3, 4);
            slt_allStatus.Name = "slt_allStatus";
            slt_allStatus.Size = new Size(384, 105);
            slt_allStatus.TabIndex = 0;
            slt_allStatus.Text = "Tất cả trạng thái";
            // 
            // pnl_notification
            // 
            pnl_notification.Controls.Add(pnl_totalviolations);
            pnl_notification.Controls.Add(pnl_condition);
            pnl_notification.Controls.Add(pnl_level);
            pnl_notification.Dock = DockStyle.Top;
            pnl_notification.Location = new Point(0, 134);
            pnl_notification.Name = "pnl_notification";
            pnl_notification.Size = new Size(1888, 320);
            pnl_notification.TabIndex = 2;
            pnl_notification.Text = "panel2";
            // 
            // pnl_totalviolations
            // 
            pnl_totalviolations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_totalviolations.BorderWidth = 1F;
            pnl_totalviolations.Controls.Add(lbl_violationNumber);
            pnl_totalviolations.Controls.Add(lbl_violation);
            pnl_totalviolations.Location = new Point(1274, 42);
            pnl_totalviolations.Margin = new Padding(3, 4, 3, 4);
            pnl_totalviolations.Name = "pnl_totalviolations";
            pnl_totalviolations.ShadowColor = Color.FromArgb(0, 0, 0);
            pnl_totalviolations.ShadowOpacity = 0F;
            pnl_totalviolations.ShadowOpacityHover = 0F;
            pnl_totalviolations.Size = new Size(570, 270);
            pnl_totalviolations.TabIndex = 14;
            pnl_totalviolations.Text = "panel2";
            // 
            // lbl_violationNumber
            // 
            lbl_violationNumber.Dock = DockStyle.Fill;
            lbl_violationNumber.Font = new Font("Arial", 21.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_violationNumber.ForeColor = Color.FromArgb(67, 139, 239);
            lbl_violationNumber.Location = new Point(3, 106);
            lbl_violationNumber.Margin = new Padding(3, 4, 3, 4);
            lbl_violationNumber.Name = "lbl_violationNumber";
            lbl_violationNumber.Size = new Size(564, 161);
            lbl_violationNumber.TabIndex = 3;
            lbl_violationNumber.Text = "3";
            lbl_violationNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_violation
            // 
            lbl_violation.Dock = DockStyle.Top;
            lbl_violation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_violation.Location = new Point(3, 3);
            lbl_violation.Margin = new Padding(3, 4, 3, 4);
            lbl_violation.Name = "lbl_violation";
            lbl_violation.Size = new Size(564, 103);
            lbl_violation.TabIndex = 2;
            lbl_violation.Text = "Tổng vi phạm";
            lbl_violation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_condition
            // 
            pnl_condition.BorderWidth = 1F;
            pnl_condition.Controls.Add(lbl_conditionNumber);
            pnl_condition.Controls.Add(lbl_condition);
            pnl_condition.Location = new Point(39, 42);
            pnl_condition.Margin = new Padding(3, 4, 3, 4);
            pnl_condition.Name = "pnl_condition";
            pnl_condition.ShadowColor = Color.FromArgb(0, 0, 0);
            pnl_condition.ShadowOpacity = 0F;
            pnl_condition.ShadowOpacityHover = 0F;
            pnl_condition.Size = new Size(570, 270);
            pnl_condition.TabIndex = 13;
            pnl_condition.Text = "panel2";
            // 
            // lbl_conditionNumber
            // 
            lbl_conditionNumber.Dock = DockStyle.Fill;
            lbl_conditionNumber.Font = new Font("Arial", 21.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_conditionNumber.ForeColor = Color.FromArgb(209, 68, 68);
            lbl_conditionNumber.Location = new Point(3, 137);
            lbl_conditionNumber.Margin = new Padding(3, 4, 3, 4);
            lbl_conditionNumber.Name = "lbl_conditionNumber";
            lbl_conditionNumber.Size = new Size(564, 130);
            lbl_conditionNumber.TabIndex = 1;
            lbl_conditionNumber.Text = "2";
            lbl_conditionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_condition
            // 
            lbl_condition.Dock = DockStyle.Top;
            lbl_condition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_condition.Location = new Point(3, 3);
            lbl_condition.Margin = new Padding(3, 4, 3, 4);
            lbl_condition.Name = "lbl_condition";
            lbl_condition.Size = new Size(564, 134);
            lbl_condition.TabIndex = 0;
            lbl_condition.Text = "Chưa xử lý";
            lbl_condition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_level
            // 
            pnl_level.Anchor = AnchorStyles.Top;
            pnl_level.BorderWidth = 1F;
            pnl_level.Controls.Add(lbl_levelNumber);
            pnl_level.Controls.Add(lbl_level);
            pnl_level.Location = new Point(655, 42);
            pnl_level.Margin = new Padding(3, 4, 3, 4);
            pnl_level.Name = "pnl_level";
            pnl_level.ShadowColor = Color.FromArgb(0, 0, 0);
            pnl_level.ShadowOpacity = 0F;
            pnl_level.ShadowOpacityHover = 0F;
            pnl_level.Size = new Size(570, 270);
            pnl_level.TabIndex = 15;
            pnl_level.Text = "panel2";
            // 
            // lbl_levelNumber
            // 
            lbl_levelNumber.Dock = DockStyle.Fill;
            lbl_levelNumber.Font = new Font("Arial", 21.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_levelNumber.ForeColor = Color.FromArgb(227, 140, 50);
            lbl_levelNumber.Location = new Point(3, 135);
            lbl_levelNumber.Margin = new Padding(3, 4, 3, 4);
            lbl_levelNumber.Name = "lbl_levelNumber";
            lbl_levelNumber.Size = new Size(564, 132);
            lbl_levelNumber.TabIndex = 3;
            lbl_levelNumber.Text = "2";
            lbl_levelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_level
            // 
            lbl_level.Dock = DockStyle.Top;
            lbl_level.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_level.Location = new Point(3, 3);
            lbl_level.Margin = new Padding(3, 4, 3, 4);
            lbl_level.Name = "lbl_level";
            lbl_level.Size = new Size(564, 132);
            lbl_level.TabIndex = 2;
            lbl_level.Text = "Mức độ cao";
            lbl_level.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phd_title
            // 
            phd_title.Dock = DockStyle.Top;
            phd_title.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phd_title.Location = new Point(0, 0);
            phd_title.Margin = new Padding(3, 4, 3, 4);
            phd_title.Name = "phd_title";
            phd_title.Size = new Size(1888, 134);
            phd_title.TabIndex = 1;
            phd_title.Text = "Quản lý Vi phạm";
            // 
            // ViolationView
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_main);
            Name = "ViolationView";
            Size = new Size(1888, 992);
            Load += ViolationView_Load;
            pnl_main.ResumeLayout(false);
            pnl_content.ResumeLayout(false);
            pnl_notification.ResumeLayout(false);
            pnl_totalviolations.ResumeLayout(false);
            pnl_condition.ResumeLayout(false);
            pnl_level.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnl_main;
        private AntdUI.PageHeader phd_title;
        private AntdUI.Panel pnl_notification;
        private AntdUI.Panel pnl_totalviolations;
        private AntdUI.Label lbl_violationNumber;
        private AntdUI.Label lbl_violation;
        private AntdUI.Panel pnl_condition;
        private AntdUI.Label lbl_conditionNumber;
        private AntdUI.Label lbl_condition;
        private AntdUI.Panel pnl_level;
        private AntdUI.Label lbl_levelNumber;
        private AntdUI.Label lbl_level;
        private AntdUI.Panel pnl_content;
        private AntdUI.Table tbl_violation;
        private AntdUI.Pagination pgnViolations;
        private AntdUI.Select slt_allLevel;
        private AntdUI.Select slt_allStatus;
    }
}