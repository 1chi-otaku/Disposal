using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piece
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1,3
            //for (int i = 0; i < 15; i++)
            //{
            //    Piece a = new Piece("name", "name", "genre", "1992");
            //}

            //Piece b;
            //Console.WriteLine();
            //for (int i = 0; i < 900; i++)
            //    using(b = new Piece("name", "name", "genre", "1992"))
            //{

            //}
            #endregion

            #region 2,3
            for (int i = 0; i < 20; i++)
            {
                Shop sj= new Shop();
                GC.Collect();
            }
            for (int i = 0; i < 900; i++)
                using (Shop sj= new Shop())
                {

                }
            #endregion
        }
    }
}
