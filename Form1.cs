using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        public void cerrarFormularioHijo()
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mostrarAlumno_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();
            
            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Alumnos order by legajo ", "Alumnos"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarMateria_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select Materia.Cod_Materia, Materia.nombre as Materia, Materia.Cod_especialidad, Carrera.Nombre as Carrera from materia inner join Carrera on Materia.Cod_especialidad=Carrera.Cod_Carrera order by cod_materia ", "Materia"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarProfesor_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Profesores order by Legajo ", "Profesores"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarEmpleado_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Empleados order by Cod_Empleado", "Empleados"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarAulas_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Aulas order by Cod_Aula", "Aulas"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarCarrera_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Carrera order by Cod_Carrera", "Carrera"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarTutor_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Tutor order by Cod_Tutor", "Tutor"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarDirectivos_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Directivos order by Cod_Directivo", "Directivos"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void mostrarTablaHorario_Click(object sender, EventArgs e)
        {
            Clase0001 c = new Clase0001();

            Mostratablas frm = new Mostratablas(c.mostrartabla("Select * from Horarios order by Cod_Horario", "Horarios"));
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarAlumno_Click(object sender, EventArgs e)
        {
           
            Agregaralumno frm = new Agregaralumno();
            
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarAlumno_Click(object sender, EventArgs e)
        {
            ModificarAlumno frm = new ModificarAlumno("xD");
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            EliminarAlumno frm = new EliminarAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarMateria_Click(object sender, EventArgs e)
        {
            AgregarMateria frm = new AgregarMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarMateria_Click(object sender, EventArgs e)
        {
            ModificarMateria frm = new ModificarMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarMateria_Click(object sender, EventArgs e)
        {
            EliminarMateria frm = new EliminarMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarProfesor_Click(object sender, EventArgs e)
        {
            AgregarProfesor frm = new AgregarProfesor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarProfesor_Click(object sender, EventArgs e)
        {
            ModificarProfesor frm = new ModificarProfesor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void elimarProfesor_Click(object sender, EventArgs e)
        {
            EliminarProfesor frm = new EliminarProfesor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frm = new AgregarEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarEmpleado_Click(object sender, EventArgs e)
        {
            ModificarEmpleado frm = new ModificarEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado frm = new EliminarEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarAulas_Click(object sender, EventArgs e)
        {
            AgregarAula frm = new AgregarAula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarAulas_Click(object sender, EventArgs e)
        {
            ModificarAulas frm = new ModificarAulas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarAulas_Click(object sender, EventArgs e)
        {
            EliminarAula frm = new EliminarAula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarCarrera_Click(object sender, EventArgs e)
        {
            AgregarCarrera frm = new AgregarCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarCarrera_Click(object sender, EventArgs e)
        {
            ModificarCarrera frm = new ModificarCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarCarrera_Click(object sender, EventArgs e)
        {
            EliminarCarrera frm = new EliminarCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarTutor_Click(object sender, EventArgs e)
        {
            AgregarTutor frm = new AgregarTutor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarTutor_Click(object sender, EventArgs e)
        {
            ModificarTutor frm = new ModificarTutor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarTutor_Click(object sender, EventArgs e)
        {
            EliminarTutor frm = new EliminarTutor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarDirectivos_Click(object sender, EventArgs e)
        {
            AgregarDirectivos frm = new AgregarDirectivos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarDirectivos_Click(object sender, EventArgs e)
        {
            ModificarDirectivo frm = new ModificarDirectivo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarDirectivos_Click(object sender, EventArgs e)
        {
            EliminarDirectivo frm = new EliminarDirectivo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarHorario_Click(object sender, EventArgs e)
        {
            AgregarHorario frm = new AgregarHorario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarHorario_Click(object sender, EventArgs e)
        {
            ModificarHorario frm = new ModificarHorario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarHorario_Click(object sender, EventArgs e)
        {
            EliminarHorario frm = new EliminarHorario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void materiaXAlumno_Click(object sender, EventArgs e)
        {
            MateriaxAlumno frm = new MateriaxAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void materiaXProfesor_Click(object sender, EventArgs e)
        {
            MateriaxProfesor frm = new MateriaxProfesor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void materiaXCarrera_Click(object sender, EventArgs e)
        {
            MateriasxCarrera frm = new MateriasxCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aulasXMateria_Click(object sender, EventArgs e)
        {
            AulaxMateria frm = new AulaxMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void directivosXCarrera_Click(object sender, EventArgs e)
        {
            DirectivosxCarrera frm = new DirectivosxCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tutorXAlumno_Click(object sender, EventArgs e)
        {
            TutorxAlumno frm = new TutorxAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignarTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void asignarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarMateria frm = new AsignarMateria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarAlumno frm = new AsignarAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
