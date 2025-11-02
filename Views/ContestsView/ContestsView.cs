using AntdUI;
using computer_monitoring_desktop.Models.Contest;
using computer_monitoring_desktop.Services;

namespace computer_monitoring_desktop.Views
{
    public partial class ContestView : UserControl
    {
        private List<Contest> allContests;
        private ContestService contestService = new ContestService();
        private int contestPageSize = 5;
        private int contestCurrentPage = 1;

        public ContestView()
        {
            InitializeComponent();
            InitializeTable();
            BindEvent();
            LoadAllContests();
        }

        private void InitializeTable()
        {
            // Configure table columns
            tblContests.Columns = new ColumnCollection
                {
                    new Column("STT", "STT", ColumnAlign.Center) {
                        Width = "60",
                        Fixed = true,
                        Render = (value, record, rowIndex) => ((contestCurrentPage - 1) * contestPageSize + rowIndex + 1)
                    },
                    new Column("Id", "ID", ColumnAlign.Center) { Width = "80", Fixed = true },
                    new Column("Name", "Tên cuộc thi", ColumnAlign.Left) { Width = "250" },
                    new Column("Description", "Mô tả", ColumnAlign.Left),
                    new Column("StartTime", "Thời gian bắt đầu", ColumnAlign.Center) { Width = "180" },
                    new Column("EndTime", "Thời gian kết thúc", ColumnAlign.Center) { Width = "180" },
                    new Column("Status", "Trạng thái", ColumnAlign.Center) { Width = "120" },
                    new Column("Actions", "Thao tác", ColumnAlign.Center)
                    {
                        Width = "240",
                        Fixed = true,
                        Render = (value, record, rowIndex) => new CellLink[]
                        {
                            new CellButton("view", "Xem") { Type = TTypeMini.Primary, Ghost = true, IconSvg = "EyeOutlined" },
                            new CellButton("edit", "Sửa") { Type = TTypeMini.Warn, Ghost = true, IconSvg = "EditOutlined" },
                            new CellButton("delete", "Xóa") { Type = TTypeMini.Error, Ghost = true, IconSvg = "DeleteOutlined" }
                        }
                }
            };

        }

        private void TblContests_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var recordType = e.Record.GetType();
            var contestProperty = recordType.GetProperty("Contest");
            if (contestProperty != null)
            {
                var contest = contestProperty.GetValue(e.Record) as Contest;
                if (contest != null)
                {
                    switch (e.Btn.Id)
                    {
                        case "view":
                            ViewContest(contest.Id, contest.Name);
                            break;
                        case "edit":
                            EditContest(contest.Id);
                            break;
                        case "delete":
                            DeleteContest(contest.Id);
                            break;
                    }
                }
            }
        }

        private void BindEvent()
        {
            tblContests.CellButtonClick += TblContests_CellButtonClick;
            pgnContests.ValueChanged += PgnContests_ValueChanged;
            pgnContests.ShowSizeChanger = true;
        }

        private void PgnContests_ValueChanged(object sender, PagePageEventArgs e)
        {
            contestCurrentPage = e.Current;
            if (e.PageSize != contestPageSize)
            {
                contestPageSize = e.PageSize;
            }
            UpdateContestsTable();
        }

        private void UpdateContestsTable()
        {
            if (allContests == null) return;

            var pagedContests = allContests
                .Skip((contestCurrentPage - 1) * contestPageSize)
                .Take(contestPageSize)
                .ToList();

            // Transform data for table with formatted dates
            var tableData = pagedContests.Select(c => new
            {
                c.Id,
                c.Name,
                c.Description,
                StartTime = c.StartTime.ToString("HH:mm:ss dd/MM/yyyy"),
                EndTime = c.EndTime.ToString("HH:mm:ss dd/MM/yyyy"),
                c.Status,
                Contest = c
            }).ToList();

            tblContests.DataSource = tableData;
        }

        private void LoadAllContests()
        {
            allContests = contestService.GetAllContests();

            pgnContests.Total = allContests.Count;
            pgnContests.PageSize = contestPageSize;
            pgnContests.Current = 1;

            UpdateContestsTable();
        }

        private void ViewContest(string id, string name)
        {
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