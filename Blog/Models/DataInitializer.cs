using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori() {KategoriAd="C#"},
                new Kategori() {KategoriAd="PHP"},
                new Kategori() {KategoriAd="JAVA"},

            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);

            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale() {Baslik="C# Dilindeki Temel Veri Türleri",
                    Aciklama="C#’da veri tipleri temel olarak 2’ye ayrılırlar. Bunlar önceden tanımlanmış veri türleri ve kullanıcı tarafından tanımlanmış veri türleridir. Önceden tanımlanmış olan veri türleri de kendi arasında değer tipi (value type) ve referans tipi (reference type) olarak 2’ye ayrılır.",
                    Resim="a1.png",
                    YayinTarihi=Convert.ToDateTime("2021-12-29"),
                    Goruntulenme=0, Onay=true,
                    KategoriId=1,
                    KullaniciAd="Ufuk Can Demirhan"
                    },
                new Makale() {Baslik="C# Akış Kontrol Mekanizmaları",
                    Aciklama="Akış kontrol mekanizmaları başlığı altında, aslında iki ayrı tipteki mekanizmaları inceleyeceğiz. Bunlardan bir tanesi eğer … ise … yap anlamına gelen if – else ve switch – case mekanizmaları, diğeri ise belirli işi farklı inputlarla yapmamıza izin veren for, while, foreach gibi döngü mekanizmaları.",
                    Resim="a2.png",
                    YayinTarihi=Convert.ToDateTime("2021-12-30"),
                    Goruntulenme=0, Onay=true,
                    KategoriId=1,
                    KullaniciAd="Mehmet Mayti"
                    },
                 new Makale() {Baslik="PHP/Operatörler",
                    Aciklama="Bir veya birden fazla değer arasında gerçekleştirilecek işlemleri temsil eden simge ya da sözcüklere operatör veya işleç denir. Örneğin matematikte kullandığımız + (artı), - (eksi), * (çarpı), / (bölü) gibi semboller PHP'de birer operatördür. Aynı şekilde mantıksal (bkz: Sembolik mantık) işlemlerde kullanılan && ile and ve || ile veya sembol ve sözcükleri de birer operatördür. Bunların dışında, başka görevler üstlenen operatörler de vardır. Operatörlerle işleme sokulan ifadelere operand denir.",
                    Resim="a2.png",
                    YayinTarihi=Convert.ToDateTime("2020-01-01"),
                    Goruntulenme=0, Onay=true,
                    KategoriId=2,
                    KullaniciAd="Ufuk Can Demirhan"
                    }
            };
            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);

        }

    }
}