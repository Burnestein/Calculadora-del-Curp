using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_del_Curp
{
    //Clase que representa una persona
    // 22-09-2022 NJSA

    class Persona
    {
        //Atributos
        string nombres;
        string apPaterno;
        string apMaterno;
        string sexo;
        string fechaNac;
        string edoNac;

        public Persona(string nombres, string apPaterno, string apMaterno, string sexo, string fechaNac, string edoNac)
        {
            this.nombres = nombres;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.sexo = sexo;
            this.fechaNac = fechaNac;
            this.edoNac = edoNac;
        }

        //Metodos
    }
}
