namespace Main.Views;

partial class MainWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        TablePanel = new TableLayoutPanel();
        SS = new StatusStrip();
        OperatorLabel = new ToolStripStatusLabel();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        MessageLabel = new ToolStripStatusLabel();
        toolStripStatusLabel2 = new ToolStripStatusLabel();
        CodeLabel = new ToolStripStatusLabel();
        TS = new ToolStrip();
        OperationsMenu = new ToolStripDropDownButton();
        ImportMenuItem = new ToolStripMenuItem();
        AutoImportMenuItem = new ToolStripMenuItem();
        ManualImportMenuItem = new ToolStripMenuItem();
        ExportMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        ValidationMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        ChartsMenuItem = new ToolStripMenuItem();
        ChartSetupMenuItem = new ToolStripMenuItem();
        ChartShowMenuItem = new ToolStripMenuItem();
        ReportMenuItem = new ToolStripMenuItem();
        TabReportMenuItem = new ToolStripMenuItem();
        ChartReportMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        PrinterMenuItem = new ToolStripMenuItem();
        PreferencesMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        ExitAppMenuItem = new ToolStripMenuItem();
        DataMenu = new ToolStripDropDownButton();
        EditRegionsMenuItem = new ToolStripMenuItem();
        EditPlantsMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        JournalMenuItem = new ToolStripMenuItem();
        toolStripSeparator6 = new ToolStripSeparator();
        EditPmMenuItem = new ToolStripMenuItem();
        ReadingsMenuItem = new ToolStripMenuItem();
        toolStripSeparator7 = new ToolStripSeparator();
        EmployeesMenuItem = new ToolStripMenuItem();
        RegistryMenuItem = new ToolStripMenuItem();
        AdminMenuItem = new ToolStripMenuItem();
        RegionsComboBox = new ToolStripComboBox();
        PlantsComboBox = new ToolStripComboBox();
        KindsComboBox = new ToolStripComboBox();
        SubKindsComboBox = new ToolStripComboBox();
        TablePanel.SuspendLayout();
        SS.SuspendLayout();
        TS.SuspendLayout();
        SuspendLayout();
        // 
        // TablePanel
        // 
        TablePanel.BackColor = Color.FromArgb(192, 255, 255);
        TablePanel.ColumnCount = 1;
        TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TablePanel.Controls.Add(SS, 0, 2);
        TablePanel.Controls.Add(TS, 0, 0);
        TablePanel.Dock = DockStyle.Fill;
        TablePanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        TablePanel.Location = new Point(0, 0);
        TablePanel.Name = "TablePanel";
        TablePanel.RowCount = 3;
        TablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        TablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        TablePanel.Size = new Size(1959, 1174);
        TablePanel.TabIndex = 0;
        // 
        // SS
        // 
        SS.BackColor = SystemColors.Control;
        SS.Dock = DockStyle.Fill;
        SS.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SS.GripMargin = new Padding(0);
        SS.ImageScalingSize = new Size(24, 24);
        SS.Items.AddRange(new ToolStripItem[] { OperatorLabel, toolStripStatusLabel1, MessageLabel, toolStripStatusLabel2, CodeLabel });
        SS.Location = new Point(0, 1110);
        SS.Name = "SS";
        SS.Size = new Size(1959, 64);
        SS.TabIndex = 1;
        SS.Text = "statusStrip1";
        // 
        // OperatorLabel
        // 
        OperatorLabel.AutoSize = false;
        OperatorLabel.Image = Properties.Resources.connected_user;
        OperatorLabel.ImageAlign = ContentAlignment.MiddleLeft;
        OperatorLabel.Name = "OperatorLabel";
        OperatorLabel.Size = new Size(200, 57);
        OperatorLabel.Text = "Operatore";
        OperatorLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(18, 57);
        toolStripStatusLabel1.Text = "|";
        // 
        // MessageLabel
        // 
        MessageLabel.BackColor = SystemColors.Control;
        MessageLabel.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        MessageLabel.Image = Properties.Resources.button_info;
        MessageLabel.ImageAlign = ContentAlignment.MiddleLeft;
        MessageLabel.Name = "MessageLabel";
        MessageLabel.Size = new Size(1382, 57);
        MessageLabel.Spring = true;
        MessageLabel.Text = "Messaggi";
        MessageLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // toolStripStatusLabel2
        // 
        toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        toolStripStatusLabel2.Size = new Size(18, 57);
        toolStripStatusLabel2.Text = "|";
        // 
        // CodeLabel
        // 
        CodeLabel.AutoSize = false;
        CodeLabel.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CodeLabel.Image = Properties.Resources.code;
        CodeLabel.ImageAlign = ContentAlignment.MiddleLeft;
        CodeLabel.Name = "CodeLabel";
        CodeLabel.Size = new Size(326, 57);
        CodeLabel.Text = "Code";
        // 
        // TS
        // 
        TS.Dock = DockStyle.Fill;
        TS.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TS.ImageScalingSize = new Size(32, 32);
        TS.Items.AddRange(new ToolStripItem[] { OperationsMenu, DataMenu, RegionsComboBox, PlantsComboBox, KindsComboBox, SubKindsComboBox });
        TS.Location = new Point(0, 0);
        TS.Name = "TS";
        TS.Size = new Size(1959, 64);
        TS.TabIndex = 0;
        TS.Text = "toolStrip1";
        // 
        // OperationsMenu
        // 
        OperationsMenu.DropDownItems.AddRange(new ToolStripItem[] { ImportMenuItem, ExportMenuItem, toolStripSeparator1, ValidationMenuItem, toolStripSeparator2, ChartsMenuItem, ReportMenuItem, toolStripSeparator3, PrinterMenuItem, PreferencesMenuItem, toolStripSeparator4, ExitAppMenuItem });
        OperationsMenu.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        OperationsMenu.Image = Properties.Resources.Gears;
        OperationsMenu.ImageAlign = ContentAlignment.MiddleLeft;
        OperationsMenu.ImageTransparentColor = Color.Magenta;
        OperationsMenu.Name = "OperationsMenu";
        OperationsMenu.Size = new Size(175, 59);
        OperationsMenu.Text = "Operazioni";
        OperationsMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ImportMenuItem
        // 
        ImportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AutoImportMenuItem, ManualImportMenuItem });
        ImportMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ImportMenuItem.Image = Properties.Resources.database_import;
        ImportMenuItem.Name = "ImportMenuItem";
        ImportMenuItem.Size = new Size(354, 42);
        ImportMenuItem.Text = "&Importazione misure";
        // 
        // AutoImportMenuItem
        // 
        AutoImportMenuItem.Image = Properties.Resources.import_from_database;
        AutoImportMenuItem.Name = "AutoImportMenuItem";
        AutoImportMenuItem.ShortcutKeys = Keys.F2;
        AutoImportMenuItem.Size = new Size(276, 38);
        AutoImportMenuItem.Text = "&Automatica";
        // 
        // ManualImportMenuItem
        // 
        ManualImportMenuItem.Image = Properties.Resources.import_from_excel;
        ManualImportMenuItem.Name = "ManualImportMenuItem";
        ManualImportMenuItem.ShortcutKeys = Keys.Alt | Keys.F2;
        ManualImportMenuItem.Size = new Size(276, 38);
        ManualImportMenuItem.Text = "&Manuale";
        // 
        // ExportMenuItem
        // 
        ExportMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ExportMenuItem.Image = Properties.Resources.export_to_excel;
        ExportMenuItem.Name = "ExportMenuItem";
        ExportMenuItem.ShortcutKeys = Keys.F3;
        ExportMenuItem.Size = new Size(354, 42);
        ExportMenuItem.Text = "&Esportazione misure";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(351, 6);
        // 
        // ValidationMenuItem
        // 
        ValidationMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ValidationMenuItem.Image = Properties.Resources.button_ok;
        ValidationMenuItem.Name = "ValidationMenuItem";
        ValidationMenuItem.ShortcutKeys = Keys.F4;
        ValidationMenuItem.Size = new Size(354, 42);
        ValidationMenuItem.Text = "&Validazione misure";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(351, 6);
        // 
        // ChartsMenuItem
        // 
        ChartsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ChartSetupMenuItem, ChartShowMenuItem });
        ChartsMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ChartsMenuItem.Image = Properties.Resources.charts_colors;
        ChartsMenuItem.Name = "ChartsMenuItem";
        ChartsMenuItem.Size = new Size(354, 42);
        ChartsMenuItem.Text = "&Grafici";
        // 
        // ChartSetupMenuItem
        // 
        ChartSetupMenuItem.Image = Properties.Resources.charts_colors_line_edit;
        ChartSetupMenuItem.Name = "ChartSetupMenuItem";
        ChartSetupMenuItem.Size = new Size(257, 38);
        ChartSetupMenuItem.Text = "&Impostazione";
        // 
        // ChartShowMenuItem
        // 
        ChartShowMenuItem.Image = Properties.Resources.charts_colors_line;
        ChartShowMenuItem.Name = "ChartShowMenuItem";
        ChartShowMenuItem.Size = new Size(257, 38);
        ChartShowMenuItem.Text = "&Visualizzazione";
        // 
        // ReportMenuItem
        // 
        ReportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TabReportMenuItem, ChartReportMenuItem });
        ReportMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ReportMenuItem.Image = Properties.Resources.report;
        ReportMenuItem.Name = "ReportMenuItem";
        ReportMenuItem.Size = new Size(354, 42);
        ReportMenuItem.Text = "&Report";
        // 
        // TabReportMenuItem
        // 
        TabReportMenuItem.Image = Properties.Resources.table;
        TabReportMenuItem.Name = "TabReportMenuItem";
        TabReportMenuItem.ShortcutKeys = Keys.F5;
        TabReportMenuItem.Size = new Size(226, 38);
        TabReportMenuItem.Text = "&Tabulari";
        // 
        // ChartReportMenuItem
        // 
        ChartReportMenuItem.Image = Properties.Resources.document_chart;
        ChartReportMenuItem.Name = "ChartReportMenuItem";
        ChartReportMenuItem.ShortcutKeys = Keys.F6;
        ChartReportMenuItem.Size = new Size(226, 38);
        ChartReportMenuItem.Text = "&Grafici";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(351, 6);
        // 
        // PrinterMenuItem
        // 
        PrinterMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PrinterMenuItem.Image = Properties.Resources.printer_edit;
        PrinterMenuItem.Name = "PrinterMenuItem";
        PrinterMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        PrinterMenuItem.Size = new Size(354, 42);
        PrinterMenuItem.Text = "&Stampante";
        PrinterMenuItem.Click += PrinterMenuItem_Click;
        // 
        // PreferencesMenuItem
        // 
        PreferencesMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PreferencesMenuItem.Image = Properties.Resources.Preferences;
        PreferencesMenuItem.Name = "PreferencesMenuItem";
        PreferencesMenuItem.Size = new Size(354, 42);
        PreferencesMenuItem.Text = "&Preferenze";
        PreferencesMenuItem.Click += PreferencesMenuItem_Click;
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(351, 6);
        // 
        // ExitAppMenuItem
        // 
        ExitAppMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ExitAppMenuItem.Image = Properties.Resources.exit;
        ExitAppMenuItem.Name = "ExitAppMenuItem";
        ExitAppMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        ExitAppMenuItem.Size = new Size(354, 42);
        ExitAppMenuItem.Text = "Esci";
        // 
        // DataMenu
        // 
        DataMenu.DropDownItems.AddRange(new ToolStripItem[] { EditRegionsMenuItem, EditPlantsMenuItem, toolStripSeparator5, JournalMenuItem, toolStripSeparator6, EditPmMenuItem, ReadingsMenuItem, toolStripSeparator7, EmployeesMenuItem });
        DataMenu.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DataMenu.Image = Properties.Resources.Factory;
        DataMenu.ImageAlign = ContentAlignment.MiddleLeft;
        DataMenu.ImageTransparentColor = Color.Magenta;
        DataMenu.Margin = new Padding(0, 2, 100, 3);
        DataMenu.Name = "DataMenu";
        DataMenu.Size = new Size(106, 59);
        DataMenu.Text = "Dati";
        // 
        // EditRegionsMenuItem
        // 
        EditRegionsMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EditRegionsMenuItem.Image = Properties.Resources.map;
        EditRegionsMenuItem.Name = "EditRegionsMenuItem";
        EditRegionsMenuItem.Size = new Size(293, 38);
        EditRegionsMenuItem.Text = "&Regioni";
        // 
        // EditPlantsMenuItem
        // 
        EditPlantsMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EditPlantsMenuItem.Image = Properties.Resources.location_on_map;
        EditPlantsMenuItem.Name = "EditPlantsMenuItem";
        EditPlantsMenuItem.Size = new Size(293, 38);
        EditPlantsMenuItem.Text = "&Impianti";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(290, 6);
        // 
        // JournalMenuItem
        // 
        JournalMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        JournalMenuItem.Image = Properties.Resources.book;
        JournalMenuItem.Name = "JournalMenuItem";
        JournalMenuItem.Size = new Size(293, 38);
        JournalMenuItem.Text = "&Giornale Impianto";
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(290, 6);
        // 
        // EditPmMenuItem
        // 
        EditPmMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EditPmMenuItem.Image = Properties.Resources.dashboard;
        EditPmMenuItem.Name = "EditPmMenuItem";
        EditPmMenuItem.Size = new Size(293, 38);
        EditPmMenuItem.Text = "&Punti di Misura";
        // 
        // ReadingsMenuItem
        // 
        ReadingsMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ReadingsMenuItem.Image = Properties.Resources.readings;
        ReadingsMenuItem.Name = "ReadingsMenuItem";
        ReadingsMenuItem.Size = new Size(293, 38);
        ReadingsMenuItem.Text = "&Misure";
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(290, 6);
        // 
        // EmployeesMenuItem
        // 
        EmployeesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RegistryMenuItem, AdminMenuItem });
        EmployeesMenuItem.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EmployeesMenuItem.Image = Properties.Resources.big_data_people;
        EmployeesMenuItem.Name = "EmployeesMenuItem";
        EmployeesMenuItem.Size = new Size(293, 38);
        EmployeesMenuItem.Text = "Personale &Addetto";
        // 
        // RegistryMenuItem
        // 
        RegistryMenuItem.Image = Properties.Resources.employees;
        RegistryMenuItem.Name = "RegistryMenuItem";
        RegistryMenuItem.Size = new Size(277, 38);
        RegistryMenuItem.Text = "&Anagrafe";
        // 
        // AdminMenuItem
        // 
        AdminMenuItem.Image = Properties.Resources.people_employees_edit;
        AdminMenuItem.Name = "AdminMenuItem";
        AdminMenuItem.Size = new Size(277, 38);
        AdminMenuItem.Text = "Amministrazione";
        // 
        // RegionsComboBox
        // 
        RegionsComboBox.AutoSize = false;
        RegionsComboBox.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        RegionsComboBox.Margin = new Padding(0, 2, 20, 2);
        RegionsComboBox.Name = "RegionsComboBox";
        RegionsComboBox.Size = new Size(250, 38);
        RegionsComboBox.Text = "Regioni";
        // 
        // PlantsComboBox
        // 
        PlantsComboBox.Font = new Font("Segoe UI Variable Display", 11F);
        PlantsComboBox.Margin = new Padding(0, 2, 20, 2);
        PlantsComboBox.Name = "PlantsComboBox";
        PlantsComboBox.Size = new Size(250, 60);
        PlantsComboBox.Text = "Impianti";
        // 
        // KindsComboBox
        // 
        KindsComboBox.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        KindsComboBox.Margin = new Padding(0, 2, 20, 2);
        KindsComboBox.Name = "KindsComboBox";
        KindsComboBox.Size = new Size(350, 60);
        KindsComboBox.Text = "Catalogo strumenti";
        // 
        // SubKindsComboBox
        // 
        SubKindsComboBox.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SubKindsComboBox.Margin = new Padding(0, 2, 0, 2);
        SubKindsComboBox.Name = "SubKindsComboBox";
        SubKindsComboBox.Size = new Size(350, 60);
        SubKindsComboBox.Text = "Strumenti";
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1959, 1174);
        Controls.Add(TablePanel);
        Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "MainWindow";
        Text = "Exact 2030";
        TablePanel.ResumeLayout(false);
        TablePanel.PerformLayout();
        SS.ResumeLayout(false);
        SS.PerformLayout();
        TS.ResumeLayout(false);
        TS.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TablePanel;
    private ToolStrip TS;
    private StatusStrip SS;
    private ToolStripDropDownButton OperationsMenu;
    private ToolStripDropDownButton DataMenu;
    private ToolStripMenuItem ImportMenuItem;
    private ToolStripMenuItem AutoImportMenuItem;
    private ToolStripMenuItem ManualImportMenuItem;
    private ToolStripMenuItem ExportMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ValidationMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ChartsMenuItem;
    private ToolStripMenuItem ChartSetupMenuItem;
    private ToolStripMenuItem ChartShowMenuItem;
    private ToolStripMenuItem ReportMenuItem;
    private ToolStripMenuItem TabReportMenuItem;
    private ToolStripMenuItem ChartReportMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem PrinterMenuItem;
    private ToolStripMenuItem PreferencesMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem ExitAppMenuItem;
    private ToolStripMenuItem EditRegionsMenuItem;
    private ToolStripMenuItem EditPlantsMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem JournalMenuItem;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem EditPmMenuItem;
    private ToolStripMenuItem ReadingsMenuItem;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem EmployeesMenuItem;
    private ToolStripMenuItem RegistryMenuItem;
    private ToolStripMenuItem AdminMenuItem;
    private ToolStripComboBox RegionsComboBox;
    private ToolStripComboBox PlantsComboBox;
    private ToolStripComboBox KindsComboBox;
    private ToolStripComboBox SubKindsComboBox;
    private ToolStripStatusLabel OperatorLabel;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel MessageLabel;
    private ToolStripStatusLabel toolStripStatusLabel2;
    private ToolStripStatusLabel CodeLabel;
}