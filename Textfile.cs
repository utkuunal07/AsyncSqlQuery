using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;




namespace SQLforloop
{
    class Textfile
    {

        public string date;
        public string enddate;

        string hstShort;
        string subeKodu;
        string ASTOREsubeKodu;


        public dynamic OpenTxt(string adres, string[] hastaneler, bool checkbox7)
        {



            //OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open Text File";
            //theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"C:\Users\Utku.Unal\Desktop";
            //theDialog.ShowDialog();


            string[] text = File.ReadAllLines(adres);
            text = text.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            text = text.Select(x => x.Trim()).ToArray();

            //int zero = 1;
            //string[] tumhastanelar = { "ADA - Adana Özel Acıbadem Hastanesi", "ANK - Ankara Acıbadem Hastanesi", "Aydın Bodrum Klinik International", "BUR - Bursa Özel Acıbadem Hastanesi", "ESK - Eskişehir Özel Acıbadem Hastanesi", "ATA - Istanbul Acıbadem Ataşehir Cerrahi Tıp Merkezi", "BAĞ - Istanbul Acıbadem Bağdat Cerrahi Tıp Merkezi", "Istanbul Acıbadem Bahçeşehir Tıp Merkezi", "BEY - Istanbul Acıbadem Beylikdüzü Cerrahi Tıp Mrk.", "ETİ - Istanbul Acıbadem Etiler Tıp Merkezi", "Istanbul Acıbadem Göktürk Tıp Merkezi", "FUL - Istanbul Acıbadem Hastanesi Fulya", "KOZ - Istanbul Acıbadem Hastanesi Kozyatağı", "TKS - Istanbul Acıbadem Hastanesi Taksim", "ZEK - Istanbul Acıbadem Zekeriyaköy Tıp Merkezi", "ATZ - Istanbul Altunizade Özel Acıbadem Hastanesi", "BAK - Istanbul Bakırköy Özel Acıbadem Hastanesi", "Istanbul International Özel Acıbadem Hastanesi", "ACB - Istanbul Kadıköy Özel Acıbadem Hastanesi", "MAS - Istanbul Maslak Özel Acıbadem Hastanesi", "ATAK - Özel Acıbadem Atakent Hastanesi", "KAY - Kayseri Özel Acıbadem Hastanesi", "KOC - Kocaeli Özel Acıbadem Hastanesi", "Muğla Bodrum Özel Acıbadem Hastanesi","AS - Acıbadem Sport","Acıbadem Gemlik Tıp Merkezi", "Tüm Hastaneler (KOZ, TAKSIM, ATK hariç)", "Tüm Hastaneler (KOZ, TAKSIM, ATK dahil)", "Tüm Tıp Merkezleri (GEM Hariç)"};//, "Hepsi (KOZ, TAKSIM, ATK hariç)", "Hepsi (KOZ, TAKSIM, ATK dahil)" 
            //
            //Console.WriteLine("\r\nArama yapacağınız hastaneleri seçin, hastane isimlerinin solundaki numarayı aralarına boşluk bırakarak girin ve 'Enter' tuşuna basın(Örn: 1 2 3 )");
            //foreach (string i in tumhastanelar)
            //{
            //    Console.WriteLine("[" + zero + "]" + " " + i);
            //    zero++;
            //}


            //var hst = Console.ReadLine();

            // hastaneler = hst.Split(' ');

            List<string> hstShortlar = new List<string>();
            List<string> subeKodular = new List<string>();
            List<string> ASTOREsubeKodular = new List<string>();





            foreach (var i in hastaneler)
            {
                switch (i.ToString().ToUpper())
                {
                    case "1":
                    case "ADN":
                        
                        hstShort = "ADN";
                        subeKodu = "22";
                        ASTOREsubeKodu = "76";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);

                        break;
                    case "2":
                    case "ANK":
                        
                        hstShort = "ANK";
                        subeKodu = "28";
                        ASTOREsubeKodu = "27";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "3":
                    case "BDRINT":
                      
                        hstShort = "BDRINT";
                        subeKodu = "59";
                        ASTOREsubeKodu = "62";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "4":
                    case "BRS":
                        
                        hstShort = "BRS";
                        subeKodu = "40";
                        ASTOREsubeKodu = "51";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "5":
                    case "ESK":
                       
                        hstShort = "ESK";
                        subeKodu = "26";
                        ASTOREsubeKodu = "57";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "6":
                    case "ATASEHIR":
                        
                        hstShort = "ATASEHIR";
                        subeKodu = "35";
                        ASTOREsubeKodu = "23";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "7":
                    case "BAGDAT":
                        
                        hstShort = "BAGDAT";
                        subeKodu = "12";
                        ASTOREsubeKodu = "69";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "8":
                    case "BSEHIR":
                       
                        hstShort = "BSEHIR";
                        subeKodu = "94";
                        ASTOREsubeKodu = "86";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "9":
                    case "BEYLIKDUZU":
                       
                        hstShort = "BEYLIKDUZU";
                        subeKodu = "14";
                        ASTOREsubeKodu = "68";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "10":
                    case "ETILER":

                        
                        hstShort = "ETILER";
                        subeKodu = "11";
                        ASTOREsubeKodu = "66";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "11":
                    case "KBURGAZ":
                        
                        hstShort = "KBURGAZ";
                        subeKodu = "31";
                        ASTOREsubeKodu = "39";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "12":
                    case "FLY":
                      
                        hstShort = "FLY";
                        subeKodu = "24";
                        ASTOREsubeKodu = "54";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "13":
                    case "KOZ":
                     
                        hstShort = "KOZ";
                        subeKodu = "30";
                        ASTOREsubeKodu = "17";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "14":
                    case "TAKSIM":
                       
                        hstShort = "TAKSIM";
                        subeKodu = "71";
                        ASTOREsubeKodu = "78";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "15":
                    case "ZKOY":
                       
                        hstShort = "ZKOY";
                        subeKodu = "87";
                        ASTOREsubeKodu = "89";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "16":
                    case "ATZ":
                      
                        hstShort = "ATZ";
                        subeKodu = "34";
                        ASTOREsubeKodu = "41";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "17":
                    case "BKR":
                       
                        hstShort = "BKR";
                        subeKodu = "20";
                        ASTOREsubeKodu = "60";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "18":
                    case "INTYSL":
                
                        hstShort = "INTYSL";
                        subeKodu = "90";
                        ASTOREsubeKodu = "12";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "19":
                    case "KDK":
                 
                        hstShort = "KDK";
                        subeKodu = "10";
                        ASTOREsubeKodu = "14";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "20":
                    case "MSL":
                    
                        hstShort = "MSL";
                        subeKodu = "45";
                        ASTOREsubeKodu = "5";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "21":
                    case "ATK":
                        
                        hstShort = "ATK";
                        subeKodu = "72";
                        ASTOREsubeKodu = "1";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "22":
                    case "KYS":
                    
                        hstShort = "KYS";
                        subeKodu = "25";
                        ASTOREsubeKodu = "55";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "23":
                    case "KCL":
                       
                        hstShort = "KCL";
                        subeKodu = "60";
                        ASTOREsubeKodu = "26";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;
                    case "24":
                    case "BDR":
                      
                        hstShort = "BDR";
                        subeKodu = "23";
                        ASTOREsubeKodu = "31";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;

                    case "25":
                    case "ASPORT":
                  
                        hstShort = "ASPORT";
                        subeKodu = "56";
                        ASTOREsubeKodu = "74";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;

                    case "26":
                    case "GEMLIK":
                   
                        hstShort = "GEMLIK";
                        subeKodu = "64";
                        ASTOREsubeKodu = "21";
                        hstShortlar.Add(hstShort);
                        subeKodular.Add(subeKodu);
                        ASTOREsubeKodular.Add(ASTOREsubeKodu);
                        break;

                    case "27":
                        
                        hstShortlar.Add("KDK");
                        subeKodular.Add("10");
                        ASTOREsubeKodular.Add("14");

                        hstShortlar.Add("ADN");
                        subeKodular.Add("22");
                        ASTOREsubeKodular.Add("76");

                        hstShortlar.Add("ANK");
                        subeKodular.Add("28");
                        ASTOREsubeKodular.Add("27");

                        hstShortlar.Add("BRS");
                        subeKodular.Add("40");
                        ASTOREsubeKodular.Add("51");

                        hstShortlar.Add("ESK");
                        subeKodular.Add("26");
                        ASTOREsubeKodular.Add("57");

                        hstShortlar.Add("FLY");
                        subeKodular.Add("24");
                        ASTOREsubeKodular.Add("54");

                        hstShortlar.Add("ATZ");
                        subeKodular.Add("34");
                        ASTOREsubeKodular.Add("41");

                        hstShortlar.Add("BKR");
                        subeKodular.Add("20");
                        ASTOREsubeKodular.Add("60");


                        hstShortlar.Add("INTYSL");
                        subeKodular.Add("90");
                        ASTOREsubeKodular.Add("12");

                        hstShortlar.Add("MSL");
                        subeKodular.Add("45");
                        ASTOREsubeKodular.Add("5");

                        hstShortlar.Add("KYS");
                        subeKodular.Add("25");
                        ASTOREsubeKodular.Add("55");

                        hstShortlar.Add("KCL");
                        subeKodular.Add("60");
                        ASTOREsubeKodular.Add("26");


                        hstShortlar.Add("BDR");
                        subeKodular.Add("23");
                        ASTOREsubeKodular.Add("31");

                        break;

                    case "28":
                        hstShortlar.Add("KDK");
                        subeKodular.Add("10");
                        ASTOREsubeKodular.Add("14");

                        hstShortlar.Add("ADN");
                        subeKodular.Add("22");
                        ASTOREsubeKodular.Add("76");

                        hstShortlar.Add("ANK");
                        subeKodular.Add("28");
                        ASTOREsubeKodular.Add("27");

                        hstShortlar.Add("BRS");
                        subeKodular.Add("40");
                        ASTOREsubeKodular.Add("51");

                        hstShortlar.Add("ESK");
                        subeKodular.Add("26");
                        ASTOREsubeKodular.Add("57");

                        hstShortlar.Add("FLY");
                        subeKodular.Add("24");
                        ASTOREsubeKodular.Add("54");

                        hstShortlar.Add("ATZ");
                        subeKodular.Add("34");
                        ASTOREsubeKodular.Add("41");

                        hstShortlar.Add("BKR");
                        subeKodular.Add("20");
                        ASTOREsubeKodular.Add("60");


                        hstShortlar.Add("INTYSL");
                        subeKodular.Add("90");
                        ASTOREsubeKodular.Add("12");

                        hstShortlar.Add("MSL");
                        subeKodular.Add("45");
                        ASTOREsubeKodular.Add("5");

                        hstShortlar.Add("KYS");
                        subeKodular.Add("25");
                        ASTOREsubeKodular.Add("55");

                        hstShortlar.Add("KCL");
                        subeKodular.Add("60");
                        ASTOREsubeKodular.Add("26");


                        hstShortlar.Add("BDR");
                        subeKodular.Add("23");
                        ASTOREsubeKodular.Add("31");

                        hstShortlar.Add("KOZ");
                        subeKodular.Add("30");
                        ASTOREsubeKodular.Add("17");

                        hstShortlar.Add("TAKSIM");
                        subeKodular.Add("71");
                        ASTOREsubeKodular.Add("78");

                        hstShortlar.Add("ATK");
                        subeKodular.Add("72");
                        ASTOREsubeKodular.Add("1");
                        break;

                    case "29":

                        hstShortlar.Add("BDRINT");
                        subeKodular.Add("59");
                        ASTOREsubeKodular.Add("62");

                        hstShortlar.Add("ATASEHIR");
                        subeKodular.Add("35");
                        ASTOREsubeKodular.Add("23");

                        hstShortlar.Add("BAGDAT");
                        subeKodular.Add("12");
                        ASTOREsubeKodular.Add("69");

                        hstShortlar.Add("BSEHIR");
                        subeKodular.Add("94");
                        ASTOREsubeKodular.Add("86");

                        hstShortlar.Add("BEYLIKDUZU");
                        subeKodular.Add("14");
                        ASTOREsubeKodular.Add("68");

                        hstShortlar.Add("ETILER");
                        subeKodular.Add("11");
                        ASTOREsubeKodular.Add("66");

                        hstShortlar.Add("KBURGAZ");
                        subeKodular.Add("31");
                        ASTOREsubeKodular.Add("39");

                        hstShortlar.Add("ZKOY");
                        subeKodular.Add("87");
                        ASTOREsubeKodular.Add("89");

                         
                        break;

                        //case "30":
                        //
                        //    hstShortlar.Add("KDK");
                        //    subeKodular.Add("10");
                        //    ASTOREsubeKodular.Add("14");
                        //
                        //    hstShortlar.Add("ADN");
                        //    subeKodular.Add("22");
                        //    ASTOREsubeKodular.Add("76");
                        //
                        //    hstShortlar.Add("ANK");
                        //    subeKodular.Add("28");
                        //    ASTOREsubeKodular.Add("27");
                        //
                        //    hstShortlar.Add("BRS");
                        //    subeKodular.Add("40");
                        //    ASTOREsubeKodular.Add("51");
                        //
                        //    hstShortlar.Add("ESK");
                        //    subeKodular.Add("26");
                        //    ASTOREsubeKodular.Add("57");
                        //
                        //    hstShortlar.Add("FLY");
                        //    subeKodular.Add("24");
                        //    ASTOREsubeKodular.Add("54");
                        //
                        //    hstShortlar.Add("ATZ");
                        //    subeKodular.Add("34");
                        //    ASTOREsubeKodular.Add("41");
                        //
                        //    hstShortlar.Add("BKR");
                        //    subeKodular.Add("20");
                        //    ASTOREsubeKodular.Add("60");
                        //
                        //
                        //    hstShortlar.Add("INTYSL");
                        //    subeKodular.Add("90");
                        //    ASTOREsubeKodular.Add("12");
                        //
                        //    hstShortlar.Add("MSL");
                        //    subeKodular.Add("45");
                        //    ASTOREsubeKodular.Add("5");
                        //
                        //    hstShortlar.Add("KYS");
                        //    subeKodular.Add("25");
                        //    ASTOREsubeKodular.Add("55");
                        //
                        //    hstShortlar.Add("KCL");
                        //    subeKodular.Add("60");
                        //    ASTOREsubeKodular.Add("26");
                        //
                        //
                        //    hstShortlar.Add("BDR");
                        //    subeKodular.Add("23");
                        //    ASTOREsubeKodular.Add("31");
                        //
                        //    hstShortlar.Add("BDRINT");
                        //    subeKodular.Add("59");
                        //    ASTOREsubeKodular.Add("62");
                        //
                        //    hstShortlar.Add("ATASEHIR");
                        //    subeKodular.Add("35");
                        //    ASTOREsubeKodular.Add("23");
                        //
                        //    hstShortlar.Add("BAGDAT");
                        //    subeKodular.Add("12");
                        //    ASTOREsubeKodular.Add("69");
                        //
                        //    hstShortlar.Add("BSEHIR");
                        //    subeKodular.Add("94");
                        //    ASTOREsubeKodular.Add("86");
                        //
                        //    hstShortlar.Add("BEYLIKDUZU");
                        //    subeKodular.Add("14");
                        //    ASTOREsubeKodular.Add("68");
                        //
                        //    hstShortlar.Add("ETILER");
                        //    subeKodular.Add("11");
                        //    ASTOREsubeKodular.Add("66");
                        //
                        //    hstShortlar.Add("KBURGAZ");
                        //    subeKodular.Add("31");
                        //    ASTOREsubeKodular.Add("39");
                        //
                        //    hstShortlar.Add("ZKOY");
                        //    subeKodular.Add("87");
                        //    ASTOREsubeKodular.Add("89");
                        //
                        //    hstShortlar.Add("ASTORE");
                        //    subeKodular.Add("56");
                        //    ASTOREsubeKodular.Add("74");
                        //
                        //    hstShortlar.Add("GEMLIK");
                        //    subeKodular.Add("64");
                        //    ASTOREsubeKodular.Add("21");
                        //
                        //    break;
                        //case "31":
                        //
                        //    hstShortlar.Add("KDK");
                        //    subeKodular.Add("10");
                        //    ASTOREsubeKodular.Add("14");
                        //
                        //    hstShortlar.Add("ADN");
                        //    subeKodular.Add("22");
                        //    ASTOREsubeKodular.Add("76");
                        //
                        //    hstShortlar.Add("ANK");
                        //    subeKodular.Add("28");
                        //    ASTOREsubeKodular.Add("27");
                        //
                        //    hstShortlar.Add("BRS");
                        //    subeKodular.Add("40");
                        //    ASTOREsubeKodular.Add("51");
                        //
                        //    hstShortlar.Add("ESK");
                        //    subeKodular.Add("26");
                        //    ASTOREsubeKodular.Add("57");
                        //
                        //    hstShortlar.Add("FLY");
                        //    subeKodular.Add("24");
                        //    ASTOREsubeKodular.Add("54");
                        //
                        //    hstShortlar.Add("ATZ");
                        //    subeKodular.Add("34");
                        //    ASTOREsubeKodular.Add("41");
                        //
                        //    hstShortlar.Add("BKR");
                        //    subeKodular.Add("20");
                        //    ASTOREsubeKodular.Add("60");
                        //
                        //
                        //    hstShortlar.Add("INTYSL");
                        //    subeKodular.Add("90");
                        //    ASTOREsubeKodular.Add("12");
                        //
                        //    hstShortlar.Add("MSL");
                        //    subeKodular.Add("45");
                        //    ASTOREsubeKodular.Add("5");
                        //
                        //    hstShortlar.Add("KYS");
                        //    subeKodular.Add("25");
                        //    ASTOREsubeKodular.Add("55");
                        //
                        //    hstShortlar.Add("KCL");
                        //    subeKodular.Add("60");
                        //    ASTOREsubeKodular.Add("26");
                        //
                        //
                        //    hstShortlar.Add("BDR");
                        //    subeKodular.Add("23");
                        //    ASTOREsubeKodular.Add("31");
                        //
                        //    hstShortlar.Add("BDRINT");
                        //    subeKodular.Add("59");
                        //    ASTOREsubeKodular.Add("62");
                        //
                        //    hstShortlar.Add("ATASEHIR");
                        //    subeKodular.Add("35");
                        //    ASTOREsubeKodular.Add("23");
                        //
                        //    hstShortlar.Add("BAGDAT");
                        //    subeKodular.Add("12");
                        //    ASTOREsubeKodular.Add("69");
                        //
                        //    hstShortlar.Add("BSEHIR");
                        //    subeKodular.Add("94");
                        //    ASTOREsubeKodular.Add("86");
                        //
                        //    hstShortlar.Add("BEYLIKDUZU");
                        //    subeKodular.Add("14");
                        //    ASTOREsubeKodular.Add("68");
                        //
                        //    hstShortlar.Add("ETILER");
                        //    subeKodular.Add("11");
                        //    ASTOREsubeKodular.Add("66");
                        //
                        //    hstShortlar.Add("KBURGAZ");
                        //    subeKodular.Add("31");
                        //    ASTOREsubeKodular.Add("39");
                        //
                        //    hstShortlar.Add("ZKOY");
                        //    subeKodular.Add("87");
                        //    ASTOREsubeKodular.Add("89");
                        //
                        //    hstShortlar.Add("KOZ");
                        //    subeKodular.Add("30");
                        //    ASTOREsubeKodular.Add("17");
                        //
                        //    hstShortlar.Add("TAKSIM");
                        //    subeKodular.Add("71");
                        //    ASTOREsubeKodular.Add("78");
                        //
                        //    hstShortlar.Add("ATK");
                        //    subeKodular.Add("72");
                        //    ASTOREsubeKodular.Add("1");
                        //
                        //    hstShortlar.Add("ASTORE");
                        //    subeKodular.Add("56");
                        //    ASTOREsubeKodular.Add("74");
                        //
                        //    hstShortlar.Add("GEMLIK");
                        //    subeKodular.Add("64");
                        //    ASTOREsubeKodular.Add("21");
                        //    break;

                }

            }
            string[] temp = text;
            List<string> queries = new List<string>();
            bool checkPSCHEMA = false;
            bool checkSUBEKODU = false;
            bool checkASTORESUBEKODU = false;
            bool checkDATE = false;
            bool checkENDDATE = false;
            bool birkere = true;
            bool birkere2 = true;
           
