using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace RealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\karxav707\Documents\vizsga0213\RealEstate\RealEstate\realestates.csv";
            List<Ad> ads = Ad.LoadFromCsv(FilePath);

            //Határozza meg és írja ki a minta szerint az eladásra kínált földszinti ingatlanok átlagos alapterületét! Az eredményt a minta alapján két tizedesjegy pontossággal írja ki!
                        Dictionary<string, List<Ad>> adsByCategory = ads.GroupBy(ad => ad.Category.Name)
                                        .ToDictionary(group => group.Key, group => group.ToList());
            var foldszint = ads.Where(ad => ad.Floors == 0).ToList();
            if(foldszint.Count > 0)
            {
                double foldatlag = foldszint.Average(ad => ad.Area);
                Console.WriteLine($"Az eladásra kínált fszinti ingatlanok átlag területe {foldatlag:F2} m2");
            }
            else
            {
                Console.WriteLine("Nincs ingatlan.");
            }
            FindClosestAd(ads);
        }
        //7. Készítsen DistanceTo néven valós értékkel visszatérő metódust, amelynek segítségével adott ingatlan esetében meg lehet állapítani egy GPS koordinátától való távolságot Pitagorasz-tétel segítségével!
        public static double DistanceTo(Ad ad, string latlong)
        {
            var adCoords = ad.LatLong
                .Split(',')
                .Select(s => double.Parse(s.Trim(), CultureInfo.InvariantCulture))
                .ToArray();

            var targetCoords = latlong
                .Split(',')
                .Select(s => double.Parse(s.Trim(), CultureInfo.InvariantCulture))
                .ToArray();

            double dx = adCoords[0] - targetCoords[0];
            double dy = adCoords[1] - targetCoords[1];

            return Math.Sqrt(dx * dx + dy * dy);
        }
        //8. A Mesevár óvoda Budán a 47.4164220114023, 19.066342425796986 GPS koordinátán helyezkedik el. Keresse ki és írja ki a minta alapján annak a tehermentes ingatlannak az adatait, melyik a legközelebb van légvonalban a Mesevár óvodához!
        public static void FindClosestAd(List<Ad> ads)
        {
            string oviCoords = "47.4164220114023,19.066342425796986";

            var closestAd = ads
                .Where(ad => ad.FreeOfCharge)
                .OrderBy(ad => DistanceTo(ad, oviCoords))
                .FirstOrDefault();

            if (closestAd != null)
            {
                Console.WriteLine($"A legközelebbi tehermentes ingatlan adatai: \n Eladó neve:{closestAd.Seller.Name} \n Eladó telefonszáma: {closestAd.Seller.Phone} \n Szobák száma: {closestAd.Rooms} \n Alapterület: {closestAd.Area}");
            }
            else
            {
                Console.WriteLine("Nincs tehermentes ingatlan.");
            }
        }
    }
}
