using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv3
{
    class Matrix
    {
        public double[,] Mat;

        public Matrix(double[,] a)
        {
            Mat = a;
        }
        
        //Operators
        public static Matrix operator +(Matrix a, Matrix b)
        {
            
            if ((a.Mat.GetLength(0)==b.Mat.GetLength(0)) && (a.Mat.GetLength(1) == b.Mat.GetLength(1)))
            {
                int xt = a.Mat.GetLength(0);
                int yt = a.Mat.GetLength(1);
                double[,] temp;
                temp = new double[xt, yt];

                for (int x = 0; x < xt; x++)
                {
                    for (int y = 0; y < yt; y++)
                    {
                        temp[x, y] = 0;
                    }
                }

                
                for(int x = 0; x < a.Mat.GetLength(0); x++)
                {
                    for (int y = 0; y < a.Mat.GetLength(1); y++)
                    {
                        temp[x,y] = a.Mat[x, y] + b.Mat[x, y];
                    }
                }

                Matrix c = new Matrix(temp);
                return c;
            }

            else
            {
                return null;
            }
        }
    }
}
