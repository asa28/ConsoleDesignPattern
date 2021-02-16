using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDesignPattern1
{
    public class User
    {
        #region Fields
        // Fields (Attributes)
        public string Name { get; set; }
        public int Id { get; set; }
        #endregion

        #region Constructors
        //Constructors
        public User() {}
        public User(string name)
        {
            this.Name = name;
        }
        public User(int id)
        {
            this.Id = id;
        }
        public User(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        #endregion

        #region Methods
        //Methods
        public void sayHello()
        {
            Console.WriteLine("Hello World Again.");
        }
        #endregion
    }
}
