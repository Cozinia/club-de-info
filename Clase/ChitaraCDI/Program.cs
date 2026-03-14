using System;

namespace ChitaraCDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Chitara zdronganitoare = new Chitara();
            int a = 5;
            Console.WriteLine("Nume:" + zdronganitoare.nume + "\nPret: " + zdronganitoare.pret + "\nEste electrica? " + zdronganitoare.esteElectrica + "\nNumar corzi: " + zdronganitoare.GetNrCorzi() +"\nEste Bass" + zdronganitoare.GetEsteBass());
            zdronganitoare.SetEbass(true);
            zdronganitoare.SetNrCorzi(9);
            Console.WriteLine("Nume:" + zdronganitoare.nume + "\nPret: " + zdronganitoare.pret + "\nEste electrica? " + zdronganitoare.esteElectrica + "\nNumar corzi: " + zdronganitoare.GetNrCorzi() + "\nEste Bass" + zdronganitoare.GetEsteBass());


            Chitara ch2 = new Chitara("Georgica", (float)50.82, false);
            Console.WriteLine("Nume:" + ch2.nume + "\nPret: " + ch2.pret + "\nEste electrica? " + ch2.esteElectrica);
            ch2.SetNrCorzi(586);
            ch2.SetEbass(true);
            Console.WriteLine("Nume:" + ch2.nume + "\nPret: " + ch2.pret + "\nEste electrica? " + ch2.esteElectrica +"\n nr corzi"+ch2.GetNrCorzi()+"\n estebass"+ch2.GetEsteBass());


        }
    }
}
