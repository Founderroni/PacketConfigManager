namespace PacketConfigManager
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Watermark = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Titlebar = new Guna.UI2.WinForms.Guna2Panel();
            Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            ContainerPanel = new Guna.UI2.WinForms.Guna2Panel();
            LoadBtn = new Guna.UI2.WinForms.Guna2Button();
            CfgDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ConfigNameColumn = new DataGridViewTextBoxColumn();
            SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            CfgNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            DragTitlebar = new Guna.UI2.WinForms.Guna2DragControl(components);
            DragContainerPanel = new Guna.UI2.WinForms.Guna2DragControl(components);
            Titlebar.SuspendLayout();
            ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CfgDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ModifyForm
            // 
            ModifyForm.BorderRadius = 6;
            ModifyForm.ContainerControl = this;
            ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            ModifyForm.TransparentWhileDrag = true;
            // 
            // Watermark
            // 
            Watermark.BackColor = Color.Transparent;
            Watermark.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Watermark.ForeColor = Color.White;
            Watermark.Location = new Point(3, 4);
            Watermark.Name = "Watermark";
            Watermark.Size = new Size(162, 17);
            Watermark.TabIndex = 0;
            Watermark.Text = "Packet Client Config Manager";
            // 
            // Titlebar
            // 
            Titlebar.BackColor = Color.Transparent;
            Titlebar.Controls.Add(Minimize);
            Titlebar.Controls.Add(Exit);
            Titlebar.Controls.Add(Watermark);
            Titlebar.CustomizableEdges = customizableEdges13;
            Titlebar.Dock = DockStyle.Top;
            Titlebar.Location = new Point(0, 0);
            Titlebar.Name = "Titlebar";
            Titlebar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Titlebar.Size = new Size(419, 25);
            Titlebar.TabIndex = 1;
            Titlebar.UseTransparentBackground = true;
            // 
            // Minimize
            // 
            Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Minimize.CustomizableEdges = customizableEdges9;
            Minimize.Dock = DockStyle.Right;
            Minimize.FillColor = Color.Transparent;
            Minimize.HoverState.FillColor = Color.Transparent;
            Minimize.IconColor = Color.DimGray;
            Minimize.Location = new Point(369, 0);
            Minimize.Name = "Minimize";
            Minimize.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Minimize.Size = new Size(25, 25);
            Minimize.TabIndex = 2;
            Minimize.UseTransparentBackground = true;
            // 
            // Exit
            // 
            Exit.CustomizableEdges = customizableEdges11;
            Exit.Dock = DockStyle.Right;
            Exit.FillColor = Color.Transparent;
            Exit.HoverState.FillColor = Color.Transparent;
            Exit.IconColor = Color.DimGray;
            Exit.Location = new Point(394, 0);
            Exit.Name = "Exit";
            Exit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Exit.Size = new Size(25, 25);
            Exit.TabIndex = 1;
            Exit.UseTransparentBackground = true;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.Transparent;
            ContainerPanel.BorderColor = Color.FromArgb(100, 100, 100, 100);
            ContainerPanel.BorderRadius = 6;
            ContainerPanel.BorderThickness = 1;
            ContainerPanel.Controls.Add(LoadBtn);
            ContainerPanel.Controls.Add(CfgDataGrid);
            ContainerPanel.Controls.Add(SaveBtn);
            ContainerPanel.Controls.Add(CfgNameBox);
            ContainerPanel.CustomizableEdges = customizableEdges7;
            ContainerPanel.FillColor = Color.FromArgb(25, 25, 25);
            ContainerPanel.Location = new Point(12, 31);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ContainerPanel.Size = new Size(395, 406);
            ContainerPanel.TabIndex = 2;
            ContainerPanel.UseTransparentBackground = true;
            // 
            // LoadBtn
            // 
            LoadBtn.Animated = true;
            LoadBtn.BorderColor = SystemColors.WindowFrame;
            LoadBtn.BorderRadius = 3;
            LoadBtn.BorderThickness = 1;
            LoadBtn.CustomizableEdges = customizableEdges1;
            LoadBtn.DisabledState.BorderColor = Color.DarkGray;
            LoadBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            LoadBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoadBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoadBtn.FillColor = Color.FromArgb(30, 30, 30);
            LoadBtn.Font = new Font("Segoe UI", 9F);
            LoadBtn.ForeColor = Color.White;
            LoadBtn.Location = new Point(46, 341);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoadBtn.Size = new Size(303, 36);
            LoadBtn.TabIndex = 3;
            LoadBtn.Text = "Load Config";
            LoadBtn.UseTransparentBackground = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // CfgDataGrid
            // 
            CfgDataGrid.AllowUserToAddRows = false;
            CfgDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 88, 255);
            CfgDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CfgDataGrid.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CfgDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CfgDataGrid.ColumnHeadersHeight = 17;
            CfgDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CfgDataGrid.Columns.AddRange(new DataGridViewColumn[] { ConfigNameColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CfgDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            CfgDataGrid.GridColor = Color.FromArgb(30, 30, 30);
            CfgDataGrid.Location = new Point(46, 72);
            CfgDataGrid.MultiSelect = false;
            CfgDataGrid.Name = "CfgDataGrid";
            CfgDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CfgDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CfgDataGrid.RowHeadersVisible = false;
            CfgDataGrid.RowTemplate.ReadOnly = true;
            CfgDataGrid.Size = new Size(303, 263);
            CfgDataGrid.TabIndex = 2;
            CfgDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(30, 30, 30);
            CfgDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            CfgDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.WhiteSmoke;
            CfgDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CfgDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(100, 88, 255);
            CfgDataGrid.ThemeStyle.BackColor = Color.FromArgb(30, 30, 30);
            CfgDataGrid.ThemeStyle.GridColor = Color.FromArgb(30, 30, 30);
            CfgDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CfgDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CfgDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CfgDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CfgDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CfgDataGrid.ThemeStyle.HeaderStyle.Height = 17;
            CfgDataGrid.ThemeStyle.ReadOnly = true;
            CfgDataGrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(30, 30, 30);
            CfgDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CfgDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CfgDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.WhiteSmoke;
            CfgDataGrid.ThemeStyle.RowsStyle.Height = 25;
            CfgDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(35, 35, 35);
            CfgDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(100, 88, 255);
            // 
            // ConfigNameColumn
            // 
            ConfigNameColumn.HeaderText = "Config Name";
            ConfigNameColumn.Name = "ConfigNameColumn";
            ConfigNameColumn.ReadOnly = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Animated = true;
            SaveBtn.BorderColor = SystemColors.WindowFrame;
            SaveBtn.BorderRadius = 3;
            SaveBtn.BorderThickness = 1;
            SaveBtn.CustomizableEdges = customizableEdges3;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.FromArgb(30, 30, 30);
            SaveBtn.Font = new Font("Segoe UI", 9F);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(252, 30);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SaveBtn.Size = new Size(97, 36);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Save Current";
            SaveBtn.UseTransparentBackground = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CfgNameBox
            // 
            CfgNameBox.Animated = true;
            CfgNameBox.BorderColor = SystemColors.WindowFrame;
            CfgNameBox.BorderRadius = 3;
            CfgNameBox.CustomizableEdges = customizableEdges5;
            CfgNameBox.DefaultText = "";
            CfgNameBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CfgNameBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CfgNameBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CfgNameBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CfgNameBox.FillColor = Color.FromArgb(30, 30, 30);
            CfgNameBox.FocusedState.BorderColor = Color.FromArgb(150, 150, 150);
            CfgNameBox.Font = new Font("Segoe UI", 9F);
            CfgNameBox.ForeColor = Color.WhiteSmoke;
            CfgNameBox.HoverState.BorderColor = Color.FromArgb(125, 125, 125);
            CfgNameBox.Location = new Point(46, 30);
            CfgNameBox.Name = "CfgNameBox";
            CfgNameBox.PasswordChar = '\0';
            CfgNameBox.PlaceholderForeColor = Color.DimGray;
            CfgNameBox.PlaceholderText = "Config name";
            CfgNameBox.SelectedText = "";
            CfgNameBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CfgNameBox.Size = new Size(200, 36);
            CfgNameBox.TabIndex = 0;
            CfgNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DragTitlebar
            // 
            DragTitlebar.DockIndicatorTransparencyValue = 0.6D;
            DragTitlebar.TargetControl = Titlebar;
            DragTitlebar.UseTransparentDrag = true;
            // 
            // DragContainerPanel
            // 
            DragContainerPanel.DockIndicatorTransparencyValue = 0.6D;
            DragContainerPanel.TargetControl = ContainerPanel;
            DragContainerPanel.UseTransparentDrag = true;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(419, 449);
            Controls.Add(ContainerPanel);
            Controls.Add(Titlebar);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PCM";
            Titlebar.ResumeLayout(false);
            Titlebar.PerformLayout();
            ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CfgDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2Panel Titlebar;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel Watermark;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2Panel ContainerPanel;
        private Guna.UI2.WinForms.Guna2DragControl DragTitlebar;
        private Guna.UI2.WinForms.Guna2DragControl DragContainerPanel;
        private Guna.UI2.WinForms.Guna2TextBox CfgNameBox;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2DataGridView CfgDataGrid;
        private DataGridViewTextBoxColumn ConfigNameColumn;
        private Guna.UI2.WinForms.Guna2Button LoadBtn;
    }
}
