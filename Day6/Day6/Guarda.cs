using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Guarda
    {
        public static Boolean GeneraBucle(int[] posicionOriginal, int[] direccionInicial, int[] posicionObstaculo, List<List<string>> mapa)
        {
            Boolean isBucle = false;

            int dosBucles = 0;

            int[] posicionActual = (int[])posicionOriginal.Clone();
            int[] direccionActual = (int[])direccionInicial.Clone();
            //Clonar 
            List<List<string>> thisMap = new List<List<string>>();
            foreach (var item in mapa)
            {
                thisMap.Add(new List<string>(item));
            }
            thisMap[posicionObstaculo[0]][posicionObstaculo[1]] = "#";

            int[][] directionsSort = new int[][] { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };
            foreach (var item in directionsSort)
            {
                if (direccionActual[0] == item[0] && direccionActual[1] == item[1])
                {
                    direccionActual = item;
                    break;
                }
            }

            List<List<string>> posicionesPasadas = new List<List<string>>();
            for (int i = 0; i < 4; i++) {
                posicionesPasadas.Add(new List<string>());
            }

            try
            {
                while (!isBucle)
                {
                    try
                    {
                        //Comprobar si la dirección es válida
                        Boolean canMove = false;
                        while (!canMove)
                        {
                            int[] nextPosition = new int[] { posicionActual[0] + direccionActual[0], posicionActual[1] + direccionActual[1] };
                            //Comprobar
                            if (thisMap[nextPosition[0]][nextPosition[1]] == "#")
                            {
                                //Girar a la derecha
                                direccionActual = directionsSort[(Array.IndexOf(directionsSort, direccionActual) + 1) % 4];
                            }
                            else
                            {
                                canMove = true;
                            }
                        }
                        //Guardar ubicación
                        //Compraobar si la ubicación ya fue guardad
                        if (!posicionesPasadas[Array.IndexOf(directionsSort, direccionActual)].Contains($"{posicionActual[0]},{posicionActual[1]}"))
                        {
                            posicionesPasadas[Array.IndexOf(directionsSort, direccionActual)].Add($"{posicionActual[0]},{posicionActual[1]}");
                        }
                        else
                        {
                           
                                isBucle = true;
                            
                            
                        }

                        //Mover
                        posicionActual[0] += direccionActual[0];
                        posicionActual[1] += direccionActual[1];
                    }//Controlar si se sale del mapa
                    catch (Exception e)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
               
            }

            return isBucle;
        }
    }
}
