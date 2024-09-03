namespace Main.Views;
public partial class MainWindow : Form
{
    public MainWindow() {
        InitializeComponent();
    }

    private void AddDockedControl(Control newOne) {
        newOne.Dock = DockStyle.Fill;
        foreach (Control? c in TablePanel.Controls) {
            if (c is UserControl) TablePanel.Controls.Remove(c);
        }
        TablePanel.Controls.Add(newOne, 0, 1);
    }

    private void PreferencesMenuItem_Click(object sender, EventArgs e) {
        AddDockedControl(new PreferencesView());
    }

    private void PrinterMenuItem_Click(object sender, EventArgs e) {
        AddDockedControl(new PrinterView());
    }
}
