using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmAgencia : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public frmAgencia(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void frmAgencia_Load(object sender, EventArgs e)
        {
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            GridHelper.MostrarDatosEnGrilla<Moneda>(agencia.ObtenerTodas(), dgvDivisas);


        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
