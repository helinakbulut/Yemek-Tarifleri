using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace YemekTarifleri
{
    public partial class FormYemekListesi : Form
    {
        // Favori yemeklerin isimlerini tutacak liste
        private static List<string> favoriYemekler = new List<string>();
        public string GelenKategori;
        private string mevcutVideoLinki = "";

        public FormYemekListesi()
        {
            InitializeComponent();
        }

        private void FormYemekListesi_Load(object sender, EventArgs e)
        {
            lblKategoriBaslik.Text = GelenKategori + " Menüsü";
            cmbYemekler.Items.Clear();

            if (GelenKategori == "Çorbalar")
                cmbYemekler.Items.AddRange(new string[] { "Mercimek Çorbası", "Ezogelin Çorbası", "Tarhana Çorbası", "Yoğurt Çorbası" });
            else if (GelenKategori == "Ana Yemekler")
                cmbYemekler.Items.AddRange(new string[] { "Karnıyarık", "Hünkar Beğendi", "Kuru Fasulye", "Pilav" });
            else if (GelenKategori == "Mezeler")
                cmbYemekler.Items.AddRange(new string[] { "Haydari", "Humus", "Şakşuka", "Acılı Ezme" });
            else if (GelenKategori == "Salatalar")
                cmbYemekler.Items.AddRange(new string[] { "Çoban Salatası", "Gavurdağı", "Rus Salatası", "Patlıcan Salatası" });
            else if (GelenKategori == "Tatlılar")
                cmbYemekler.Items.AddRange(new string[] { "Sütlaç", "Baklava", "Künefe", "Kazandibi" });
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYemekler.SelectedItem == null) return;
            string secilen = cmbYemekler.SelectedItem.ToString();

            rtbMalzemeler.Clear();
            rtbTarif.Clear();
            pbYemekResmi.Image = null; // Her seçimde eski resmi temizle

            // ================= ÇORBALAR =================
            if (secilen == "Mercimek Çorbası")
            {
                rtbMalzemeler.Text = "2 su bardağı kırmızı mercimek\r\n1 adet soğan\r\n2 yemek kaşığı un\r\n1 adet havuç\r\nYarım yemek kaşığı biber ya da  domates salçası (rengi kırmızı olsun isterseniz artırabilir ya da hiç kullanmayabilirsiniz)\r\n1 tatlı kaşığı tuz\r\nYarım çay kaşığı karabiber\r\n1 çay kaşığı kimyon (isteğe bağlı)\r\n2 litre sıcak su\r\n5 yemek kaşığı sıvı yağ\r\nSosu için:\r\n\r\n2 yemek kaşığı tereyağı\r\n1 tatlı kaşığı kırmızı toz biber";
                rtbTarif.Text = "Kırmızı mercimek çorbası için sıvı yağı tencereye alınarak yemeklik doğranan soğanlar hafif pembeleşinceye kadar kavrulur.\r\nDaha sonra un ilave edilerek kısık ateşte kavurmaya devam edilir.\r\nSalça kullanılacak ise salça ilave edilir, kavrulduktan sonra küp küp doğranmış havuç ve iyice yıkanıp suyu süzülen mercimekler ilave edilir.\r\nÜzerine su eklenerek karıştırılır ve tencerenin kapağı kapatılır. Çorbamız kaynayana kadar orta ateşte, kaynadıktan sonra mercimekler ve havuçlar yumuşayana kadar ara ara karıştırılarak kısık ateşte pişirilir.\r\nÇorba piştikten sonra el blenderı ile güzelce ezilir. Eğer blenderiniz yoksa süzgeçten de geçirebilirsiniz.\r\nKarabiber, tuz ve isteğe bağlı olarak kimyon eklenir ve karıştırılır. 5 dakika daha pişirilerek ocaktan alınır.\r\nKıvamı koyu gelirse size, bir miktar su ilave edilerek bir taşım kaynatılır.\r\nBu arada küçük bir tavaya iki yemek kaşığı tereyağı alınır, kızdırılır ve bir tatlı kaşığı kırmızı toz biber eklenerek ocaktan alınır.\r\nMercimek çorbası servis kasesine alındıktan sonra üzerine kırmızı biberli sos gezdirilir ve bir dilim limon ile servis edilir.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=_TQEHoEgXvg";
                pbYemekResmi.Image = Properties.Resources.mercimek;
            }
            else if (secilen == "Ezogelin Çorbası")
            {
                rtbMalzemeler.Text = "1 yemek kaşığı sıvı yağ\r\n1 yemek kaşığı tereyağı\r\n1 adet kuru soğan\r\n2 diş sarımsak\r\n1 su bardağı kırmızı mercimek\r\n1 kahve fincanı bulgur (4 yemek kaşığı)\r\nYarım kahve fincanı pirinç (2 yemek kaşığı)\r\n6 su bardağı sıcak su + 2,5 su bardağı sıcak su\r\nSosu için;\r\n\r\n2 yemek kaşığı sıvıyağ\r\n1 yemek kaşığı un\r\n2 yemek kaşığı domates salçası\r\n2 su bardağı sıcak su\r\n1 tatlı kaşığı nane\r\n1 çay kaşığı kırmızı pul biber\r\n1 çay kaşığı karabiber\r\n1,5 tatlı kaşığı kadar tuz";
                rtbTarif.Text = "Tencereye tereyağı ve 1 yemek kaşığı sıvı yağ tencereye alınarak ısıtılır.\r\nSoğan ve sarımsak küçük küçük doğranır ve tencerede orta ateşte, soğanlar diriliğini kaybedinceye kadar kavrulur. Dilerseniz sarımsakları rendeleyerek de kullanabilirsiniz.\r\nÜzerine yıkanmış ve suyu süzülmüş olan kırmızı mercimek, pirinç ve bulgur eklenerek karıştırılır ve kavrulur.\r\nÜzerine sıcak su ilave edilerek tencerenin kapağı kapatılır ve pişmeye bırakılır. Çorba kaynayana kadar yüksek ateşte kaynadıktan sonra kısık ateşte ara ara karıştırılır.\r\nBakliyatlar yumuşayınca kadar yaklaşık 35 dakika pişirilir ve ocak kapatılır.\r\nAyrı bir yerde 2 yemek kaşığı sıvı yağ ısıtılır.\r\n1 yemek kaşığı un eklenir ve unun kokusu çıkana kadar karıştırılarak kavrulur.\r\nÜzerine 2 yemek kaşığı domates salçası eklenir, 1-2 dakika daha kavrulur.\r\nSalça da kavrulduktan sonra 2 su bardağı kadar su ilave edilerek kaynatılır.\r\nNane, kırmızı biber, karabiber ilave edilerek hazırlanan sos ocaktan alınır ve çorbaya ilave edilir.\r\nTuzu da eklenerek 1-2 dakika kaynatılır. Bu aşamada gerek duyarsanız sıcak su ekleyebilirsiniz. Ben 2,5 su bardağı kadar sıcak su ekledim ancak siz çorbanızın kıvamına göre ayarlayabilirsiniz.\r\nYaklaşık 5 dakika daha kaynattıktan sonra Ezogelin Çorbamız servise hazır. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=5qwzunAd7KM";
                pbYemekResmi.Image = Properties.Resources.ezogelin;
            }
            else if (secilen == "Tarhana Çorbası")
            {
                rtbMalzemeler.Text = "3 yemek kaşığı ev tarhanası\r\n1 yemek kaşığı nane\r\n2 yemek kaşığı sıvı yağ\r\n1 yemek kaşığı salça\r\n6 su bardağı su\r\nKırmızı pul biber\r\nKarabiber\r\nTuz";
                rtbTarif.Text = "Tenceremizin içerisine sıvı yağ, nane, salça, baharatlar ve tarhanayı ekleyip biraz karıştırarak kavuruyoruz. Dilerseniz tereyağı da kullanabilirsiniz.( Veya tarhanayı suyu ekledikten sonra ekleyip çırpıcı ile karıştırabilirsiniz. böylelikle topaklanma ihtimali azalır.)\r\nSuyu yavaş yavaş ilave ediyoruz ve devamlı karıştırarak pişiriyoruz. Topaklanmaması için tel çırpıcı ile karıştırabilirsiniz. (kaynayana kadar karıştırarak pişirelim.)\r\nKaynadıktan sonra 5 dk daha bekleyip ocaktan alıyoruz, çorbamızı…";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=nncdWyHP2F4";
                pbYemekResmi.Image = Properties.Resources.tarhana;
            }
            else if (secilen == "Yoğurt Çorbası")
            {
                rtbMalzemeler.Text = "7 su bardağı su\r\n 4 çorba kaşığı pirinç\r\n 1 çorba kaşığı un\r\n 1 yumurta sarısı\r\n 1 su bardağı yoğurt\r\n 2 çay kaşığı tuz\r\n Kuru nane";
                rtbTarif.Text = "Yoğurt çorbası yapımı için, tencereye suyu ekleyin kaynamaya bırakın.\r\nKaynadıktan sonra pirinçleri ekleyin, yumuşayana kadar pişirin.\r\nTerbiyesi için bir kapta yumurta, un ve yoğurdu karıştırın. Çorbanın suyundan 1-2 kepçe alarak terbiyeye ekleyin ve ılımasını sağlayın.\r\nArdından terbiyeyi pişen pirincin üzerine ekleyin ve karıştırın.\r\nPişerken bir tutam kuru nane ekleyin.\r\n10 dakikaya yakın pişirdikten sonra yoğurt çorbasının altını kapatın ve tuzunu ekleyin.\r\nYoğurt çorbası servise hazır. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=DlrqTQsW2J8";
                pbYemekResmi.Image = Properties.Resources.yogurt_corbasi;
            }

            // ================= ANA YEMEKLER =================
            else if (secilen == "Karnıyarık")
            {
                rtbMalzemeler.Text = "6 adet küçük boy patlıcan (büyük ise ikiye bölebilirsiniz)\r\n3 adet sivri biber\r\nKıymalı Harç İçin;\r\n\r\n2 adet orta boy soğan\r\n2 adet domates\r\n2 adet sivri biber\r\n2 diş sarımsak\r\nSıvı yağ, tuz, karabiber, kırmızıbiber\r\n200 gr kıyma\r\n1 çay bardağı sıcak su\r\nSosu İçin;\r\n\r\n1 yemek kaşığı salça\r\n1 su bardağı sıcak su";
                rtbTarif.Text = "Patlıcanları çizgili soyup, yarım saat yağ çekmemesi için tuzlu suda bekletin.\r\nİyice yıkadıktan sonra suyunu havlu ile çektirin ve az yağda kızartın. 3 adet biberi de yağda kızartın.\r\nDaha sonra aynı tavada doğranmış soğanları kavurun, kıymayı ekleyerek bir müddet daha kavurun ve biberleri, sarımsağı ekleyerek 2 dakika daha kavurun.\r\nKüp küp doğramış olduğunuz 2 adet domatesi, tuzu, baharatları ekleyerek karıştırın.\r\nÜzerine bir çay bardağı su ekleyerek 5 dk kaynatın.\r\nTepsiye patlıcanların ortalarını keserek yerleştirin ve bu kesiklerden patlıcanın içine bastırarak iç malzemesine yer açın ve malzeme ile patlıcanları doldurun.\r\nDoldurduğunuz patlıcanların üzerine ortadan ikiye kestiğiniz çeri domatesi ya da 1 adet domatesi eşit büyüklükte olacak şekilde paylaştırın ve kızarttığımız biberlerden birer tane koyun.\r\nAyrı bir yerde 1 kaşık salçayı, 1 su bardağı sıcak suda ezerek patlıcanların aralarına dökün. Kıymalar çıkmasın diye üzerine dökmeyin.\r\nDaha sonra 170 derece de ısıttığınız fırına sürerek 20-25 dk pişirin. Dilerseniz bu işlemi pilav tenceresi gibi bir tencerede ocakta yapabilirsiniz. Aynı sürede tencerede de  pişecektir.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=brvuUWDqXw8";
                pbYemekResmi.Image = Properties.Resources.karniyarik;
            }
            else if (secilen == "Hünkar Beğendi")
            {
                rtbMalzemeler.Text = "200g kuşbaşı et\r\n3 yemek kaşığı sıvı yağ\r\n1 adet soğan\r\n1 adet biber\r\n1 adet domates\r\nYaklaşık 1 yemek kaşığı salça\r\n1,5-2 su bardağı su\r\nTuz, karabiber\r\nBeğendi için;\r\n\r\n3 adet patlıcan\r\n1 çay bardağı süt (az gelirse ilave edebilirsiniz)\r\n1 yemek kaşığı tereyağı\r\n1 yemek kaşığı un\r\nTuz\r\nYarım su bardağı kaşar rendesi";
                rtbTarif.Text = "İlk olarak patlıcanlar fırında ya da ocakta közlenir. (Ben kemer patlıcan kullandığım için beğendi çekirdekli oldu. Siz mümkünse çekirdeksiz patlıcan kullanın)\r\nKözlenen patlıcanlar kabuğu soyulup doğranır.\r\nBeğendisi için tavada yağ ve un karıştırılarak kavrulur.\r\nPatlıcanlar tavaya eklenir ve iyice ezilerek karıştırılır.\r\nOcağın altı iyice kısılarak süt yavaş yavaş karıştırarak patlıcana ilave edilir. İyice karıştırılır.\r\nSon olarak tuz ve ardından kaşar peynirini rendesi eklenir, karıştırılır ve ocak kapatılır.\r\nKaşar da tamamen karıştırılarak beğendi hazırlanır.\r\nAyrı bir tava yağ ile ocağa konur. Tava ısındığında etler ilave edilir. Etler suyunu bırakıp çekene kadar kavrulur.\r\nİnce doğranmış soğan ve biberler eklenir, kavurmaya devam edilir.\r\nOnlar da kavrulunca salça eklenip karıştırılır.\r\nSalçadan sonra çekirdekleri alınıp doğranmış domates eklenir.\r\n1,5-2 su bardağı sıcak su da göz kararı eklenerek kapağı kapatılıp etler pişene kadar pişirilir.\r\nPiştikten sonra tuzu karabiberi eklenir, karıştırılır. Ocağın altı kapatılır. (Eğer etiniz geç pişecek bir et ise düdüklüde haşlayıp yapabilirsiniz. Su yerine et suyunuzu ilave edip pişirirseniz de aynı tadı elde edersiniz.)\r\nServis tabağınıza önce beğendiyi üstüne de etinizi koyarak servis edebilirsiniz.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=GCdGT6cwi5E";
                pbYemekResmi.Image = Properties.Resources.hunkar_begendi;
            }
            else if (secilen == "Kuru Fasulye")
            {
                rtbMalzemeler.Text = "1 su bardağı kuru fasulye\r\n1 baş kuru soğan\r\n1 tatlı kaşığı domates salçası\r\nisteğe bağlı tuz, karabiber, kırmızı pul biber\r\nYarım limonun suyu\r\n1 yemek kaşığı zeytinyağı";
                rtbTarif.Text = "Bir su bardağı kuru fasulyeyi bir gece suda bekletiyoruz. Ertesi gün orta derece yumuşayana kadar kaynar suda haşlıyoruz. Kuru fasulyenin haşlanmış gazlı suyunu döküyoruz ve fasulyeyi suda geçiriyoruz.\r\nGenişçe olan çelik tencereye bir yemek kaşığı zeytinyağımızı koyuyoruz. Yağımızı yakmadan kızdırıyoruz.\r\nSoğanı dilediğimiz şekilde doğrayıp yağda kavuruyoruz.\r\nSoğan iyice ölünce bir tatlı kaşığı domates salçasını tencereye koyuyoruz. Salçayı yakmadan kavuruyoruz.\r\nArdından kuru fasulyeyi tencereye aktarıyoruz.\r\nÜzerini iki parmak geçecek kadar kaynar su ilave edip orta hararetli ateşte pişmeye bırakıyoruz.\r\nBu sırada yarım limonun suyunu ekliyoruz.\r\nFasulyeler iyice yumuşadıktan sonra ocağı kapatıyoruz.\r\nTuzunu ayarlıyoruz.\r\nDilerseniz sıcak servis ederken toz, karabiber ve kırmızı pul biber de ekleyebilirsiniz. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=GCdGT6cwi5E";
                pbYemekResmi.Image = Properties.Resources.kuru_fasulye;
            }
            else if (secilen == "Pilav")
            {
                rtbMalzemeler.Text = "2 su bardağı pirinç\r\n2,5 su bardağı sıcak su\r\n3 yemek kaşığı tereyağı\r\n1 yemek kaşığı sıvı yağ\r\nTuz\r\nPirinçleri ıslatmak için;\r\n\r\nPirinçlerin üzerini geçecek kadar ılık su\r\nTuz";
                rtbTarif.Text = "Pirinci bol su ile yıkayın. Uygun bir kaba alarak üzerini geçecek kadar ılık su ekleyin. Birazda tuz ilave edip karıştırın ve 15-20 dakika bekletin. Daha sonra yıkayarak suyunu süzün. Nişastası gidene kadar yıkıyoruz. Çıkan suyun berrak olması gerekiyor.\r\nTencerede tereyağını eritip suyu süzülmüş pirinci ekleyin ve 4-5 dakika kadar kavurun. Pirinçlerin yeteri kadar kavrulduğunu pirinler tane tane dökülmeye başladığında anlayabilirsiniz.\r\nPirinçler kavrulduktan sonra sıcak su veya sıcak et suyunu ekleyelim. İsterseniz yarım tavuk suyu yarım sıcak su kullanabilirsiniz. Tavuk suyunuz yağlı ise bu şekilde su ile karıştırmanızı tavsiye ederim ancak yağlı değilse tamamı tavuk suyu ile çok daha lezzetli olacaktır. Son olarak tuzu ekleyin.\r\nPilavımızı kapağı kapalı bir şekilde önce yüksek ateşte pişmeye bırakalım.\r\nÜzeri göz göz olduğunda yani üzerindeki suyu çekip pilavın üzerinde nokta nokta delikler oluştuğunda kısık ateşe alalım.  Pirinçler yumuşayıp suyu tamamen çekene kadar pişirelim.\r\nPişen pilavımızı ocaktan aldıktan sonra üzerine havlu peçete sererek kapağını tekrar kapatalım.\r\nPilavı 10-15 dk. dinlendirelim. Daha sonra tahta kaşık ile karıştırarak servis yapabilirsiniz.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=8eUFgKsstwQ";
                pbYemekResmi.Image = Properties.Resources.pilav;
            }

            // ================= MEZELER =================
            else if (secilen == "Haydari")
            {
                rtbMalzemeler.Text = "6 yemek kaşığı süzme yoğurt\r\n1 tutam dereotu\r\n1 yemek kaşığı tereyağı\r\n1 tatlı kaşığı nane\r\n1 çay kaşığı tuz\r\n1 dilim beyaz peynir\r\n1 diş sarımsak";
                rtbTarif.Text = "İlk olarak tavaya tereyağını alarak kızdıralım. Bu aşamada cağı çok yüksek ateşte açıp yağı yakmamaya dikkat edelim.\r\nDaha sonra naneyi ekleyerek 1-2 tur karıştıralım ve ocaktan alalım.\r\nKarıştırma kabına süzme yoğurdu alalım.\r\nDiğer taraftan beyaz peyniri çatalla ezerek ufalayalım, dereotunu ince ince kıyalım.\r\nSüzme yoğurdun üzerine peynir ve dereotunu ilave edelim.\r\nSon olarak naneli tereyağı, ezilmiş sarımsak, tuzu ekleyerek karıştıralım.\r\nHaydari mezesini servis tabağına alarak üzerini zeytinyağı ve dereotu ile süsleyelim.\r\nHaydari servise hazır. Afiyet olsun :)";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=MdfH3rjEW4k";
                pbYemekResmi.Image = Properties.Resources.haydari;
            }
            else if (secilen == "Humus")
            {
                rtbMalzemeler.Text = "2 su bardağı haşlanmış nohut\r\nYarım su bardağı tahin\r\n2 diş sarımsak\r\n1 adet limon suyu\r\n1 çay kaşığı kimyon\r\n2 çay kaşığı tuz\r\n3 yemek kaşığı zeytinyağı\r\nÜzeri için :\r\n\r\n2 yemek kaşığı zeytinyağı\r\n2 çay kaşığı kırmızı biber";
                rtbTarif.Text = "Akşamdan ıslatılan nohutları iyice haşlayın. Belki kızan olur ama; zaman kazanmak istiyorsanız haşlanmış hazır nohut kullanın derim :)\r\nİyice haşladığınız nohutları kabuklarından tek tek ayırın.\r\nMutfak robotunda zeytinyağı, tahin, dövülmüş sarımsak, limon suyu, tuz ve kimyonla birlikte püre haline getirin.\r\nHazır olan karışımı servis tabağına alın.\r\nKüçük bir kapta zeytinyağını kızdırıp kırmızı biberi ekleyin. Karıştırıp ateşten alın ve humusun üzerine gezdirin.\r\nTaze veya kızartılmış ekmeğin üzerine sürüp kahvaltıda gözü kapalı tüketebilirsiniz :) Yanında turşu, biber, taze domates iyi gider bu arada. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=5z_QeQoXJ3k";
                pbYemekResmi.Image = Properties.Resources.humus;
            }
            else if (secilen == "Şakşuka")
            {
                rtbMalzemeler.Text = "4 adet patlıcan\r\n3 adet yeşil biber\r\n1 adet kuru soğan\r\n4 diş sarımsak\r\n4 adet domates\r\n1 tatlı kaşığı domates salçası\r\n1 çay kaşığı şeker\r\nTuz, istenilen baharatlar\r\n1 çay bardağı sıcak su\r\nKızartmak için sıvı yağ";
                rtbTarif.Text = "Patlıcanları küp küp doğrayıp tuzlu suya koyalım, bir müddet bekletelim\r\nDaha sonra sıvı yağı uygun bir tavaya alalım, kızdıralım.\r\nTuzlu sudan alıp kuruladığımız patlıcanlarımızı tavaya alalım.\r\nSoğan ve sarımsağı da yemeklik doğrayarak az miktarda yağda kavuralım.\r\nYeşil biberleri  doğrayalım ve tavaya alalım.\r\nÜzerine rendelediğimiz domatesi ve salçayı da ekleyerek karıştıralım.\r\nBir süre sonra da şeker, tuz, karabiber ve pul biberi ekleyelim ve tekrardan karıştıralım.\r\nSıcak suyu da ilave ederek 4-5 dakika kadar pişirelim.\r\nSon olarak kızarttığımız patlıcanları da tavaya alalım ve pişirdiğimiz sos ile harmanlanmasını sağlayalım. Şakşukamız servise hazır, afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=MDJRDkykfyg";
                pbYemekResmi.Image = Properties.Resources.saksuka;
            }
            else if (secilen == "Acılı Ezme")
            {
                rtbMalzemeler.Text = "2 adet domates\r\n2 adet kapya\r\n1 adet acı yeşil sivri biber\r\n2 diş sarımsak\r\n1 adet soğan\r\n6 dal maydanoz\r\nSosu için;\r\n\r\n1 yemek kaşığı domates salçası\r\n1 yemek kaşığı biber salçası\r\n6 yemek kaşığı zeytinyağ\r\n1 yemek kaşığı nar ekşisi\r\n1 adet limonun suyu\r\n1 çay kaşığı pul biber\r\n1 çay kaşığı sumak\r\n1 çay kaşığı isot\r\n1 çay kaşığı tuz\r\n1,5 çay kaşığı kuru nane";
                rtbTarif.Text = "Maydanoz hariç bütün diğer malzemeler teker teker robottan çekilir. Dilerseniz malzemeleri iri parçalar halinde doğrayarak tek seferde de robottan geçirebilirsiniz. Robotunuz yoksa ince ince doğrayın.\r\nMaydanozu ince ince kıyın.\r\nTaze malzemeleri uygun bir tabağa alın ve kenarda bekletin. Ezmenizin sulu olmaması için robottan geçirdiğiniz malzemeleri tel süzgeçte de bekletebilirsiniz.\r\nSosu için salçaları, yağı, nar ekşisini, limon suyunu, tuz ve baharatları güzelce bir kasede karıştırın.\r\nSosu sebzelerin üzerine dökün. Maydanozu da ekleyin ve güzelce karıştırın. Sonra servis tabağına alın. Afiyet olsun ";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=q_W6Hy9cyqk";
                pbYemekResmi.Image = Properties.Resources.acili_ezme;
            }

            // ================= SALATALAR =================
            else if (secilen == "Çoban Salatası")
            {
                rtbMalzemeler.Text = "4 adet domates\r\n1 adet soğan\r\n1 çay kaşığı tuz\r\n2 adet yeşil biber\r\n1 adet salatalık\r\nMaydanoz\r\nLimon suyu\r\nZeytinyağı";
                rtbTarif.Text = "İlk olarak domatesleri küçük küçük doğrayın ve karıştırma kabına alın.\r\nDaha sonra soğanı da küçük küçük doğrayın ve üzerine tuz serpip elinizle güzelce ovun.\r\nİnce ince doğradığımız yeşil biber ve küçük küçük doğradığımız salatalığımızı da karıştırma kabına alalım.\r\nSon olarak maydanozu da ince ince doğrayalım ve doğradığımız diğer malzemelerimizin üzerine ekleyelim.\r\nSalatamızın zeytin yağını ve limon suyunu da ekledikten sonra güzelce harmanlayalım ve servis tabağına alarak servis edelim. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=xS121G16n0A";
                pbYemekResmi.Image = Properties.Resources.coban_salatasi;
            }
            else if (secilen == "Gavurdağı")
            {
                rtbMalzemeler.Text = "3 adet domates\r\n1 adet yeşil biber\r\n1 adet kuru soğan\r\n3-4 dal taze soğan\r\nMaydanoz\r\n2 avuç iri kırılmış ceviz\r\nZeytinyağı\r\nNar ekşisi\r\nSumak\r\nTuz";
                rtbTarif.Text = "Domatesler ve yeşil biber küçük küçük doğranır.\r\nYeşil soğanlar ve maydanozlar da çok ince kıyılır.\r\nKuru soğan mümkün olduğunca küçük doğranarak biraz tuzla ovulur.\r\nBütün malzeme geniş bir kaba alınır, iri kırılmış cevizler, zeytinyağı ve nar ekşisi ilave edilir.\r\nGöz kararı yaklaşık 1 yemek kaşığı sumak da eklenir.\r\nKarıştırılarak servis tabağına alınır.\r\nZeytinyağının ve nar ekşisinin miktarını kendi zevkinize göre ayarlayabilirsiniz, ben sevdiğim için oldukça bol kullanıyorum.\r\nCevizi de yine neredeyse 1 su bardağına yakın ekliyorum.\r\nHarika bir salata, denemeyenlere tavsiye ederim. Şimdiden afiyet olsun…";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=hqzdAZt5r-4";
                pbYemekResmi.Image = Properties.Resources.gavurdagi;
            }
            else if (secilen == "Rus Salatası")
            {
                rtbMalzemeler.Text = "3-4 adet patates\r\n2-3 adet havuç\r\n1 su bardağı bezelye\r\n1 küçük konserve mısır (1 su bardağı)\r\n1 çay bardağı kadar kornişon (6 adet)\r\nYarım su bardağı mayonez (5 yemek kaşığı)\r\n1 su bardağı susuz tarafından yoğurt\r\nTuz";
                rtbTarif.Text = "Patatesleri havuçlarımızı güzelce küp şeklinde doğrayalım. Onları güzelce haşlayalım. Doğrayarak haşlarsak daha çabuk haşlanır.\r\nAynı şekilde bezelyeleri de haşlayalım.\r\nSonra sularını süzelim.\r\nDiğer yandan konserve mısırıma yıkayıp süzelim.\r\nDoğradığımız kornişonları da ekleyelim.\r\nSon olarak mayonez ve yoğurdumuzu ekleyelim.\r\nHepsini karıştıralım. Damak zevkimize göre de tuz ekleyelim.\r\nRus salatamız hazır.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=4uYtkWrQFa0";
                pbYemekResmi.Image = Properties.Resources.rus_salatasi;
            }
            else if (secilen == "Patlıcan Salatası")
            {
                rtbMalzemeler.Text = "3 adet közlenmiş bostan patlıcanı\r\n2 adet domates\r\n4-5 adet sivri biber\r\n8-10 dal maydanoz\r\n1 adet kuru soğan\r\n3 çay kaşığı sumak\r\nTuz\r\nSos için:\r\n\r\n½ çay bardağı zeytinyağı\r\n3 diş dövülmüş sarımsak\r\n2 çorba kaşığı limonsuyu";
                rtbTarif.Text = "Patlıcan Salatası yapmak için ilk olarak patlıcanları közleyin, kabukları soyun ve küçük kuşbaşı ebatın da doğrayın.\r\nDerin bir kasede kabukları doğranmış tavla zarından biraz büyük doğradığınız domates, ince kıyılmış maydanoz ve biberlerle harmanlayın.\r\nKuru soğanı ay biçimde ince doğrayın, tuzla hafif ovun.\r\nSumakla birlikte soğanları patlıcanlı karışıma ekleyin.\r\nSos için zeytinyağı sarımsak ve limon suyunu karıştırın,\r\nPatlıcan salatasına ekleyin.\r\n10 dk kadar sosu çekmesi için bekletin.\r\nPatlıcan salatamız hazır servis tabağınıza alabilirsiniz.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=WU2RilG3Lsg";
                pbYemekResmi.Image = Properties.Resources.patlican_salatasi;
            }

            // ================= TATLILAR =================
            else if (secilen == "Sütlaç")
            {
                rtbMalzemeler.Text = "1 lt süt\r\n2 çay bardağı pirinç\r\n1 litre su\r\n3 yemek kaşığı pirinç unu\r\n1,5 -2 su bardağı toz şeker (eğer çok şekerli sevmiyorsanız 1,5 bardak kullanabilirsiniz)\r\n1 su bardağı süt\r\ntarçın";
                rtbTarif.Text = "Sütlaç yapmak için öncelikle pirinci yıkayıp su ile ateşe koyun.\r\nPirinçler uzayıp suyu çekene kadar kaynatın. Ocağı çok yüksek ateşte açarak pirinçleri yakmamaya dikkat edin.\r\nArdında soğuk sütü ekleyin. 1-2 defa karıştırıp, kaynamasını bekleyin.\r\nBu arada bir kasede pirinç ununu 1 su bardağı soğuk süt ile ezin. Topak kalmamasına mutlaka dikkat edin.\r\nTencerede kaynamakta olan sütten 1-2 kepçe alıp kaseye ekleyin. (pirinç unu ılınmış olmalı).\r\nPirinç ununu tencereye ekleyin, ara sıra karıştırarak 10 dakika kadar pişirin.\r\nToz şekeri ilave edip karıştırın ve 1-2 taşım daha kaynatın.\r\nSütlacı kaselere paylaştırın.\r\nSoğuyunca sütlaçların üzerlerine tarçın serperek servis edebilirsiniz. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=vCzTZP9hv5M";
                pbYemekResmi.Image = Properties.Resources.sutlac;
            }
            else if (secilen == "Baklava")
            {
                rtbMalzemeler.Text = "Şerbeti için;\r\n\r\n4 su bardağı şeker\r\n4 su bardağı su\r\n1 tatlı kaşığı limon suyu\r\nHamuru için;\r\n\r\n3,5 su bardağı un\r\n2 adet yumurta\r\n1 çay bardağı sıvı yağ\r\n1 çay bardağı süt\r\n1 yemek kaşığı sirke\r\nÇay kaşığı ucu ile Tuz\r\nHamuru açmak için;\r\n\r\nNişasta\r\nArası için;\r\n\r\n2 su bardağı ceviz kırığı\r\nÜzerine;\r\n\r\n250g tereyağı\r\nYarım çay bardağı sıvı yağ";
                rtbTarif.Text = "Kolay ev baklavasının şerbeti  için tencereye şeker ve suyu alarak karıştıralım. Kaynamaya bırakalım.\r\n15 dakika kadar kaynadıktan sonra içerisine limon suyu ekleyelim ve 1-2 dakika daha kaynatıp ocaktan alalım.\r\nHamurunu hazırlamak için öncelikle yumurtayı, sütü, sıvı yağı, sirkeyi, kabartma tozunu ve tuzu yoğurma kabına boşaltın ve yavaş yavaş un ekleyerek ortalama yumuşaklıkta bir hamur elde edinceye kadar yoğuralım.\r\nHazırladığımız hamuru un serptiğimiz tezgahta toparlayalım ve  30 eşit parçaya bölelim. Bunun için önce hamuru 3 eşit parçaya ardından her parçayı 10’a bölebilirsiniz.\r\nBu parçaları beze haline getirelim.\r\nArdından bezelerimizi unlayarak, tek tek tabak büyüklüğünde açalım.\r\nAçtığımız hamurların aralarına nişasta serpip 10’ar 10’ar üst üste koyun.\r\n10’arlı olarak grupladığımız bu üç parçadan parçalardan her birini merdane yardımı ile tepsi büyüklüğüne getirelim. Hamurları açarken her hamurun eşit olması için ara ara çevirebilirsiniz. Ben bu aşamada 42 cm civarında tepsi kullandım. Siz de bu boyutlarda kullanabilirsiniz.\r\n Merdane ile açtığınız hamurların aralarına ceviz ya da fındık serperek üst üste yerleştirelim.\r\nBaklavamızı dilediğiniz şekilde keselim ve üzerine her yerine eşit şekilde gelmesine dikkat ederek eritilmiş yağın yarısını dökün. Bu aşamada tereyağını eritirken yağın üzerinde oluşan köpükleri almalısınız. Aksi takdirde yanarak kötü bir görüntü oluşturacaktır.\r\nHazırladığımız baklavamızı önceden ısıtılmış 160°C fırına sürelim ve 30 dakika pişmeye bırakalım.\r\nHafif rengi değiştiğinde fırından alarak kalan yağı gezdirelim ve tekrar fırına sürerek altı üstü kızarana kadar 30 dakika daha  pişirelim.\r\nSürenin sonunda baklavamızı fırından alalım ve soğuk şerbeti üzerine gezdirerek 2 saat kadar dinlenmeye bırakalım.\r\nŞerbetini güzelce çeken kolay ve baklavamız servise hazır. Afiyet olsun!";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=Ehf8igYTJVk";
                pbYemekResmi.Image = Properties.Resources.baklava;
            }
            else if (secilen == "Künefe")
            {
                rtbMalzemeler.Text = "250 gram tel kadayıf\r\n150 gr tuzsuz künefe peyniri\r\n4 yemek kaşığı tereyağı\r\n1 çay kaşığı pekmez\r\nŞerbeti için:\r\n\r\n2 su bardağı su\r\n2 su bardağı toz şeker\r\n1 çay kaşığı limon suyu\r\nÜzeri için;\r\n\r\nToz Antep fıstığı\r\nSüt kaymağı veya dondurma (isteğe bağlı)";
                rtbTarif.Text = "İlk olarak künefenin şerbeti hazırlanır. Şerbet için, su ve şeker bir tencereye alınarak kaynamaya bırakılır. (Şerbetin dibine tutmaması için ara ara karıştırılır.)\r\nŞerbet kaynamaya başlayınca şekerin kesilmemesi için 1 çay kaşığı limon suyu eklenip 10-15 dakika kadar daha kaynatılır ve şerbet soğumaya bırakılır.\r\nKünefe için, tereyağı kısık ateşte erimeye bırakılır.\r\nEriyen tereyağı bir kenara alınarak bekletilir.\r\nTereyağı donduktan sonra altında tereyağının suyu olacaktır bu suyu kullanmayın.\r\nHafif donmuş olan tereyağına 1 çay kaşığı pekmezi eklenerek muhallebi kıvamına gelecek şekilde karıştırılır.\r\nVarsa künefe tepsisi yoksa alüminyum veya teflon tavanın altı bu pekmezli yağ karışımı ile yağlanır.\r\nKadayıf tel tel tiftiklenerek ayrılır.\r\nArdından bıçakla 1 cm kalınlığında kesilerek iki parçaya ayrılır.\r\nAyırdığımız kadayıfın bir parçası yağlanmış tepsinin dibine aralarda boşluk kalmayacak şekilde serilir.\r\nRendelenmiş peynirler kadayıfın üzerine yayılır.\r\nDiğer kadayıf da peynirin üzerinde boşluk kalmayacak şekilde kapatılır.\r\nKenarları düzeltilir ve başka bir tepsi altıyla veya eliniz ile üzerine bastırılır.\r\nİyice bastırarak arasında boşluk kalmamasını dikkat edin.\r\nEn kısık ateşte ocağın üzerinde tepsi çevrilerek pişirilir.\r\nAltının tamamen kızardığından emin olduğunuzda tepsiyi bir tabağın veya tepsinin üzerine ters çevrilir ve diğer tarafının pişmesi için ikinci tepsinin içi de yağlanır.\r\nKızaran kısım üstte kalacak şekilde künefe tepsiye yerleştirilir ve altı kızartılır. Böylece iki tarafı da kızarmış olur.\r\nŞerbeti kenarından başlanarak dökülür. Antep fıstığı veya süt kaymağı ile servis edilir. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=j-7ZW0n5QW4";
                pbYemekResmi.Image = Properties.Resources.kunefe;
            }
            else if (secilen == "Kazandibi")
            {
                rtbMalzemeler.Text = "6 su bardağı süt\r\n2 yemek kaşığı nişasta\r\n1 su bardağı un\r\n1 su bardağı şeker\r\n1 yemek kaşığı tereyağı\r\n1 paket vanilya";
                rtbTarif.Text = "Öncelikle orta boy bir tencereye bütün malzemeleri alarak karıştırıyoruz.\r\nMuhallebi elde ediyoruz. En son tereyağını ve vanilyasını dökerek muhallebimizi 5 dk. kadar pişiriyoruz.\r\nOrta boy alüminyum tepsiye bolca tereyağı sürüyoruz ve 3 yemek kaşığı kadar tepsiye şeker döküyoruz.\r\nHer yeri eşit olmasına özen gösterin.\r\nSonra pişmiş muhallebiyi tepsiye döküyoruz ve orta ateşte sürekli olarak çevirerek muhallebiyi pişiriyoruz.\r\n25-30 dk. yeterli burada önemli olan tepsiyi sürekli çevirerek kontrollü pişirmek kenar kısımların da pişmesine özen göstermek biraz dibi tutan muhallebinin kokusu biraz çıkar.\r\nO zaman hemen ocaktan alıyoruz ve soğumaya bırakıyoruz.\r\nSoğuduktan sonra 1-2 saat de buzdolabında bekletiyoruz.\r\nSonra istediğimiz gibi dilimleyip servis yapabilirsiniz. Afiyet olsun.";
                mevcutVideoLinki = "https://www.youtube.com/watch?v=f8Ztx-g-FFY";
                pbYemekResmi.Image = Properties.Resources.kazandibi;
            }
        }

        private void btnVideoAc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mevcutVideoLinki))
                Process.Start(mevcutVideoLinki);
            else
                MessageBox.Show("Lütfen bir yemek seçin.");
        }

        private void btnFavoriEkle_Click(object sender, EventArgs e)
        {
            if (cmbYemekler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir yemek seçin!");
                return;
            }

            string secilenYemek = cmbYemekler.SelectedItem.ToString();

            if (!favoriYemekler.Contains(secilenYemek))
            {
                favoriYemekler.Add(secilenYemek);
                MessageBox.Show($"{secilenYemek} favorilerinize eklendi.");
            }
            else
            {
                MessageBox.Show("Bu yemek zaten favorilerinizde!");
            }
        }

        private void btnFavorileriGor_Click(object sender, EventArgs e)
        {
            if (favoriYemekler.Count == 0)
            {
                MessageBox.Show("Henüz favori yemeğiniz yok.");
                return;
            }

            string liste = string.Join("\n", favoriYemekler);
            MessageBox.Show("Favori Yemekleriniz:\n\n" + liste);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormKategoriler kat = new FormKategoriler();
            kat.Show();
            this.Close();
        }
    }
}