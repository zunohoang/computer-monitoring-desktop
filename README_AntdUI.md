# AntdUI Controls Reference (Detailed)

This document provides a detailed reference for AntdUI controls in WinForms, including all major properties, events, and advanced usage tips. Use this as a comprehensive guide for building modern, Ant Design-inspired UIs in your project.

---

## 1. AntdUI.Label

- **Description:** Modern label for text, badges, icons, and status.
- **Key Properties:**
  - `Text` (string): The label text.
  - `Font` (Font): Font style and size.
  - `ForeColor` (Color): Text color.
  - `BackColor` (Color): Background color.
  - `BadgeSvg` (string): SVG icon name (e.g., "EyeOutlined").
  - `BadgeBack` (Color): Badge background color.
  - `BadgeSize` (float): Badge size (relative to font).
  - `TextAlign` (ContentAlignment): Text alignment (e.g., MiddleLeft).
  - `Padding` (Padding): Inner padding.
  - `AutoSize` (bool): Auto-resize to fit text.
  - `Cursor` (Cursor): Mouse cursor (e.g., Hand for clickable labels).
- **Events:**
  - `Click`: Fires when the label is clicked.
- **Usage:**

```csharp
var label = new AntdUI.Label {
    Text = "Status",
    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
    ForeColor = Color.Green,
    BadgeSvg = "CheckCircleOutlined",
    BadgeBack = Color.LightGreen,
    BadgeSize = 1.2f,
    TextAlign = ContentAlignment.MiddleLeft
};
```

---

## 2. AntdUI.Button

- **Description:** Modern button with Ant Design styles, icons, and ghost/primary states.
- **Key Properties:**
  - `Text` (string): Button text.
  - `Type` (TTypeMini): Button style (Primary, Default, Warn, Error).
  - `Ghost` (bool): Outlined/ghost style.
  - `IconSvg` (string): SVG icon name (e.g., "EditOutlined").
  - `Font` (Font): Font style.
  - `Enabled` (bool): Enable/disable button.
  - `Size` (Size): Button size.
  - `Location` (Point): Button position.
  - `Padding` (Padding): Inner padding.
- **Events:**
  - `Click`: Fires when the button is clicked.
- **Usage:**

```csharp
var btn = new AntdUI.Button {
    Text = "Sửa",
    Type = TTypeMini.Warn,
    Ghost = true,
    IconSvg = "EditOutlined",
    Font = new Font("Segoe UI", 9F),
    Size = new Size(60, 30)
};
btn.Click += (s, e) => { /* handler */ };
```

---

## 3. AntdUI.Panel

- **Description:** Card-like container with shadow, border, and rounded corners. Used for grouping content.
- **Key Properties:**
  - `Back` (Color): Background color.
  - `Shadow` (int): Shadow size (0 = none, 1-10 = increasing shadow).
  - `Radius` (int): Corner radius (0 = square, 8 = rounded).
  - `BorderColor` (Color): Border color.
  - `BorderWidth` (float): Border width.
  - `Padding` (Padding): Inner padding.
  - `Dock` (DockStyle): Docking behavior.
  - `Controls` (ControlCollection): Child controls.
- **Usage:**

```csharp
var panel = new AntdUI.Panel {
    Back = Color.White,
    Shadow = 5,
    Radius = 8,
    BorderColor = Color.LightGray,
    BorderWidth = 1f,
    Padding = new Padding(20)
};
panel.Controls.Add(myLabel);
```

---

## 4. AntdUI.Input

- **Description:** Modern text input, supports single-line and multi-line.
- **Key Properties:**
  - `Text` (string): Input value.
  - `PlaceholderText` (string): Placeholder text.
  - `Multiline` (bool): Multiline mode.
  - `Enabled` (bool): Editable state.
  - `Font` (Font): Font style.
  - `Size` (Size): Input size.
  - `Location` (Point): Input position.
- **Events:**
  - `TextChanged`: Fires when the text changes.
- **Usage:**

```csharp
var input = new AntdUI.Input {
    PlaceholderText = "Nhập mô tả cuộc thi",
    Multiline = true,
    Size = new Size(600, 80)
};
input.TextChanged += (s, e) => { /* handler */ };
```

---

## 5. AntdUI.Table

