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

            if ((a.Mat.GetLength(0) == b.Mat.GetLength(0)) && (a.Mat.GetLength(1) == b.Mat.GetLength(1)))
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


                for (int x = 0; x < a.Mat.GetLength(0); x++)
                {
                    for (int y = 0; y < a.Mat.GetLength(1); y++)
                    {
                        temp[x, y] = a.Mat[x, y] + b.Mat[x, y];
                    }
                }

                Matrix c = new Matrix(temp);
                return c;

            }

            else
            {
                Console.WriteLine("Something went wrong :(");
                return null;
            }
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {

            if ((a.Mat.GetLength(0) == b.Mat.GetLength(0)) && (a.Mat.GetLength(1) == b.Mat.GetLength(1)))
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


                for (int x = 0; x < a.Mat.GetLength(0); x++)
                {
                    for (int y = 0; y < a.Mat.GetLength(1); y++)
                    {
                        temp[x, y] = a.Mat[x, y] - b.Mat[x, y];
                    }
                }

                Matrix c = new Matrix(temp);
                return c;
            }

            else
            {
                Console.WriteLine("Something went wrong :(");
                return null;
            }
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {

            if (a.Mat.GetLength(1) == b.Mat.GetLength(0))
            {
                int xt = a.Mat.GetLength(0);
                int yt = b.Mat.GetLength(1);
                double[,] temp;
                temp = new double[xt, yt];

                for (int x = 0; x < xt; x++)
                {
                    for (int y = 0; y < yt; y++)
                    {
                        temp[x, y] = 0;
                    }
                }


                for (int x = 0; x < xt; x++)
                {
                    for (int y = 0; y < yt; y++)
                    {
                        for (int i = 0; i < a.Mat.GetLength(1); i++)
                        {
                            temp[x, y] += a.Mat[x, i] * b.Mat[i, y];
                        }
                    }
                }

                Matrix c = new Matrix(temp);
                return c;
            }

            else
            {
                Console.WriteLine("Something went wrong :(");
                return null;
            }
        }

        public static Matrix operator -(Matrix a)
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


            for (int x = 0; x < a.Mat.GetLength(0); x++)
            {
                for (int y = 0; y < a.Mat.GetLength(1); y++)
                {
                    temp[x, y] = -a.Mat[x, y];
                }
            }

            Matrix c = new Matrix(temp);
            return c;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            int kontrola = 0;
            if ((a.Mat.GetLength(0) == b.Mat.GetLength(0)) && (a.Mat.GetLength(1) == b.Mat.GetLength(1)))
            {
                kontrola = 1;
                for (int x = 0; x < a.Mat.GetLength(0); x++)
                {
                    for (int y = 0; y < a.Mat.GetLength(1); y++)
                    {
                        if (a.Mat[x, y] != b.Mat[x, y])
                        {
                            kontrola++;
                        }
                        else
                        {

                        }
                    }
                }
            }

            if (kontrola == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            int kontrola = 0;
            if ((a.Mat.GetLength(0) == b.Mat.GetLength(0)) && (a.Mat.GetLength(1) == b.Mat.GetLength(1)))
            {
                kontrola = 1;
                for (int x = 0; x < a.Mat.GetLength(0); x++)
                {
                    for (int y = 0; y < a.Mat.GetLength(1); y++)
                    {
                        if (a.Mat[x, y] != b.Mat[x, y])
                        {
                            kontrola++;
                        }
                        else
                        {

                        }
                    }
                }
            }

            if (kontrola == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double Det(Matrix a)
        {
            double det3_1 = 1;
            double det3 = 0;
            if (a.Mat.GetLength(0)==a.Mat.GetLength(1))
            {
                if(a.Mat.GetLength(0) == 1)
                {
                    return a.Mat[0, 0];
                }
                else if (a.Mat.GetLength(0) == 2)
                {
                    return (a.Mat[0, 0]*a.Mat[1,1] - a.Mat[0,1]*a.Mat[1,0]);
                }
                else if (a.Mat.GetLength(0) == 3)
                {
                    int xt = a.Mat.GetLength(0);
                    int yt = a.Mat.GetLength(1);
                    double[,] temp;
                    temp = new double[xt+2, yt];

                    for (int x = 0; x < xt; x++)
                    {
                        for (int y = 0; y < yt; y++)
                        {
                            temp[x, y] = a.Mat[x, y];
                        }
                    }

                    //zkopírování prvních dvou řádků
                    for (int x = 0; x < 2; x++)
                    {
                        for (int y = 0; y < yt; y++)
                        {
                            temp[x+3, y] = a.Mat[x, y];
                        }
                    }

                    //kladné členy
                    for (int i=0; i<3; i++)
                    {
                        for(int j=0; j<3; j++)
                        {
                            det3_1 = det3_1 * temp[i + j, j];
                        }
                        det3 = det3 + det3_1;
                        det3_1 = 1;
                    }

                    //záporné členy
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            det3_1 = det3_1 * temp[i + j, 2 - j];
                        }
                        det3 = det3 - det3_1;
                        det3_1 = 1;
                    }
                    return det3;
                }
                else
                {
                    Console.WriteLine("Something went wrong :(");
                    return 2147483647;
                }
            }
            else
            {
                Console.WriteLine("Something went wrong :(");
                return 2147483647;
            }
        }

        public override string ToString()
        {
            int xt = Mat.GetLength(0);
            int yt = Mat.GetLength(1);
            string output = null;

            for (int x = 0; x < xt; x++)
            {
                for (int y = 0; y < yt; y++)
                {
                    output = output + Mat[x, y] + "\t";
                }
                output = output + "\n";
            }

            return output;
        }
    }
}

