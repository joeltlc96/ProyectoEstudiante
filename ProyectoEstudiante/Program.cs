using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoEstudiante
{
    internal class Program
    {
       
        public class Estudiante
        {
            public string Cedula;
            public string Nombre;
            public string apellido;
            public string direccion;
            public int Edad;
            public string Correo;
            public List<Decimal> HistorialAcademico;

            public Estudiante() { HistorialAcademico = new List<Decimal>(); }

            public Estudiante(string cedula, string nombre, string apellido, string direccion, int edad, string correo, List<decimal> historialAcademico)
            {
                Cedula = cedula;
                Nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                Edad = edad;
                Correo = correo;
                HistorialAcademico = historialAcademico;
            }
        }

        public class Cursos
        {
            public string Codigo;
            public string Nombre;
            public List<string> listaestudiantesmatriculados;
            public string profesor_a_cargo;
            public DateTime horario;
            public List<string> matrial_de_curso;
            public List<string> historial_de_asistencias;
            public List<Decimal> historial_de_notas;

            //faltan los metodos





        }

        public class Asistencias
        {
            public DateTime Fecha;
            public List<string> listaestudiantesP;
            public List<string> listaestudiantesA;

            //faltan los metodos

        }

        public class Nota
        {
            public int evaluacion;
            public string Estudianrte;
            public string Curso;
            public Decimal Puntuacion;
            public DateTime fecha;
            public string Comentarios;

            //faltan los metodos

        }

        public class Sistemaeducativo
        {
            List<Estudiante> listaestudiantes;
            List<Cursos> ListaCursos;
            List<string> historialdeasistencias;
            List<Decimal> historialdenotas;

            //faltan los metodos

        }

        //si pueden mejorarlo mejorenlo
        static void Main(string[] args)
        {
            Boolean bContinuar = true;
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            do
            {
                Console.Clear();
                int opcion = 0;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*************************************************");
                Console.WriteLine("********TecnoEducativo Cristiano Integral********");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*****************TECI System*********************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("");
                Console.WriteLine("1.- Creación de Estudiantes");
                Console.WriteLine("2.- Creación de Docentes");
                Console.WriteLine("3.- Creación de Curso");
                Console.WriteLine("4.- Ingreso de Notas");
                Console.WriteLine("5.- Ver Estudiantes");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una Opción");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("********INGRESO DE ESTUDIANTES********");
                        Estudiante nuevoEstudiante = CrearEstudiante();
                        listaEstudiantes.Add(nuevoEstudiante);
                        MostrarPantallaCarga();
                        Console.WriteLine(" Estudiante nuevo " + nuevoEstudiante.Nombre + " Ingresado exitosamente.");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("********CREACIÓN DE DOCENTES********");
                        Console.Write("Ingrese el Nombre del Nuevo Docente: ");
                        string sDocente = Console.ReadLine();
                        MostrarPantallaCarga();
                        Console.WriteLine("Docente creado exitosamente.");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("********CREACIÓN DE CURSO********");
                        Console.Write("Ingrese el Nombre de la Nuevo Curso: ");
                        string sMateria = Console.ReadLine();
                        MostrarPantallaCarga();
                        Console.WriteLine("Notas ingresadas exitosamente.");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("********INGRESO DE NOTAS********");
                        Console.Write("Ingrese el Nombre de la Nueva Materia: ");

                        MostrarPantallaCarga();
                        Console.WriteLine("Notas ingresadas exitosamente.");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("********VER ESTUDIANTES********");
                        MostrarEstudiantes(listaEstudiantes);
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 6:
                        bContinuar = false;
                        break;

                }


            } while (bContinuar);


        }
        static Estudiante CrearEstudiante()
        {
            Estudiante estudiante = new Estudiante();

            Console.Write("Ingrese la Cédula del Estudiante: ");
            estudiante.Cedula = Console.ReadLine();

            Console.Write("Ingrese el Nombre del Estudiante: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Ingrese la Edad del Estudiante: ");
            estudiante.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el Correo del Estudiante: ");
            estudiante.Correo = Console.ReadLine();

            return estudiante;
        }

        static void MostrarEstudiantes(List<Estudiante> estudiantes)
        {
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Cédula: {estudiante.Cedula}, Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Correo: {estudiante.Correo}");
            }
        }

        static void MostrarPantallaCarga()
        {
            Console.WriteLine("Procesando...");
            Thread.Sleep(2000);
            Console.Clear();
        }
        //copiar y pegar dentro del Internal class Program






    }
}
