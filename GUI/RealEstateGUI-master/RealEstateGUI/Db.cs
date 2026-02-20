using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RealEstateGUI
{
    public static class Db
    {
        // UGYANAZ, mint a Form1-ben (és nincs SslMode=None!)
        private const string ConnStr =
            "server=localhost;port=3307;uid=root;pwd=;database=ingatlan;charset=utf8;";

        public static List<Seller> LoadSellers()
        {
            var list = new List<Seller>();

            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                using (var cmd = new MySqlCommand("SELECT id, name, phone FROM sellers ORDER BY name;", conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Seller
                        {
                            Id = r.GetInt64("id"),
                            Name = r.IsDBNull(r.GetOrdinal("name")) ? "" : r.GetString("name"),
                            Phone = r.IsDBNull(r.GetOrdinal("phone")) ? "" : r.GetString("phone")
                        });
                    }
                }
            }

            return list;
        }

        public static int CountRealEstatesBySellerId(long sellerId)
        {
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM realestates WHERE sellerId = @id;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", sellerId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
