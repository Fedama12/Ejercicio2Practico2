using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Practico2
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { ID = 1, Name = "IAlpha" });
            listaEmpresas.Add(new Empresa { ID = 2, Name = "Udelar" });
            listaEmpresas.Add(new Empresa { ID = 3, Name = "SpaceZ" });

            listaEmpleados.Add(new Empleado { ID = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaID = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { ID = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { ID = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { ID = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { ID = 5, Nombre = "GonzaloT", Cargo = "CEO", EmpresaID = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { ID = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaID = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { ID = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaID = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { ID = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaID = 3, Salario = 3000 });



        }

        public void getSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados where empleado.Cargo == _Cargo select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }

        public void getEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Salario select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }

        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaID
                                              equals empresa.ID
                                              where empresa.ID == _Empresa
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }


        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaID
                           into g
                           select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };

            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {

                }
            }
        }
    }
}
