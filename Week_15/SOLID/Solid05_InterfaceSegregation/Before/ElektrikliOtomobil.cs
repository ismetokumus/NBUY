﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterfaceSegregation.Before
{
    public class ElektrikliOtomobil : IOtomobil, IElektrikliOtomobil
    {
        public int KapiSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UretimYili { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BataryaTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string BataryaTipiniGetir()
        {
            throw new NotImplementedException();
        }

        public int IletimHiziniGetir()
        {
            throw new NotImplementedException();
        }

        public string IletimTipiniGetir()
        {
            throw new NotImplementedException();
        }

        public int KapiSayisiniGetir()
        {
            throw new NotImplementedException();
        }

        public double MotorunGucunuGetir()
        {
            throw new NotImplementedException();
        }

        public decimal VoltaDegeriniGetir()
        {
            throw new NotImplementedException();
        }

        public string YakitTipiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
