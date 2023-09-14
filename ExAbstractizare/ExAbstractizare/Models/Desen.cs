using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    public class Desen : IFigura
    {
        private int _idDesen;
        private List<IFigura> figuri;

        public Desen(int idDesen, List<IFigura> figuri)
        {
            _idDesen = idDesen;
            this.figuri = figuri;
        }

        public int IdDesen { get => _idDesen; set => _idDesen = value; }

        public List<IFigura> Figuri { get => figuri; set => figuri = value; }

        public int IdFigura()
        {
           return IdDesen;
        }

        public void Afisare()
        {

            foreach (IFigura f in figuri)
            {
                f.Afisare();
            }

        }

        public void Translatare(int x,int y)
        {
            foreach(IFigura f in figuri)
            {
                f.Translatare(x,y);
            }
        }

        public void Duplicare()
        {
            foreach (IFigura f in figuri)
            {
                f.Duplicare();
            }
        }

    }
}
