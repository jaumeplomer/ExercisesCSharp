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

        private void MoveItemUp(ToDoItemModel todo)
        {
            if (todo.PositionNumber == 1)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber - 2, todo);
            Reorder();
        }

        private void MoveItemDown(ToDoItemModel todo)
        {
            if (todo.PositionNumber == todoList.Count)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber, todo);
            Reorder();
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

        private void todoListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void todoListBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
                case Keys.Up:
                    e.IsInputKey = true;
                    break;
                default:
                    break;
            }
        }

        private void todoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                ToDoItemModel todo = (ToDoItemModel)todoListBox.SelectedItem;

                switch (e.KeyCode)
                {
                    case Keys.Down:
                        MoveItemDown(todo);
                        break;
                    case Keys.Up:
                        MoveItemUp(todo);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
