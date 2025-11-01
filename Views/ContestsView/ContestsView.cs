using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Services;

namespace computer_monitoring_desktop.Views
{
    public partial class ContestView : UserControl
    {

        // Pagination state
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalPages = 1;
        private List<(string id, string name, string description, string startTime, string endTime, string status)> allContests;

        private ContestService contestService = new ContestService();

        public ContestView()
        {
            InitializeComponent();
            AddPageSizeInput();
            LoadAllContests();
            RenderCurrentPage();
        }

        private void LoadAllContests()
        {
            // Use ContestService to load contests
            var contests = contestService.GetAllContests();
            allContests = contests.Select(c => (
                c.Id,
                c.Name,
                c.Description,
                c.StartTime.ToString("HH:mm:ss dd/MM/yyyy"),
                c.EndTime.ToString("HH:mm:ss dd/MM/yyyy"),
                c.Status
            )).ToList();
            totalPages = (int)Math.Ceiling(allContests.Count / (double)pageSize);
        }

        private void RenderCurrentPage()
        {
            pnlContestsContainer.Controls.Clear();
            int startIdx = (currentPage - 1) * pageSize;
            int endIdx = Math.Min(startIdx + pageSize, allContests.Count);
            for (int i = startIdx; i < endIdx; i++)
            {
                var c = allContests[i];
                AddContestRow(c.id, c.name, c.description, c.startTime, c.endTime, c.status);
            }
            RenderPagination();
        }

