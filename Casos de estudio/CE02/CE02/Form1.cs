using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CE02
{
    public partial class Form1 : Form
    {
        // Cola FIFO: primero en entrar, primero en salir.
        private readonly Queue<Solicitud> _cola = new Queue<Solicitud>();
        // Para generar datos de prueba.
        private readonly Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            InicializarFormulario(); // Carga opciones iniciales.
            btnEncolar.Click += btnEncolar_Click;
            btnAtender.Click += btnAtender_Click;
            btnProxima.Click += btnProxima_Click;
            btnPendientes.Click += btnPendientes_Click;
            btnVaciarCola.Click += btnVaciarCola_Click;
            btnCargarPrueba.Click += btnCargarPrueba_Click;
        }

        private void InicializarFormulario()
        {
            // Tipos de solicitud disponibles.
            comboTipoSolicitud.Items.AddRange(new object[]
            {
                "Consulta de notas",
                "Inscripción de materias",
                "Descarga de materiales"
            });
            comboTipoSolicitud.SelectedIndex = 0; // Selección por defecto.
            RefrescarLista();                     // Dibuja la cola (vacía al inicio).
        }

        // Objeto que representa una solicitud del estudiante.
        private class Solicitud
        {
            public string Tipo { get; set; } = "";
            public string Usuario { get; set; } = "";
            public string Descripcion { get; set; } = "";
            public DateTime Fecha { get; set; } = DateTime.Now; // Momento de encolado.

            // Texto mostrado en la ListBox (resumen legible).
            public override string ToString() =>
                $"[{Fecha:HH:mm:ss}] {Usuario} - {Tipo} - {Descripcion}";
        }

        // Redibuja la ListBox y habilita/deshabilita botones según la cola.
        private void RefrescarLista()
        {
            lstCola.BeginUpdate();
            lstCola.Items.Clear();
            foreach (var s in _cola) lstCola.Items.Add(s.ToString());
            lstCola.EndUpdate();

            bool hay = _cola.Count > 0;
            btnAtender.Enabled = hay;
            btnProxima.Enabled = hay;
            btnVaciarCola.Enabled = hay;
        }

        // Validación simple de entradas obligatorias.
        private bool ValidarEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        // --- Eventos de botones ---

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada()) return;

            // Crear y encolar la solicitud.
            var s = new Solicitud
            {
                Tipo = comboTipoSolicitud.SelectedItem?.ToString() ?? "",
                Usuario = txtUsuario.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Fecha = DateTime.Now
            };
            _cola.Enqueue(s);  // Entra al final de la cola (FIFO).
            RefrescarLista();

            // Limpieza rápida para seguir encolando.
            txtDescripcion.Clear();
            txtDescripcion.Focus();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (_cola.Count == 0) return;

            var atendida = _cola.Dequeue(); // Sale la primera (FIFO).
            RefrescarLista();

            // Mostrar un resumen de lo atendido.
            var msg = new StringBuilder();
            msg.AppendLine("Solicitud atendida:");
            msg.AppendLine($"• Tipo: {atendida.Tipo}");
            msg.AppendLine($"• Usuario: {atendida.Usuario}");
            msg.AppendLine($"• Descripción: {atendida.Descripcion}");
            msg.AppendLine($"• Encolada: {atendida.Fecha:dd/MM/yyyy HH:mm:ss}");
            MessageBox.Show(msg.ToString(), "Atención completada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (_cola.Count == 0)
            {
                MessageBox.Show("No hay solicitudes en la cola.", "Próxima",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var prox = _cola.Peek(); // Mira la primera sin sacarla.
            MessageBox.Show(
                $"Próxima:\n• {prox.Usuario} - {prox.Tipo}\n• {prox.Descripcion}",
                "Próxima en cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            // Mensaje directo del estado actual.
            MessageBox.Show(_cola.Count > 0
                    ? $"Hay {_cola.Count} solicitud(es) pendiente(s)."
                    : "No hay solicitudes pendientes.",
                "Estado de la cola",
                MessageBoxButtons.OK,
                _cola.Count > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnVaciarCola_Click(object sender, EventArgs e)
        {
            if (_cola.Count == 0) return;

            var ok = MessageBox.Show("¿Vaciar toda la cola?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
            {
                _cola.Clear();  // Quita todas.
                RefrescarLista();
            }
        }

        private void btnCargarPrueba_Click(object sender, EventArgs e)
        {
            // Genera N solicitudes aleatorias (simulación de carga).
            if (!int.TryParse(txtCantidadPrueba.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (> 0).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadPrueba.Focus();
                return;
            }

            string[] tipos = {
                "Consulta de notas", "Inscripción de materias", "Descarga de materiales"
            };

            for (int i = 1; i <= cantidad; i++)
            {
                _cola.Enqueue(new Solicitud
                {
                    Tipo = tipos[_rnd.Next(tipos.Length)],
                    Usuario = $"user{_rnd.Next(1000, 9999)}",
                    Descripcion = $"Solicitud de prueba #{i}",
                    Fecha = DateTime.Now
                });
            }
            RefrescarLista();
        }
    }
}
