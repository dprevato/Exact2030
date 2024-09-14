using Main.Services;
using Main.ViewModels;
namespace Main.Views;
public partial class MainWindow : Form
{
    public MainViewModel ViewModel { get; set; }

    protected ToolStripTextBox? OperatorBox;
    protected ToolStripLabel? InfoMessageImageLabel;
    protected ToolstripSpringTextBox? InfoMessageBox;
    protected ToolStripTextBox? CodeBox;

    public MainWindow(MainViewModel viewModel) {
        ViewModel = viewModel;
        InitializeComponent();
        BindingSource mainBindingSource = [];
        mainBindingSource.DataSource = ViewModel;
    }

    #region Overrides of Form

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        CreateStatusBar();

        // Qui devono essere inseriti tutti i binding
        OperatorBox?.DataBindings.Add(nameof(OperatorBox.Text), ViewModel, nameof(ViewModel.AppUserName), false, DataSourceUpdateMode.OnPropertyChanged);
        OperatorBox?.DataBindings.Add(nameof(OperatorBox.ToolTipText), ViewModel, nameof(ViewModel.OperatorBoxTooltip), false, DataSourceUpdateMode.OnPropertyChanged);
        InfoMessageBox?.DataBindings.Add(nameof(InfoMessageBox.ToolTipText), ViewModel, nameof(ViewModel.InfoBoxTooltip), false, DataSourceUpdateMode.OnPropertyChanged);
        CodeBox?.DataBindings.Add(nameof(CodeBox.Text), ViewModel, nameof(ViewModel.CurrentCode), false, DataSourceUpdateMode.OnPropertyChanged);
        CodeBox?.DataBindings.Add(nameof(CodeBox.ToolTipText), ViewModel, nameof(ViewModel.CodeBoxTooltip), false, DataSourceUpdateMode.OnPropertyChanged);
        InfoMessageImageLabel?.DataBindings.Add(nameof(InfoMessageImageLabel.Image), ViewModel, nameof(ViewModel.InfoImage), true, DataSourceUpdateMode.OnPropertyChanged);
        InfoMessageBox?.DataBindings.Add(nameof(InfoMessageBox.Text), ViewModel, nameof(ViewModel.InfoMessage), false, DataSourceUpdateMode.OnPropertyChanged);
    }

    #endregion

    private void CreateStatusBar() {
        // Imposto la barra di stato nel codice, per poter usare i componenti che mi interessano
        var StatusStrip = new ToolStrip {
            AutoSize = false,
            BackColor = SystemColors.Control,
            Dock = DockStyle.Fill,
            ImageScalingSize = new Size(48, 48),
        };

        StatusStrip.Items.Add(new ToolStripLabel {
            AutoSize = false,
            BackColor = SystemColors.Control,
            DisplayStyle = ToolStripItemDisplayStyle.Image,
            Image = new Bitmap("..\\..\\..\\Resources\\connected-user.png"),
            Size = new Size(48, 48)
        });

        OperatorBox = new ToolStripTextBox() {
            Name = "OperatorBox",
            AutoSize = false,
            BackColor = SystemColors.Control,
            Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0),
            Margin = new Padding(0),
            ReadOnly = true,
            Size = new Size(250, 64)
        };

        StatusStrip.Items.Add(OperatorBox);

        StatusStrip.Items.Add(new ToolStripSeparator {
            Name = "Separator1",
            Margin = new Padding(10, 0, 10, 0),
            Size = new Size(6, 64)
        });

        InfoMessageImageLabel = new ToolStripLabel {
            AutoSize = false,
            BackColor = SystemColors.Control,
            DisplayStyle = ToolStripItemDisplayStyle.Image,
            Image = new Bitmap("..\\..\\..\\Resources\\button-info.png"),
            Size = new Size(48, 48)
        };

        StatusStrip.Items.Add(InfoMessageImageLabel);

        InfoMessageBox = new ToolstripSpringTextBox {
            Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0),
            Margin = new Padding(5, 0, 0, 0),
            ReadOnly = true
        };

        StatusStrip.Items.Add(InfoMessageBox);

        StatusStrip.Items.Add(new ToolStripSeparator {
            Name = "Separator2",
            Margin = new Padding(10, 0, 10, 0),
            Size = new Size(6, 64)
        });

        StatusStrip.Items.Add(new ToolStripLabel {
            AutoSize = false,
            BackColor = SystemColors.Control,
            DisplayStyle = ToolStripItemDisplayStyle.Image,
            Image = new Bitmap("..\\..\\..\\Resources\\code.png"),
            Size = new Size(48, 48)
        });

        CodeBox = new ToolStripTextBox {
            AutoSize = false,
            BackColor = SystemColors.Control,
            Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point, 0),
            Margin = new Padding(5, 0, 0, 0),
            ReadOnly = true,
            Size = new Size(250, 64)
        };

        StatusStrip.Items.Add(CodeBox);

        TablePanel.Controls.Add(StatusStrip, 0, 2);
    }

    private void AddDockedControl(Control? newOne = null) {
        foreach (Control? c in TablePanel.Controls) {
            if (c is UserControl) TablePanel.Controls.Remove(c);
        }

        if (newOne is null) return;
        newOne.Dock = DockStyle.Fill;
        TablePanel.Controls.Add(newOne, 0, 1);
    }

    private void PreferencesMenuItem_Click(object sender, EventArgs e) {
        // AddDockedControl(Program.ServiceProvider!.GetService<PreferencesView>());
    }

    private void PrinterMenuItem_Click(object sender, EventArgs e) {
        // AddDockedControl(Program.ServiceProvider!.GetService<PrinterView>());
    }
}
