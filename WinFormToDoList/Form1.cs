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

        //MINUT 39:14 DEL VIEDEO

        public toDoMainform()
        {
            InitializeComponent();

            todoListBox.DataSource = todoList;
            todoListBox.DisplayMember = nameof(ToDoItemModel.TodoDisplay);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (currentEdit == null)
            {
                AddTodo(todoText.Text);
            }
            else
            {
                CompleteEdit();
            }

            todoText.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;
                StartEdit(todo);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;
                Remove(todo);
            }
        }

        private void todoListBox_DoubleClick(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;
                CompleteItem(todo);
            }
        }
    }
}
