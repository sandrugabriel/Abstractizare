using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    public interface IFigura
    {

        int IdFigura();

        void Afisare();

        void Duplicare();

        void Translatare(int x, int y);

    }
}
