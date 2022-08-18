namespace CapaPresentacion
{
    public partial class FRCliente : Form
    {
        public FRCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Value = 0;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            PicFoto.Image = null;
        }

        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdFoto.FileName = string.Empty;
            if (ofdFoto.ShowDialog()==DialogResult.OK)
            {
                PicFoto.Load(ofdFoto.FileName);
            }
            ofdFoto.FileName = string.Empty;
        }
    }
}