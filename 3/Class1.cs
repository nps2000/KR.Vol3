using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Class1
    {
        public class SuperLinkedList<T> : LinkedList<T>
        {
            

            public void Remove(SuperLinkedList<T> element, T el)
            {
                if ( element.Count == 0)
                {
                    throw new Exception("НЕТ ЭЛЕМЕТОВ В SuperLinkedList!!");
                }
                element.Remove(el);
            }

        }

        
        public class Trainer
        {
            public event EventHandler Up;
            public void ComandUp()
            {
                Console.WriteLine("Всем встать на дыбы!");
                if (Up != null)
                    Up(this, null);
            }
            
        }
        public class Horse
        {
            
            public void OnUp(object sebder, EventArgs e)
            {
                
                Console.WriteLine("Лошадь " + "стала на дыбы");
            } 
            
        }


        
            


    static void Main()
        {
            try
            {
                SuperLinkedList<string> A = new SuperLinkedList<string>();
                A.AddLast("1234256");
                A.AddLast("123");
                A.AddLast("347");
                A.Remove("123");
                IEnumerable<string> Length = from n in A
                                             where n.Length < 6
                                             select n;
                
                foreach (string i in Length)
                {
                    Console.WriteLine(i);
                }

                Trainer trainer = new Trainer();
                Horse H1 = new Horse();
                Horse H2 = new Horse();
                Horse H3 = new Horse();
                trainer.Up += H1.OnUp;
                trainer.Up += H2.OnUp;
                trainer.Up += H3.OnUp;
                trainer.ComandUp();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

