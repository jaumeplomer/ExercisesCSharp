using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormToDoList
{
    public partial class toDoMainform : Form
    {
        BindingList<ToDoItemModel> todoList = new BindingList<ToDoItemModel>();
        ToDoItemModel currentEdit = null;
        public toDoMainform()
        {
            InitializeComponent();
        }

        private void AddTodo(string todoText)
        {
            ToDoItemModel todo = new ToDoItemModel
            {
                PositionNumber = todoList.Count + 1,
                TodoText = todoText
            };

            todoList.Add(todo);
        }

        private void Reorder()
        {
            for(int i = 0; i < todoList.Count; i++)
            {
                todoList[i].PositionNumber = (i + 1);
            }
        }

        private void Remove(ToDoItemModel todo)
        {
            todoList.Remove(todo);
            Reorder();
        }

        private void StartEdit(ToDoItemModel todo)
        {
            currentEdit = todo;
            todoLabel.Text = "Update ToDo Item";
            addButton.Text = "Edit ToDo Item";
            todoText.Text = currentEdit.TodoText;
        }

        private void CompleteEdit()
        {
            currentEdit.TodoText = todoText.Text;
            currentEdit = null;
            todoLabel.Text = "New ToDo Item";
            addButton.Text = "Add ToDo Item";
        }

        private void CompleteItem(ToDoItemModel todo)
        {
            todo.IsComplete = true;
        }
    }
}
