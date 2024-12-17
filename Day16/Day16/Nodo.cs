using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    internal class Nodo : IEquatable<Nodo>
    {

        public int X { get; private set; }
        public int Y { get; private set; }

        public int directionX { get; private set; }
        public int directionY { get; private set; }


        // Constructor
        public Nodo(int x, int y, int[] direction)
        {
            this.X = x;
            this.Y = y;
            this.directionX = direction[0];
            this.directionY = direction[1];
        }

        public Nodo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Método para comparar dos nodos por sus coordenadas
        public bool Equals(Nodo other)
        {
            if (other == null)
                return false;
            return X == other.X && Y == other.Y && directionX==other.directionX && directionY==other.directionY;
        }

        // Sobrescribe GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, directionX, directionY);
        }

        // Sobrescribe Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Nodo)obj);
        }

        // Método ToString opcional para depuración y visualización
        public override string ToString()
        {
            return $"Nodo({X}, {Y})";
        }
    }
}
