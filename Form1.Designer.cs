namespace Prueba1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.elimarProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCarreras = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDirectivos = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDirectivos = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDirectivos = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDirectivos = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDirectivos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTablaHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaXAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaXProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaXCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasXMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.directivosXCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorXAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAlumno,
            this.MenuMateria,
            this.MenuProfesor,
            this.MenuEmpleado,
            this.MenuAulas,
            this.MenuCarreras,
            this.MenuTutor,
            this.MenuDirectivos,
            this.MenuHorario,
            this.MenuInformes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAlumno
            // 
            this.MenuAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlumno,
            this.modificarAlumno,
            this.eliminarAlumno,
            this.mostrarAlumno});
            this.MenuAlumno.Name = "MenuAlumno";
            this.MenuAlumno.Size = new System.Drawing.Size(62, 20);
            this.MenuAlumno.Text = "Alumno";
            // 
            // agregarAlumno
            // 
            this.agregarAlumno.Name = "agregarAlumno";
            this.agregarAlumno.Size = new System.Drawing.Size(192, 22);
            this.agregarAlumno.Text = "Agregar Alumno";
            this.agregarAlumno.Click += new System.EventHandler(this.agregarAlumno_Click);
            // 
            // modificarAlumno
            // 
            this.modificarAlumno.Name = "modificarAlumno";
            this.modificarAlumno.Size = new System.Drawing.Size(192, 22);
            this.modificarAlumno.Text = "Modificar Alumno";
            this.modificarAlumno.Click += new System.EventHandler(this.modificarAlumno_Click);
            // 
            // eliminarAlumno
            // 
            this.eliminarAlumno.Name = "eliminarAlumno";
            this.eliminarAlumno.Size = new System.Drawing.Size(192, 22);
            this.eliminarAlumno.Text = "Eliminar Alumno";
            this.eliminarAlumno.Click += new System.EventHandler(this.eliminarAlumno_Click);
            // 
            // mostrarAlumno
            // 
            this.mostrarAlumno.Name = "mostrarAlumno";
            this.mostrarAlumno.Size = new System.Drawing.Size(192, 22);
            this.mostrarAlumno.Text = "Mostrar Tabla Alumno";
            this.mostrarAlumno.Click += new System.EventHandler(this.mostrarAlumno_Click);
            // 
            // MenuMateria
            // 
            this.MenuMateria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMateria,
            this.modificarMateria,
            this.eliminarMateria,
            this.mostrarMateria,
            this.asignarAlumnoToolStripMenuItem});
            this.MenuMateria.Name = "MenuMateria";
            this.MenuMateria.Size = new System.Drawing.Size(59, 20);
            this.MenuMateria.Text = "Materia";
            // 
            // agregarMateria
            // 
            this.agregarMateria.Name = "agregarMateria";
            this.agregarMateria.Size = new System.Drawing.Size(189, 22);
            this.agregarMateria.Text = "Agregar Materia";
            this.agregarMateria.Click += new System.EventHandler(this.agregarMateria_Click);
            // 
            // modificarMateria
            // 
            this.modificarMateria.Name = "modificarMateria";
            this.modificarMateria.Size = new System.Drawing.Size(189, 22);
            this.modificarMateria.Text = "Modificar Materia";
            this.modificarMateria.Click += new System.EventHandler(this.modificarMateria_Click);
            // 
            // eliminarMateria
            // 
            this.eliminarMateria.Name = "eliminarMateria";
            this.eliminarMateria.Size = new System.Drawing.Size(189, 22);
            this.eliminarMateria.Text = "Eliminar Materia";
            this.eliminarMateria.Click += new System.EventHandler(this.eliminarMateria_Click);
            // 
            // mostrarMateria
            // 
            this.mostrarMateria.Name = "mostrarMateria";
            this.mostrarMateria.Size = new System.Drawing.Size(189, 22);
            this.mostrarMateria.Text = "Mostrar Tabla Materia";
            this.mostrarMateria.Click += new System.EventHandler(this.mostrarMateria_Click);
            // 
            // asignarAlumnoToolStripMenuItem
            // 
            this.asignarAlumnoToolStripMenuItem.Name = "asignarAlumnoToolStripMenuItem";
            this.asignarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.asignarAlumnoToolStripMenuItem.Text = "Asignar Alumno";
            this.asignarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.asignarAlumnoToolStripMenuItem_Click);
            // 
            // MenuProfesor
            // 
            this.MenuProfesor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProfesor,
            this.modificarProfesor,
            this.elimarProfesor,
            this.mostrarProfesor,
            this.asignarMateriaToolStripMenuItem});
            this.MenuProfesor.Name = "MenuProfesor";
            this.MenuProfesor.Size = new System.Drawing.Size(63, 20);
            this.MenuProfesor.Text = "Profesor";
            // 
            // agregarProfesor
            // 
            this.agregarProfesor.Name = "agregarProfesor";
            this.agregarProfesor.Size = new System.Drawing.Size(204, 22);
            this.agregarProfesor.Text = "Agregar Profesor";
            this.agregarProfesor.Click += new System.EventHandler(this.agregarProfesor_Click);
            // 
            // modificarProfesor
            // 
            this.modificarProfesor.Name = "modificarProfesor";
            this.modificarProfesor.Size = new System.Drawing.Size(204, 22);
            this.modificarProfesor.Text = "Modificar Profesor";
            this.modificarProfesor.Click += new System.EventHandler(this.modificarProfesor_Click);
            // 
            // elimarProfesor
            // 
            this.elimarProfesor.Name = "elimarProfesor";
            this.elimarProfesor.Size = new System.Drawing.Size(204, 22);
            this.elimarProfesor.Text = "Eliminar Profesor";
            this.elimarProfesor.Click += new System.EventHandler(this.elimarProfesor_Click);
            // 
            // mostrarProfesor
            // 
            this.mostrarProfesor.Name = "mostrarProfesor";
            this.mostrarProfesor.Size = new System.Drawing.Size(204, 22);
            this.mostrarProfesor.Text = "Mostrar Tabla Profesores";
            this.mostrarProfesor.Click += new System.EventHandler(this.mostrarProfesor_Click);
            // 
            // asignarMateriaToolStripMenuItem
            // 
            this.asignarMateriaToolStripMenuItem.Name = "asignarMateriaToolStripMenuItem";
            this.asignarMateriaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.asignarMateriaToolStripMenuItem.Text = "Asignar Materia";
            this.asignarMateriaToolStripMenuItem.Click += new System.EventHandler(this.asignarMateriaToolStripMenuItem_Click);
            // 
            // MenuEmpleado
            // 
            this.MenuEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleado,
            this.modificarEmpleado,
            this.eliminarEmpleado,
            this.mostrarEmpleado});
            this.MenuEmpleado.Name = "MenuEmpleado";
            this.MenuEmpleado.Size = new System.Drawing.Size(72, 20);
            this.MenuEmpleado.Text = "Empleado";
            // 
            // agregarEmpleado
            // 
            this.agregarEmpleado.Name = "agregarEmpleado";
            this.agregarEmpleado.Size = new System.Drawing.Size(202, 22);
            this.agregarEmpleado.Text = "Agregar Empleado";
            this.agregarEmpleado.Click += new System.EventHandler(this.agregarEmpleado_Click);
            // 
            // modificarEmpleado
            // 
            this.modificarEmpleado.Name = "modificarEmpleado";
            this.modificarEmpleado.Size = new System.Drawing.Size(202, 22);
            this.modificarEmpleado.Text = "Modificar Empleado";
            this.modificarEmpleado.Click += new System.EventHandler(this.modificarEmpleado_Click);
            // 
            // eliminarEmpleado
            // 
            this.eliminarEmpleado.Name = "eliminarEmpleado";
            this.eliminarEmpleado.Size = new System.Drawing.Size(202, 22);
            this.eliminarEmpleado.Text = "Eliminar Empleado";
            this.eliminarEmpleado.Click += new System.EventHandler(this.eliminarEmpleado_Click);
            // 
            // mostrarEmpleado
            // 
            this.mostrarEmpleado.Name = "mostrarEmpleado";
            this.mostrarEmpleado.Size = new System.Drawing.Size(202, 22);
            this.mostrarEmpleado.Text = "Mostrar Tabla Empleado";
            this.mostrarEmpleado.Click += new System.EventHandler(this.mostrarEmpleado_Click);
            // 
            // MenuAulas
            // 
            this.MenuAulas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAulas,
            this.modificarAulas,
            this.eliminarAulas,
            this.mostrarAulas});
            this.MenuAulas.Name = "MenuAulas";
            this.MenuAulas.Size = new System.Drawing.Size(48, 20);
            this.MenuAulas.Text = "Aulas";
            // 
            // agregarAulas
            // 
            this.agregarAulas.Name = "agregarAulas";
            this.agregarAulas.Size = new System.Drawing.Size(178, 22);
            this.agregarAulas.Text = "Agregar Aulas";
            this.agregarAulas.Click += new System.EventHandler(this.agregarAulas_Click);
            // 
            // modificarAulas
            // 
            this.modificarAulas.Name = "modificarAulas";
            this.modificarAulas.Size = new System.Drawing.Size(178, 22);
            this.modificarAulas.Text = "Modificar Aulas";
            this.modificarAulas.Click += new System.EventHandler(this.modificarAulas_Click);
            // 
            // eliminarAulas
            // 
            this.eliminarAulas.Name = "eliminarAulas";
            this.eliminarAulas.Size = new System.Drawing.Size(178, 22);
            this.eliminarAulas.Text = "Eliminar Aulas";
            this.eliminarAulas.Click += new System.EventHandler(this.eliminarAulas_Click);
            // 
            // mostrarAulas
            // 
            this.mostrarAulas.Name = "mostrarAulas";
            this.mostrarAulas.Size = new System.Drawing.Size(178, 22);
            this.mostrarAulas.Text = "Mostrar Tabla Aulas";
            this.mostrarAulas.Click += new System.EventHandler(this.mostrarAulas_Click);
            // 
            // MenuCarreras
            // 
            this.MenuCarreras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCarrera,
            this.modificarCarrera,
            this.eliminarCarrera,
            this.mostrarCarrera});
            this.MenuCarreras.Name = "MenuCarreras";
            this.MenuCarreras.Size = new System.Drawing.Size(62, 20);
            this.MenuCarreras.Text = "Carreras";
            // 
            // agregarCarrera
            // 
            this.agregarCarrera.Name = "agregarCarrera";
            this.agregarCarrera.Size = new System.Drawing.Size(192, 22);
            this.agregarCarrera.Text = "Agregar Carrera";
            this.agregarCarrera.Click += new System.EventHandler(this.agregarCarrera_Click);
            // 
            // modificarCarrera
            // 
            this.modificarCarrera.Name = "modificarCarrera";
            this.modificarCarrera.Size = new System.Drawing.Size(192, 22);
            this.modificarCarrera.Text = "Modificar Carrera";
            this.modificarCarrera.Click += new System.EventHandler(this.modificarCarrera_Click);
            // 
            // eliminarCarrera
            // 
            this.eliminarCarrera.Name = "eliminarCarrera";
            this.eliminarCarrera.Size = new System.Drawing.Size(192, 22);
            this.eliminarCarrera.Text = "Eliminar Carrera";
            this.eliminarCarrera.Click += new System.EventHandler(this.eliminarCarrera_Click);
            // 
            // mostrarCarrera
            // 
            this.mostrarCarrera.Name = "mostrarCarrera";
            this.mostrarCarrera.Size = new System.Drawing.Size(192, 22);
            this.mostrarCarrera.Text = "Mostrar Tabla Carreras";
            this.mostrarCarrera.Click += new System.EventHandler(this.mostrarCarrera_Click);
            // 
            // MenuTutor
            // 
            this.MenuTutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTutor,
            this.modificarTutor,
            this.eliminarTutor,
            this.mostrarTutor});
            this.MenuTutor.Name = "MenuTutor";
            this.MenuTutor.Size = new System.Drawing.Size(48, 20);
            this.MenuTutor.Text = "Tutor";
            // 
            // agregarTutor
            // 
            this.agregarTutor.Name = "agregarTutor";
            this.agregarTutor.Size = new System.Drawing.Size(178, 22);
            this.agregarTutor.Text = "Agregar Tutor";
            this.agregarTutor.Click += new System.EventHandler(this.agregarTutor_Click);
            // 
            // modificarTutor
            // 
            this.modificarTutor.Name = "modificarTutor";
            this.modificarTutor.Size = new System.Drawing.Size(178, 22);
            this.modificarTutor.Text = "Modificar Tutor";
            this.modificarTutor.Click += new System.EventHandler(this.modificarTutor_Click);
            // 
            // eliminarTutor
            // 
            this.eliminarTutor.Name = "eliminarTutor";
            this.eliminarTutor.Size = new System.Drawing.Size(178, 22);
            this.eliminarTutor.Text = "Eliminar Tutor";
            this.eliminarTutor.Click += new System.EventHandler(this.eliminarTutor_Click);
            // 
            // mostrarTutor
            // 
            this.mostrarTutor.Name = "mostrarTutor";
            this.mostrarTutor.Size = new System.Drawing.Size(178, 22);
            this.mostrarTutor.Text = "Mostrar Tabla Tutor";
            this.mostrarTutor.Click += new System.EventHandler(this.mostrarTutor_Click);
            // 
            // MenuDirectivos
            // 
            this.MenuDirectivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDirectivos,
            this.modificarDirectivos,
            this.eliminarDirectivos,
            this.mostrarDirectivos});
            this.MenuDirectivos.Name = "MenuDirectivos";
            this.MenuDirectivos.Size = new System.Drawing.Size(71, 20);
            this.MenuDirectivos.Text = "Directivos";
            // 
            // agregarDirectivos
            // 
            this.agregarDirectivos.Name = "agregarDirectivos";
            this.agregarDirectivos.Size = new System.Drawing.Size(201, 22);
            this.agregarDirectivos.Text = "Agregar Directivos";
            this.agregarDirectivos.Click += new System.EventHandler(this.agregarDirectivos_Click);
            // 
            // modificarDirectivos
            // 
            this.modificarDirectivos.Name = "modificarDirectivos";
            this.modificarDirectivos.Size = new System.Drawing.Size(201, 22);
            this.modificarDirectivos.Text = "Modificar Directivos";
            this.modificarDirectivos.Click += new System.EventHandler(this.modificarDirectivos_Click);
            // 
            // eliminarDirectivos
            // 
            this.eliminarDirectivos.Name = "eliminarDirectivos";
            this.eliminarDirectivos.Size = new System.Drawing.Size(201, 22);
            this.eliminarDirectivos.Text = "Eliminar Directivos";
            this.eliminarDirectivos.Click += new System.EventHandler(this.eliminarDirectivos_Click);
            // 
            // mostrarDirectivos
            // 
            this.mostrarDirectivos.Name = "mostrarDirectivos";
            this.mostrarDirectivos.Size = new System.Drawing.Size(201, 22);
            this.mostrarDirectivos.Text = "Mostrar Tabla Directivos";
            this.mostrarDirectivos.Click += new System.EventHandler(this.mostrarDirectivos_Click);
            // 
            // MenuHorario
            // 
            this.MenuHorario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarHorario,
            this.modificarHorario,
            this.eliminarHorario,
            this.mostrarTablaHorario});
            this.MenuHorario.Name = "MenuHorario";
            this.MenuHorario.Size = new System.Drawing.Size(59, 20);
            this.MenuHorario.Text = "Horario";
            // 
            // agregarHorario
            // 
            this.agregarHorario.Name = "agregarHorario";
            this.agregarHorario.Size = new System.Drawing.Size(189, 22);
            this.agregarHorario.Text = "Agregar Horario";
            this.agregarHorario.Click += new System.EventHandler(this.agregarHorario_Click);
            // 
            // modificarHorario
            // 
            this.modificarHorario.Name = "modificarHorario";
            this.modificarHorario.Size = new System.Drawing.Size(189, 22);
            this.modificarHorario.Text = "Modificar Horario";
            this.modificarHorario.Click += new System.EventHandler(this.modificarHorario_Click);
            // 
            // eliminarHorario
            // 
            this.eliminarHorario.Name = "eliminarHorario";
            this.eliminarHorario.Size = new System.Drawing.Size(189, 22);
            this.eliminarHorario.Text = "Eliminar Horario";
            this.eliminarHorario.Click += new System.EventHandler(this.eliminarHorario_Click);
            // 
            // mostrarTablaHorario
            // 
            this.mostrarTablaHorario.Name = "mostrarTablaHorario";
            this.mostrarTablaHorario.Size = new System.Drawing.Size(189, 22);
            this.mostrarTablaHorario.Text = "Mostrar Tabla Horario";
            this.mostrarTablaHorario.Click += new System.EventHandler(this.mostrarTablaHorario_Click);
            // 
            // MenuInformes
            // 
            this.MenuInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaXAlumno,
            this.materiaXProfesor,
            this.materiaXCarrera,
            this.aulasXMateria,
            this.directivosXCarrera,
            this.tutorXAlumno});
            this.MenuInformes.Name = "MenuInformes";
            this.MenuInformes.Size = new System.Drawing.Size(66, 20);
            this.MenuInformes.Text = "Informes";
            // 
            // materiaXAlumno
            // 
            this.materiaXAlumno.Name = "materiaXAlumno";
            this.materiaXAlumno.Size = new System.Drawing.Size(171, 22);
            this.materiaXAlumno.Text = "MateriaXAlumno";
            this.materiaXAlumno.Click += new System.EventHandler(this.materiaXAlumno_Click);
            // 
            // materiaXProfesor
            // 
            this.materiaXProfesor.Name = "materiaXProfesor";
            this.materiaXProfesor.Size = new System.Drawing.Size(171, 22);
            this.materiaXProfesor.Text = "MateriaXProfesor";
            this.materiaXProfesor.Click += new System.EventHandler(this.materiaXProfesor_Click);
            // 
            // materiaXCarrera
            // 
            this.materiaXCarrera.Name = "materiaXCarrera";
            this.materiaXCarrera.Size = new System.Drawing.Size(171, 22);
            this.materiaXCarrera.Text = "MateriaXCarrera";
            this.materiaXCarrera.Click += new System.EventHandler(this.materiaXCarrera_Click);
            // 
            // aulasXMateria
            // 
            this.aulasXMateria.Name = "aulasXMateria";
            this.aulasXMateria.Size = new System.Drawing.Size(171, 22);
            this.aulasXMateria.Text = "AulasXMateria";
            this.aulasXMateria.Click += new System.EventHandler(this.aulasXMateria_Click);
            // 
            // directivosXCarrera
            // 
            this.directivosXCarrera.Name = "directivosXCarrera";
            this.directivosXCarrera.Size = new System.Drawing.Size(171, 22);
            this.directivosXCarrera.Text = "DirectivosXCarrera";
            this.directivosXCarrera.Click += new System.EventHandler(this.directivosXCarrera_Click);
            // 
            // tutorXAlumno
            // 
            this.tutorXAlumno.Name = "tutorXAlumno";
            this.tutorXAlumno.Size = new System.Drawing.Size(171, 22);
            this.tutorXAlumno.Text = "TutorXAlumno";
            this.tutorXAlumno.Click += new System.EventHandler(this.tutorXAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(719, 490);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Universidad Tegnolociga Nacional";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAlumno;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumno;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mostrarAlumno;
        private System.Windows.Forms.ToolStripMenuItem MenuMateria;
        private System.Windows.Forms.ToolStripMenuItem agregarMateria;
        private System.Windows.Forms.ToolStripMenuItem modificarMateria;
        private System.Windows.Forms.ToolStripMenuItem eliminarMateria;
        private System.Windows.Forms.ToolStripMenuItem mostrarMateria;
        private System.Windows.Forms.ToolStripMenuItem MenuProfesor;
        private System.Windows.Forms.ToolStripMenuItem agregarProfesor;
        private System.Windows.Forms.ToolStripMenuItem modificarProfesor;
        private System.Windows.Forms.ToolStripMenuItem elimarProfesor;
        private System.Windows.Forms.ToolStripMenuItem mostrarProfesor;
        private System.Windows.Forms.ToolStripMenuItem MenuEmpleado;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem MenuAulas;
        private System.Windows.Forms.ToolStripMenuItem agregarAulas;
        private System.Windows.Forms.ToolStripMenuItem modificarAulas;
        private System.Windows.Forms.ToolStripMenuItem eliminarAulas;
        private System.Windows.Forms.ToolStripMenuItem mostrarAulas;
        private System.Windows.Forms.ToolStripMenuItem MenuCarreras;
        private System.Windows.Forms.ToolStripMenuItem agregarCarrera;
        private System.Windows.Forms.ToolStripMenuItem modificarCarrera;
        private System.Windows.Forms.ToolStripMenuItem eliminarCarrera;
        private System.Windows.Forms.ToolStripMenuItem mostrarCarrera;
        private System.Windows.Forms.ToolStripMenuItem MenuTutor;
        private System.Windows.Forms.ToolStripMenuItem agregarTutor;
        private System.Windows.Forms.ToolStripMenuItem modificarTutor;
        private System.Windows.Forms.ToolStripMenuItem eliminarTutor;
        private System.Windows.Forms.ToolStripMenuItem mostrarTutor;
        private System.Windows.Forms.ToolStripMenuItem MenuDirectivos;
        private System.Windows.Forms.ToolStripMenuItem agregarDirectivos;
        private System.Windows.Forms.ToolStripMenuItem modificarDirectivos;
        private System.Windows.Forms.ToolStripMenuItem eliminarDirectivos;
        private System.Windows.Forms.ToolStripMenuItem mostrarDirectivos;
        private System.Windows.Forms.ToolStripMenuItem MenuInformes;
        private System.Windows.Forms.ToolStripMenuItem materiaXAlumno;
        private System.Windows.Forms.ToolStripMenuItem materiaXProfesor;
        private System.Windows.Forms.ToolStripMenuItem materiaXCarrera;
        private System.Windows.Forms.ToolStripMenuItem aulasXMateria;
        private System.Windows.Forms.ToolStripMenuItem directivosXCarrera;
        private System.Windows.Forms.ToolStripMenuItem tutorXAlumno;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem MenuHorario;
        private System.Windows.Forms.ToolStripMenuItem agregarHorario;
        private System.Windows.Forms.ToolStripMenuItem modificarHorario;
        private System.Windows.Forms.ToolStripMenuItem eliminarHorario;
        private System.Windows.Forms.ToolStripMenuItem mostrarTablaHorario;
        private System.Windows.Forms.ToolStripMenuItem asignarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAlumnoToolStripMenuItem;
    }
}

