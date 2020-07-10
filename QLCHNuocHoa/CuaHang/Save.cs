using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHang
{
    static class Save
    {
        public static string account="";
        public static String s1 = "";
        public static String s2 = "";
        public static int i1 = 0;
        public static int i2 = 0;
        public static double d1 = 0;
        public static Point point;
        public static int width;
        public static int height;
        public static System.Drawing.Bitmap anh3;
        public static System.Drawing.Bitmap anh26;
        public static System.Drawing.Bitmap anh37;

        public static void LoadResource()
        {
            anh3 = global::CuaHang.Properties.Resources.anh3;
            anh26 = global::CuaHang.Properties.Resources.anh26;
            anh37 = global::CuaHang.Properties.Resources.anh37;
        }
    }
}
