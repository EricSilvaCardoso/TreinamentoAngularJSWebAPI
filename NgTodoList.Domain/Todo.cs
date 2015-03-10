using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgTodoList.Domain
{
    public class Todo
    {
        protected Todo() { }

        public Todo(string title)
            : this(title, 0)
        { }

        public Todo(string title, int userId)
        {
            if(title.Length > 3)
                throw new Exception("Título Inválido");

            this.Id = 0;
            this.Title = title;
            this.Done = false;
            this.UserId = userId;
        }

        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public bool Done { get; protected set; }
        public int UserId { get; protected set; }

        public void MarkAsDone()
        {
            this.Done = true;
        }

        public void MarkAsUndone()
        {
            this.Done = false;
        }
    
    }
}