        private void RenderPagination()
        {
            var oldPanel = pnlContestsContainer.Controls.Find("paginationPanel", false);
            if (oldPanel.Length > 0)
                pnlContestsContainer.Controls.Remove(oldPanel[0]);

            var paginationPanel = new System.Windows.Forms.Panel
            {
                Name = "paginationPanel",
                Height = 50,
                Dock = DockStyle.Bottom,
                BackColor = Color.White
            };


            int btnWidth = 40;
            int spacing = 10;
            int x = 10;

            // Page size input
            var lblPageSize = new AntdUI.Label
            {
                Text = "Số dòng:",
                Location = new Point(x, 10),
                Size = new Size(90, 30),
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.Transparent
            };
            paginationPanel.Controls.Add(lblPageSize);
            x += 95;

            var txtPageSize = new AntdUI.Input
            {
                Text = pageSize.ToString(),
                Location = new Point(x, 10),
                Size = new Size(50, 30),
                Font = new Font("Segoe UI", 10F),
                TextAlign = HorizontalAlignment.Center
            };
            txtPageSize.KeyPress += (s, e) =>
            {
                // Only allow digits
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
            txtPageSize.Leave += (s, e) =>
            {
                int newSize;
                if (int.TryParse(txtPageSize.Text, out newSize) && newSize > 0)
                {
                    pageSize = newSize;
                    totalPages = (int)Math.Ceiling(allContests.Count / (double)pageSize);
                    currentPage = 1;
                    RenderCurrentPage();
                }
                else
                {
                    txtPageSize.Text = pageSize.ToString();
                }
            };
            paginationPanel.Controls.Add(txtPageSize);
            x += 60;


            // Previous button
            var btnPrev = new AntdUI.Button
            {
                Text = "<",
                Location = new Point(x, 10),
                Size = new Size(btnWidth, 30),
                Enabled = currentPage > 1
            };
            btnPrev.Click += (s, e) => { currentPage--; RenderCurrentPage(); };
            paginationPanel.Controls.Add(btnPrev);
            x += btnWidth + spacing;

            // Page numbers
            for (int i = 1; i <= totalPages; i++)
            {
                var btnPage = new AntdUI.Button
                {
                    Text = i.ToString(),
                    Location = new Point(x, 10),
                    Size = new Size(btnWidth, 30),
                    Type = i == currentPage ? TTypeMini.Primary : TTypeMini.Default
                };
                int pageNum = i;
                btnPage.Click += (s, e) => { currentPage = pageNum; RenderCurrentPage(); };
                paginationPanel.Controls.Add(btnPage);
                x += btnWidth + spacing;
            }

            // Next button
            var btnNext = new AntdUI.Button
            {
                Text = ">",
                Location = new Point(x, 10),
                Size = new Size(btnWidth, 30),
                Enabled = currentPage < totalPages
            };
            btnNext.Click += (s, e) => { currentPage++; RenderCurrentPage(); };
            paginationPanel.Controls.Add(btnNext);

            pnlContestsContainer.Controls.Add(paginationPanel);
            paginationPanel.BringToFront();
        }


        private void AddContestRow(string id, string name, string description, string startTime, string endTime, string status)
        {
            var rowPanel = new AntdUI.Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(20, 10, 20, 10),
                Back = Color.White
            };

            var lblId = new System.Windows.Forms.Label
            {
                Text = id,
                Location = new Point(10, 20),
                Size = new Size(50, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            var lblName = new System.Windows.Forms.Label
            {
                Text = name,
                Location = new Point(80, 20),
                Size = new Size(250, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            var lblDescription = new System.Windows.Forms.Label
            {
                Text = description.Length > 40 ? description.Substring(0, 40) + "..." : description,
                Location = new Point(350, 20),
                Size = new Size(300, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            // Start Time Label
            var lblStartTime = new System.Windows.Forms.Label
            {
                Text = startTime,
                Location = new Point(760, 20),
                Size = new Size(180, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            // End Time Label
            var lblEndTime = new System.Windows.Forms.Label
            {
                Text = endTime,
                Location = new Point(990, 20),
                Size = new Size(180, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            // Status Label
            var lblStatus = new System.Windows.Forms.Label
            {
                Text = status,
                Location = new Point(1220, 20),
                Size = new Size(100, 20),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            // Action Buttons Container
            var actionPanel = new System.Windows.Forms.Panel
            {
                Location = new Point(1360, 15),
                Size = new Size(229, 30),
                BackColor = Color.Transparent
            };

            // View Button
            var btnView = new AntdUI.Button
            {
                Text = "Xem",
                Type = TTypeMini.Primary,
                Ghost = true,
                Location = new Point(0, 0),
                Size = new Size(60, 30),
                Font = new Font("Segoe UI", 9F),
                IconSvg = "EyeOutlined"
            };
            btnView.Click += (s, e) => ViewContest(id, name);

            // Edit Button
            var btnEdit = new AntdUI.Button
            {
                Text = "Sửa",
                Type = TTypeMini.Warn,
                Ghost = true,
                Location = new Point(70, 0),
                Size = new Size(60, 30),
                Font = new Font("Segoe UI", 9F),
                IconSvg = "EditOutlined"
            };
            btnEdit.Click += (s, e) => EditContest(id);

            // Delete Button
            var btnDelete = new AntdUI.Button
            {
                Text = "Xóa",
                Type = TTypeMini.Error,
                Ghost = true,
                Location = new Point(140, 0),
                Size = new Size(70, 30),
                Font = new Font("Segoe UI", 9F),
                IconSvg = "DeleteOutlined"
            };
            btnDelete.Click += (s, e) => DeleteContest(id);

            rowPanel.Controls.Add(lblId);
            rowPanel.Controls.Add(lblName);
            rowPanel.Controls.Add(lblDescription);
            rowPanel.Controls.Add(lblStartTime);
            rowPanel.Controls.Add(lblEndTime);
            rowPanel.Controls.Add(lblStatus);
            rowPanel.Controls.Add(actionPanel);

            actionPanel.Controls.Add(btnView);
            actionPanel.Controls.Add(btnEdit);
            actionPanel.Controls.Add(btnDelete);

            // Add to the container panel (not the main table panel)
            pnlContestsContainer.Controls.Add(rowPanel);
            rowPanel.BringToFront();
        }

        // Add page size input above table (optional, for initial load)
        private void AddPageSizeInput()
        {
            // Optionally, you can add a page size input above the table if you want it always visible.
            // For now, the input is in the pagination panel below the table.
        }

        private void ViewContest(string id, string name)
        {
            // Navigate to contest details view
            var mainWindow = this.FindForm() as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadContestDetailsView(id, name);
            }
        }

        private void EditContest(string id)
        {
            ShowContestModal("Chỉnh Sửa Cuộc Thi", id, isReadOnly: false);
        }

        private void DeleteContest(string id)
        {
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa cuộc thi {id}?\n\nHành động này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                AntdUI.Message.success(FindForm(), $"Đã xóa cuộc thi {id} thành công!");
                LoadAllContests();
                if (currentPage > totalPages) currentPage = totalPages;
                RenderCurrentPage();
            }
        }

        private void BtnCreateContest_Click(object sender, EventArgs e)
        {
            ShowContestModal("Tạo Cuộc Thi Mới", null, isReadOnly: false);
        }

        private void ShowContestModal(string title, string? contestId, bool isReadOnly)
        {
            // Create modal form
            var modalForm = new Form
            {
                Text = title,
                Width = 700,
                Height = 600,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            // Main panel
            var mainPanel = new System.Windows.Forms.Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(30),
                AutoScroll = true
            };

            int yPos = 10;

            // Contest Name
            var lblName = new AntdUI.Label
            {
                Text = "Tên cuộc thi",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(0, yPos),
                Size = new Size(600, 25)
            };
            mainPanel.Controls.Add(lblName);
            yPos += 30;

            var txtName = new AntdUI.Input
            {
                Location = new Point(0, yPos),
                Size = new Size(600, 40),
                PlaceholderText = "Nhập tên cuộc thi",
                Enabled = !isReadOnly
            };
            if (contestId != null) txtName.Text = $"Cuộc thi số {contestId}";
            mainPanel.Controls.Add(txtName);
            yPos += 50;

            // Description
            var lblDesc = new AntdUI.Label
            {
                Text = "Mô tả",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(0, yPos),
                Size = new Size(600, 25)
            };
            mainPanel.Controls.Add(lblDesc);
            yPos += 30;

            var txtDesc = new AntdUI.Input
            {
                Location = new Point(0, yPos),
                Size = new Size(600, 80),
                PlaceholderText = "Nhập mô tả cuộc thi",
                Multiline = true,
                Enabled = !isReadOnly
            };
            if (contestId != null) txtDesc.Text = "Mô tả chi tiết về cuộc thi";
            mainPanel.Controls.Add(txtDesc);
            yPos += 90;

            // Start Time
            var lblStartTime = new AntdUI.Label
            {
                Text = "Thời gian bắt đầu",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(0, yPos),
                Size = new Size(290, 25)
            };
            mainPanel.Controls.Add(lblStartTime);

            var lblEndTime = new AntdUI.Label
            {
                Text = "Thời gian kết thúc",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(310, yPos),
                Size = new Size(290, 25)
            };
            mainPanel.Controls.Add(lblEndTime);
            yPos += 30;

            var dtpStartTime = new DateTimePicker
            {
                Location = new Point(0, yPos),
                Size = new Size(290, 40),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Enabled = !isReadOnly
            };
            mainPanel.Controls.Add(dtpStartTime);

            var dtpEndTime = new DateTimePicker
            {
                Location = new Point(310, yPos),
                Size = new Size(290, 40),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Enabled = !isReadOnly
            };
            mainPanel.Controls.Add(dtpEndTime);
            yPos += 50;

            // Status
            var lblStatus = new AntdUI.Label
            {
                Text = "Trạng thái",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(0, yPos),
                Size = new Size(600, 25)
            };
            mainPanel.Controls.Add(lblStatus);
            yPos += 30;

            var cboStatus = new ComboBox
            {
                Location = new Point(0, yPos),
                Size = new Size(600, 40),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Enabled = !isReadOnly
            };
            cboStatus.Items.AddRange(new object[] { "Chưa bắt đầu", "Đang diễn ra", "Đã kết thúc" });
            cboStatus.SelectedIndex = 0;
            mainPanel.Controls.Add(cboStatus);
            yPos += 60;

            // Buttons panel
            var btnPanel = new System.Windows.Forms.Panel
            {
                Location = new Point(0, yPos),
                Size = new Size(600, 50)
            };

            if (!isReadOnly)
            {
                var btnSave = new AntdUI.Button
                {
                    Text = contestId == null ? "Tạo mới" : "Lưu thay đổi",
                    Type = AntdUI.TTypeMini.Primary,
                    Location = new Point(400, 0),
                    Size = new Size(120, 40)
                };
                btnSave.Click += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        AntdUI.Message.error(modalForm, "Vui lòng nhập tên cuộc thi!");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtDesc.Text))
                    {
                        AntdUI.Message.error(modalForm, "Vui lòng nhập mô tả!");
                        return;
                    }
                    if (dtpStartTime.Value >= dtpEndTime.Value)
                    {
                        AntdUI.Message.error(modalForm, "Thời gian kết thúc phải sau thời gian bắt đầu!");
                        return;
                    }

                    modalForm.DialogResult = DialogResult.OK;
                    AntdUI.Message.success(FindForm(), contestId == null ? "Tạo cuộc thi thành công!" : "Cập nhật cuộc thi thành công!");
                    LoadAllContests();
                    if (currentPage > totalPages) currentPage = totalPages;
                    RenderCurrentPage();
                    modalForm.Close();
                };
                btnPanel.Controls.Add(btnSave);

                var btnCancel = new AntdUI.Button
                {
                    Text = "Hủy",
                    Type = AntdUI.TTypeMini.Default,
                    Location = new Point(270, 0),
                    Size = new Size(120, 40)
                };
                btnCancel.Click += (s, e) => modalForm.Close();
                btnPanel.Controls.Add(btnCancel);
            }
            else
            {
                var btnClose = new AntdUI.Button
                {
                    Text = "Đóng",
                    Type = AntdUI.TTypeMini.Default,
                    Location = new Point(480, 0),
                    Size = new Size(120, 40)
                };
                btnClose.Click += (s, e) => modalForm.Close();
                btnPanel.Controls.Add(btnClose);
            }

            mainPanel.Controls.Add(btnPanel);
            modalForm.Controls.Add(mainPanel);

            // Show modal
            modalForm.ShowDialog(FindForm());
        }
    }
}