- **Description:** Data table for displaying lists (participants, rooms, etc.).
- **Key Properties:**
  - `DataSource` (IEnumerable): Data to display (list of objects).
  - `Columns` (List<TableColumn>): Column definitions (see below).
  - `RowHeight` (int): Row height.
  - `HeaderVisible` (bool): Show/hide header.
  - `SelectionMode` (enum): Row selection mode (None, Single, Multi).
  - `Dock` (DockStyle): Docking behavior.
  - `Font` (Font): Font style.
- **TableColumn Structure:**
  - `Title` (string): Column header text.
  - `Field` (string): Property name in data source.
  - `Width` (int): Column width.
  - `CellTemplate` (Func<object, Control>): Custom cell rendering.
- **Events:**
  - `CellClick`: Fires when a cell is clicked.
- **Usage:**

```csharp
var columns = new List<TableColumn> {
    new TableColumn { Title = "ID", Field = "Id", Width = 60 },
    new TableColumn { Title = "Tên", Field = "Name", Width = 200 },
    new TableColumn { Title = "Thao tác", Field = "", Width = 100, CellTemplate = (row) => new AntdUI.Button { Text = "Xóa" } }
};
var table = new AntdUI.Table {
    DataSource = myList,
    Columns = columns,
    RowHeight = 40,
    HeaderVisible = true
};
```

---

## 6. AntdUI.FlowPanel

- **Description:** Horizontal/vertical flow layout for cards, stats, etc.
- **Key Properties:**
  - `FlowDirection` (FlowDirection): Direction (LeftToRight, TopDown).
  - `WrapContents` (bool): Wrap items.
  - `Controls` (ControlCollection): Child controls.
- **Usage:**

```csharp
var flow = new AntdUI.FlowPanel {
    FlowDirection = FlowDirection.LeftToRight,
    WrapContents = true
};
flow.Controls.Add(card1);
flow.Controls.Add(card2);
```

---

## 7. AntdUI.Tag

- **Description:** Colored tag for status, labels, etc.
- **Key Properties:**
  - `Text` (string): Tag text.
  - `BackColor` (Color): Tag color.
  - `ForeColor` (Color): Text color.
  - `Font` (Font): Font style.
- **Usage:**

```csharp
var tag = new AntdUI.Tag {
    Text = "Đã kết thúc",
    BackColor = Color.Gray,
    ForeColor = Color.White
};
```

---

## 8. AntdUI.Message

- **Description:** Toast notification for success, error, info.
- **Key Methods:**
  - `Message.success(Form, string, Font? font = null, int? autoClose = null)`
  - `Message.error(Form, string, Font? font = null, int? autoClose = null)`
- **Usage:**

```csharp
AntdUI.Message.success(this.FindForm(), "Thành công!");
```

---

## 9. AntdUI.ComboBox

- **Description:** Modern dropdown selector.
- **Key Properties:**
  - `Items` (object[]): Items.
  - `SelectedIndex` (int): Selected item.
  - `DropDownStyle` (ComboBoxStyle): Drop-down style.
  - `Enabled` (bool): Enable/disable.
- **Events:**
  - `SelectedIndexChanged`: Fires when selection changes.
- **Usage:**

```csharp
var combo = new AntdUI.ComboBox {
    Items = new object[] { "A", "B", "C" },
    DropDownStyle = ComboBoxStyle.DropDownList
};
combo.SelectedIndexChanged += (s, e) => { /* handler */ };
```

---

## 10. AntdUI.ProgressBar

- **Description:** Modern progress bar for status, table cells, etc.
- **Key Properties:**
  - `Value` (int): Progress value (0-100).
  - `BackColor` (Color): Bar color.
  - `ForeColor` (Color): Background color.
  - `Height` (int): Bar height.
- **Usage:**

```csharp
var progress = new AntdUI.ProgressBar {
    Value = 75,
    BackColor = Color.Green,
    Height = 8
};
```

---

## General Usage Notes

- Always instantiate controls before adding to containers.
- Set all properties before adding to panels/forms.
- For AntdUI.Table, define columns and set DataSource before showing.
- Use AntdUI.Panel for card-like sections and AntdUI.Table for data grids.
- Use AntdUI.Label with BadgeSvg for icon+text combos.
- Use FlowPanel for dashboard cards and stat layouts.
- Use Tag for status/labels in tables.
- Use Message for user feedback.

---

For more details, see the official AntdUI documentation or explore the control properties in Visual Studio's designer. If you need a sample for a specific control or advanced feature, ask for an example!
