using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class Dbo
    {
        private static QL_CHNuocHoa qL_CHNuocHoa = null;
        protected Dbo()
        {
            
        }
        public static QL_CHNuocHoa getObject()
        {
            if (qL_CHNuocHoa == null)
                return qL_CHNuocHoa = new QL_CHNuocHoa();
            return qL_CHNuocHoa;
        }
    }
}
