namespace Projeto.Forms;
public partial class Admin : BaseForm
{
    public Admin()
    {
        InitializeComponent();
    }

    public void Admin_Load(object? sender, EventArgs e)
    {
        tabela_usuarios.DefaultCellStyle.ForeColor = Color.Black;
        tabela_usuarios.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        tabela_usuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        tabela_usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        tabela_usuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        tabela_usuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        tabela_usuarios.DataSource = BD.GetUsuarios();
    }
}
