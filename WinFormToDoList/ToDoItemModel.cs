using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToDoList
{
    public class ToDoItemModel
    {
        public int PositionNumber { get; set; }
        public string TodoText { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}
