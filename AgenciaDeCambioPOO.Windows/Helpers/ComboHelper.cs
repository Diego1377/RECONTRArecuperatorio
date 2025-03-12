namespace AgenciaDeCambioPOO.Windows.Helpers
{
    public static class ComboHelper
    {
        public static void CargarDatosCombo<T>(ref ComboBox combo, List<T> datos, string campoMostrar, string campoValor) where T : class
        {
            combo.DataSource = datos;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = 0;
        }
    }
}
