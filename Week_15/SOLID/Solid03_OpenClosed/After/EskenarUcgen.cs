﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.After
{
    //Vscode örneği
    public class EskenarUcgen : Sekil
    {
        public EskenarUcgen(int taban, int yukseklik)
        {
            Taban = taban;
            Yukseklik = yukseklik;
        }

        public int Taban { get; set; }
        public int Yukseklik { get; set; }
        public override double AlanHesapla()
        {
            return (Taban * Yukseklik) / 2;
        }
    }
}
