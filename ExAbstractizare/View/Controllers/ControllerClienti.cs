using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Models;

namespace View.Controllers
{
    internal class ControllerClienti
    {


        List<Client> clienti;

        // List<int> list;
        public ControllerClienti()
        {
            clienti = new List<Client>();
            // list = new List<int>();
            load();
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/useri.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                clienti.Add(new Client(t));
            }

            streamReader.Close();
        }

        public void afisare()
        {
            foreach (Client client in clienti)
            {
                MessageBox.Show(client.Id.ToString());
            }
        }

        public bool verificare(string name, string pass)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Name == name && clienti[i].Password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public Client getClient(string name, string pass)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Name == name && clienti[i].Password == pass)
                {
                    return clienti[i];
                }
            }
            return null;
        }

        public Client getById(int id)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (id == clienti[i].Id) return clienti[i];
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next(0, 10000);

            while (this.getById(id) != null)
            {
                id = random.Next(0, 100000);
            }

            return id;
        }

        public void save(string text)
        {

            string path = Application.StartupPath + @"/data/useri.txt";
            File.AppendAllText(path, text + "\n");

        }

        public int pozIdClient(int id)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Id == id) return i;
            }
            return -1;
        }

        public string toSave()
        {
            string t = "";

            for (int i = 0; i < clienti.Count; i++)
            {
                t += clienti[i].tosave() + "\n";
            }

            return t;
        }

        public void update()
        {
            string path = Application.StartupPath + @"/data/useri.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSave());
            streamWriter.Close();
        }



    }
}
