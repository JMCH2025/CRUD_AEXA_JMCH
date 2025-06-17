

namespace CRUD_AEXA_JMCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void Clear()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            chkReactivar.Checked = false;
        }

        private void CargarEmpleados()
        {
            bool incluirInactivos = chkInactivos.Checked;

            if (incluirInactivos)
            {
                dgvEmpleados.DataSource = EmpleadoQuerys.ObtenerTodos(true);
            }
            else
            {
                dgvEmpleados.DataSource = EmpleadoQuerys.ObtenerTodos(false);
            }
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es un campo obligatorio.");
                return;
            }

            empleado emp = new empleado
            {
                nombre = txtNombre.Text,
                descripcion = txtDescripcion.Text
            };

            try
            {
                EmpleadoQuerys.Crear(emp);
                CargarEmpleados();
                MessageBox.Show("Empleado agregado correctamente al sistema.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear al Empleado: " + ex.Message);
            }

            Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado para actualizar.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

                empleado emp = new empleado
                {
                    id = id,
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text,
                    activo = chkReactivar.Checked ? 1 : 1
                };

                EmpleadoQuerys.Actualizar(emp);
                CargarEmpleados();
                Clear();
                MessageBox.Show("Empleado actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }


        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado para marcarlo como Inactivo.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);
                EmpleadoQuerys.EliminarLogico(id);
                CargarEmpleados();
                MessageBox.Show("Empleado marcado como inactivo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al intentar marcarlo como Inactivo " + ex.Message);
            }

            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado para eliminar físicamente.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado permanentemente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);
                EmpleadoQuerys.EliminarFisico(id);
                CargarEmpleados();
                MessageBox.Show("Empleado eliminado físicamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar físicamente: " + ex.Message);
            }
        }

        private void chkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["descripcion"].Value.ToString();

            }
        }
    }
}