using PentaNest.Emlak.Api.Models;
using System.Globalization;

namespace PentaNest.Emlak.Api.Services
{
    public class DataService
    {
        public List<Danisman> Danismanlar { get; }
        public List<BlogPost> BlogPosts { get; }
        public List<Property> AllProperties { get; }

        public DataService()
        {
            Danismanlar = new List<Danisman>
            {
                new Danisman
                {
                    Foto = "/assets/hasanduganpfp.png",
                    Url = "hasan-dugan",
                    Isim = "Hasan Dugan",
                    Hakkimda = "1974 Ankara doğumluyum. Öğrenim hayatımın tamamı Ankara'da geçti, 1998 yılında ODTÜ İstatistik Bölümünden mezun olduğumda kariyerim artık İstanbul'da devam ediyordu. 1998 de başlayan Bankacılık hayatım, Müfettiş, Şube Pazarlama, Bölge Pazarlama, Şube Müdürü olarak 17 yıl devam etti. Sonrasında özel sektörde, sektörün önde gelen firmalarında Finans Direktörlüğü, İç Denetim sorumlusu olarak çalıştım.  Ankara merkezli 212 Derece bünyesinde Koçluk eğitimleri alarak Koç unvanını aldım, Sermaye Piyasası Lisanslama Enstitüsü tarafından açılan Gayrimenkul Değerleme Lisansı eğitimi ve sınavlarını tamamlayarak Gayrimenkul Değerleme Uzmanı unvanını ve aynı zamanda Konkordato Komiserliği unvanını aldım. Emeklilik sonrası her zaman ilgimi çeken geçmişte şahsen alım satımlar yaptığım gayrimenkul sektöründe yola devam etme kararı aldım .  Kendi marka ve ofislerimizi oluşturduğum arkadaşlarım ile birlikte Ankara Çankaya Alacaatlı bölgesinde bulunan ofisimizde Gayrimenkul Danışmanı olarak çalışmaya devam etmekteyim. ",
                    Telefon = "+90 532 485 2602",
                    Mail = "hdugan@gmail.com",
                    Instagram = "https://instagram.com/hasandugangd",
                    Whatsapp = "https://wa.me/905324852602",
                    Endeksa = "https://www.endeksa.com/tr/danisman/hasan-dugan/d6c1a6c9-03a3-4efb-bd1c-3a7e4dd26133",
                    Properties = new List<Property>
                    {
                        new Property
                        {
                            Id = "1257154655",
                            ImageURL = "https://i0.shbdn.com/photos/15/46/55/12571546551bj.jpg",
                            Title = "Kazan Yeşilova Villalarında Bağımsız Köşe Lüks Tripleks Villa",
                            Price = 10000000,
                            Location = "Ankara Kahramankazan",
                            Emlakci = "Hasan Dugan",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//40.1843859,32.6879245/@40.0552261,32.556688,11z?entry=ttu&g_ep=EgoyMDI1MDcxMy4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Kazan'ın prestijli ve doğayla iç içe konumuyla öne çıkan Yeşilova Kent Villaları'nda, az sayıda bulunan bağımsız villamız satışa sunulmuştur.\nModern mimarisi, geniş yeşil alanları ve sakin ortamıyla dikkat çeken bu villa, aradığınız özel yaşam alanını sunuyor.\n3 katlı ayrıca depo alanı da bulunan Villamızda 4+1 2 Banyo ve 3 adet WC^ye sahiptir.\nGeniş bahçesi ve yetişmiş meyve ağaçları ile bahçesinde bulunan çocuk parkı ile size şehir karmaşasından uzak bir hayat sunuyor.\nMarket ve Alışveriş bölgesine 150 mt.\nDetaylı bilgi ve randevu için lütfen iletişime geçiniz.",
                            M2 = 300,
                            OdaSayisi = "4+1",
                            IlanTarihi = "2025-07-7",
                            EmlakTipi = "Satılık Villa",
                            BinaYasi = 7,
                            BulunduguKat = "Tripleks",
                            KatSayisi = 3,
                            Isitma = "Kat Kaloriferleri",
                            BanyoSayisi = "2",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = "Yok",
                            Otopark = "Açık Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Mülk Sahibi",
                            SiteIcerisinde = "Var",
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Müstakil Tapu",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Evet",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d195449.90519795005!2d32.556688!3d40.0552261!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d40.184385899999995!2d32.6879245!5e0!3m2!1str!2str!4v1753257992026!5m2!1str!2str",
                            ImageCount = 35
                        },
                        new Property
                        {
                            Id = "1245053079",
                            ImageURL = "https://i0.shbdn.com/photos/05/30/79/1245053079t6o.jpg",
                            Title = "Ankara Gölbaşı - Gerder Mahallesi Satılık Arsa Hissesi",
                            Price = 7500000,
                            Location = "Ankara Gölbaşı",
                            Emlakci = "Hasan Dugan",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.7507143,32.867074/@39.8395243,32.7515268,12z?entry=ttu&g_ep=EgoyMDI1MDcxMy4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "8.432 M2 lik arsamız 3 hissedara ait olup 1 hisse satılmaktadır.\nAnkara'nın gelecek vaadeden bölgesinde erken yatırım fırsatı.\nDoğalgaz ve Elektrik hattı hazır bölgede.\nGölbaşı Gerder TOKI Projesine (@golbasi.gerder.toki) yakın.\nAnkara’nın ulaşım master planında Gölbaşı’na metro entegrasyonu gündemde olup, bu projenin hayata geçmesi durumunda bölge değeri hızla artacaktır.\nKonut, sosyal tesis veya yatırım amaçlı projeler için ideal.\nTOKİ ve özel sektör tarafından planlanan yeni konut projeleri ile bölgenin değeri hızla artmakta.\nParsel, imar planlarına doğrultusunda konut veya ticari projeler için uygun.\nYeni altyapı çalışmaları ve kamu yatırımları ile bölge cazibesini artırmaktadır.",
                            M2 = 2700,
                            OdaSayisi = null,
                            IlanTarihi = "2025-07-7",
                            EmlakTipi = "Satılık Arsa",
                            BinaYasi = null,
                            BulunduguKat = null,
                            KatSayisi = null,
                            Isitma = null,
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Hayır",
                            TapuDurumu = "Hisseli Tapu",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d98033.57372711043!2d32.7515268!3d39.8395243!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.7507143!2d32.867073999999995!5e0!3m2!1str!2str!4v1753259085618!5m2!1str!2str",
                            ImageCount = 4
                        },
                        new Property
                        {
                            Id = "1249834218",
                            ImageURL = "https://i0.shbdn.com/photos/83/42/18/1249834218wis.jpg",
                            Title = "PENTA NEST Güvencesi ile ERGAZİ ÖZDAMLA SİTESİ SATILIK 3+1 Daire",
                            Price = 4390000,
                            Location = "Ankara Yenimahalle",
                            Emlakci = "Hasan Dugan",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9577395,32.7135194/@39.9408507,32.6942884,12z?entry=ttu&g_ep=EgoyMDI1MDcxMy4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "YENİLENMİŞ LÜKS 3+1 DAİRE - ÖZDAMLA SİTESİ / ERGAZİ MAHALLESİ.\nKöşe Daire - 2 Balkonlu (Kapalı) - Krediye Uygun - Şehir Merkezine Yakın.\nÖzdamla Sitesi, Ergazi Mahallesi, Yenimahalle / Ankara.\n25 Dönüm yeşil alan içinde 28 bloktan oluşan bakımlı ve güvenli site.\n5 katlı, 5. katta köşe daire (güneş alan, ferah).\nKök tapulu, krediye uygun (Kredi işlemleriniz eski bankacılardan oluşan Penta Nest ekibi tarafından yönetilir).\nOda Sayısı: 3+1 (geniş ve modern tasarım).\n2 adet kapalı balkon (manzaralı).\nTamamen yenilenmiş.\nKombi doğalgaz.\nŞifreli/çipli anahtar giriş sistemi (site ve bina girişleri kontrollü).\nSite içi Peyzaj alanlarına ilave Asaf Bey Parkı (hemen bitişiğinde).\nAtlantis AVM, Migros, BİM, semt pazarı.\nErgazi Aile Sağlık Merkezi, Yenimahalle Devlet Hastanesi.\nMetro (Batıkent hattı Anıt Durağı), otobüs durakları, minibüs hatları.\nErgazi İlkokulu, özel kreşler.\nŞehir karmaşasından uzak, ulaşımı kolay, sessiz, yeşil ve güvenli bir ortamda yer alan bu Mülk sahibinin ikamet ettiği dairemizi görmek için lütfen iletişime geçiniz.",
                            M2 = 125,
                            OdaSayisi = "3+1",
                            IlanTarihi = "2025-07-3",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 26,
                            BulunduguKat = "5. Kat",
                            KatSayisi = 5,
                            Isitma = "Kombi Doğalgaz",
                            BanyoSayisi = "1",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = "Yok",
                            Otopark = "Açık Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Mülk Sahibi",
                            SiteIcerisinde = "Evet",
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyeti",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97888.77104285988!2d32.6942884!3d39.9408507!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.957739499999995!2d32.713519399999996!5e0!3m2!1str!2str!4v1753259110047!5m2!1str!2str",
                            ImageCount = 34
                        },
                        new Property
                        {
                            Id = "1256050414",
                            ImageURL = "https://i0.shbdn.com/photos/05/04/14/x5_12560504148gh.jpg",
                            Title = "Penta Nest Güvencesiyle Pursaklar Fatih Mah. Satılık 3+1 Daire",
                            Price = 2990000,
                            Location = "Ankara Pursaklar",
                            Emlakci = "Hasan Dugan",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//40.0408456,32.8989339/@39.9805334,32.7894961,12z?entry=ttu&g_ep=EgoyMDI1MDcxMy4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Pursaklar'da Köşe Başı 3+1 Daire - SATILIK.\nBodrum Sokak No:18, 1. Kat 120 m².\nCaddeye bakan köşe konumuyla tüm gün güneş alır, aydınlık ve ferah bir yaşam sunar.\nGömme dolaplarıyla pratik kullanım, kiracılı ve bakımlı durumda.\nUlaşım, sağlık ve eğitim imkanlarına yürüme mesafesinde!\nOtobüs Durağı: 439-440 numaralı hatlara yürüme mesafesi.\nPursaklar Devlet Hastanesi → 1.2 km.\nA Life Hastanesi → Yürüme mesafesi.\nFatih & Saray Aile Sağlık Merkezi → 500 m.\nŞehit Ali Yıldırım Ortaokulu → 400 m.\nPursaklar İMKB Meslek Lisesi → 700 m.\nGros market, Pursaklar Salı Pazarı → 1.5 km.\nFatih Camii → 200 m.\nOyun parkı & yürüyüş yolu → Binanın hemen arkasında!\nProtokol yoluna 10 dakika.\nBelediye, Emniyet Müdürlüğü, Kaymakamlık → 1.5 km çevrede.",
                            M2 = 130,
                            OdaSayisi = "3+1",
                            IlanTarihi = "2025-07-2",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 11,
                            BulunduguKat = "1. Kat",
                            KatSayisi = 3,
                            Isitma = "Kombi Doğalgaz",
                            BanyoSayisi = "1",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = "Yok",
                            Otopark = "Açık Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Kiracılı",
                            SiteIcerisinde = "Hayır",
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97831.9781699273!2d32.7894961!3d39.9805334!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d40.0408456!2d32.898933899999996!5e0!3m2!1str!2str!4v1753259138093!5m2!1str!2str",
                            ImageCount = 16
                        },
                        new Property
                        {
                            Id = "1256021445",
                            ImageURL = "https://i0.shbdn.com/photos/02/14/45/x5_12560214451ve.jpg",
                            Title = "Kızılay Atatürk Bulvarı Engürü Pasajı Satılık İşyeri",
                            Price = 1250000,
                            Location = "Ankara Çankaya",
                            Emlakci = "Hasan Dugan",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9186982,32.8545981/@39.9208509,32.8376234,15z?entry=ttu&g_ep=EgoyMDI1MDcxMy4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Ankara Kızılay'ın Kalbinde İşletme Fırsatı!\nKızılay, Atatürk Blv No:107/ 14. 8 m² (2,30 Mt cephesi bulunmaktadır.) (Pasaj alt katında).\nAnkara’nın en işlek noktası, Kızılay’ın tam göbeğinde!\nGün boyu yoğun insan trafiği ile ticaretin merkezinde.\nKızılay Metro, otobüs durakları ve yaya akışıyla günde 100.000 kişi üzerinde yaya trafiği.\nDüşük maliyetle işletme kurma veya yatırım yapma fırsatı.\nFırsatı kaçırmayın, Kızılay’da ticaretin tam ortasında yerinizi alın!\nGayrimenkulün satışında tek yetkili Penta Nest Gayrimenkul Ofisidir.\nDetaylı bilgi ve randevu için lütfen iletişime geçiniz.",
                            M2 = 8,
                            OdaSayisi = "-",
                            IlanTarihi = "2025-07-2",
                            EmlakTipi = "Satılık İşyeri",
                            BinaYasi = 30,
                            BulunduguKat = null,
                            KatSayisi = null,
                            Isitma = "Yok",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d12239.672056791022!2d32.8376234!3d39.9208509!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.9186982!2d32.8545981!5e0!3m2!1str!2str!4v1753259948890!5m2!1str!2str",
                            ImageCount = 4
                        },
                        new Property
                        {
                            Id = "1259297035",
                            ImageURL = "https://i0.shbdn.com/photos/29/70/35/1259297035tka.jpg",
                            Title = "Kiralık Ofis Daire İpektaş Cadde 1+1 55m², Merkezi Adliye Yakını",
                            Price = 39000,
                            Location = "Ankara Yenimahalle",
                            Emlakci = "Hasan Dugan",
                            Durum = "Kiralık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9598836,32.7777356/@39.9023307,32.6466085,12z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Yeni Rezidansınız Ağustos 2025'te Hazır! Hem Konforlu Yaşam Hem Profesyonel Çalışma Alanı\nŞehrin kalbinde yükselen bu modern rezidans, Ağustos 2025'te oturuma hazır hale gelecek. Hem konut hem de işyeri olarak kullanabileceğiniz geniş ve fonksiyonel yaşam alanlarıyla, iş ve yaşam konforunu bir arada sunuyor. Eşya fotoğrafları projenin temsili reklam fotoğrafları olup Kiracı ile Mülk sahibi ortak kararı doğrultusunda eşya konulacaktır. \n55m² brüt 45m² net alana sahip dairemiz Batı cepheli olup öğleden sonra güneşi almakta ve günbatımı manzaralıdır. C1 - 55\n✔ Çift amaçlı kullanım: Daire veya ofis olarak kullanılabilir\n✔ 7/24 güvenlik ile huzurlu bir ortam\n✔ Her daireye özel kapalı otopark\n✔ Yerden ısıtma sistemi ile konforlu yaşam\n\n• Siemens 3'lü ankastre set (modern mutfak donanımı)\n• Çamaşır makinesi dolabı \n• Şık ve kullanışlı banyo ve WC tasarımı\n• Korkuluk, vestiyer ve çelik kapı (güvenlik ve estetik)\n• Laminat ve parke zemin (şık ve dayanıklı)\n• Winsa PVC pencereler (ısı ve ses yalıtımlı)\n•  3 adet asansör\n\n• Otobüs, minibüs durakları binanın hemen önünde\n• Metro (Hastane Durağı) sadece 1.4 km uzaklıkta\n\nÇEVREDEKİ ÖNEMLİ NOKTALAR\n\n✔ Nazım Hikmet Kültür Merkezi → 50 metre\n✔ Podium AVM → 750 metre\n✔ Onkoloji Hastanesi → 1.5 km\n✔ Yeni Adliye Sarayı (Eski MİT Yerleşkesi) → 2.1 km\n✔ ASELSAN Genel Müdürlüğü → 2.2 km\n✔ Acity AVM → 3 km\n✔ Cumhurbaşkanlığı Külliyesi → 4.8 km\n✔ Antares & Ankamall AVM → 4.8 - 5.5 km\n✔ Etlik & Bilkent Şehir Hastaneleri → 5.7 - 11 km\nTek Yetkili: Penta Nest Gayrimenkul\n☎ 0 532 485 26 02\n Hemen iletişime geçin, bu fırsatı kaçırmayın!",
                            M2 = 55,
                            OdaSayisi = "1+1",
                            IlanTarihi = "2025-07-17",
                            EmlakTipi = "Kiralık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "4",
                            KatSayisi = 10,
                            Isitma = "Merkezi",
                            BanyoSayisi = "1",
                            MutfakTipi = "Amerikan",
                            Balkon = "Var",
                            Asansor = "Var",
                            Otopark = "Açık & Kapalı Otopark",
                            Esyali = "Evet",
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = "Evet",
                            KrediyeUygun = null,
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "EMlak Ofisinden",
                            Takas = null,
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97943.85497698688!2d32.6466085!3d39.9023307!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.9598836!2d32.7777356!5e0!3m2!1str!2str!4v1753260038988!5m2!1str!2str",
                            ImageCount = 11
                        },
                        new Property
                        {
                            Id = "1259100407",
                            ImageURL = "https://i0.shbdn.com/photos/10/04/07/x5_12591004077yp.jpg",
                            Title = "Kiralık Ofis Daire EŞYALI İpektaş Cadde 1+1 55m² Adliye Yakını",
                            Price = 35000,
                            Location = "Ankara Yenimahalle",
                            Emlakci = "Hasan Dugan",
                            Durum = "Kiralık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9598964,32.7775857/@39.9020676,32.6466085,12z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Yeni Rezidansınız Ağustos 2025'te Hazır! Hem Konforlu Yaşam Hem Profesyonel Çalışma Alanı\nŞehrin kalbinde yükselen bu modern rezidans, Ağustos 2025'te oturuma hazır hale gelecek. Hem konut hem de işyeri olarak kullanabileceğiniz geniş ve fonksiyonel yaşam alanlarıyla, iş ve yaşam konforunu bir arada sunuyor.\n55m² brüt 45m² net alana sahip dairemiz Batı cepheli olup öğleden sonra güneşi almakta ve günbatımı manzaralıdır. B2 - 78\n✔ Çift amaçlı kullanım: Daire veya ofis olarak kullanılabilir\n✔ 7/24 güvenlik ile huzurlu bir ortam\n✔ Her daireye özel kapalı otopark\n✔ Yerden ısıtma sistemi ile konforlu yaşam\n\n• Siemens 3'lü ankastre set (modern mutfak donanımı)\n• Çamaşır makinesi dolabı \n• Şık ve kullanışlı banyo ve WC tasarımı\n• Korkuluk, vestiyer ve çelik kapı (güvenlik ve estetik)\n• Laminat ve parke zemin (şık ve dayanıklı)\n• Winsa PVC pencereler (ısı ve ses yalıtımlı)\n•  3 adet asansör\n\n• Otobüs, minibüs durakları binanın hemen önünde\n• Metro (Hastane Durağı) sadece 1.4 km uzaklıkta\n\nÇEVREDEKİ ÖNEMLİ NOKTALAR\n\n✔ Nazım Hikmet Kültür Merkezi → 50 metre\n✔ Podium AVM → 750 metre\n✔ Onkoloji Hastanesi → 1.5 km\n✔ Yeni Adliye Sarayı (Eski MİT Yerleşkesi) → 2.1 km\n✔ ASELSAN Genel Müdürlüğü → 2.2 km\n✔ Acity AVM → 3 km\n✔ Cumhurbaşkanlığı Külliyesi → 4.8 km\n✔ Antares & Ankamall AVM → 4.8 - 5.5 km\n✔ Etlik & Bilkent Şehir Hastaneleri → 5.7 - 11 km",
                            M2 = 55,
                            OdaSayisi = "1+1",
                            IlanTarihi = "2025-07-19",
                            EmlakTipi = "Kiralık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "6",
                            KatSayisi = 7,
                            Isitma = "Yerden Isıtma",
                            BanyoSayisi = "1",
                            MutfakTipi = "Amerikan",
                            Balkon = "Var",
                            Asansor = "Var",
                            Otopark = "Açık & Kapalı Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = "Evet",
                            KrediyeUygun = "Belirtilmemiş",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = null,
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97944.23106007962!2d32.6466085!3d39.9020676!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.9598964!2d32.777585699999996!5e0!3m2!1str!2str!4v1753260065536!5m2!1str!2str",
                            ImageCount = 22
                        },
                    },
                },
                new Danisman
                {
                    Foto = "/assets/serifecelikpfp.png",
                    Isim = "Şerife Çelik",
                    Url = "serife-celik",
                    Hakkimda = "Emlak uzmanıyım",
                    Telefon = "+90 532 549 47 49",
                    Mail = "serifecelik@gmail.com",
                    Instagram = "https://instagram.com/serifedilercelik1",
                    Whatsapp = "https://wa.me/905325494749",
                    Endeksa = "https://www.endeksa.com/tr/danisman/serife-celik/00f1dab4-3331-4000-b615-2ba1240609b9",
                    Properties = new List<Property>
                    {
                        new Property
                        {
                            Id = "1245808368",
                            ImageURL = "https://i0.shbdn.com/photos/80/83/68/x5_1245808368eea.jpg",
                            Title = "OFİS 110 PLAZA DIŞKAPI METRO DURAĞINDA KİRALIK 145 M2 OFİS",
                            Price = 60000,
                            Location = "Ankara Altındağ",
                            Emlakci = "Şerife Çelik",
                            Durum = "Kiralık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9559854,32.8583274/@39.9559781,32.8171279,13z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "OFİS 110 PLAZA KİRALIK OFİS.\nDışkapı Metro çıkışında olup, Plazada 85 Ofis, İtfaiye Çarşısında 152 Dükkan bulunmaktadır.\n60 Ofis 1+0, 15 Ofis 2+0, 10 Ofis 3+0 Ofisten oluşmaktadır.\nGENEL ÖZELLİKLER:\n4. Kat, 145 m2 Net Kullanım Alanı, Şehir Manzaralı, Fancoil Isıtma Sistemi, Laminant ve Islak Zemin Seramik, Yangın Söndürme Sistemi, 2 Asansör, Ofis Girişi Bağımsız, Açık ve Kapalı Otopark, 6 Dönüm Peyzaj Alanı, Kamelyalar, Çocuk Bahçesi, 24 Saat Güvenlik, 265 Adet Kayıtlı Kamera Sistemi.\nAnkara Üniversitesi Ziraat Fakültesi, Dışkapı Yıldırım Beyazıt Eğitim ve Araştırma Hastanesi, Gülhane Eğitim ve Araştırma Hastanesi, Türk Telekom Genel Müdürlüğü, Aski Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.",
                            M2 = 145,
                            OdaSayisi = "3+0",
                            IlanTarihi = "2025-07-19",
                            EmlakTipi = "Kiralık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "4. Kat",
                            KatSayisi = null,
                            Isitma = "Fancoil Isıtma Sistemi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = null,
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = null,
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d48933.56331433824!2d32.8171279!3d39.9559781!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.955985399999996!2d32.8583274!5e0!3m2!1str!2str!4v1753260172655!5m2!1str!2str",
                            ImageCount = 34
                        },
                        new Property
                        {
                            Id = "1247956711",
                            ImageURL = "https://i0.shbdn.com/photos/95/67/11/1247956711s7b.jpg",
                            Title = "AKADİA MODERN KONUTLARINDA BOŞ 2+1 TEMİZ YAPILI SATILIK DAİRE",
                            Price = 6400000,
                            Location = "Ankara Mamak",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.8898253,32.9326293/@39.8389139,32.6453055,11z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "GENEL ÖZELLİKLERİ:\nDoğukent Bulvarına Cephe, Ikea ve Nata Vega AVM Karşısında Akadia Modern Konutlarında.\nArsa Alanı 50000 m2.\n891 Konut 2+1 3+1 4+1.\n8 Katlı Bina, 4. Kat.\nTip 10. 105 m2 Net Kullanım Alanı.\n7/24 Güvenlik, Kamera Sistemleri.\nMerkezi (Pay Ölçer) Isıtma.\nKapalı ve Açık Otopark.\nAnkastre Set (Fırın, Mikrodalga Fırın, Ocak, Davlumbaz).\nDuvar Kağıdı.\nMutfak Kapısı Sürgülü.\nÇelik Kapı.\nYangın Uyarı Sistemi.\nMerkezi Uydu Sistemi.\nGiyinme Odası.\nEbeveyn Banyosu.\nDairemiz Temiz ve Yapılıdır.\nÇocuk Parkı.\nPeyzaj Alanı.\nHamam, Sauna, Buhar Odası.\nDairemiz Lokasyon olarak Otobüs ve Dolmuş Duraklarına Yakın, Nata Vega AVM, Metro Market ve İkea'ya yürüme mesafesinde, Bim, A101 ve Şok Marketlerine Yürüme Mesafesinde, Çevre Yoluna Yakın Bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYINIZ...",
                            M2 = 119,
                            OdaSayisi = "2+1",
                            IlanTarihi = "2025-06-25",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 5,
                            BulunduguKat = "4. Kat",
                            KatSayisi = 8,
                            Isitma = "Merkezi(Pay Ölçer)",
                            BanyoSayisi = "2",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = "Var",
                            Otopark = "Kapalı ve Açık Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = "Evet",
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d196068.89020765765!2d32.6453055!3d39.8389139!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.8898253!2d32.932629299999995!5e0!3m2!1str!2str!4v1753260191478!5m2!1str!2str",
                            ImageCount = 34
                        },
                        new Property
                        {
                            Id = "1235105117",
                            ImageURL = "https://i0.shbdn.com/photos/10/51/17/x5_1235105117vo0.jpg",
                            Title = "KUŞADASI/DAVUTLAR ORSEN SİT. DENİZE YAKIN EŞYALI SATILIK YAZLIK",
                            Price = 12900000,
                            Location = "Aydın Kuşadası Davutlar",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//37.7697736,27.2635707/@38.6967504,24.6875355,6z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "Yazlığımız Kuşadası/Davutlar Mevkinde bulunmaktadır.\nOrsen Sitesi Denize Sıfır Konumdadır.\nGENEL ÖZELLİKLERİ:\nEşyalı, Köşe Villa, Geniş Bahçe, Çift Tapu.\n2 Ayrı Girişi Olduğundan 2 Ayrı Yazlık Olarak Kullanılabilir.\nHer Katta Mutfak ve Banyo.\nAlt Kat 1+1, Açık Mutfak.\nÜst Kat:1+1 Kapalı Mutfak.\nHer Katta Klima.\nGüneş Enerjisi.\nÇocuk Parkı.\nBahçe Bakımı.\nYazlığımız Denize Yürüme Mesafesi 5 Dk.\nSahil Boyunca Bisiklet ve Yürüyüş Yolları Bulunmaktadır.\nSite Konumu İtibariyle Marketlere, Ulaşım Araçlarına, Sosyal Alanlarına Yürüme Mesafesindedir.\nKuşadasına 20 Km Uzaklıktadır.\nDETAYLAR İÇİN LÜTFEN ARAYINIZ.\nDAİREYİ GÖRMEK İÇİN LÜTFEN RANDEVU ALINIZ.",
                            M2 = 150,
                            OdaSayisi = "3+1",
                            IlanTarihi = "2025-06-30",
                            EmlakTipi = "Satılık Yazlık",
                            BinaYasi = 21,
                            BulunduguKat = "Villa Tipi",
                            KatSayisi = 2,
                            Isitma = "Klima",
                            BanyoSayisi = "2",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = null,
                            Otopark = null,
                            Esyali = "Evet",
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d6377302.049761673!2d24.6875355!3d38.6967504!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d37.7697736!2d27.2635707!5e0!3m2!1str!2str!4v1753260222689!5m2!1str!2str",
                            ImageCount = 7
                        },
                        new Property
                        {
                            Id = "1234670390",
                            ImageURL = "https://i0.shbdn.com/photos/67/03/90/x5_123467039096t.jpg",
                            Title = "OFİS 110 PLAZADA DIŞKAPI METRO ÇIKIŞI KİRALIK 60 M2 OFİS",
                            Price = 40000,
                            Location = "Ankara Altındağ",
                            Emlakci = "Şerife Çelik",
                            Durum = "Kiralık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9559597,32.8587148/@39.9050852,32.6056394,11z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "OFİS 110 PLAZA.\nDışkapı Metro çıkışında olup, Plazada 85 Ofis, İtfaiye Çarşısında 152 Dükkan bulunmaktadır.\n60 Ofis 1+0, 15 Ofis 2+0, 10 Ofis 3+0 Ofisten oluşmaktadır.\nGENEL ÖZELLİKLER:\n6. Kat\n60 m2 Net Kullanım Alanı\nŞehir Manzaralı\nFancoil Isıtma Sistemi\nLaminant ve Islak Zemin Seramik\nYangın Söndürme Sistemi\n2 Asansör\nOfis Girişi Bağımsız\nAçık ve Kapalı Otopark\n6 Dönüm Peyzaj Alanı\nKamelyalar\nÇocuk Bahçesi\n24 Saat Güvenlik\n265 Adet Kayıtlı Kamera Sistemi.\nAnkara Üniversitesi Ziraat Fakültesi, Dışkapı Yıldırım Beyazıt Eğitim ve Araştırma Hastanesi, Gülhane Eğitim ve Araştırma Hastanesi Türk Telekom Genel Müdürlüğü, Aski Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.",
                            M2 = 60,
                            OdaSayisi = "2+0",
                            IlanTarihi = "2025-06-30",
                            EmlakTipi = "Kiralık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "3. Kat",
                            KatSayisi = null,
                            Isitma = "Fancoil Isıtma Sistemi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = null,
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d195879.83497486456!2d32.6056394!3d39.9050852!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.9559597!2d32.8587148!5e0!3m2!1str!2str!4v1753260253219!5m2!1str!2str",
                            ImageCount = 18
                        },
                        new Property
                        {
                            Id = "1231813949",
                            ImageURL = "https://i0.shbdn.com/photos/81/39/49/x5_1231813949hbn.jpg",
                            Title = "ÇANKAYA ÖVEÇLER MAHALLESİ SATILIK 2 KATLI 230 M2 DÜKKAN",
                            Price = 6900000,
                            Location = "Ankara Çankaya",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.893531,32.8263722/@39.87285,32.6698799,12z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "ÖVEÇLER'DE ÇETİN EMEÇ CADDESİNE YAKIN SATILIK DÜKKAN.\nGenel Özellikleri:\nGiriş Kat, 230 m2 Net Kullanım Alanı.\nGiriş Kat 160 M2 - Alt Kat 70 M2.\nGiriş 2+1.\nAlt Kat Mutfak + WC + Açık Alan.\nAçık Otopark.\nDoğalgaz.\nKiracılı.\nDükkan Girişi Bağımsız.\nÇetin Emeç Bulvarına, Konya Yoluna, Balgat Semtine, Dikmen Caddesine, Polisevine, Emniyet Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.",
                            M2 = 230,
                            OdaSayisi = "2+1",
                            IlanTarihi = "2025-07-08",
                            EmlakTipi = "Satılık Dükkan & Mağaza",
                            BinaYasi = 20,
                            BulunduguKat = null,
                            KatSayisi = null,
                            Isitma = "Merkezi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97985.98272938137!2d32.6698799!3d39.87285!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.893530999999996!2d32.8263722!5e0!3m2!1str!2str!4v1753260294205!5m2!1str!2str",
                            ImageCount = 30
                        },
                        new Property
                        {
                            Id = "1231798215",
                            ImageURL = "https://i0.shbdn.com/photos/79/82/15/x5_1231798215htk.jpg",
                            Title = "ÖVEÇLER MAH. ÇETİN EMEÇ BULVARINA YAKIN 170 M2 DÜKKAN",
                            Price = 6500000,
                            Location = "Ankara Çankaya",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.8936535,32.8263168/@39.87285,32.6698522,12z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "ÖVEÇLER'DE ÇETİN EMEÇ CADDESİNE YAKIN SATILIK DÜKKAN.\nGenel Özellikleri:\nGiriş Kat, 170 m2 Net Kullanım Alanı.\nGiriş Kat 100 M2 - Alt Kat 70 M2.\nGiriş 2+1.\nAlt Kat Mutfak + WC + Açık Alan.\nAçık Otopark.\nMerkezi Isıtma Sistemi.\nKiracılı.\nDükkan Girişi Bağımsız.\nÇetin Emeç Bulvarına, Konya Yoluna, Balgat Semtine, Dikmen Caddesine, Polisevine, Emniyet Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.",
                            M2 = 170,
                            OdaSayisi = "2+1",
                            IlanTarihi = "2025-07-08",
                            EmlakTipi = "Satılık Dükkan",
                            BinaYasi = 21,
                            BulunduguKat = null,
                            KatSayisi = null,
                            Isitma = "Merkezi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97985.98272938137!2d32.6698522!3d39.87285!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.8936535!2d32.8263168!5e0!3m2!1str!2str!4v1753260325548!5m2!1str!2str",
                            ImageCount = 32
                        },
                        new Property
                        {
                            Id = "1257519956",
                            ImageURL = "https://i0.shbdn.com/photos/51/99/56/x5_12575199560yu.jpg",
                            Title = "BİRLİK MAH. SATILIK 258 M2 DUBLEKS BAKIMLI 7+1 DAİRE",
                            Price = 9750000,
                            Location = "Ankara Çankaya",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.8758797,32.877371/@39.8721982,32.6130105,11z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "GENEL ÖZELLİKLERİ:\nDubleks Bakımlı Daire.\n4 Katlı Bina, 3. Ve 4. Kat.\n6+1 (Teras kapatılmış olup, mutfak ve barbekü eklenmiştir. Oda olarak da kullanılabilir).\n258 m2 Net Kullanım Alanı.\nÇift Mutfak.\nÖn Cephe.\nGörüntülü Diyafon.\nKombi (Doğalgaz).\nAçık Otopark.\nAnkastre Set (Fırın, Mikrodalga Fırın, Ocak, Davlumbaz).\nÇelik Kapı.\nDaireye Ait Depo.\nDairemiz Temiz ve Yapılıdır.\nDairemiz Lokasyon olarak Otobüs ve Dolmuş Duraklarına, Doğukent Bulvarı, 365 AVM, Lozan Parkı'na yürüme mesafesinde, Marketlere, Okullara Yürüme Mesafesinde Bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYINIZ...",
                            M2 = 300,
                            OdaSayisi = "7+1",
                            IlanTarihi = "2025-07-09",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 15,
                            BulunduguKat = "3. Kat",
                            KatSayisi = 4,
                            Isitma = "Kombi Doğalgaz",
                            BanyoSayisi = "2",
                            MutfakTipi = "Kapalı",
                            Balkon = "Var",
                            Asansor = "Yok",
                            Otopark = "Açık Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Mülk Sahibi",
                            SiteIcerisinde = "Yok",
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d195973.82770959035!2d32.6130105!3d39.8721982!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.8758797!2d32.877371!5e0!3m2!1str!2str!4v1753260389232!5m2!1str!2str",
                            ImageCount = 31
                        },
                        new Property
                        {
                            Id = "1231787853",
                            ImageURL = "https://i0.shbdn.com/photos/78/78/53/x5_1231787853wtb.jpg",
                            Title = "OFİS 110 PLAZA MANZARALI METRO GİRİŞİ SATILIK OFİS",
                            Price = 8850000,
                            Location = "Ankara Altındağ",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9578322,32.8577233/@39.9009825,32.6031477,11z?entry=ttu&g_ep=EgoyMDI1MDcxNS4xIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "DIŞKAPI İTFAİYE ÇARŞISI OFİS 110 SATILIK OFİS.\n6. Katta Ofisimiz Satılıktır.\nGenel Özellikleri:\n165 m2 Net Kullanım Alanı.\nFancoil Isıtma Sistemi.\nLaminant ve Islak Zemin Seramik.\nYangın Söndürme Sistemi.\n2 Asansör.\nOfis Girişi Bağımsız.\n24 Saat Güvenlik.\n265 Adet Kayıtlı Kamera Sistemi.\nAnkara Üniversitesi Ziraat Fakültesi, Dışkapı Yıldırım Beyazıt Eğitim ve Araştırma Hastanesi, Gülhane Eğitim ve Araştırma Hastanesi Türk Telekom Genel Müdürlüğü, Aski Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.\nİRTİBAT TELEFONLARIMIZ: ŞERİFE ÇELİK 0532 5494749, DUYGU GÜLNAZ 0532 4878126.",
                            M2 = 165,
                            OdaSayisi = "2+1",
                            IlanTarihi = "2025-07-21",
                            EmlakTipi = "Satılık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "6. Kat",
                            KatSayisi = null,
                            Isitma = "Fancoil Isıtma Sistemi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Hayır",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d195891.5642259906!2d32.6031477!3d39.9009825!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.9578322!2d32.857723299999996!5e0!3m2!1str!2str!4v1753260409821!5m2!1str!2str",
                            ImageCount = 25
                        },
                        new Property
                        {
                            Id = "1238609645",
                            ImageURL = "https://i0.shbdn.com/photos/60/96/45/x5_1238609645dcl.jpg",
                            Title = "OFİS 110 PLAZADA METRO DURAĞINDA KİRALIK 60 M2 OFİS",
                            Price = 40000,
                            Location = "Ankara Altındağ",
                            Emlakci = "Şerife Çelik",
                            Durum = "Kiralık",
                            KonumLinki = "https://www.google.com/maps/dir//39.9558255,32.8586502/@39.9099518,32.7108447,12z?entry=ttu&g_ep=EgoyMDI1MDcyMC4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "OFİS 110 PLAZA\nDışkapı Metro çıkışında olup, Plazada 85 Ofis, İtfaiye Çarşısında 152 Dükkan bulunmaktadır.\n60 Ofis 1+0, 15 Ofis 2+0, 10 Ofis 3+0 Ofisten oluşmaktadır.\nGENEL ÖZELLİKLER\n4. Kat\n60 m2 Net Kullanım Alanı \nŞehir Manzaralı \nFancoil Isıtma Sistemi\nLaminant ve Islak Zemin Seramik\nYangın Söndürme Sistemi\n2 Asansör\nOfis Girişi Bağımsız\nAçık ve Kapalı Otopark\n6 Dönüm Peyzaj Alanı\nKamelyalar\nÇocuk Bahçesi\n24 Saat Güvenlik \n265 Adet Kayıtlı Kamera Sistemi\nAnkara Üniversitesi Ziraat Fakültesi, Dışkapı Yıldırım Beyazıt Eğitim ve Araştırma Hastanesi, Gülhane Eğitim ve Araştırma Hastanesi Türk Telekom Genel Müdürlüğü, Aski Genel Müdürlüğüne yakın konumda bulunmaktadır.\nDETAYLI BİLGİ İÇİN LÜTFEN ARAYIN.",
                            M2 = 60,
                            OdaSayisi = "2+0",
                            IlanTarihi = "2025-07-21",
                            EmlakTipi = "Kiralık Ofis",
                            BinaYasi = 0,
                            BulunduguKat = "4. Kat",
                            KatSayisi = null,
                            Isitma = "Fancoil Isıtma Sistemi",
                            BanyoSayisi = null,
                            MutfakTipi = null,
                            Balkon = null,
                            Asansor = null,
                            Otopark = null,
                            Esyali = null,
                            KullanimDurumu = null,
                            SiteIcerisinde = null,
                            KrediyeUygun = "Uygun",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = null,
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d97932.9602499662!2d32.7108447!3d39.9099518!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d39.955825499999996!2d32.8586502!5e0!3m2!1str!2str!4v1753260432701!5m2!1str!2str",
                            ImageCount = 32
                        },
                        new Property
                        {
                            Id = "1231950448",
                            ImageURL = "https://i0.shbdn.com/photos/95/04/48/x5_1231950448gs5.jpg",
                            Title = "MALTEPE ZÜMRÜTEVLER TABLO ADALAR DA SATILIK 1+1 DAİRE",
                            Price = 7300000,
                            Location = "Ankara Maltepe",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//40.9399851,29.1568693/@40.240996,28.3507636,7z?entry=ttu&g_ep=EgoyMDI1MDcyMC4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "TABLO ADALAR PROJESİ ; 15.000 m2 arazi üzerinde 2 Blok 316 Daireden oluşan bir alana sahiptir.\nProje prestijli sitelerin bulunduğu bir bölgede yeralmaktadır.\nGENEL ÖZELLİKLER\n64 M2 net 42 M2\nBalkon 6 M2\nOcak - Fırın - Bulaşık Makinası Sıemens Marka Ankastre\nDavlumbaz Teka Marka\nKapaklı Vestiyer\nÇamaşır Makinası Alanı\nKlima Alt Yapısı Hazır\nYerler Ahşap Parke Zemin\nMerkezi Isıtma Sistemi\nDaireye Ait Özel Depo\nÖzel Otopark Alanı\nAçık ve Kapalı Yüzme Havuz\nSauna - Fitness Salonu\nTenis Kortu , Basketbol Sahası\nÇocuk Oyun Alanları\nYürüyüş Yolları , Seyir Terası\n22 Adet Elektrikli Şarj İstasyonu\n24 Saat Canlı Güven\nEsenkent Metro Durağına 1 Dakika , E-5 Otoyolu 2 Dakika , Maltepe Park & Pizza AVM 2 Dakika\nAnatolium & Ikea AVM 4 Dakika, Maltepe Sahil 10 Dakika , Bostancı İdo 15 Dakika , 15 Temmuz Şehitler Köprüsü 20 Dakika ,\nSabiha Gökçen Havaalanı 20 Dakika , Avrasya Tüneli 25 Dakika mesafede bulunmaktadır\nDETAYLAR İÇİN LÜTFEN ARAYINIZ",
                            M2 = 64,
                            OdaSayisi = "1+1",
                            IlanTarihi = "2025-07-21",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 0,
                            BulunduguKat = "6. Kat",
                            KatSayisi = 15,
                            Isitma = "Merkezi Isıtma Sistemi",
                            BanyoSayisi = "1",
                            MutfakTipi = "Açık",
                            Balkon = "Var",
                            Asansor = "Var",
                            Otopark = "Var & Kapalı Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = "Var",
                            KrediyeUygun = "Hayır",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Evet",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d3118657.5066005797!2d28.3507636!3d40.240996!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d40.9399851!2d29.1568693!5e0!3m2!1str!2str!4v1753260460236!5m2!1str!2str",
                            ImageCount = 19
                        },
                        new Property
                        {
                            Id = "12345678900",
                            ImageURL = "https://i0.shbdn.com/photos/95/04/48/x5_1231950448gs5.jpg",
                            Title = "  sdfsdfsdfsdf TABLO ADALAR DA SATILIK 1+1 DAİRE",
                            Price = 7300000,
                            Location = "Ankara Maltepe",
                            Emlakci = "Şerife Çelik",
                            Durum = "Satılık",
                            KonumLinki = "https://www.google.com/maps/dir//40.9399851,29.1568693/@40.240996,28.3507636,7z?entry=ttu&g_ep=EgoyMDI1MDcyMC4wIKXMDSoASAFQAw%3D%3D",
                            Aciklama = "TABLO ADALAR PROJESİ ; 15.000 m2 arazi üzerinde 2 Blok 316 Daireden oluşan bir alana sahiptir.\nProje prestijli sitelerin bulunduğu bir bölgede yeralmaktadır.\nGENEL ÖZELLİKLER\n64 M2 net 42 M2\nBalkon 6 M2\nOcak - Fırın - Bulaşık Makinası Sıemens Marka Ankastre\nDavlumbaz Teka Marka\nKapaklı Vestiyer\nÇamaşır Makinası Alanı\nKlima Alt Yapısı Hazır\nYerler Ahşap Parke Zemin\nMerkezi Isıtma Sistemi\nDaireye Ait Özel Depo\nÖzel Otopark Alanı\nAçık ve Kapalı Yüzme Havuz\nSauna - Fitness Salonu\nTenis Kortu , Basketbol Sahası\nÇocuk Oyun Alanları\nYürüyüş Yolları , Seyir Terası\n22 Adet Elektrikli Şarj İstasyonu\n24 Saat Canlı Güven\nEsenkent Metro Durağına 1 Dakika , E-5 Otoyolu 2 Dakika , Maltepe Park & Pizza AVM 2 Dakika\nAnatolium & Ikea AVM 4 Dakika, Maltepe Sahil 10 Dakika , Bostancı İdo 15 Dakika , 15 Temmuz Şehitler Köprüsü 20 Dakika ,\nSabiha Gökçen Havaalanı 20 Dakika , Avrasya Tüneli 25 Dakika mesafede bulunmaktadır\nDETAYLAR İÇİN LÜTFEN ARAYINIZ",
                            M2 = 64,
                            OdaSayisi = "1+1",
                            IlanTarihi = "2025-07-21",
                            EmlakTipi = "Satılık Daire",
                            BinaYasi = 0,
                            BulunduguKat = "6. Kat",
                            KatSayisi = 15,
                            Isitma = "Merkezi Isıtma Sistemi",
                            BanyoSayisi = "1",
                            MutfakTipi = "Açık",
                            Balkon = "Var",
                            Asansor = "Var",
                            Otopark = "Var & Kapalı Otopark",
                            Esyali = "Hayır",
                            KullanimDurumu = "Boş",
                            SiteIcerisinde = "Var",
                            KrediyeUygun = "Hayır",
                            TapuDurumu = "Kat Mülkiyetli",
                            Kimden = "Emlak Ofisinden",
                            Takas = "Evet",
                            HaritaUrl = "https://www.google.com/maps/embed?pb=!1m17!1m8!1m3!1d3118657.5066005797!2d28.3507636!3d40.240996!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d40.9399851!2d29.1568693!5e0!3m2!1str!2str!4v1753260460236!5m2!1str!2str",
                            ImageCount = 19
                        },
                    }
                }
            };
            BlogPosts = new List<BlogPost>
            {
                new BlogPost
                {
                    Slug = "degerleme-hizmeti",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Değerleme Hizmeti",
                    Image = "https://www.hepsiemlak.com/emlak-yasam/wp-content/uploads/2018/09/ev-satisi-icin-ilan-aciklamasina-neler-yazilmalidir-4.jpg",
                    Snippet = "Gayrimenkul yatırımları, önemli finansal kararlar almayı gerektiren uzun vadeli yatırımlardır. Yatırımcıların veya satıcıların mülklerinin gerçek",
                    FullContent = @"
          <p>Gayrimenkul yatırımları, önemli finansal kararlar almayı gerektiren uzun vadeli yatırımlardır. Yatırımcıların veya satıcıların mülklerinin gerçek değerini öğrenmeleri, doğru kararlar alabilmeleri ve en verimli şekilde ilerleyebilmeleri için gayrimenkul değerleme hizmeti büyük bir önem taşır. Doğru bir değerleme, hem alıcı hem de satıcı için en iyi fırsatları sunar ve piyasadaki dalgalanmalara karşı güçlü bir savunma oluşturur.</p>
          <h2>Değerleme Hizmeti Nedir?</h2>
          <p>Gayrimenkul değerlemesi, bir mülkün piyasa koşullarına, fiziksel durumuna ve diğer dış etkenlere göre belirli bir değere sahip olup olmadığının hesaplanması sürecidir. Bu hizmet, profesyonel değerleme uzmanları tarafından gerçekleştirilir ve alıcılar, satıcılar, banka ve finansal kurumlar için çok önemli bir araçtır.</p>
          <p>Değerleme, genellikle; mülkün bulunduğu bölge, metrekare fiyatları, benzer mülklerin satış fiyatları, mülkün yaşı, kullanılan malzemeler, altyapı olanakları gibi kriterlere dayanarak yapılır.</p>
          <h2>Neden Değerleme Hizmeti Almalısınız?</h2>
          <p>Değerleme hizmeti almak, birçok farklı durumu daha iyi yönetmenize olanak tanır:</p>
          <ul>
            <li><strong>Doğru Fiyatlandırma:</strong> Mülkünüzün doğru bir şekilde değerlenmesi, doğru fiyatla alım-satım yapmanızı sağlar. Aksi takdirde, değerinin çok altında ya da çok üstünde bir fiyatla işlem yapabilirsiniz.</li>
            <li><strong>Yatırım Kararları İçin Güvenilir Veriler:</strong> Yatırımcılar için, doğru bir değerleme, hangi mülkün daha fazla kazanç sağlayacağını anlamada en önemli adımdır. Değerleme hizmeti, yalnızca mevcut değerleri değil, gelecekteki değer artışı beklentilerini de göz önünde bulundurur.</li>
            <li><strong>Finansal Güvence:</strong> Bankalar ve finansal kurumlar, kredi verirken mülkün değerini göz önünde bulundurur. Bu nedenle, değerleme raporları, kredilerin onaylanmasında ve ipotek işlemlerinde çok önemlidir.</li>
            <li><strong>Vergi ve Yasal İşlemler:</strong> Yatırımcılar, mülkün değeri ile doğru orantılı vergi ödemek zorundadırlar. Değerleme, doğru vergilendirme ve mülk yönetimi için gerekli bir adımdır.</li>
          </ul>
          <h2>Değerleme Süreci Nasıl İşler?</h2>
          <p>Bir gayrimenkul değerleme hizmeti genellikle aşağıdaki adımları içerir:</p>
          <ol>
            <li><strong>Yerinde İnceleme:</strong> Uzman değerleme uzmanı, mülkün yerinde fiziksel incelemesini yapar. Bu aşamada, mülkün genel durumu, yapısal özellikleri ve kullanılan malzemeler değerlendirilir.</li>
            <li><strong>Pazar Araştırması:</strong> Mülkün bulunduğu bölgedeki piyasa koşulları, emlak fiyatları ve benzer mülklerle karşılaştırma yapılır.</li>
            <li><strong>Raporlama:</strong> Değerleme uzmanı, bulguları bir rapor halinde sunar. Bu rapor, mülkün piyasa değeri, gelecekteki değer tahminleri ve potansiyel riskler hakkında detaylı bilgiler içerir.</li>
          </ol>
          <h2>Profesyonel Değerleme Hizmeti ile Kazanç Sağlayın</h2>
          <p>Gayrimenkul değerleme, basit bir tahminin ötesinde, doğru hesaplamalar ve piyasaya dayalı analizlere dayanır. Uzman kişiler tarafından yapılan değerleme hizmeti, alıcıların ve satıcıların mülklerine en uygun fiyatı belirlemelerine yardımcı olur ve dolayısıyla gereksiz kayıplardan korunmalarını sağlar.</p>
          <p>Gayrimenkul alım satımı yaparken ya da yatırım yaparken, profesyonel değerleme hizmeti almak, başarıyı garantileyen önemli bir adımdır.</p>
        "
                },
                new BlogPost
                {
                    Slug = "gelecegi-planlama",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Geleceği Planlama",
                    Image = "https://www.speakeragency.com.tr/media/2qpixzbk/yatirim-arac-lari.jpg",
                    Snippet = "Geleceği planlamak, yalnızca kısa vadeli hedeflere ulaşmaktan çok daha fazlasıdır. İster bireysel, ister kurumsal düzeyde",
                    FullContent = @"
          <p>Geleceği planlamak, yalnızca kısa vadeli hedeflere ulaşmaktan çok daha fazlasıdır. İster bireysel, ister kurumsal düzeyde olsun, doğru bir strateji ile yarınları inşa etmek, başarılı ve sürdürülebilir bir gelecek için kritik öneme sahiptir.</p>
          <h2>Neden Geleceği Planlamalıyız?</h2>
          <p>Geleceği planlamak, belirsizlikleri azaltır ve hedeflerinize ulaşmanız için net bir yol haritası sunar. Bu, hem finansal hem de kişisel büyüme için temel bir adımdır.</p>
          <ul>
            <li><strong>Risk Yönetimi:</strong> Potansiyel riskleri önceden belirlemenizi ve bunlara karşı önlemler almanızı sağlar.</li>
            <li><strong>Fırsatları Yakalama:</strong> Gelecekte ortaya çıkabilecek fırsatları erken fark etmenize ve değerlendirmenize yardımcı olur.</li>
            <li><strong>Kaynak Verimliliği:</strong> Zaman, para ve enerji gibi kaynaklarınızı daha verimli kullanmanızı sağlar.</li>
          </ul>
          <h2>Planlama Süreci Nasıl İşler?</h2>
          <ol>
            <li><strong>Hedef Belirleme:</strong> Kısa, orta ve uzun vadeli hedefleriniz netleştirin.</li>
            <li><strong>Durum Analizi:</strong> Mevcut durumunuzu, güçlü ve zayıf yönlerinizi değerlendirin.</li>
            <li><strong>Strateji Geliştirme:</strong> Belirlediğiniz hedeflere ulaşmak için yol haritaları oluşturun.</li>
            <li><strong>Uygulama ve Takip:</strong> Planlarınızı hayata geçirin ve düzenli olarak ilerlemenizi takip edin.</li>
            <li><strong>Esneklik:</strong> Değişen koşullara göre planlarınızı güncelleyin.</li>
          </ol>
          <p>Unutmayın, geleceği planlamak bir kerelik bir işlem değil, sürekli bir süreçtir. Düzenli gözden geçirmeler ve adaptasyon, başarılı bir geleceğin anahtarıdır.</p>
        "
                },
                new BlogPost
                {
                    Slug = "yatirim-danismanligi",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Yatırım Danışmanlığı",
                    Image = "https://www.turkiyefinansala.com/tr-tr/ala-hayat-blog/PublishingImages/yatirimaraci-blog-v1.png",
                    Snippet = "Yatırım, doğru yapıldığında geleceği güvence altına almanın en etkili yollarından biridir. Ancak her yatırım fırsatı,",
                    FullContent = @"
          <p>Yatırım, doğru yapıldığında geleceği güvence altına almanın en etkili yollarından biridir. Ancak her yatırım fırsatı, kendi risklerini ve karmaşıklıklarını barındırır. İşte bu noktada, profesyonel yatırım danışmanlığı devreye girer. Yatırım danışmanlığı, finansal hedeflerinize ulaşmanız için size özel stratejiler sunan uzmanlık hizmetidir.</p>
          <h2>Yatırım Danışmanlığı Nedir?</h2>
          <p>Yatırım danışmanlığı, finansal piyasalar hakkında derin bilgiye sahip uzmanların, bireylerin veya kurumların yatırım hedeflerini, risk toleranslarını ve finansal durumlarını analiz ederek onlara özel yatırım stratejileri geliştirmesidir. Bu hizmet, portföy oluşturma, varlık dağılımı, piyasa analizi ve yatırım araçları seçimi gibi konularda rehberlik sağlar.</p>
          <h2>Neden Yatırım Danışmanlığı Almalısınız?</h2>
          <ul>
            <li><strong>Uzman Bilgisi:</strong> Finans piyasalarının karmaşıklığı içinde doğru kararlar almak için uzman bir rehberlik sağlar.</li>
            <li><strong>Risk Yönetimi:</strong> Yatırım risklerini minimize etmenize ve portföyünüzü dengeli hale getirmenize yardımcı olur.</li>
            <li><strong>Zaman Tasarrufu:</strong> Piyasaları sürekli takip etme ve analiz etme yükünü üzerinizden alır.</li>
            <li><strong>Kişiselleştirilmiş Stratejiler:</strong> Finansal hedeflerinize ve risk profilinize uygun kişiselleştirilmiş yatırım planları sunar.</li>
          </ul>
          <h2>Yatırım Danışmanlığı Süreci:</h2>
          <ol>
            <li><strong>Finansal Durum Analizi:</strong> Mevcut varlıklarınız, borçlarınız, gelir ve giderleriniz incelenir.</li>
            <li><strong>Hedef Belirleme:</strong> Kısa, orta ve uzun vadeli finansal hedefleriniz netleştirilir.</li>
            <li><strong>Risk Toleransı Belirleme:</strong> Ne kadar risk almaya istekli olduğunuz değerlendirilir.</li>
            <li><strong>Strateji Geliştirme:</strong> Belirlediğiniz hedeflere ulaşmak için yol haritaları oluşturun.</li>
            <li><strong>Portföy Oluşturma ve Yönetimi:</strong> Seçilen yatırım araçları ile portföy oluşturulur ve düzenli olarak takip edilir.</li>
          </ol>
          <p>Profesyonel yatırım danışmanlığı ile finansal geleceğinizi güvence altına alabilir, daha bilinçli ve stratejik yatırım kararları verebilirsiniz.</p>
        "
                },
                new BlogPost
                {
                    Slug = "gayrimenkul-gelecegi-planlama",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Gayrimenkul Geleceği Planlama",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQz0flIZyJrdaz0V_FReWz8jcn71htsdqqQrQ&s",
                    Snippet = "Gayrimenkul, geçmişten bugüne en güvenilir yatırım araçlarından biri olmuştur. Ancak artık yalnızca “taşınmaz sahibi olmak”",
                    FullContent = @"
          <p>Gayrimenkul, geçmişten bugüne en güvenilir yatırım araçlarından biri olmuştur. Ancak artık yalnızca “taşınmaz sahibi olmak” yeterli değil. Geleceğin gayrimenkulünü planlamak, sürdürülebilirlik, teknoloji ve değişen yaşam tarzları gibi faktörleri göz önünde bulundurmayı gerektirir.</p>
          <h2>Gayrimenkul Geleceği Neden Önemli?</h2>
          <p>Şehirlerin büyümesi, iklim değişikliği, teknolojik gelişmeler ve yeni nesillerin beklentileri, gayrimenkul sektörünü sürekli değişmeye zorluyor. Geleceği planlamak, hem yatırımcılar hem de şehirler için uzun vadeli değer yaratmanın anahtarıdır.</p>
          <ul>
            <li><strong>Sürdürülebilirlik:</strong> Çevre dostu binalar ve enerji verimliliği ön planda.</li>
            <li><strong>Akıllı Şehirler:</strong> Teknoloji entegrasyonu ile daha yaşanabilir ve verimli kentler.</li>
            <li><strong>Esnek Yaşam Alanları:</strong> Uzaktan çalışma ve hibrit yaşam modellerine uygun konut ve ofisler.</li>
          </ul>
          <h2>Gelecek İçin Gayrimenkul Stratejileri:</h2>
          <ol>
            <li><strong>Yeşil Binalar:</strong> Enerji verimliliği yüksek, çevreye duyarlı projeler.</li>
            <li><strong>Teknoloji Entegrasyonu:</strong> Akıllı ev sistemleri, IoT tabanlı çözümler.</li>
            <li><strong>Karma Kullanım Projeleri:</strong> Konut, iş yeri, alışveriş ve sosyal alanları bir araya getiren yapılar.</li>
            <li><strong>Kentsel Dönüşüm:</strong> Eski ve riskli yapıların modern ve güvenli alanlara dönüştürülmesi.</li>
          </ol>
          <p>Gayrimenkulde geleceği planlamak, sadece bugünü değil, yarınları da düşünen, yenilikçi ve vizyoner bir yaklaşım gerektirir.</p>
        "
                },
                new BlogPost
                {
                    Slug = "gayrimenkul-kiralama",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Gayrimenkul Kiralama",
                    Image = "https://www.katilimevim.com.tr/wp-content/uploads/shutterstock_11416447557-min-580x350.jpg",
                    Snippet = "Gayrimenkul kiralama, hem mülk sahibi hem de kiracı açısından dikkatli yönetilmesi gereken önemli bir süreçtir.",
                    FullContent = @"
          <p>Gayrimenkul kiralama, hem mülk sahibi hem de kiracı açısından dikkatli yönetilmesi gereken önemli bir süreçtir. Doğru adımlar atıldığında her iki taraf için de sorunsuz ve karlı bir deneyim olabilir. Bu yazımızda gayrimenkul kiralama sürecinin püf noktalarına değineceğiz.</p>
          <h3>Mülk Sahibi Açısından:</h3>
          <ul>
            <li><strong>Doğru Fiyatlandırma:</strong> Bölgedeki benzer mülklerin kira bedellerini araştırarak rekabetçi ve adil bir kira belirleyin.</li>
            <li><strong>Güvenilir Kiracı Seçimi:</strong> Kiracının finansal geçmişini ve referanslarını kontrol edin.</li>
            <li><strong>Kira Sözleşmesi:</strong> Detaylı ve yasalara uygun bir kira sözleşmesi hazırlayın. Depozito, aidat, kira artış oranı, mülkün teslim durumu gibi tüm detayları netleştirin.</li>
            <li><strong>Mülk Bakımı:</strong> Mülkün kiraya verilmeden önce gerekli bakım ve onarımlarının yapıldığından emin olun.</li>
          </ul>
          <h3>Kiracı Açısından:</h3>
          <ul>
            <li><strong>Bütçe Belirleme:</strong> Kira, depozito, aidat ve diğer olası masrafları karşılayabileceğiniz bir bütçe belirleyin.</li>
            <li><strong>Mülk İncelemesi:</strong> Kiralamadan önce mülkü detaylıca inceleyin, eksik veya hasarlı yerleri not alın ve sözleşmeye ekletin.</li>
            <li><strong>Kira Sözleşmesi:</strong> Sözleşmedeki her maddeyi dikkatlice okuyun ve anladığınız yerleri sorun. Özellikle kira artış oranları ve erken çıkış koşulları önemlidir.</li>
            <li><strong>Konum Araştırması:</strong> Mülkün konumunun yaşam tarzınıza, işinize ve ulaşım imkanlarına uygun olup olmadığını değerlendirin.</li>
          </ul>
          <h2>Profesyonel Destek:</h2>
          <p>Gayrimenkul kiralama sürecinde bir emlak danışmanından destek almak, hem mülk sahipleri hem de kiracılar için süreci çok daha kolay ve güvenli hale getirebilir. Danışmanlar, yasal süreçler, doğru fiyatlandırma ve güvenilir eşleştirme konularında uzman desteği sunar.</p>
        "
                },
                new BlogPost
                {
                    Slug = "gayrimenkul-alim-satim",
                    Author = "admin",
                    Date = "Nisan 30, 2025",
                    Title = "Gayrimenkul Alım Satım",
                    Image = "https://media.istockphoto.com/id/1409298953/tr/foto%C4%9Fraf/real-estate-agents-shake-hands-after-the-signing-of-the-contract-agreement-is-complete.jpg?s=612x612&w=0&k=20&c=M3fmkbnEOnFlAqZsuDE-W4bfMqvtsF4oPrAsR2ID96s=",
                    Snippet = "Gayrimenkul alım satımı, yüksek bütçeli ve uzun vadeli kararlar gerektirdiği için ciddi bir bilgi ve",
                    FullContent = @"
          <p>Gayrimenkul alım satımı, yüksek bütçeli ve uzun vadeli kararlar gerektirdiği için ciddi bir bilgi ve dikkat gerektiren önemli bir süreçtir. Doğru adımlar atıldığında karlı ve sorunsuz bir işlem olabilirken, hatalar ciddi sonuçlar doğurabilir. İşte gayrimenkul alım satımında dikkat etmeniz gerekenler:</p>
          <h2>Alım Sürecinde Dikkat Edilmesi Gerekenler:</h2>
          <ul>
            <li><strong>İhtiyaç ve Bütçe Analizi:</strong> Ne tür bir gayrimenkule ihtiyacınız olduğunu (konut, iş yeri, arsa vb.) ve bütçenizi netleştirin.</li>
            <li><strong>Konum Araştırması:</strong> Konumun yaşam tarzınıza, işinize, ulaşım imkanlarına ve gelecek potansiyeline uygunluğunu değerlendirin.</li>
            <li><strong>Tapu ve Hukuki Durum İncelemesi:</strong> Gayrimenkulün tapu kaydını, ipotek, haciz gibi şerhleri ve imar durumunu mutlaka kontrol edin. Gerekirse bir hukuk danışmanından destek alın.</li>
            <li><strong>Mülk Değerlemesi:</strong> Bağımsız bir eksperden değerleme hizmeti alarak mülkün gerçek piyasa değerini öğrenin.</li>
            <li><strong>Sözleşme Detayları:</strong> Satış sözleşmesindeki tüm maddeleri dikkatlice okuyun ve anladığınızdan emin olun.</li>
            <li><strong>İletişim Becerileri:</strong> Sizinle düzenli ve etkili iletişim kurabilmeli, sorularınıza hızlı ve tatmin edici yanıtlar vermelidir.</li>
          </ul>
          <h2>Satım Sürecinde Dikkat Edilmesi Gerekenler:</h2>
          <ul>
            <li><strong>Doğru Fiyat Belirleme:</strong> Piyasa koşulları ve benzer mülklerin satış fiyatlarına göre rekabetçi ve gerçekçi bir satış fiyatı belirleyin.</li>
            <li><strong>Mülkü Hazırlama:</strong> Potansiyel alıcılar için mülkü en iyi şekilde sunmak üzere küçük onarımlar, temizlik ve düzenlemeler yapın.</li>
            <li><strong>Etkili Pazarlama:</strong> Profesyonel fotoğraflar ve detaylı açıklamalarla ilanınızı cazip hale getirin. Doğru platformlarda ilanınızı yayınlayın.</li>
            <li><strong>Gerekli Belgeler:</strong> Tapu, iskan, enerji kimlik belgesi gibi satış için gerekli tüm belgeleri hazır bulundurun.</li>
            <li><strong>Profesyonel Destek:</strong> Emlak danışmanları, süreci hızlandırma, doğru alıcı bulma ve hukuki prosedürlerde size yardımcı olabilir.</li>
          </ul>
          <h2>Alım Satımda Penta Nest Farkı:</h2>
          <p>Penta Nest olarak, gayrimenkul alım satım sürecinizi baştan sona profesyonelce yönetiyor, doğru kararlar almanız için size danışmanlık hizmeti sunuyoruz. Güvenilir ve şeffaf bir süreç için bize ulaşın.</p>
        "
                },
                new BlogPost
                {
                    Slug = "ankara-guvenilir-en-iyi-emlakci",
                    Author = "admin",
                    Date = "Nisan 26, 2025",
                    Title = "Ankara Güvenilir En İyi Emlakçı",
                    Image = "/assets/pentanestlogo.png",
                    Snippet = "Emlak alım-satımı ciddi bir yatırımdır. Bu yüzden çalıştığınız emlakçının sadece satış odaklı değil, tamamen…",
                    FullContent = @"
          <p>Emlak alım-satımı ciddi bir yatırımdır. Bu yüzden çalıştığınız emlakçının sadece satış odaklı değil, tamamen sizin çıkarlarınızı gözeten, güvenilir ve profesyonel bir yaklaşım sergilemesi hayati önem taşır. Ankara'da güvenilir bir emlakçı arayışınızda nelere dikkat etmelisiniz?</p>
          <h2>Güvenilir Emlakçı Seçiminde Anahtar Kriterler:</h2>
          <ul>
            <li><strong>Tecrübe ve Bilgi Birikimi:</strong> Bölgenin dinamiklerini, piyasa koşullarını ve yasal mevzuatları iyi bilen bir emlakçı, size doğru yönlendirmeler yapabilir.</li>
            <li><strong>Şeffaflık ve Dürüstlük:</strong> Tüm süreçleri şeffaf bir şekilde yönetmeli, olası riskler ve avantajlar hakkında size net bilgi vermelidir.</li>
            <li><strong>Referanslar ve İtibar:</strong> Daha önceki müşterilerinin geri bildirimleri ve sektördeki itibarı, emlakçının güvenilirliği hakkında önemli ipuçları verir.</li>
            <li><strong>Profesyonel Yaklaşım:</strong> Sözleşmeler, değerleme raporları ve pazarlama stratejileri gibi konularda profesyonel bir hizmet sunmalıdır.</li>
            <li><strong>İletişim Becerileri:</strong> Sizinle düzenli ve etkili iletişim kurabilmeli, sorularınıza hızlı ve tatmin edici yanıtlar vermelidir.</li>
          </ul>
          <h2>Ankara'da Güvenilir Emlakçı Ararken:</h2>
          <p>Ankara'nın geniş ve dinamik emlak piyasasında doğru emlakçıyı bulmak zaman alabilir. Yerel bilgiye sahip, müşteri odaklı çalışan ve olumlu referansları olan emlakçılarla görüşmek önemlidir.</p>
          <p>Penta Nest olarak, Ankara'da gayrimenkul alım, satım ve kiralama süreçlerinizde güvenilir, şeffaf ve profesyonel bir hizmet sunarak yanınızdayız. Uzman ekibimizle tanışmak ve ihtiyaçlarınıza özel çözümlerimiz hakkında bilgi almak için bize ulaşın.</p>
        "
                },
                new BlogPost
                {
                    Slug = "ankara-en-iyi-emlakci",
                    Author = "admin",
                    Date = "Nisan 26, 2025",
                    Title = "Ankara En İyi Emlakçı",
                    Image = "/assets/pentanestlogo.png",
                    Snippet = "Gayrimenkul alım satımı, doğru bilgi ve deneyim gerektiren önemli bir süreçtir. Özellikle Ankara gibi…",
                    FullContent = @"
          <p>Gayrimenkul alım satımı, doğru bilgi ve deneyim gerektiren önemli bir süreçtir. Özellikle Ankara gibi büyük ve dinamik bir şehirde en iyi emlakçıyı bulmak, yatırımınızın başarısı için kritik öneme sahiptir. Peki, Ankara'da ""en iyi"" emlakçıyı tanımlayan kriterler nelerdir?</p>
          <h2>Ankara'da En İyi Emlakçı Özellikleri:</h2>
          <ul>
            <li><strong>Yerel Piyasa Uzmanlığı:</strong> Ankara'nın farklı bölgelerindeki piyasa koşullarına, değer artış potansiyellerine ve demografik yapılarına hakim olmalıdır.</li>
            <li><strong>Geniş Portföy:</strong> İhtiyaçlarınıza uygun geniş ve çeşitli bir gayrimenkul portföyü sunabilmelidir.</li>
            <li><strong>Profesyonel Pazarlama:</strong> Gayrimenkullerinizi en iyi şekilde sergileyen profesyonel fotoğrafçılık, sanal tur ve etkili ilan metinleri gibi pazarlama stratejileri kullanmalıdır.</li>
            <li><strong>Güçlü İletişim Ağı:</strong> Hem alıcı hem de satıcı tarafında geniş bir iletişim ağına sahip olmalıdır.</li>
            <li><strong>Müşteri Memnuniyeti Odaklı:</strong> Müşteri geri bildirimleri olumlu olmalı ve sizin hedeflerinize ulaşmanızı önceliklendirmelidir.</li>
            <li><strong>Hukuki Bilgi ve Destek:</strong> Alım-satım süreçlerindeki yasal prosedürlere hakim olmalı ve gerektiğinde hukuki destek sağlayabilmelidir.</li>
          </ul>
          <h2>Neden Penta Nest?</h2>
          <p>Penta Nest olarak, Ankara'da gayrimenkul sektöründe yılların verdiği tecrübe ve geniş uzman kadromuzla ""en iyi"" hizmeti sunmayı hedefliyoruz. Müşteri odaklı yaklaşımımız, detaylı piyasa analizlerimiz ve şeffaf süreçlerimizle, gayrimenkul süreçlerinizi en verimli şekilde yönetiyoruz. Ankara’daki gayrimenkul ihtiyaçlarınız için güvenilir bir partner arıyorsanız,  Nest sizin için doğru adres.</p>
        "
                },
                new BlogPost
                {
                    Slug = "cankaya-en-iyi-emlakci",
                    Author = "admin",
                    Date = "Nisan 26, 2025",
                    Title = "Çankaya En İyi Emlakçı",
                    Image = "/assets/pentanestlogo.png",
                    Snippet = "Emlak sektöründe güvenilir bir isim arıyorsanız, bölgeyi yakından tanıyan ve profesyonel yaklaşımı ile öne…",
                    FullContent = @"
          <p>Emlak sektöründe güvenilir bir isim arıyorsanız, bölgeyi yakından tanıyan ve profesyonel yaklaşımı ile öne çıkan bir emlakçı bulmak büyük önem taşır. Ankara'nın en gözde ve merkezi ilçelerinden Çankaya'da gayrimenkul alım-satım veya kiralama işlemleri yaparken ""en iyi emlakçı""ya nasıl ulaşabilirsiniz?</p>
          <h2>Çankaya'da En İyi Emlakçıyı Seçme Kriterleri:</h2>
          <ul>
            <li><strong>Bölgesel Uzmanlık:</strong> Çankaya'nın semtlerini (Çayyolu, Ümitköy, Ayrancı, Kavaklıdere vb.) ve her birinin kendine özgü dinamiklerini iyi bilmelidir.</li>
            <li><strong>Geniş Çankaya Portföyü:</strong> Bölgede geniş bir konut, iş yeri ve arsa portföyüne sahip olmalıdır.</li>
            <li><strong>Piyasa Bilgisi:</strong> Çankaya'daki güncel piyasa değerlerini, kira ve satış trendlerini yakından takip etmelidir.</li>
            <li><strong>Müşteri İlişkileri:</strong> Daha önceki Çankaya müşterilerinden olumlu geri bildirimler almalıdır.</li>
            <li><strong>Hukuki Destek:</strong> Özellikle Çankaya'daki imar, tapu ve kentsel dönüşüm süreçleri hakkında bilgi sahibi olmalıdır.</li>
          </ul>
          <h2>Penta Nest ile Çankaya'da Güvenilir Emlak Deneyimi:</h2>
          <p>Penta Nest olarak, Çankaya'nın her noktasındaki gayrimenkul ihtiyaçlarınıza yönelik kapsamlı ve profesyonel çözümler sunuyoruz. Uzman ekibimizle, Çankaya'daki ev arayışınızda veya mülkünüzü satma/kiralamada size en doğru rehberliği sağlamaktan gurur duyarız. Çankaya'daki emlak işlemleriniz için bize güvenebilirsiniz.</p>
        "
                },
                new BlogPost
                {
                    Slug = "ankara-en-iyi-gayrimenkul-ofisi",
                    Author = "admin",
                    Date = "Nisan 26, 2025",
                    Title = "Ankara En İyi Gayrimenkul Ofisi",
                    Image = "/assets/pentanestlogo.png",
                    Snippet = "Ankara, Türkiye’nin başkenti olmanın ötesinde, her geçen gün büyüyen ve gelişen bir gayrimenkul piyasasına sahip.",
                    FullContent = @"
          <p>Ankara, Türkiye’nin başkenti olmanın ötesinde, her geçen gün büyüyen ve gelişen bir gayrimenkul piyasasına sahip. Bu dinamik pazarda doğru kararları almak ve hedeflerinize ulaşmak için profesyonel bir gayrimenkul ofisi ile çalışmak büyük önem taşır. Peki, Ankara’da ""en iyi gayrimenkul ofisi""ni seçerken nelere dikkat etmelisiniz?</p>
          <h2>Ankara’da En İyi Gayrimenkul Ofisinin Özellikleri:</h2>
          <ul>
            <li><strong>Kapsamlı Hizmet Yelpazesi:</strong> Alım, satım, kiralama, değerleme, yatırım danışmanlığı gibi geniş bir yelpazede hizmet sunabilmelidir.</li>
            <li><strong>Uzman Kadro:</strong> Gayrimenkul hukuku, piyasa analizi ve satış stratejileri konularında uzmanlaşmış, deneyimli danışmanlara sahip olmalıdır.</li>
            <li><strong>Teknolojik Altyapı:</strong> Modern pazarlama araçları, veri analiz sistemleri ve müşteri ilişkileri yönetimi (CRM) yazılımları kullanmalıdır.</li>
            <li><strong>Güçlü Network:</strong> Sektördeki diğer paydaşlar (bankalar, inşaat firmaları, hukuki danışmanlar) ile güçlü ilişkilere sahip olmalıdır.</li>
            <li><strong>Müşteri Odaklılık:</strong> Müşteri memnuniyetini ön planda tutan, şeffaf ve etik çalışma prensiplerine sahip olmalıdır.</li>
          </ul>
          <h2>Penta Nest: Ankara’nın Güvenilir Gayrimenkul Çözüm Ortağı</h2>
          <p>Penta Nest olarak, Ankara’nın tüm bölgelerinde, geniş portföyümüz ve uzman ekibimizle size özel gayrimenkul çözümleri sunuyoruz. Sektördeki yenilikleri takip eden, teknoloji destekli hizmet anlayışımız ve müşteri odaklı yaklaşımımızla, gayrimenkul süreçlerinizi en verimli şekilde yönetiyoruz. Ankara’daki gayrimenkul ihtiyaçlarınız için güvenilir bir partner arıyorsanız,  Nest sizin için doğru adres.</p>
        "
                }
            };
            AllProperties = Danismanlar.SelectMany(d => d.Properties).ToList();
        }
    }
}