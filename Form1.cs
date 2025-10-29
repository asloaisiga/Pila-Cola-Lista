using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace caso_3
{
    public partial class Form1 : Form
    {
        // Lista dinámica para almacenar los programas
        private List<Software> catalogo = new List<Software>();

        public Form1()
        {
            InitializeComponent();

            // Configurar DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Versión";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string idTexto = Interaction.InputBox("Ingrese el ID del programa:", "Agregar Programa");
                string nombre = Interaction.InputBox("Ingrese el nombre del programa:", "Agregar Programa");
                string version = Interaction.InputBox("Ingrese la versión:", "Agregar Programa");

                if (string.IsNullOrWhiteSpace(idTexto) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(version))
                {
                    MessageBox.Show("Debes ingresar todos los campos.");
                    return;
                }

                if (!int.TryParse(idTexto, out int id))
                {
                    MessageBox.Show("El ID debe ser un número entero.");
                    return;
                }

                //  Validar que no sea un número negativo
                if (id < 0)
                {
                    MessageBox.Show("El ID no puede ser un número negativo.");
                    return;
                }

                if (catalogo.Any(s => s.Id == id))
                {
                    MessageBox.Show("Ya existe un programa con ese ID.");
                    return;
                }

                Software nuevo = new Software { Id = id, Nombre = nombre, Version = version };
                catalogo.Add(nuevo);
                ActualizarTabla();
                MessageBox.Show("Programa agregado correctamente.");
            }
            catch
            {
                MessageBox.Show("Error al agregar el programa.");
            }
        }

        // ELIMINAR
        private void button2_Click(object sender, EventArgs e)
        {
            string idTexto = Interaction.InputBox("Ingrese el ID del programa a eliminar:", "Eliminar Programa");

            if (!int.TryParse(idTexto, out int id))
            {
                MessageBox.Show("Debes ingresar un número válido.");
                return;
            }

            //  Validar que no sea negativo
            if (id < 0)
            {
                MessageBox.Show("El ID no puede ser negativo.");
                return;
            }

            var encontrado = catalogo.FirstOrDefault(s => s.Id == id);
            if (encontrado != null)
            {
                catalogo.Remove(encontrado);
                ActualizarTabla();
                MessageBox.Show("Programa eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún programa con ese ID.");
            }
        }

        // BUSCAR
        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del programa a buscar:", "Buscar Programa");

            var resultados = catalogo
                .Where(s => s.Nombre.ToLower().Contains(nombre.ToLower()))
                .ToList();

            if (resultados.Any())
            {
                dataGridView1.Rows.Clear();
                foreach (var s in resultados)
                {
                    dataGridView1.Rows.Add(s.Id, s.Nombre, s.Version);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún programa con ese nombre.");
            }
        }

        // MOSTRAR TODOS
        private void button4_Click(object sender, EventArgs e)
        {
            //  Validar si la lista está vacía
            if (catalogo.Count == 0)
            {
                MessageBox.Show("La lista está vacía. Agrega programas antes de mostrar todos.");
                return; // No cierra el programa, solo sale del método
            }

            ActualizarTabla();
        }

        // MÉTODO PARA REFRESCAR LA TABLA
        private void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            foreach (var s in catalogo)
            {
                dataGridView1.Rows.Add(s.Id, s.Nombre, s.Version);
            }
        }

        // CLASE SOFTWARE
        public class Software
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Version { get; set; }
        }
    }
}

