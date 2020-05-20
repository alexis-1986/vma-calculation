using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace VmaCalculation
{
    class Lois
    {

        private List<double> _a = new List<double>() { 0, 0.0090, 0.0120, 0.0151, 0.0188, 0.0278, 0.0379 };
        private List<double> _b = new List<double>() { 0, -1152, -593.1940, -263.0551, -650.835, 350.3018, 228.6119 };
        private List<double> _c = new List<double>() { 0, -3.4000, -4.1791, -4.2654, -3.2498, -6.7429, -6.2911 };
        private List<double> _pourcentageVma = new List<double>() { 0, 1.10, 1.05, 1, 0.95, 0.90, 0.85 };

        private double Loi(double temps, int numLoi)
        {
            double res = _a[numLoi] / temps + _b[numLoi] * temps + _c[numLoi];

            return res;
        }

        // temps en sec
        public double PourcentageVma(double temps, int nbRepet)
        {
            List<double> res = new List<double>();

            for (int i = 1; i <= 6; i++)
            {
                 res.Add(Loi(temps, i));
            }

            res.Add(nbRepet);
            res.Sort();
  
            int index = res.IndexOf(nbRepet);

            // Calcul %VMA
            double pVma;

            if (index < 1)
            {
                pVma = 1.10;
            }
            else if (index > 5)
            {
                pVma = 0.85;
            }
            else
            {
                double pVmaMax = _pourcentageVma[index];
                double pVmaMin = _pourcentageVma[index + 1];
                double ratiopVma = (nbRepet - res[index - 1]) / (res[index + 1] - res[index - 1]);
                double deltapVma = pVmaMax - pVmaMin;
                pVma = pVmaMax + ratiopVma * deltapVma;

                Debug.WriteLine("VMA: " + pVma + " pVMAX: " + pVmaMax + " pVMIN: " + pVmaMin + " d: " + deltapVma + " r: " + ratiopVma);
            }

            return pVma;
        }

        public string CalculeVma(double distance, double min, double sec, int nbRepet)
        {
            // Conversion du temps en jour(s)
            double tempsJour = min / (24 * 60) + sec / (24 * 60 * 60);
            Debug.WriteLine("Temps jour: " + tempsJour);
            double pVma = PourcentageVma(tempsJour, nbRepet);
            // Calcule de la vitesse en mètre par min
            double vmMin = distance / (min + sec / 60);
            // Calcule de la vitesse en mètre par heure
            double vmH = (vmMin) * 60;
            // Calcule de la vitesse en kilomètre par heure
            double vKmH = vmH / 1000;
            Debug.WriteLine("Vkmh: " + vKmH + " pVma: " + pVma);
            double vma = vKmH / pVma;
            Debug.WriteLine("Vma: " + vma);
            return string.Format("{0:0.0}", vma);
        }

    }
}