            for (int i = 0; i < hstShortlar.Count; i++)
            {
                temp = text;


                for (int f = 0; f < temp.Length; f++)
                {
                    if (temp[f].Contains("--"))
                    {
                        int index = Int32.Parse(temp[f].IndexOf("--") + Environment.NewLine);

                        temp[f] = temp[f].Remove(index);
                    }
                    if (checkDATE == false)
                    {
                        checkDATE = temp[f].Contains(":P_DATE");
                    }

                    if (checkENDDATE == false)
                    {
                        checkENDDATE = temp[f].Contains(":P_ENDDATE");
                    }

                    if (checkPSCHEMA == false)
                    {
                        checkPSCHEMA = temp[f].Contains(":P_SCHEMA");
                    }

                    if (checkSUBEKODU == false)
                    {
                        checkSUBEKODU = temp[f].Contains(":SUBE_KODU");
                    }
                    if (checkASTORESUBEKODU == false)
                    {
                        checkASTORESUBEKODU = temp[f].Contains(":ASTORE_KODU");
                    }

                    if (checkPSCHEMA && checkSUBEKODU && checkASTORESUBEKODU && checkDATE && checkENDDATE)
                    {
                        break;
                    }
                }

                if (checkDATE)
                {
                    if (birkere)
                    {
                        
                        birkere = false;
                    }   
                    temp = temp.Select(x => x.Replace(":P_DATE","'"+ date+"'")).ToArray();
                }
                if (checkENDDATE)
                {
                    if (birkere2)
                    {
                        
                        birkere2 = false;
                    }                  
                    temp = temp.Select(x => x.Replace(":P_ENDDATE","'"+ enddate+"'")).ToArray();
                }

                if (checkPSCHEMA)
                {
                    if (checkbox7)
                    {

                        if (hstShortlar[i]=="KOZ" | hstShortlar[i] == "TAKSIM" | hstShortlar[i] == "ATK")
                        {
                            StringBuilder sb2 = new StringBuilder();

                            for (int z = 0; z < temp.Length; z++)
                            {
                                string temp1 = temp[z] + " ";
                                sb2.Append(temp1);
                            }

                             temp = sb2.ToString().Split(' ');


                           
                            for (int g = 0; g < temp.Length; g++)
                            {
                                if (temp[g].Contains(":P_SCHEMA"))
                                {
                                    temp[g] = temp[g] + "@"+ hstShortlar[i] + "DB.WORLD";
                                }
                            }
                        }
                    }
                    temp = temp.Select(x => x.Replace(":P_SCHEMA", hstShortlar[i])).ToArray();
                }
                if (checkSUBEKODU)
                {
                    temp = temp.Select(x => x.Replace(":SUBE_KODU", subeKodular[i])).ToArray();
                }
                if (checkASTORESUBEKODU)
                {
                    temp = temp.Select(x => x.Replace(":ASTORE_KODU", ASTOREsubeKodular[i])).ToArray();
                }

                StringBuilder sb = new StringBuilder();

                for (int z = 0; z < temp.Length; z++)
                {
                    string temp1 = temp[z] + " ";
                    sb.Append(temp1);
                }

                queries.Add(sb.ToString());

            }

            return (queries);

        }
    }
}
