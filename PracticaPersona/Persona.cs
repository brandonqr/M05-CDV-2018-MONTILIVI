using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPersona
{
    class Persona
    {
        private string nombre;
        private string dataNaixement;
        private string nif;
        private char sexe;
        private double pes;
        private double alçada;


        public string calcularIMC()
        {
            double resultat = pes / (Math.Pow(alçada, 2));
            string cadena = "";
            if (resultat < 18)
                cadena = "Baix";
            if (resultat > 18 && resultat < 24.9)
                cadena = "Normal";
            else if (resultat > 25 && resultat < 26.9)
                cadena = "Sobrepes";
            else
                cadena = "Obes";
            return cadena;
        }
        public int edat()
        {
            DateTime fecha = DateTime.Now;
            int año = fecha.Year;
            int AñoNacimiento = Int32.Parse(dataNaixement.Split('/')[2]);
            return (año - AñoNacimiento);
        }
        public bool esMajorEdat()
        {
            return (edat() > 18) ? true : false;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string DNaixement
        {
            get
            {
                return dNaixement;
            }

            set
            {
                dNaixement = value;
            }
        }

        public string Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public char Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public double Pes
        {
            get
            {
                return pes;
            }

            set
            {
                pes = value;
            }
        }

        public double Alçada
        {
            get
            {
                return alçada;
            }

            set
            {
                alçada = value;
            }
        }

        public Persona(string nombre, string dNaixement, string nif, char sexe, double pes, double alçada)
        {
            this.Nombre = nombre;
            this.DNaixement = dNaixement;
            this.Nif = nif;
            this.Sexe = sexe;
            this.Pes = pes;
            this.Alçada = alçada;
        }
    }
}
