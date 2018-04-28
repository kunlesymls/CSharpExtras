using DatabaseFirst.Models;
using System;
using System.Linq;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();

            //Adding  data to databse 

            Console.WriteLine("Did you want to add todo");

            Console.WriteLine("Please type how many todo you want to add");
            int count = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please Type your todo");
                string todoItem = Console.ReadLine();

                var todo = new Todo()
                {
                    Text = todoItem,
                    CreatedAt = DateTime.Now
                };
                // Adding data and saving to database
                db.Todo.Add(todo);
            }

            db.SaveChanges();


            var todoList = db.Todo.ToList();
            foreach (var item in todoList)
            {
                Console.WriteLine($"Todo Name: {item.Text}   -- Created At:  {item.CreatedAt}");
            }
        }
    }
}

