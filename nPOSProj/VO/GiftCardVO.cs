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

        public String[,] ReadGC()
        {
            gcdao = new DAO.GiftCardDAO();
            Int32 count = gcdao.PositionCount();
            String[,] xxx = new String[5, count];
            gcdao.Read();
            xxx = gcdao.Read();
            return xxx;
        }
    }
}
