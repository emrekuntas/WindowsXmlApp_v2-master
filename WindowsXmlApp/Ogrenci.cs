using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsXmlApp
{
    [Serializable]
    public class Ogrenci
    {
        private Guid ıd;

        public Guid ID
        {
            get { return ıd; }
            set { ıd = value; }
        }

        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }


        private string soyad;

        public string  Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }


        private DateTime dtarih;

        public DateTime DogumTarih
        {
            get { return dtarih; }
            set { dtarih = value; }
        }

        private Cinsiyet cinsiyet;

        public Cinsiyet Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }


    }

   public enum Cinsiyet
    {
        Kadın=1,
        Erkek=2,
        Diğer=3
    }
}
