using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup the classes (dependency injection)
            //TopLevel topLevel = new TopLevel();
            //MiddleLevel middleLevel = new MiddleLevel(topLevel);
            //BottomLevel bottomLevel = new BottomLevel(middleLevel);

            ////set up the handler
            //Handler h = new Handler(topLevel);

            ////using this will not link to 'Handler' as there is no relation between this bottom and top
            ////BottomLevel bottomLevel = new BottomLevel(); 

            ////trigger the bottom class
            //bottomLevel.TriggerBottom();
            ////or
            //bottomLevel.DoSomething(null, "call from main");

            //Console.ReadLine();


            string exitName = "exit";
            Console.Write($"hello Player what is your name? (to skip the while loop you must type {exitName}) {Environment.NewLine}");
            String Name = Console.ReadLine();

            while (Name != exitName)//while the name does not equal 'exit' you will stay in the loop
            {
                Console.WriteLine("You did not exit!");
                Console.WriteLine($"You entered {Name} you must enter {exitName} to exit this loop!");
                Name = Console.ReadLine();
            }

            Console.WriteLine("press any key to end game");
            Console.ReadLine();
        }
    }



    public class Handler
    {
        TopLevel _topLevel;
        public Handler(TopLevel topLevel)
        {
            if (topLevel != null)
                _topLevel = topLevel;

            _topLevel.Message += _topLevel_Message;
        }

        private void _topLevel_Message(object sender, string e)
        {
            Console.WriteLine($"handler triggered : {e}");
        }
    }

    public class TopLevel
    {
        public event EventHandler<string> Message;

        public TopLevel()
        { }

        public void TriggerTop()
        {
            Message?.Invoke(this, "origin top");
        }

        public void DoSomething(object sender, string e)
        {
            Console.WriteLine($"Do something at top : {e}");
            Message?.Invoke(this, e);
        }
    }

    public class MiddleLevel
    {
        TopLevel _TopLevel;
        public event EventHandler<string> Message;

        public MiddleLevel(TopLevel topLevel) : this()
        {
            _TopLevel = topLevel;
        }
        public MiddleLevel()
        {
            if (_TopLevel == null)
                _TopLevel = new TopLevel();
            //subscribe this message to bottom message event method
            Message += (s, e) => { _TopLevel.DoSomething(s, e); };
        }

        public void TriggerMiddle()
        {
            Message?.Invoke(this, "origin middle");
        }

        public void DoSomething(object sender, string e)
        {
            Console.WriteLine($"do something in middle : {e}");

            //invoke the event(s)        
            Message?.Invoke(sender, e);
        }
    }

    public class BottomLevel
    {
        MiddleLevel _MidLevel;
        public event EventHandler<string> Message;

        public BottomLevel(MiddleLevel midLevel) : this()
        {
            _MidLevel = midLevel;
        }

        public BottomLevel()
        {
            if (_MidLevel == null)
                _MidLevel = new MiddleLevel();

            ////here you assign it
            Message += (s, e) => { _MidLevel.DoSomething(s, e); };

        }

        public void TriggerBottom()
        {
            DoSomething(this, "origin bottom");
        }

        public void DoSomething(object sender, string e)
        {
            Console.WriteLine($"do something at bottom : {e}");
            Message?.Invoke(sender, e);
        }
    }


}