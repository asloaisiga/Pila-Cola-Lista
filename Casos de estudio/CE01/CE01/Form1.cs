using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CE01
{
    public partial class Form1 : Form
    {
        // Esta clase representa una acción realizada en el sistema.
        // La creamos para guardar el tipo, la descripción y la hora exacta en que se hizo.
        private class Accion
        {
            public string Tipo { get; }
            public string Descripcion { get; }
            public DateTime Fecha { get; } = DateTime.Now; // Fecha automática al crear la acción

            public Accion(string tipo, string descripcion)
            {
                // Guardamos los datos que pasa el usuario
                Tipo = tipo;
                Descripcion = descripcion;
            }

            public override string ToString()
                // Esto define cómo se verá cada acción en pantalla
                => $"{Fecha:HH:mm:ss}  •  {Tipo}  —  {Descripcion}";
        }

        // Aquí declaramos nuestra estructura principal: una PILA.
        // La pila funciona con la lógica LIFO: el último que entra es el primero que sale.
        private readonly Stack<Accion> _pila = new Stack<Accion>();
        public Form1()
        {
            InitializeComponent();

            // Cargamos manualmente los posibles tipos de acciones que puede elegir el usuario.
            cmbTipo.Items.AddRange(new object[]
            {
                "Agregar función",
                "Eliminar clase",
                "Modificar variable"

            });

            // Seleccionamos la primera opción por defecto para que no quede vacío.
            if (cmbTipo.Items.Count > 0) cmbTipo.SelectedIndex = 0;

            ActualizarUI(); // Llamamos a una función que muestra el estado actual en la interfaz.

            // Asignamos eventos a los botones (si no están asignados desde el diseñador).
            btnAgregar.Click += btnAgregar_Click;
            btnDeshacer.Click += btnDeshacer_Click;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Capturamos los valores que el usuario selecciona y escribe.
            var tipo = cmbTipo.SelectedItem?.ToString() ?? "Acción";
            var desc = (txtDescripcion.Text ?? "").Trim();

            // Validamos que el usuario realmente escribió algo.
            if (desc.Length == 0)
            {
                MessageBox.Show("Escribe una descripción.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
                return; // Si no escribió nada, detenemos aquí.
            }

            // Creamos un nuevo objeto Accion y lo apilamos.
            _pila.Push(new Accion(tipo, desc));

            // Limpiamos el cuadro de texto para que quede listo para otra acción.
            txtDescripcion.Clear();

            // Actualizamos toda la interfaz gráfica para reflejar el cambio.
            ActualizarUI();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            // Verificamos si hay acciones para deshacer.
            if (_pila.Count == 0)
            {
                MessageBox.Show("No hay acciones para deshacer.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Si la pila está vacía, no hacemos nada.
            }

            // Quitamos la última acción agregada (esto es la esencia del comportamiento LIFO).
            _pila.Pop();

            // Actualizamos la interfaz para mostrar que la pila cambió.
            ActualizarUI();
        }

        // === FUNCIÓN PARA REFRESCAR TODA LA INTERFAZ ===
        private void ActualizarUI()
        {
            // Si la pila tiene elementos, mostramos la acción más reciente con Peek.
            // Peek NO elimina, solo mira qué hay arriba.
            lblUltima.Text = _pila.Count > 0 ? _pila.Peek().ToString() : "(sin acciones)";

            // Actualizamos el historial visualmente.
            lstHistorial.BeginUpdate(); // Mejora gráfica para evitar parpadeos.
            lstHistorial.Items.Clear(); // Limpiamos para evitar duplicados.
            foreach (var a in _pila)
                lstHistorial.Items.Add(a.ToString()); // Mostramos cada acción en orden LIFO.
            lstHistorial.EndUpdate();

            // Mostramos cuántas acciones hay actualmente en total.
            lblTotal.Text = $"Total de Acciones: {_pila.Count}";
        }

    }
}
