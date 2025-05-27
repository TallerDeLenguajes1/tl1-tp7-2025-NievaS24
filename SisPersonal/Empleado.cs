namespace EspacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCiv;
        private DateTime fechaIngreso;
        private double basico;
        private Cargos cargo;
        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCiv, DateTime fechaIngreso, double basico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.estadoCiv = estadoCiv;
            this.fechaIngreso = fechaIngreso;
            this.basico = basico;
            this.cargo = cargo;
        }
        public string Nombre
        {
            get => nombre;
        }
        public string Apellido
        {
            get => apellido;
        }
        public DateTime FechaNac
        {
            get => fechaNac;
        }
        public char EstadoCiv
        {
            get => estadoCiv;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso;
        }
        public double Basico
        {
            get => basico;
        }
        public Cargos Cargo
        {
            get => cargo;
        }

        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        public int Antiguedad()
        {
            return DateTime.Now.Year - this.fechaIngreso.Year;
        }
        public int Edad()
        {
            return DateTime.Now.Year - this.fechaNac.Year;
        }
        public int AniosRestantes()
        {
            return 65 - this.Edad();
        }
        public double Salario()
        {
            double adicional = 0;
            int antiguedad = this.Antiguedad();
            if (antiguedad > 0 && antiguedad < 20)
            {
                adicional += basico * 0.01 * antiguedad;
            }
            else if (antiguedad >= 20)
            {
                adicional += basico * 0.25;
            }
            if (this.cargo == Cargos.Ingeniero || this.cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }
            if (this.estadoCiv == 'C')
            {
                adicional += 150000;
            }
            return basico + adicional;
        }
    }
}