using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Message
    {
        private int matin = 9;    
        private int midi = 13;
        private int soir = 18;

        //récupère le nom utilisateur
        String userName = System.Environment.UserName;

        //récupère la date det heure du jour
        DateTime localDate = DateTime.Now;

        //récupère les jours de la semaine
        DayOfWeek today = DateTime.Today.DayOfWeek;

        //constructeur
        public Message(int matin, int midi, int soir)
        {
            this.matin = matin;
            this.midi = midi;
            this.soir = soir;
        }

        //Modification du msg en fonction du jour et heure courante
        public void GetHelloMessage()
        {
            if (today == DayOfWeek.Saturday | today == DayOfWeek.Sunday | (today == DayOfWeek.Friday & localDate.Hour >= soir) | (today == DayOfWeek.Monday & localDate.Hour <= matin))
            {
                Console.WriteLine("Bon week-end " + userName);
            }
            else if (localDate.Hour >= soir | localDate.Hour <= matin)
            {
                Console.WriteLine("Bonsoir " + userName + "\n" + localDate.ToString("F"));
            }
            else if (localDate.Hour >= midi | localDate.Hour <= soir)
            {
                Console.WriteLine("Bon après-midi " + userName + "\n" + localDate.ToString("F"));
            }
            else
            {
                Console.WriteLine("Bonjour " + userName + "\n" + localDate.ToString("F"));
            }

        }
    }
}
