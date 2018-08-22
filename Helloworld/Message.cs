using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Message
    {
        private int matin = 9;
        private int midi = 13;
        private int soir = 17;
        private IDateTime _date;

        //récupère le nom utilisateur
        String userName = System.Environment.UserName;

        //récupère la date et heure du jour + utile pour test méthode sans argument
        //DateTime localDate = DateTime.Now;

        //récupère les jours de la semaine
        //DayOfWeek today = DateTime.Today.DayOfWeek;


        //constructeur
        //public Message(int matin, int midi, int soir)
        //{
        //    this.matin = matin;
        //    this.midi = midi;
        //    this.soir = soir;
        //}

        //constructeur pour interface
        public Message()
            : this(new RealDateTime())
        {
        }

        public Message(IDateTime date)
        {
            _date = date;
        }
        
        //Modification du msg en fonction du jour et heure courante
        public String GetHelloMessage()
        {
            //DayOfWeek today = localDate.DayOfWeek;
            DateTime localDate = _date.Date;
            DayOfWeek today = _date.Date.DayOfWeek;

            String result = " ";

            if (today == DayOfWeek.Saturday | today == DayOfWeek.Sunday | (today == DayOfWeek.Friday & localDate.Hour >= soir) | (today == DayOfWeek.Monday & localDate.Hour <= matin))
            {
                result = "Bon weekend " + userName + "\n" + localDate.ToString("F");
            }
            else if (localDate.Hour > soir | localDate.Hour < matin)
            {
                result = "Bonsoir " + userName + "\n" + localDate.ToString("F");
            }
            else if (localDate.Hour <= midi)
            {
                result = "Bonjour " + userName + "\n" + localDate.ToString("F");
            }
            else
            {
                result = "Bon après-midi " + userName + "\n" + localDate.ToString("F");
            }
            return result;
        }
    }
}
