using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proje__yenı_deneme
{
    class Program
    {
        //değişkenlerimizi class içerisinde tuttuk cunku farklı methodlarda kullanacagız...
        static Random rastgele = new Random();
        static int HumanScore=0;
        static int CompScore = 0;
        static int saniye=60;
        static char[][] Box0 = new char[12][];
        static char[] Box1 = new char[20];
        static char[] Box2 = new char[20];
        static char[] Box3 = new char[20];
        static int[] blok_uzunluk = new int[12] { rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), rastgele.Next(4, 10), };
        static int box1sayac = 0;
        static int box2sayac = 0;
        static int box3sayac = 0;

        static int BestScore = 0;
        static char[] BestBox1 = new char[20];
        static char[] BestBox2 = new char[20];
        static char[] BestBox3 = new char[20];
      

        static int compharf;
        static int compnum;
        static char[][] CompBox0 = new char[12][];
        static char[] CompBox1 = new char[20];
        static char[] CompBox2 = new char[20];
        static char[] CompBox3 = new char[20];
        static int Compbox1sayac = 0;
        static int Compbox2sayac = 0;
        static int Compbox3sayac = 0;


        public static void Zamansayacı()
        {
            Thread.Sleep(1000);
            //zaman sayacı
            for (saniye = 60; saniye >= 0; saniye--) //saniyeyi gerisayım.
            {

                Console.SetCursorPosition(47, 1);
                Console.Write("Time "+saniye);
                Thread.Sleep(1000);

            }
        
        }

        public static void OyunArayüz()
        {
          
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("HUMAN");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(72, 1);
            Console.WriteLine("COMPUTER");
            Console.SetCursorPosition(72, 2);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(20, 3);                                        //OYUNUN ARAYÜZÜNDE EN BAŞTA YAZMASI GEREKENLERİ BU METHODDA TUTTUK...
            Console.WriteLine("SCORE = {0} ", HumanScore);
            Console.SetCursorPosition(72, 3);
            Console.WriteLine("SCORE = {0} ", CompScore);
            Console.SetCursorPosition(43, 9);
            for (int i = 0; i < 22; i++)
            {
                Console.SetCursorPosition(50, i + 3);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("[0]");
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("[0]");

            // HUMAN 1.2.3. BOX ORTA BÖLGE

            Console.SetCursorPosition(25, 7);
            Console.WriteLine("5   10   15   20");
            Console.SetCursorPosition(21, 8);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("----+");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(14, i + 9);
                Console.WriteLine("[{0}]", i + 1);

            }

            //COMP. 1.2.3. BOX ORTA BÖLGE

            Console.SetCursorPosition(76, 7);
            Console.WriteLine("5   10   15   20");
            Console.SetCursorPosition(72, 8);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("----+");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(66, i + 9);
                Console.WriteLine("[{0}]", i + 1);

            }
       
        }
        
        public static void gameplay()
        {
           

                //HUMAN BLOKLARI TANIMLADIK
                Box0[0] = new char[blok_uzunluk[0]];
                Box0[1] = new char[blok_uzunluk[1]];
                Box0[2] = new char[blok_uzunluk[2]];
                Box0[3] = new char[blok_uzunluk[3]];
                Box0[4] = new char[blok_uzunluk[4]];
                Box0[5] = new char[blok_uzunluk[5]];
                Box0[6] = new char[blok_uzunluk[6]];                            //BUTUN BLOKLARI 2 BOYUTLU JAGGER ARRAY ILE BOX0 DEGISKENINDE TUTTUK.
                Box0[7] = new char[blok_uzunluk[7]];
                Box0[8] = new char[blok_uzunluk[8]];
                Box0[9] = new char[blok_uzunluk[9]];
                Box0[10] = new char[blok_uzunluk[10]];
                Box0[11] = new char[blok_uzunluk[11]];

                for (int i = 0; i < blok_uzunluk[0]; i++)
                {
                    Box0[0][i] = 'A';
                }
                for (int i = 0; i < blok_uzunluk[1]; i++)
                {
                    Box0[1][i] = 'B';
                }
                for (int i = 0; i < blok_uzunluk[2]; i++)
                {
                    Box0[2][i] = 'C';
                }
                for (int i = 0; i < blok_uzunluk[3]; i++)
                {
                    Box0[3][i] = 'D';
                }
                for (int i = 0; i < blok_uzunluk[4]; i++)
                {
                    Box0[4][i] = 'E';
                }
                for (int i = 0; i < blok_uzunluk[5]; i++)
                {
                    Box0[5][i] = 'F';
                }                  //BLOK UZUNLUKLARI SCORE TUTMAMIZ ICIN GEREKLI OLDUGUNDAN DEGISKEN OLARAK TANIMLADIK
                for (int i = 0; i < blok_uzunluk[6]; i++)
                {
                    Box0[6][i] = 'G';
                }
                for (int i = 0; i < blok_uzunluk[7]; i++)
                {
                    Box0[7][i] = 'H';
                }
                for (int i = 0; i < blok_uzunluk[8]; i++)
                {
                    Box0[8][i] = 'I';
                }
                for (int i = 0; i < blok_uzunluk[9]; i++)
                {
                    Box0[9][i] = 'J';
                }
                for (int i = 0; i < blok_uzunluk[10]; i++)
                {
                    Box0[10][i] = 'K';
                }
                for (int i = 0; i < blok_uzunluk[11]; i++)
                {
                    Box0[11][i] = 'L';
                }

            //HUMAN BLOKLARI YAZILDI...

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(1, i + 5);
                for (int j = 0; j < blok_uzunluk[i]; j++)
                {
                    Console.Write(Box0[i][j]);
                }
            }

                //kullanıcıdan  input alıyoruz
                komutalim:
                ConsoleKeyInfo ilkkomut = Console.ReadKey(true);
                ConsoleKeyInfo ikincikomut = Console.ReadKey(true);

                //BUTUN DURUMLAR DEGERLENDIRILDI A1-A2-A3-A0-B1....ŞAYET A1 GIRILIRSE VE 1.BOXTAKI ELEMAN SAYISI ILE 0.BOXTAKI A BLOGU UZUNLUGU 20 DEN BUYUKSE KOMUT ALMAYACAK
                //20 DEN KUCUKSE BOX1'E BOX0 DAKI A ELEMANLARINI YAPISTIRACAK FAKAT BOX1 DE ZATEN ELEMAN VARSA UZERINE YAPISTIRMAMAK ICIN BOX1SAYACINDA TUTTUGUMUZ ELEMAN SAYISINDAN SONRAKI INDEXTEN ITIBAREN YAPISTIRACAK.
                //YAPISTIRILAN BLOGUN UZUNLUGUNU BOX1 SAYACA EKLEYECEK. VE SCORE BOLUMUNE BOX1 SAYACI YAZACAK..
                //AYRICA BOX 0 DAN TASINAN A ELEMANLARI YERINE BOSLUK KARAKTERI YAZDIRACAK YANI SILECEK...
                //A0 KOMUTUNDA  ISE  A BLOGU HANGI  BOXTA  ISE  ONCE  ONU BULACAK (IFLERLE KONTROL ETTIK) DAHA SONRA  A BLOGUNU GERI  BOXTAKI INDEXINE  ESITLEDIK...
                //DAHA SONRA KAYDIRMA  ISLEMI  ICIN A BLOGUNUN BULUNDUGU BOXTAKI A BLOGUNUN INDEXINDEN SON INDEXE KADAR BUTUN ELEMANLARI  A BLOGUUZUNLUGU KADAR SONRAKI INDEXE ESITLEDIK..
                //VE SONDAN ARTACAK OLAN A BLOGU UZUNLUGUNU ARRAY CLEAR METHODU  ILE SILDIK...BU SAYEDE KAYDIRMIS OLDUK...
                //EKRANI GUNCELLE METHODUNU CAGIRARAK BOXLARIN GUNCEL HALINI EKRANA BASTIRIYORUZ...
                //DIGER HARFLER VE BOXLAR  ICINDE BENZER DURUM SOZKONUSU...
                if (ilkkomut.Key == ConsoleKey.A)
                {
                    if (Box0[0][0] == 'A')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[0] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[0]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[0][i];
                                    Box0[0][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[0];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;


                            }
                            else
                            {
                                goto komutalim;
                            }


                        }
                        else if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[0] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[0]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[0][i];
                                    Box0[0][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[0];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        else if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[0] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[0]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[0][i];
                                    Box0[0][i] = ' ';

                                }
                                box3sayac += blok_uzunluk[0];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    else if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'A')
                            {
                                for (int j = 0; j < blok_uzunluk[0]; j++)
                                {
                                    Box0[0][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }

                        for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                        {
                            if (Box1[i] == 'A')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[0]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'A')
                            {
                                for (int j = 0; j < blok_uzunluk[0]; j++)
                                {
                                    Box0[0][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                        {
                            if (Box2[i] == 'A')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[0]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'A')
                            {
                                for (int j = 0; j < blok_uzunluk[0]; j++)
                                {
                                    Box0[0][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                        {
                            if (Box3[i] == 'A')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[0]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[0];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");

                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();
                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.B)
                {
                    if (Box0[1][0] == 'B')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[1] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[1]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[1][i];
                                    Box0[1][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[1];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");

                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        else if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[1] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[1]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[1][i];
                                    Box0[1][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[1];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        else if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[1] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[1]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[1][i];
                                    Box0[1][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[1];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }

                    else if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'B')
                            {
                                for (int j = 0; j < blok_uzunluk[1]; j++)
                                {
                                    Box0[1][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                        {
                            if (Box1[i] == 'B')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[1]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'B')
                            {
                                for (int j = 0; j < blok_uzunluk[1]; j++)
                                {
                                    Box0[1][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                        {
                            if (Box2[i] == 'B')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[1]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'B')
                            {
                                for (int j = 0; j < blok_uzunluk[1]; j++)
                                {
                                    Box0[1][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                        {
                            if (Box3[i] == 'B')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[1]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[1];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();


                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.C)
                {
                    if (Box0[2][0] == 'C')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[2] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[2]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[2][i];
                                    Box0[2][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[2];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        else if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[2] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[2]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[2][i];
                                    Box0[2][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[2];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        else if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[2] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[2]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[2][i];
                                    Box0[2][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[2];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    else if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'C')
                            {
                                for (int j = 0; j < blok_uzunluk[2]; j++)
                                {
                                    Box0[2][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                        {
                            if (Box1[i] == 'C')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[2]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'C')
                            {
                                for (int j = 0; j < blok_uzunluk[2]; j++)
                                {
                                    Box0[2][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                        {
                            if (Box2[i] == 'C')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[2]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'C')
                            {
                                for (int j = 0; j < blok_uzunluk[2]; j++)
                                {
                                    Box0[2][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                        {
                            if (Box3[i] == 'C')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[2]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[2];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.D)
                {
                    if (Box0[3][0] == 'D')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[3] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[3]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[3][i];
                                    Box0[3][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[3];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[3] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[3]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[3][i];
                                    Box0[3][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[3];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[3] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[3]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[3][i];
                                    Box0[3][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[3];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'D')
                            {
                                for (int j = 0; j < blok_uzunluk[3]; j++)
                                {
                                    Box0[3][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                        {
                            if (Box1[i] == 'D')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[3]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'D')
                            {
                                for (int j = 0; j < blok_uzunluk[3]; j++)
                                {
                                    Box0[3][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                        {
                            if (Box2[i] == 'D')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[3]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'D')
                            {
                                for (int j = 0; j < blok_uzunluk[3]; j++)
                                {
                                    Box0[3][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                        {
                            if (Box3[i] == 'D')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[3]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[3];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.E)
                {
                    if (Box0[4][0] == 'E')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[4] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[4]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[4][i];
                                    Box0[4][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[4];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[4] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[4]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[4][i];
                                    Box0[4][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[4];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[4] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[4]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[4][i];
                                    Box0[4][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[4];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'E')
                            {
                                for (int j = 0; j < blok_uzunluk[4]; j++)
                                {
                                    Box0[4][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                        {
                            if (Box1[i] == 'E')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[4]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'E')
                            {
                                for (int j = 0; j < blok_uzunluk[4]; j++)
                                {
                                    Box0[4][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                        {
                            if (Box2[i] == 'E')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[4]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'E')
                            {
                                for (int j = 0; j < blok_uzunluk[4]; j++)
                                {
                                    Box0[4][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                        {
                            if (Box3[i] == 'E')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[4]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[4];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }

                }
                if (ilkkomut.Key == ConsoleKey.F)
                {
                    if (Box0[5][0] == 'F')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[5] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[5]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[5][i];
                                    Box0[5][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[5];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[5] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[5]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[5][i];
                                    Box0[5][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[5];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[5] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[5]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[5][i];
                                    Box0[5][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[5];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'F')
                            {
                                for (int j = 0; j < blok_uzunluk[5]; j++)
                                {
                                    Box0[5][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                        {
                            if (Box1[i] == 'F')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[5]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'F')
                            {
                                for (int j = 0; j < blok_uzunluk[5]; j++)
                                {
                                    Box0[5][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                        {
                            if (Box2[i] == 'F')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[5]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'F')
                            {
                                for (int j = 0; j < blok_uzunluk[5]; j++)
                                {
                                    Box0[5][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                        {
                            if (Box3[i] == 'F')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[5]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[5];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }

                }
                if (ilkkomut.Key == ConsoleKey.G)
                {
                    if (Box0[6][0] == 'G')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[6] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[6]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[6][i];
                                    Box0[6][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[6];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[6] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[6]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[6][i];
                                    Box0[6][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[6];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[6] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[6]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[6][i];
                                    Box0[6][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[6];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'G')
                            {
                                for (int j = 0; j < blok_uzunluk[6]; j++)
                                {
                                    Box0[6][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                        {
                            if (Box1[i] == 'G')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[6]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'G')
                            {
                                for (int j = 0; j < blok_uzunluk[6]; j++)
                                {
                                    Box0[6][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                        {
                            if (Box2[i] == 'G')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[6]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'G')
                            {
                                for (int j = 0; j < blok_uzunluk[6]; j++)
                                {
                                    Box0[6][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                        {
                            if (Box3[i] == 'G')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[6]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[6];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }

                }
                if (ilkkomut.Key == ConsoleKey.H)
                {
                    if (Box0[7][0] == 'H')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[7] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[7]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[7][i];
                                    Box0[7][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[7];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[7] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[7]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[7][i];
                                    Box0[7][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[7];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[7] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[7]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[7][i];
                                    Box0[7][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[7];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'H')
                            {
                                for (int j = 0; j < blok_uzunluk[7]; j++)
                                {
                                    Box0[7][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                        {
                            if (Box1[i] == 'H')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[7]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'H')
                            {
                                for (int j = 0; j < blok_uzunluk[7]; j++)
                                {
                                    Box0[7][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                        {
                            if (Box2[i] == 'H')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[7]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'H')
                            {
                                for (int j = 0; j < blok_uzunluk[7]; j++)
                                {
                                    Box0[7][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                        {
                            if (Box3[i] == 'H')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[7]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[7];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }

                }
                if (ilkkomut.Key == ConsoleKey.I)
                {
                    if (Box0[8][0] == 'I')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[8] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[8]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[8][i];
                                    Box0[8][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[8];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[8] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[8]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[8][i];
                                    Box0[8][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[8];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[8] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[8]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[8][i];
                                    Box0[8][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[8];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'I')
                            {
                                for (int j = 0; j < blok_uzunluk[8]; j++)
                                {
                                    Box0[8][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                        {
                            if (Box1[i] == 'I')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[8]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'I')
                            {
                                for (int j = 0; j < blok_uzunluk[8]; j++)
                                {
                                    Box0[8][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                        {
                            if (Box2[i] == 'I')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[8]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'I')
                            {
                                for (int j = 0; j < blok_uzunluk[8]; j++)
                                {
                                    Box0[8][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                        {
                            if (Box3[i] == 'I')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[8]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[8];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.J)
                {
                    if (Box0[9][0] == 'J')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[9] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[9]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[9][i];
                                    Box0[9][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[9];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[9] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[9]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[9][i];
                                    Box0[9][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[9];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[9] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[9]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[9][i];
                                    Box0[9][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[9];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'J')
                            {
                                for (int j = 0; j < blok_uzunluk[9]; j++)
                                {
                                    Box0[9][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                        {
                            if (Box1[i] == 'J')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[9]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'J')
                            {
                                for (int j = 0; j < blok_uzunluk[9]; j++)
                                {
                                    Box0[9][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                        {
                            if (Box2[i] == 'J')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[9]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'J')
                            {
                                for (int j = 0; j < blok_uzunluk[9]; j++)
                                {
                                    Box0[9][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                        {
                            if (Box3[i] == 'J')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[9]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[9];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.K)
                {
                    if (Box0[10][0] == 'K')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[10] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[10]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[10][i];
                                    Box0[10][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[10];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[10] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[10]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[10][i];
                                    Box0[10][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[10];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[10] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[10]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[10][i];
                                    Box0[10][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[10];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'K')
                            {
                                for (int j = 0; j < blok_uzunluk[10]; j++)
                                {
                                    Box0[10][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                        {
                            if (Box1[i] == 'K')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[10]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'K')
                            {
                                for (int j = 0; j < blok_uzunluk[10]; j++)
                                {
                                    Box0[10][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                        {
                            if (Box2[i] == 'K')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[10]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'K')
                            {
                                for (int j = 0; j < blok_uzunluk[10]; j++)
                                {
                                    Box0[10][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                        {
                            if (Box3[i] == 'K')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[10]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[10];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                if (ilkkomut.Key == ConsoleKey.L)
                {
                    if (Box0[11][0] == 'L')
                    {
                        if (ikincikomut.Key == ConsoleKey.D1)
                        {
                            if (box1sayac + blok_uzunluk[11] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[11]; i++)
                                {
                                    Box1[i + box1sayac] = Box0[11][i];
                                    Box0[11][i] = ' ';
                                }
                                box1sayac += blok_uzunluk[11];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[" + box1sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }

                        }
                        if (ikincikomut.Key == ConsoleKey.D2)
                        {
                            if (box2sayac + blok_uzunluk[11] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[11]; i++)
                                {
                                    Box2[i + box2sayac] = Box0[11][i];
                                    Box0[11][i] = ' ';
                                }
                                box2sayac += blok_uzunluk[11];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[" + box2sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                        if (ikincikomut.Key == ConsoleKey.D3)
                        {
                            if (box3sayac + blok_uzunluk[11] <= 20)
                            {
                                for (int i = 0; i < blok_uzunluk[11]; i++)
                                {
                                    Box3[i + box3sayac] = Box0[11][i];
                                    Box0[11][i] = ' ';
                                }
                                box3sayac += blok_uzunluk[11];
                                ekrangüncelle();
                                HumanScore = box1sayac + box2sayac + box3sayac;
                                Console.SetCursorPosition(27, 3);
                                Console.Write("[" + HumanScore + "]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[" + box3sayac + "]");
                                goto komutalim;
                            }
                            else
                            {
                                goto komutalim;
                            }
                        }
                    }
                    if (ikincikomut.Key == ConsoleKey.D0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box1[i] == 'L')
                            {
                                for (int j = 0; j < blok_uzunluk[11]; j++)
                                {
                                    Box0[11][j] = Box1[i];
                                }
                                box1sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                        {
                            if (Box1[i] == 'L')
                            {
                                Box1[i] = Box1[i + blok_uzunluk[11]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box2[i] == 'L')
                            {
                                for (int j = 0; j < blok_uzunluk[11]; j++)
                                {
                                    Box0[11][j] = Box2[i];
                                }
                                box2sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                        {
                            if (Box2[i] == 'L')
                            {
                                Box2[i] = Box2[i + blok_uzunluk[11]];
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (Box3[i] == 'L')
                            {
                                for (int j = 0; j < blok_uzunluk[11]; j++)
                                {
                                    Box0[11][j] = Box3[i];
                                }
                                box3sayac--;
                            }
                        }
                        for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                        {
                            if (Box3[i] == 'L')
                            {
                                Box3[i] = Box3[i + blok_uzunluk[11]];
                            }
                        }
                        HumanScore = HumanScore - blok_uzunluk[11];
                        Console.SetCursorPosition(27, 3);
                        Console.Write("[" + HumanScore + "]");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("[" + box1sayac + "]");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("[" + box2sayac + "]");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("[" + box3sayac + "]");
                        Array.Clear(Box1, box1sayac, 20 - box1sayac);
                        Array.Clear(Box2, box2sayac, 20 - box2sayac);
                        Array.Clear(Box3, box3sayac, 20 - box3sayac);
                        ekrangüncelle();

                        goto komutalim;
                    }
                    else
                    {
                        goto komutalim;
                    }
                }
                else
                {
                    goto komutalim;
                }
            

        }
        public static void AIPlay()
            {
                //BOT ICIN AYRI BOXLAR TANIMLADIK YINE... CLASSTA TANIMLADIGIMIZ BLOKUZUNLUKLARINI INDEXLEYEN DEGISKENIMIZI KULLANDIK...
                CompBox0[0] = new char[blok_uzunluk[0]];
                CompBox0[1] = new char[blok_uzunluk[1]];
                CompBox0[2] = new char[blok_uzunluk[2]];
                CompBox0[3] = new char[blok_uzunluk[3]];
                CompBox0[4] = new char[blok_uzunluk[4]];
                CompBox0[5] = new char[blok_uzunluk[5]];
                CompBox0[6] = new char[blok_uzunluk[6]];
                CompBox0[7] = new char[blok_uzunluk[7]];
                CompBox0[8] = new char[blok_uzunluk[8]];
                CompBox0[9] = new char[blok_uzunluk[9]];
                CompBox0[10] = new char[blok_uzunluk[10]];
                CompBox0[11] = new char[blok_uzunluk[11]];

                //COMPUTER BLOKLARINI TANIMLADIK (BOX0 I).....
                for (int i = 0; i < blok_uzunluk[0]; i++)
                {
                    CompBox0[0][i] = 'A';
                }
                for (int i = 0; i < blok_uzunluk[1]; i++)
                {
                    CompBox0[1][i] = 'B';
                }
                for (int i = 0; i < blok_uzunluk[2]; i++)
                {
                    CompBox0[2][i] = 'C';
                }
                for (int i = 0; i < blok_uzunluk[3]; i++)
                {
                    CompBox0[3][i] = 'D';
                }
                for (int i = 0; i < blok_uzunluk[4]; i++)
                {
                    CompBox0[4][i] = 'E';
                }
                for (int i = 0; i < blok_uzunluk[5]; i++)
                {
                    CompBox0[5][i] = 'F';
                }
                for (int i = 0; i < blok_uzunluk[6]; i++)
                {
                    CompBox0[6][i] = 'G';
                }
                for (int i = 0; i < blok_uzunluk[7]; i++)
                {
                    CompBox0[7][i] = 'H';
                }
                for (int i = 0; i < blok_uzunluk[8]; i++)
                {
                    CompBox0[8][i] = 'I';
                }
                for (int i = 0; i < blok_uzunluk[9]; i++)
                {
                    CompBox0[9][i] = 'J';
                }
                for (int i = 0; i < blok_uzunluk[10]; i++)
                {
                    CompBox0[10][i] = 'K';
                }
                for (int i = 0; i < blok_uzunluk[11]; i++)
                {
                    CompBox0[11][i] = 'L';
                }

                //COMP BLOKLAR YAZILDI
                for (int i = 0; i < 12; i++)
                {
                    Console.SetCursorPosition(52, i + 5);
                    for (int j = 0; j < blok_uzunluk[i]; j++)
                    {
                        Console.Write(CompBox0[i][j]);
                    }
                }
                //BOT  OYNAMASI SANIYE 0 DAN BUYUK IKEN DEVAM EDECEK...HER 1 SANIYEDE 1  HAMLE YAPAN BOT  OYUNUNU SAYI VE HARFI SUREKLI RANDOM ATARAK OYNAYACAK.
                //AYRICA HUMAN OYUNUNDAN FARKLI  OLARAK  BOT  IYI BIR  SEVIYEDE OYUNU  TAMAMLAMAK ICIN  HER BLOK SCORE 15  IN UZERINE CIKARSA GERI YOLLAMAYI BIRAKACAK EKLEYEBILIRSE EKLEYECEK...

                while (saniye > 0)
                {
                    compharf = rastgele.Next(65, 76);
                    compnum = rastgele.Next(0, 4);
                    if (compharf == 65)
                    {
                        if (CompBox0[0][0] == 'A')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[0] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[0]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[0][i];
                                        CompBox0[0][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[0];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[0] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[0]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[0][i];
                                        CompBox0[0][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[0];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[0] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[0]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[0][i];
                                        CompBox0[0][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[0];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'A')
                                    {
                                        for (int j = 0; j < blok_uzunluk[0]; j++)
                                        {
                                            CompBox0[0][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                                {
                                    if (CompBox1[i] == 'A')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[0]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'A')
                                    {
                                        for (int j = 0; j < blok_uzunluk[0]; j++)
                                        {
                                            CompBox0[0][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                                {
                                    if (CompBox2[i] == 'A')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[0]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'A')
                                    {
                                        for (int j = 0; j < blok_uzunluk[0]; j++)
                                        {
                                            CompBox0[0][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[0]; i++)
                                {
                                    if (CompBox3[i] == 'A')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[0]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[0];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(43, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(43, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(43, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 66)
                    {
                        if (CompBox0[1][0] == 'B')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[1] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[1]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[1][i];
                                        CompBox0[1][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[1];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[1] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[1]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[1][i];
                                        CompBox0[1][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[1];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[1] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[1]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[1][i];
                                        CompBox0[1][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[1];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'B')
                                    {
                                        for (int j = 0; j < blok_uzunluk[1]; j++)
                                        {
                                            CompBox0[1][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                                {
                                    if (CompBox1[i] == 'B')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[1]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'B')
                                    {
                                        for (int j = 0; j < blok_uzunluk[1]; j++)
                                        {
                                            CompBox0[1][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                                {
                                    if (CompBox2[i] == 'B')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[1]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'B')
                                    {
                                        for (int j = 0; j < blok_uzunluk[1]; j++)
                                        {
                                            CompBox0[1][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[1]; i++)
                                {
                                    if (CompBox3[i] == 'B')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[1]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[1];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[" + CompScore + "]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[" + Compbox1sayac + "]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[" + Compbox2sayac + "]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[" + Compbox3sayac + "]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 67)
                    {
                        if (CompBox0[2][0] == 'C')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[2] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[2]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[2][i];
                                        CompBox0[2][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[2];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[2] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[2]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[2][i];
                                        CompBox0[2][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[2];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[2] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[2]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[2][i];
                                        CompBox0[2][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[2];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'C')
                                    {
                                        for (int j = 0; j < blok_uzunluk[2]; j++)
                                        {
                                            CompBox0[2][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                                {
                                    if (CompBox1[i] == 'C')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[2]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'C')
                                    {
                                        for (int j = 0; j < blok_uzunluk[2]; j++)
                                        {
                                            CompBox0[2][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                                {
                                    if (CompBox2[i] == 'C')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[2]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'C')
                                    {
                                        for (int j = 0; j < blok_uzunluk[2]; j++)
                                        {
                                            CompBox0[2][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[2]; i++)
                                {
                                    if (CompBox3[i] == 'C')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[2]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[2];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }

                    }
                    else if (compharf == 68)
                    {
                        if (CompBox0[3][0] == 'D')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[3] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[3]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[3][i];
                                        CompBox0[3][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[3];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[3] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[3]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[3][i];
                                        CompBox0[3][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[3];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[3] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[3]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[3][i];
                                        CompBox0[3][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[3];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'D')
                                    {
                                        for (int j = 0; j < blok_uzunluk[3]; j++)
                                        {
                                            CompBox0[3][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                                {
                                    if (CompBox1[i] == 'D')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[3]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'D')
                                    {
                                        for (int j = 0; j < blok_uzunluk[3]; j++)
                                        {
                                            CompBox0[3][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                                {
                                    if (CompBox2[i] == 'D')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[3]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'D')
                                    {
                                        for (int j = 0; j < blok_uzunluk[3]; j++)
                                        {
                                            CompBox0[3][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[3]; i++)
                                {
                                    if (CompBox3[i] == 'D')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[3]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[3];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }

                    }
                    else if (compharf == 69)
                    {
                        if (CompBox0[4][0] == 'E')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[4] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[4]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[4][i];
                                        CompBox0[4][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[4];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[4] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[4]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[4][i];
                                        CompBox0[4][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[4];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[4] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[4]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[4][i];
                                        CompBox0[4][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[4];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'E')
                                    {
                                        for (int j = 0; j < blok_uzunluk[4]; j++)
                                        {
                                            CompBox0[4][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                                {
                                    if (CompBox1[i] == 'E')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[4]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'E')
                                    {
                                        for (int j = 0; j < blok_uzunluk[4]; j++)
                                        {
                                            CompBox0[4][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                                {
                                    if (CompBox2[i] == 'E')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[4]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'E')
                                    {
                                        for (int j = 0; j < blok_uzunluk[4]; j++)
                                        {
                                            CompBox0[4][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[4]; i++)
                                {
                                    if (CompBox3[i] == 'E')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[4]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[4];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 70)
                    {
                        if (CompBox0[5][0] == 'F')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[5] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[5]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[5][i];
                                        CompBox0[5][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[5];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[5] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[5]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[5][i];
                                        CompBox0[5][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[5];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[5] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[5]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[5][i];
                                        CompBox0[5][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[5];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'F')
                                    {
                                        for (int j = 0; j < blok_uzunluk[5]; j++)
                                        {
                                            CompBox0[5][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                                {
                                    if (CompBox1[i] == 'F')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[5]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'F')
                                    {
                                        for (int j = 0; j < blok_uzunluk[5]; j++)
                                        {
                                            CompBox0[5][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                                {
                                    if (CompBox2[i] == 'F')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[5]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'F')
                                    {
                                        for (int j = 0; j < blok_uzunluk[5]; j++)
                                        {
                                            CompBox0[5][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[5]; i++)
                                {
                                    if (CompBox3[i] == 'F')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[5]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[5];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 70)
                    {
                        if (CompBox0[6][0] == 'G')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[6] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[6]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[6][i];
                                        CompBox0[6][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[6];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[6] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[6]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[6][i];
                                        CompBox0[6][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[6];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[6] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[6]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[6][i];
                                        CompBox0[6][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[6];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'G')
                                    {
                                        for (int j = 0; j < blok_uzunluk[6]; j++)
                                        {
                                            CompBox0[6][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                                {
                                    if (CompBox1[i] == 'G')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[6]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'G')
                                    {
                                        for (int j = 0; j < blok_uzunluk[6]; j++)
                                        {
                                            CompBox0[6][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                                {
                                    if (CompBox2[i] == 'G')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[6]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'G')
                                    {
                                        for (int j = 0; j < blok_uzunluk[6]; j++)
                                        {
                                            CompBox0[6][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[6]; i++)
                                {
                                    if (CompBox3[i] == 'G')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[6]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[6];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 71)
                    {
                        if (CompBox0[7][0] == 'H')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[7] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[7]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[7][i];
                                        CompBox0[7][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[7];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[7] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[7]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[7][i];
                                        CompBox0[7][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[7];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[7] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[7]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[7][i];
                                        CompBox0[7][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[7];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'H')
                                    {
                                        for (int j = 0; j < blok_uzunluk[7]; j++)
                                        {
                                            CompBox0[7][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                                {
                                    if (CompBox1[i] == 'H')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[7]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'H')
                                    {
                                        for (int j = 0; j < blok_uzunluk[7]; j++)
                                        {
                                            CompBox0[7][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                                {
                                    if (CompBox2[i] == 'H')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[7]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'H')
                                    {
                                        for (int j = 0; j < blok_uzunluk[7]; j++)
                                        {
                                            CompBox0[7][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[7]; i++)
                                {
                                    if (CompBox3[i] == 'H')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[7]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[7];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 72)
                    {
                        if (CompBox0[8][0] == 'I')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[8] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[8]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[8][i];
                                        CompBox0[8][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[8];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[8] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[8]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[8][i];
                                        CompBox0[8][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[8];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[8] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[8]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[8][i];
                                        CompBox0[8][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[8];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'I')
                                    {
                                        for (int j = 0; j < blok_uzunluk[8]; j++)
                                        {
                                            CompBox0[8][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                                {
                                    if (CompBox1[i] == 'I')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[8]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'I')
                                    {
                                        for (int j = 0; j < blok_uzunluk[8]; j++)
                                        {
                                            CompBox0[8][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                                {
                                    if (CompBox2[i] == 'I')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[8]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'I')
                                    {
                                        for (int j = 0; j < blok_uzunluk[8]; j++)
                                        {
                                            CompBox0[8][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[8]; i++)
                                {
                                    if (CompBox3[i] == 'I')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[8]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[8];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 73)
                    {
                        if (CompBox0[9][0] == 'J')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[9] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[9]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[9][i];
                                        CompBox0[9][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[9];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[9] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[9]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[9][i];
                                        CompBox0[9][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[9];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[9] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[9]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[9][i];
                                        CompBox0[9][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[9];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'J')
                                    {
                                        for (int j = 0; j < blok_uzunluk[9]; j++)
                                        {
                                            CompBox0[9][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                                {
                                    if (CompBox1[i] == 'J')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[9]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'J')
                                    {
                                        for (int j = 0; j < blok_uzunluk[9]; j++)
                                        {
                                            CompBox0[9][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                                {
                                    if (CompBox2[i] == 'J')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[9]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'J')
                                    {
                                        for (int j = 0; j < blok_uzunluk[9]; j++)
                                        {
                                            CompBox0[9][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[9]; i++)
                                {
                                    if (CompBox3[i] == 'J')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[9]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[9];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 74)
                    {
                        if (CompBox0[10][0] == 'K')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[10] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[10]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[10][i];
                                        CompBox0[10][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[10];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[10] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[10]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[10][i];
                                        CompBox0[10][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[10];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[10] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[10]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[10][i];
                                        CompBox0[10][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[10];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'K')
                                    {
                                        for (int j = 0; j < blok_uzunluk[10]; j++)
                                        {
                                            CompBox0[10][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                                {
                                    if (CompBox1[i] == 'K')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[10]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'K')
                                    {
                                        for (int j = 0; j < blok_uzunluk[10]; j++)
                                        {
                                            CompBox0[10][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                                {
                                    if (CompBox2[i] == 'K')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[10]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'K')
                                    {
                                        for (int j = 0; j < blok_uzunluk[10]; j++)
                                        {
                                            CompBox0[10][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[10]; i++)
                                {
                                    if (CompBox3[i] == 'K')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[10]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[10];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }
                    }
                    else if (compharf == 75)
                    {
                        if (CompBox0[11][0] == 'L')
                        {
                            if (compnum == 1)
                            {
                                if (Compbox1sayac + blok_uzunluk[11] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[11]; i++)
                                    {
                                        CompBox1[i + Compbox1sayac] = CompBox0[11][i];
                                        CompBox0[11][i] = ' ';
                                    }
                                    Compbox1sayac += blok_uzunluk[11];
                                    Console.SetCursorPosition(95, 9);
                                    Console.Write("[" + Compbox1sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 2)
                            {
                                if (Compbox2sayac + blok_uzunluk[11] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[11]; i++)
                                    {
                                        CompBox2[i + Compbox2sayac] = CompBox0[11][i];
                                        CompBox0[11][i] = ' ';
                                    }
                                    Compbox2sayac += blok_uzunluk[11];
                                    Console.SetCursorPosition(95, 10);
                                    Console.Write("[" + Compbox2sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                            if (compnum == 3)
                            {
                                if (Compbox3sayac + blok_uzunluk[11] <= 20)
                                {
                                    for (int i = 0; i < blok_uzunluk[11]; i++)
                                    {
                                        CompBox3[i + Compbox3sayac] = CompBox0[11][i];
                                        CompBox0[11][i] = ' ';
                                    }
                                    Compbox3sayac += blok_uzunluk[11];
                                    Console.SetCursorPosition(95, 11);
                                    Console.Write("[" + Compbox3sayac + "]");
                                    CompScore = Compbox1sayac + Compbox2sayac + Compbox3sayac;
                                    Console.SetCursorPosition(79, 3);
                                    Console.Write("[" + CompScore + "]");
                                    ekrangüncelleComp();
                                }
                            }
                        }
                        else if (Compbox1sayac <= 14 || Compbox2sayac <= 14 || Compbox3sayac <= 14)
                        {
                            if (compnum == 0)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox1[i] == 'L')
                                    {
                                        for (int j = 0; j < blok_uzunluk[11]; j++)
                                        {
                                            CompBox0[11][j] = CompBox1[i];
                                        }
                                        Compbox1sayac--;
                                    }
                                }

                                for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                                {
                                    if (CompBox1[i] == 'L')
                                    {
                                        CompBox1[i] = CompBox1[i + blok_uzunluk[11]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox2[i] == 'L')
                                    {
                                        for (int j = 0; j < blok_uzunluk[11]; j++)
                                        {
                                            CompBox0[11][j] = CompBox2[i];
                                        }
                                        Compbox2sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                                {
                                    if (CompBox2[i] == 'L')
                                    {
                                        CompBox2[i] = CompBox2[i + blok_uzunluk[11]];
                                    }
                                }
                                for (int i = 0; i < 20; i++)
                                {
                                    if (CompBox3[i] == 'L')
                                    {
                                        for (int j = 0; j < blok_uzunluk[11]; j++)
                                        {
                                            CompBox0[11][j] = CompBox3[i];
                                        }
                                        Compbox3sayac--;
                                    }
                                }
                                for (int i = 0; i < 20 - blok_uzunluk[11]; i++)
                                {
                                    if (CompBox3[i] == 'L')
                                    {
                                        CompBox3[i] = CompBox3[i + blok_uzunluk[11]];
                                    }
                                }
                                CompScore = CompScore - blok_uzunluk[11];
                                Console.SetCursorPosition(79, 3);
                                Console.Write("[ " + CompScore + " ]");
                                Console.SetCursorPosition(95, 9);
                                Console.Write("[ " + Compbox1sayac + " ]");
                                Console.SetCursorPosition(95, 10);
                                Console.Write("[ " + Compbox2sayac + " ]");
                                Console.SetCursorPosition(95, 11);
                                Console.Write("[ " + Compbox3sayac + " ]");

                                Array.Clear(CompBox1, Compbox1sayac, 20 - Compbox1sayac);
                                Array.Clear(CompBox2, Compbox2sayac, 20 - Compbox2sayac);
                                Array.Clear(CompBox3, Compbox3sayac, 20 - Compbox3sayac);
                                ekrangüncelleComp();

                            }
                        }

                    }
                    Thread.Sleep(1000);
                }
            
        }
        public static void ekrangüncelle()
        {
            //Human tarafı
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(1, i + 5);
                for (int j = 0; j < blok_uzunluk[i]; j++)
                {
                    Console.Write(Box0[i][j]);
                }
            }
            Console.SetCursorPosition(21, 9);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Box1[i]);
            }
            Console.SetCursorPosition(21, 10);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Box2[i]);
            }
            Console.SetCursorPosition(21, 11);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Box3[i]);
            }
           
        }
        public static void ekrangüncelleComp()
        {
            //Comp tarafı
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(52, i + 5);
                for (int j = 0; j < blok_uzunluk[i]; j++)
                {
                    Console.Write(CompBox0[i][j]);
                }
            }
            Console.SetCursorPosition(72, 9);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(CompBox1[i]);
            }
            Console.SetCursorPosition(72, 10);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(CompBox2[i]);
            }
            Console.SetCursorPosition(72, 11);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(CompBox3[i]);
            }

        }
        public static void BestSCORE()
        {
            //MAALESEF BEST SCORE  ALGORITMASI GELISTIREMEDIM ELIMDEN GELMEDI :( EN AZINDAN  GORSEL OLARAK  KOYDUM...

            Console.SetCursorPosition(72, 20);
            Console.WriteLine("Best Score");
            Console.SetCursorPosition(76, 22);
            Console.WriteLine("5   10   15   20");
            Console.SetCursorPosition(72, 23);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("----+");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(67, i + 24);
                Console.WriteLine("[{0}]", i + 1);
            }
            if (CompScore >= BestScore)
            {
                BestScore = CompScore;
                for (int i = 0; i < 20; i++)
                {
                    BestBox1[i] = CompBox1[i];
                    BestBox2[i] = CompBox2[i];
                    BestBox3[i] = CompBox3[i];
                }          
            }
            Console.SetCursorPosition(72, 24);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(BestBox1[i]);
            }
            Console.SetCursorPosition(72, 25);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(BestBox2[i]);
            }
            Console.SetCursorPosition(72, 26);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(BestBox3[i]);
            }
        }


        public static void Eszaman()
        {
            //BURADA BOT OYUNU VE ZAMANSAYACI HUMANPLAY ILE ESZAMANLI OLMASI  ICIN  2  TANE METHODUMUZU THREAD  OLARAK  TANIMLADIK VE TEK THREAD METHODUNA  ALDIK...
            Thread tr1 = new Thread(new ThreadStart(Zamansayacı));
            Thread tr2 = new Thread(new ThreadStart(AIPlay));
           
            tr1.Start();
            tr2.Start();
       
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
           
            OyunArayüz();

            BestSCORE();

            Eszaman();
            gameplay();
         
            Console.ReadKey();
        }


    }
}

