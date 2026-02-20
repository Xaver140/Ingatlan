using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RealEstate
{
    public class Ad
    {
        public int Area { get; set; }
        public Category Category { get; set; }
        public DateTime CreateAt { get; set; }
        public int Floors { get; set; }
        public bool FreeOfCharge { get; set; }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string LatLong { get; set; }
        public int Rooms { get; set; }
        public Seller Seller { get; set; }

        public Ad(int id,int rooms,string latLong,int floors,int area,bool freeOfCharge,string imageUrl,DateTime createAt,Seller seller,Category category)
        {
            Id = id;
            Rooms = rooms;
            LatLong = latLong;
            Floors = floors;
            Area = area;
            FreeOfCharge = freeOfCharge;
            ImageUrl = imageUrl;
            CreateAt = createAt;
            Seller = seller;
            Category = category;
        }
        //3. Készítsen statikus metódust az Ad osztályhoz az adatforráshoz történő kapcsolódásra, és az adatforrásban levő adatok betöltésére! A metódus neve utaljon az adatforrásból betöltésre(pl.: LoadFromCsv). A metódus visszatérési értéke az Ad osztályból képzett lista legyen! A metódus paramétere a betöltendő fájl neve legyen!
        public static List<Ad> LoadFromCsv(string filePath)
        {
            var ads = new List<Ad>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var fields = line.Split(';');
                if (fields.Length < 14) continue;

                var ad = new Ad(
                    int.Parse(fields[0]), // id
                    int.Parse(fields[1]), // rooms
                    fields[2],            // latlong
                    int.Parse(fields[3]), // floors
                    int.Parse(fields[4]), // area
                    fields[6] == "1",     // freeOfCharge 
                    fields[7],            // imageUrl
                    DateTime.Parse(fields[8]), // createAt
                    new Seller(int.Parse(fields[9]), fields[10], fields[11]),
                    new Category(int.Parse(fields[12]), fields[13])
                );
                ads.Add(ad);
            }
            return ads;
        }
    }
}
