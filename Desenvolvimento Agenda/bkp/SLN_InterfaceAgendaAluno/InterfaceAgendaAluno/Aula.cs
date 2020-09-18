using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAgendaAluno
{
    class Aula
    {
        public int idAula { set; get; }
        public string dataAula { set; get; }
        public string locall { set; get; }
        public string horaInicio {set;get;}
        public string horaTermino { set; get; }
        public int codTurma { set; get; }
        public int codDisciplina { set; get; }
    }
}
