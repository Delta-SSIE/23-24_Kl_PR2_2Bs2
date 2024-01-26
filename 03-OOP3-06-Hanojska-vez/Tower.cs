using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_06_Hanojska_vez
{
    internal class Tower
    {
        public int Size { get; }

        private Stack<int> _leftPin = new Stack<int>();
        private Stack<int> _middlePin = new Stack<int>();
        private Stack<int> _rightPin = new Stack<int>();
        public Tower(int size)
        {
            Size = size;

            for (int i = Size; i > 0; i--)
            {
                _leftPin.Push(i);
            }
        }
        public bool Move(int from, int to)
        {
            Stack<int> pinFrom, pinTo;
            try {
                pinFrom = GetPinByNo(from);
                pinTo = GetPinByNo(to);
            }
            catch
            {
                return false;
            }

            if (pinFrom.Count < 1) //není co brát
                return false;

            if (pinTo.Count > 0 && pinFrom.Peek() > pinTo.Peek()) //dal bych větší na menší
                return false;

            int disc = pinFrom.Pop();
            pinTo.Push(disc);
            return true;
        }
        private Stack<int> GetPinByNo(int number)
        {
            return number switch
            {
                0 => _leftPin,
                1 => _middlePin,
                2 => _rightPin,
                _ => throw new ArgumentOutOfRangeException(nameof(number)),
            };
        }
        public void Dump()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + ":");
                int[] pin = GetPinByNo(i).ToArray();

                for (int j = pin.Length - 1; j >= 0; j--) {
                    int disc = pin[j];
                    Console.Write(disc + " ");
                }
                Console.WriteLine();
            }
        }

        public void Render()
        {
            int baseY = Console.CursorTop + 1;

            for (int i = 0; i < 3; i++)
            {
                int baseX = 2 * i * (Size + 1) + 1;

                Stack<int> pin = GetPinByNo(i);
                RenderPin(pin, baseX, baseY);
            }


        }

        private void RenderPin(Stack<int> pin, int x, int topY)
        {
            int y = topY;

            int emptyRows = Size - pin.Count;
            for (int i = 0; i < emptyRows; i++)
            {
                RenderDisc(0, x, y);
                y++;
            }
            foreach (int disc in pin)
            {
                RenderDisc(disc, x, y);
                y++;
            }
            RenderBase(x, y);


        }
        private void RenderDisc(int disc, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            if (disc > 0)
            {
                Console.Write(new string(' ', Size - disc));
                Console.Write(new string('#', 2 * disc - 1));
            }
            else
            {
                Console.Write(new string(' ', Size - 1));
                Console.Write('|');
            }
        }
        private void RenderBase(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string('=', 2 * Size - 1));
        }

        
    }
}
