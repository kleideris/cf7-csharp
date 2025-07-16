using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Model
{
    internal class MovingSpace
    {
        private readonly IMovable? _movable;

        public MovingSpace(IMovable? movable)
        {
            _movable = movable;
        }

        public void MakeMove15()
        {
            _movable!.Move15();
        }
    }
}
