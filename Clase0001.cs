using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prueba1
{
    class Clase0001
    {
        //public string rutaUniversidad = "Data Source=FRANCIS-PC\\SQLDESAROLLO;Initial Catalog=Universidad;Integrated Security=True";
        public string rutaUniversidad = "Data Source=localhost\\sqlexpress;Initial Catalog=Universidad;Integrated Security=True";

            public DataTable mostrartabla(string consulta, string tabla){
                  SqlConnection cnUniversidad = new SqlConnection(rutaUniversidad);
            
                  SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnUniversidad);
                  DataSet dsAlumno = new DataSet();

                  cnUniversidad.Open();
                  
                     adaptador.Fill(dsAlumno, tabla);
        
                  cnUniversidad.Close();
                  return dsAlumno.Tables[tabla];
            }



            private void ArmarParametros(ref SqlCommand comando, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@Legajo", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
                parametros.Value = c;
                parametros = comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50);
                parametros.Value = d;
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = e;
                parametros = comando.Parameters.Add("@direccion", SqlDbType.VarChar, 50);
                parametros.Value = f;
                parametros = comando.Parameters.Add("@localidad", SqlDbType.VarChar, 50);
                parametros.Value = g;
                parametros = comando.Parameters.Add("@cp", SqlDbType.VarChar, 50);
                parametros.Value = h;
                parametros = comando.Parameters.Add("@pais", SqlDbType.VarChar, 50);
                parametros.Value = i;
                parametros = comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
                parametros.Value = Convert.ToDateTime(j);
                parametros = comando.Parameters.Add("@especialidad", SqlDbType.VarChar, 50);
                parametros.Value = k;
                parametros = comando.Parameters.Add("@lugar", SqlDbType.VarChar, 50);
                parametros.Value = k;
                parametros = comando.Parameters.Add("@egresado", SqlDbType.VarChar, 50);
                parametros.Value = m;
                parametros = comando.Parameters.Add("@tutor", SqlDbType.VarChar, 50);
                parametros.Value = n;
                parametros = comando.Parameters.Add("@Cuatrimestre", SqlDbType.VarChar, 50);
                parametros.Value = o;
            }

            private void ArmarParametrosTutor(ref SqlCommand comando, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodTutor", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
                parametros.Value = c;
                parametros = comando.Parameters.Add("@DNI", SqlDbType.Int, 50);
                parametros.Value = d;
                parametros = comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 50);
                parametros.Value = e;
                parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 50);
                parametros.Value = f;
                parametros = comando.Parameters.Add("@cp", SqlDbType.VarChar, 50);
                parametros.Value = g;
                parametros = comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50);
                parametros.Value = h;
                parametros = comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
                parametros.Value = i;
                parametros = comando.Parameters.Add("@pais", SqlDbType.VarChar, 50);
                parametros.Value = j;
            }

            private void ArmarParametrosAula(ref SqlCommand comando, string a, bool b, string c)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodAula", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Computadoras", SqlDbType.Bit);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Capacidad", SqlDbType.VarChar, 50);
                parametros.Value = c;
            }

            private void ArmarParametrosCarrera(ref SqlCommand comando, string a, string b)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodCarrera", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
            }
            
            private void ArmarParametrosDirectivos(ref SqlCommand comando, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string m)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodDirectivo", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
                parametros.Value = c;
                parametros = comando.Parameters.Add("@Cargo", SqlDbType.VarChar, 50);
                parametros.Value = d;
                parametros = comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 50);
                parametros.Value = e;
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = f;
                parametros = comando.Parameters.Add("@DIreccion", SqlDbType.VarChar, 50);
                parametros.Value = g;
                parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 50);
                parametros.Value = h;
                parametros = comando.Parameters.Add("@CP", SqlDbType.VarChar, 50);
                parametros.Value = i;
                parametros = comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
                parametros.Value = j;
                parametros = comando.Parameters.Add("@Pais", SqlDbType.VarChar, 50);
                parametros.Value = k;
                parametros = comando.Parameters.Add("@CodCarrera", SqlDbType.VarChar, 50);
                parametros.Value = m;
            }

            private void ArmarParametrosEmpleado(ref SqlCommand comando, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodEmpleado", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
                parametros.Value = c;       
                parametros = comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 50);
                parametros.Value = d;
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = e;
                parametros = comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 50);
                parametros.Value = f;
                parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 50);
                parametros.Value = g;
                parametros = comando.Parameters.Add("@CP", SqlDbType.VarChar, 50);
                parametros.Value = h;
                parametros = comando.Parameters.Add("@Pais", SqlDbType.VarChar, 50);
                parametros.Value = i;
                parametros = comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
                parametros.Value = j;
                parametros = comando.Parameters.Add("@Ocupacion", SqlDbType.VarChar, 50);
                parametros.Value = k;
            }

            private void ArmarParametrosHorario(ref SqlCommand comando, string a, string b, string c, string d)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodHorario", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Horario", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Turno", SqlDbType.VarChar, 50);
                parametros.Value = c;
                parametros = comando.Parameters.Add("@Dia", SqlDbType.VarChar, 50);
                parametros.Value = d;
            }

            private void ArmarParametrosMateria(ref SqlCommand comando, string a, string b, string c)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodMateria", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@CodEspecialidad", SqlDbType.VarChar, 50);
                parametros.Value = c;
            }

            private void ArmarParametrosProfesor(ref SqlCommand comando, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@Legajo", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
                parametros.Value = c;
                parametros = comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 50);
                parametros.Value = d;
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = e;
                parametros = comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 50);
                parametros.Value = f;
                parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 50);
                parametros.Value = g;
                parametros = comando.Parameters.Add("@CP", SqlDbType.VarChar, 50);
                parametros.Value = h;
                parametros = comando.Parameters.Add("@Pais", SqlDbType.VarChar, 50);
                parametros.Value = i;
                parametros = comando.Parameters.Add("@Fecha", SqlDbType.SmallDateTime);
                parametros.Value = j;
            }

            private void ArmarParametrosAsignarProfesor(ref SqlCommand comando, string a, string b)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@Legajo", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Cod_Materia", SqlDbType.VarChar, 50);
                parametros.Value = b;

            }

            private void ArmarParametrosAsignarAlumno(ref SqlCommand comando, string a, string b, string c)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = a;
                parametros = comando.Parameters.Add("@Cod_Materia", SqlDbType.VarChar, 50);
                parametros.Value = b;
                parametros = comando.Parameters.Add("@Cuatrimestre", SqlDbType.VarChar, 50);
                parametros.Value = c;

            }

            private void EliminarAlumnoParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@DNI", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarTutorParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodTutor", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarAulaParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodAula", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }
            
            private void EliminarCarreraParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodCarrera", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarDirectivoParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodDirectivo", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarEmpleadoParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodEmpleado", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarHorarioParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodHorario", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarMateriaParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@CodMateria", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EliminarProfesorParametros(ref SqlCommand comando, string a)
            {
                SqlParameter parametros = new SqlParameter();
                parametros = comando.Parameters.Add("@Legajo", SqlDbType.VarChar, 50);
                parametros.Value = a;
            }

            private void EjecutarProcedure(string ruta, string nombreP, SqlCommand comando)
            {
               
                SqlConnection Conexion = new SqlConnection(ruta);
                Conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = comando;
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreP;
                cmd.ExecuteReader();
                Conexion.Close();
            }
            //////////////////////////////////////////////////////////////////////////  Agregar/Modificar/Eliminar Datos  //////////////////////////////////////////////////////////////////////////////////////
            public void AgregarAlumno(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
            {

                SqlCommand comando = new SqlCommand();
                //ArmarParametros(ref comando, fila);
                ArmarParametros(ref comando, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
                EjecutarProcedure(rutaUniversidad, "AgregarAlumno", comando);

            }
            public void EliminarAlumno(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarAlumnoParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarAlumno2", comando);

            }

            public void ModificarAlumno(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametros(ref comando, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
                EjecutarProcedure(rutaUniversidad, "ModificarAlumnos", comando);
            }

            public void AgregarTutor(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosTutor(ref comando, a, b, c, d, e, f, g, h, i, j);
                EjecutarProcedure(rutaUniversidad, "AgregarTutor", comando);

            }

            public void EliminarTutor(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarTutorParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarTutor", comando);
            }

            public void ModificarTutor(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosTutor(ref comando, a, b, c, d, e, f, g, h, i, j);
                EjecutarProcedure(rutaUniversidad, "ModificarTutor", comando);
            }

            public void AgregarAula(string a, bool b, string c)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosAula(ref comando, a, b, c);
                EjecutarProcedure(rutaUniversidad, "AgregarAula", comando);
            }

            public void EliminarAula(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarAulaParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarAula", comando);
            }

            public void ModificarAula(string a, bool b, string c)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosAula(ref comando, a, b, c);
                EjecutarProcedure(rutaUniversidad, "ModificarAula", comando);
            }

            public void AgregarCarrera(string a, string b)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosCarrera(ref comando, a, b);
                EjecutarProcedure(rutaUniversidad, "AgregarCarrera", comando);
            }

            public void EliminarCarrera(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarCarreraParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarCarrera", comando);
            }

            public void ModificarCarrera(string a, string b)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosCarrera(ref comando, a, b);
                EjecutarProcedure(rutaUniversidad, "ModificarCarrera", comando);
            }

            public void AgregarDirectivo(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string m)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosDirectivos(ref comando, a, b, c, d, e, f, g, h, i, j, k, m);
                EjecutarProcedure(rutaUniversidad, "AgregarDirectivo", comando);
            }

            public void EliminarDirectivo(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarDirectivoParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarDirectivo", comando);
            }

            public void ModificarDirectivo(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string m)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosDirectivos(ref comando, a, b, c, d, e, f, g, h, i, j, k, m);
                EjecutarProcedure(rutaUniversidad, "ModificarDirectivo", comando);
            }

            public void AgregarEmpleado(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosEmpleado(ref comando, a, b, c, d, e, f, g, h, i, j, k);
                EjecutarProcedure(rutaUniversidad, "AgregarEmpleado", comando);
            }

            public void EliminarEmpleado(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarEmpleadoParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarEmpleado", comando);
            }
            
            public void ModificarEmpleado(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosEmpleado(ref comando, a, b, c, d, e, f, g, h, i, j, k);
                EjecutarProcedure(rutaUniversidad, "ModificarEmpleado", comando);
            }

            public void AgregarHorario(string a, string b, string c, string d)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosHorario(ref comando, a, b, c, d);
                EjecutarProcedure(rutaUniversidad, "AgregarHorario", comando);
            }

            public void EliminarHorario(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarHorarioParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarHorario", comando);
            }

            public void ModificarHorario(string a, string b, string c, string d)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosHorario(ref comando, a, b, c, d);
                EjecutarProcedure(rutaUniversidad, "ModificarHorario", comando);
            }

            public void AgregarMateria(string a, string b, string c)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosMateria(ref comando, a, b, c);
                EjecutarProcedure(rutaUniversidad, "AgregarMateria", comando);
            }

            public void EliminarMateria(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarMateriaParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarMateria", comando);
            }

            public void ModificarMateria(string a, string b, string c)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosMateria(ref comando, a, b, c);
                EjecutarProcedure(rutaUniversidad, "ModificarMateria", comando);
            }

            public void AgregarProfesor(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosProfesor(ref comando, a, b, c, d, e, f, g, h, i, j);
                EjecutarProcedure(rutaUniversidad, "AgregarProfesor", comando);
            }

            public void EliminarProfesor(string a)
            {
                SqlCommand comando = new SqlCommand();
                EliminarProfesorParametros(ref comando, a);
                EjecutarProcedure(rutaUniversidad, "EliminarProfesor", comando);
            }

            public void ModificarProfesor(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosProfesor(ref comando, a, b, c, d, e, f, g, h, i, j);
                EjecutarProcedure(rutaUniversidad, "ModificarProfesor", comando);
            }

            public void AsignarProfesor(string a, string b)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosAsignarProfesor(ref comando, a, b);
                EjecutarProcedure(rutaUniversidad, "AsignarProfesor", comando);
            }

            public void AsignarAlumno(string a, string b, string c)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametrosAsignarAlumno(ref comando, a, b, c);
                EjecutarProcedure(rutaUniversidad, "AsignarAlumno", comando);
            }

    }
    class clasemostrarmateria
    {
        DataSet dsAgregar;
        DataSet dsUniversidad;
        string rutaUniversidad = "Data Source=localhost\\sqlexpress;Initial Catalog=Universidad;Integrated Security=True";
        public DataTable mostrartablamateria(string consulta, string tabla)
        {
            SqlConnection cnUniversidad = new SqlConnection(rutaUniversidad);

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnUniversidad);
            DataSet dsAlumno = new DataSet();

            cnUniversidad.Open();

            adaptador.Fill(dsAlumno, tabla);

            cnUniversidad.Close();
            return dsAlumno.Tables[tabla];
        }
    }
}
