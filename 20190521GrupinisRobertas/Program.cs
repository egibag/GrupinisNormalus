using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190521GrupinisRobertas
{
    public interface IDuombaze
    {
        void GautiDuomenis(); // Gauna duomenis is DB
        void SiustiDuomenis();// Siuncia i DB
        void DuomenuTipas();// 
    }

    interface IRobertas
    {
        void GautiDuomenis(); // Gauna duomenis is DB
        void SiustiDuomenis();// Siuncia i DB
        void DuomenuTipas();// 
    }

    class CsvFailas : IDuombaze
    {
        public void DuomenuTipas()
        {
            System.Console.WriteLine(".csv failas");
        }

        public void GautiDuomenis()
        {
            System.Console.WriteLine("Duomenys gaunami");
        }

        public void SiustiDuomenis()
        {
            System.Console.WriteLine("Duomenys siunciami");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
