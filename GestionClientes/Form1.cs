using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestionClientesBDEntitiesConexion contexto = new GestionClientesBDEntitiesConexion();
            dataGridView1.DataSource = contexto.Clientes.ToList();
        }

        private void rellenar()
        {
            this.Idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Nombretxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.Apellidotxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.Edadtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.Sexotxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.Direcciontxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


        }
        private void btnGuardad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.Idtxt.Text);
            String nombre = Nombretxt.Text;
            String apellido = Apellidotxt.Text;
            int    edad = int.Parse(this.Edadtxt.Text);
            String sexo = Sexotxt.Text;
            String direccion = Direcciontxt.Text;

            string message = "Registro Guardado";
            string title = "Alerta";
            MessageBox.Show(message, title);


            using (GestionClientesBDEntitiesConexion contexto = new GestionClientesBDEntitiesConexion())
            {
                Clientes clien = new Clientes
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Edad = edad,
                    Sexo = sexo,
                    Direccion = direccion

                };

                contexto.Clientes.Add(clien);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            rellenar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.Idtxt.Text);
            String nombre = Nombretxt.Text;
            String apellido = Apellidotxt.Text;
            int edad = int.Parse(this.Edadtxt.Text);
            String sexo = Sexotxt.Text;
            String direccion = Direcciontxt.Text;

            string message = "Registro Editado";
            string title = "Informacion";
            MessageBox.Show(message, title);

            using (GestionClientesBDEntitiesConexion contexto= new GestionClientesBDEntitiesConexion() )

            {
                Clientes clien = contexto.Clientes.FirstOrDefault(L => L.Id ==id );  //consultas de base dcontext 
                clien.Nombre = nombre;
                clien.Apellido = apellido;
                clien.Edad = edad;
                clien.Sexo = sexo;
                clien.Direccion = direccion;
                contexto.SaveChanges();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.Idtxt.Text);

            string message = "Registro Eliminado";
            string title = "Informacion";
            MessageBox.Show(message, title);

            using (GestionClientesBDEntitiesConexion contexto = new GestionClientesBDEntitiesConexion())

            {
                Clientes clien = contexto.Clientes.FirstOrDefault(L => L.Id == id);  //consultas de base dcontext 
                contexto.Clientes.Remove(clien);
                contexto.SaveChanges();
                cargar();
            }
        }

      
    }
}
