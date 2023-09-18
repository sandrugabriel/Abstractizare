using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Models
{
    public interface IFigura
    {

        int IdFigura();

        Color culoare();

        string Nume();

        void Afisare();

        void Duplicare();

        string Type();

        void translatare(int x1, int y1);

    }
}
