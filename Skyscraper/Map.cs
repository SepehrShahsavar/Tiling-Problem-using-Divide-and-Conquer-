using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyscraper
{
    public class Map
    {
        public void Mapper(int[,] map ,int size , int x , int y , int xBorder1 , int xBorder2 , int yBorder1 , int yBorder2)
        {
            int a = (size / 2) - 1;
            int b = size / 2;
            int c = size - 1;
            if (size == 2)
            {
                if ( x==xBorder1 && y == yBorder1)
                {
                    map[xBorder1 , yBorder2] = 8;
                    map[xBorder2 , yBorder2] = 8;
                    map[xBorder2 , yBorder1] = 8;
                }

                if (x == xBorder1 && y == yBorder2)
                {
                    map[xBorder1 , yBorder1] = 7;
                    map[xBorder2 , yBorder2] = 7;
                    map[xBorder2 , yBorder1] = 7;
                }

                if (x == xBorder2 && y == yBorder1)
                {
                    map[xBorder1 , yBorder1] = 6;
                    map[xBorder1 , yBorder2] = 6;
                    map[xBorder2 , yBorder2] = 6;
                }

                if (x == xBorder2 && y == yBorder2)
                {
                    map[xBorder1 , yBorder1] = 5;
                    map[xBorder1 , yBorder2] = 5;
                    map[xBorder2 , yBorder1] = 5;
                }
                return;
            }

            if (x <= a + xBorder1)
            {
                if (y <= a + yBorder1)
                {
                    map[a + xBorder1 , b + yBorder1] = 4;
                    map[b + xBorder1 , b + yBorder1] = 4;
                    map[b + xBorder1 , a + yBorder1] = 4;    
                    Mapper(map , size / 2 , x , y , 0 + xBorder1, a + xBorder1 , 0 + yBorder1 , a + yBorder1);
                    Mapper(map , size / 2 , a + xBorder1, b + yBorder1, 0 + xBorder1, a + xBorder1 , b + yBorder1 , c + yBorder1);
                    Mapper(map , size / 2 , b + xBorder1, b + yBorder1, b + xBorder1, c + xBorder1 , b + yBorder1 , c + yBorder1);
                    Mapper(map , size / 2 , b + xBorder1, a + yBorder1, b + xBorder1, c + xBorder1 , 0 + yBorder1 , a + yBorder1);
                }
                else
                {
                    map[a + xBorder1 , a + yBorder1] = 3;
                    map[b + xBorder1 , b + yBorder1] = 3;
                    map[b + xBorder1 , a + yBorder1] = 3;
                    Mapper(map, size / 2 , x , y , 0 + xBorder1, a + xBorder1, b + yBorder1, c + yBorder1);
                    Mapper(map, size / 2 , a + xBorder1, a + yBorder1, 0 + xBorder1, a + xBorder1, 0 + yBorder1, a + yBorder1);
                    Mapper(map, size / 2 , b + xBorder1, b + yBorder1, b + xBorder1, c + xBorder1, b + yBorder1, c + yBorder1);
                    Mapper(map, size / 2 , b + xBorder1, a + yBorder1, b + xBorder1, c + xBorder1, 0 + yBorder1, a + yBorder1);
                }
            }
            else
            {
                if (y <= a + yBorder1)
                {
                    map[a + xBorder1, a + yBorder1] = 1;
                    map[b + xBorder1, b + yBorder1] = 1;
                    map[a + xBorder1, b + yBorder1] = 1;
                    Mapper(map, size / 2 , x , y , b + xBorder1, c + xBorder1, 0 + yBorder1, a + yBorder1);
                    Mapper(map, size / 2 , a + xBorder1, a + yBorder1, 0 + xBorder1, a + xBorder1, 0 + yBorder1, a + yBorder1);
                    Mapper(map, size / 2 , b + xBorder1, b + yBorder1, b + xBorder1, c + xBorder1, b + yBorder1, c + yBorder1);
                    Mapper(map, size / 2 , a + xBorder1, b + yBorder1, 0 + xBorder1, a + xBorder1, b + yBorder1, c + yBorder1);
                }
                else
                {
                    map[a + xBorder1, a + yBorder1] = 2;
                    map[b + xBorder1, a + yBorder1] = 2;
                    map[a + xBorder1, b + yBorder1] = 2;
                    Mapper(map, size / 2 , x , y , b + xBorder1, c + xBorder1, b + yBorder1, c + yBorder1);
                    Mapper(map, size / 2 , a + xBorder1, a + yBorder1, 0 + xBorder1, a + xBorder1, 0 + yBorder1, a + yBorder1);
                    Mapper(map, size / 2 , b + xBorder1, a + yBorder1, b + xBorder1, c + xBorder1, 0 + yBorder1, a + yBorder1);
                    Mapper(map, size / 2 , a + xBorder1, b + yBorder1, 0 + xBorder1, a + xBorder1, b + yBorder1, c + yBorder1);
                }
            }
        }
    }
}
