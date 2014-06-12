using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class GiftCardVO
    {
        private DAO.GiftCardDAO gcdao;
        public GiftCardVO() { }

        private String gc_cardno;

        public String Gc_cardno
        {
            get { return gc_cardno; }
            set { gc_cardno = value; }
        }

        private Double gc_amount;

        public Double Gc_amount
        {
            get { return gc_amount; }
            set { gc_amount = value; }
        }

        private String gc_holder;

        public String Gc_holder
        {
            get { return gc_holder; }
            set { gc_holder = value; }
        }

        private DateTime gc_validuntil;

        public DateTime Gc_validuntil
        {
            get { return gc_validuntil; }
            set { gc_validuntil = value; }
        }

        public String[,] ReadGC()
        {
            gcdao = new DAO.GiftCardDAO();
            Int32 count = gcdao.PositionCount();
            String[,] xxx = new String[4, count];
            gcdao.Read();
            xxx = gcdao.Read();
            return xxx;
        }

        public void AddGC()
        {
            gcdao = new DAO.GiftCardDAO();
            gcdao.Add(Gc_cardno, Gc_amount, Gc_holder, Gc_validuntil);
        }

        public void DeleteGC()
        {
            gcdao = new DAO.GiftCardDAO();
            gcdao.Delete(Gc_cardno);
        }
    }
}