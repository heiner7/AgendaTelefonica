using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class AgendaTeléfonica : Form
    {
        //creamos una variable global que captura el evento de ser click en la tabla(dataGridView1)
        int poc;
        public AgendaTeléfonica()
        {
            InitializeComponent();
            limpiar();
        }

        //metodo para limpiar el textBox cuando agregamos nueva informacion
        private void limpiar()
        {
            txtNom.Clear();
            txtDireccion.Clear();
            txtComentario.Clear();
            txtCorreo.Clear();
            txtExtension.Clear();
            txtTelemo.Clear();
            txtTelePar.Clear();
            txtTeleTra.Clear();
            //desabilita los botones Modificar/Eliminar
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //metodo para agregar al presionar el boton
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //capturamos los campos de textBox
            string n, d, t, f, m, q, w, l;
            n = txtNom.Text;
            d = txtDireccion.Text;
            t = txtTelePar.Text;
            f = txtTelemo.Text;
            m = txtTeleTra.Text;
            q = txtExtension.Text;
            w = txtCorreo.Text;
            l = txtComentario.Text;
           
            //agregamos los datos en una fila de la tabla
            dataGridView1.Rows.Add( n, d,t, f, m, q, w, l);
            //llamamos el metodo limpiar 
            limpiar();
            
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminamos una sola fila
            dataGridView1.Rows.RemoveAt(poc);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //metodo que vuelve a la normalidad(no modifica o elimina)
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            //habilitamos el boton agregar
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos los datos
            string n, d, t, f, m, q, w, l;
            n = txtNom.Text;
            d = txtDireccion.Text;
            t = txtTelePar.Text;
            f = txtTelemo.Text;
            m = txtTeleTra.Text;
            q = txtExtension.Text;
            w = txtCorreo.Text;
            l = txtComentario.Text;

            //modificamos las columnas de la tabla(dataGridView1)
            dataGridView1[0, poc].Value = n;
            dataGridView1[1, poc].Value = d;
            dataGridView1[2, poc].Value = t;
            dataGridView1[3, poc].Value = f;
            dataGridView1[4, poc].Value = m;
            dataGridView1[5, poc].Value = q;
            dataGridView1[6, poc].Value = w;
            dataGridView1[7, poc].Value = l;
        

            limpiar();
        }

        //creamos el metodo para capturar el click en la tabla(dataGridView1)
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //captura la posicion en la tabla
            poc = dataGridView1.CurrentRow.Index;
            //captura los textBox y le asignamos un valor
            txtNom.Text = dataGridView1[0, poc].Value.ToString();
            txtDireccion.Text = dataGridView1[1, poc].Value.ToString();
            txtTelePar.Text = dataGridView1[2, poc].Value.ToString();
            txtTelemo.Text = dataGridView1[3, poc].Value.ToString();
            txtTeleTra.Text = dataGridView1[4, poc].Value.ToString();
            txtExtension.Text = dataGridView1[5, poc].Value.ToString();
            txtCorreo.Text = dataGridView1[6, poc].Value.ToString();
            txtComentario.Text = dataGridView1[7, poc].Value.ToString();

            //abilitamos los botones Modificar/Eliminar y desabilitamos Agregar para que no se inserte un dato
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            

        }
    }
}
