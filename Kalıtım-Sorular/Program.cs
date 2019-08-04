using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Sorular
{
    //e ticaret sitesi-
    //televizyon:ekranboyutu,cözünürlük,PPI,yenilemehızı
    //bilgisayar:Ram,CPU,GPU,Diskboyutu,ssdboyutu
    //              Bool GPUOnboard
    //Laptop:bool parmakizi, ekranboyutu,bool klavyeisik
    //masaüstü:bool ekranvarmı, boolklavyevarmı
    class Program
    {
        static void Main(string[] args)
        {
            televizyon tv1 = new televizyon();
            tv1.AD = "LG Televizyon";
            tv1.ekranboyutu = "50\"";
            tv1.ACIKLAMA = "LG açıklama falan filan";
            tv1.FIYAT = 750.000F;
            tv1.yenilemehizi = "144hz";
            Console.Write("TV adı: ");
            Console.WriteLine(tv1.AD);
            Console.Write("TV Ekran Boyutu: ");
            Console.WriteLine(tv1.ekranboyutu);
            Console.Write("TV açıklaması: ");
            Console.WriteLine(tv1.ACIKLAMA);
            Console.Write("TV Fiyatı: ");
            Console.WriteLine(tv1.FIYAT);
            Console.Write("Ekran Yenileme Hızı: ");
            Console.WriteLine(tv1.yenilemehizi);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            laptop lt1 = new laptop();
            lt1.AD = "Asus";
            lt1.MODEL = "K55VD";
            lt1.parmakizi = true;
            lt1.parmakizistr = lt1.parmakizi ? "Var" : "Yok";
            lt1.RAM = 16;
            lt1.SSDBoyutu = "500";
            lt1.klavyeisik = true;
            lt1.klavyeisikstr = lt1.klavyeisik ? "Var" : "Yok";
            lt1.GPUOnBoard = false;
            lt1.GPUOnBoardStr = lt1.GPUOnBoard ? "Var" : "Yok";
            lt1.ekranboyutu = "120hz";
            Console.Write("bilgisayar adı: ");
            Console.WriteLine(lt1.AD);
            Console.Write("bilgisayar modeli: ");
            Console.WriteLine(lt1.MODEL);
            Console.Write("Parmak izi varmı?: ");
            Console.WriteLine(lt1.parmakizistr);
            Console.Write("bilgisayarın RAM'ı: ");
            Console.WriteLine(lt1.RAM);
            Console.Write("bilgisayarın SSD kapasitesi: ");
            Console.WriteLine(lt1.SSDBoyutu);
            Console.Write("bilgisayar klavyesi ışıklı mı: ");
            Console.WriteLine(lt1.klavyeisikstr);
            Console.Write("Ekran Kartı Dahili mi?: ");
            Console.WriteLine(lt1.GPUOnBoardStr);
            Console.Write("Ekran Boyutu: ");
            Console.WriteLine(lt1.ekranboyutu);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            masaüstü bil1 = new masaüstü();
            bil1.AD = "Casper";
            bil1.ACIKLAMA = "Toplama bilgisayar";
            bil1.CPU = "i9 Yeni nesil işlemci";
            bil1.DiskBoyutu = "2TB";
            bil1.SSDBoyutu = "500gb";
            bil1.FIYAT = 12.000F;
            bil1.klavyevarmı = false;
            bil1.klavyevarmıStr = bil1.klavyevarmı ? "Var" : "Yok";
            bil1.ekranvarmı = true;
            bil1.ekranvarmıStr = bil1.ekranvarmı ? "Var" : "Yok";
            Console.Write("Bilgisayarın adı: ");
            Console.WriteLine(bil1.AD);
            Console.Write("Bilgisayarın açıklaması: ");
            Console.WriteLine(bil1.ACIKLAMA);
            Console.Write("Bilgisayarın CPU'su: ");
            Console.WriteLine(bil1.CPU);
            Console.Write("Bilgisayarın disk boyutu: ");
            Console.WriteLine(bil1.DiskBoyutu);
            Console.Write("Bilgisayarın SSD boyutu: ");
            Console.WriteLine(bil1.SSDBoyutu);
            Console.Write("Bilgisayarın fiyatı: ");
            Console.WriteLine(bil1.FIYAT);
            Console.Write("Bilgisayarın klavyesi varmı?: ");
            Console.WriteLine(bil1.klavyevarmıStr);
            Console.Write("Bilgisayarın ekranı varmı?: ");
            Console.WriteLine(bil1.ekranvarmıStr);





            Console.Read();
        }
    }

    class urun
    {
        public string ID;
        public string AD;
        public string ACIKLAMA;
        public float FIYAT;
        public string MARKA;
        public string MODEL;
    }
    class televizyon : urun
    {
        public string yenilemehizi;
        public string ekranboyutu;
        public string PPI;
    }
    class bilgisayar : urun
    {
        public byte RAM;
        public string CPU;
        public string DiskBoyutu;
        public string SSDBoyutu;
        public string GPU;
        public bool GPUOnBoard;
        public string GPUOnBoardStr;
    }
    class laptop : bilgisayar
    {
        public bool parmakizi;
        public string parmakizistr;
        public bool klavyeisik;
        public string klavyeisikstr;
        public string ekranboyutu;
    }
    class masaüstü : bilgisayar
    {
        public bool ekranvarmı;
        public string ekranvarmıStr;
        public bool klavyevarmı;
        public string klavyevarmıStr;
    }

}