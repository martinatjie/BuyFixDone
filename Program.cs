// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello SQLite!");

            using (var context = new TodoDbContext())
            {
                context.Database.EnsureCreated();

                var newTodo = new TodoItem
                {
                    Description = "Buy groceries",
                    IsCompleted = false
                };

                context.TodoItems.Add(newTodo);
                context.SaveChanges();

                var todos = context.TodoItems.ToList();

                foreach (var todo in todos)
                {
                    Console.WriteLine($"Todo: {todo.Description} (Completed: {todo.IsCompleted})");
                }
            }