using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    class Board
    {
        public Board(int size)
        {
            Size = size;
            Cells = new List<Cell>();
            for (int i = 0; i < size * size; ++i) {
                Cells.Add(new Cell(i));
            }
        }

        public int Size
        {
            get; set;
        }

        public List<Cell> Cells
        {
            get; private set;
        }
    }
}
