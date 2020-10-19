using System;

namespace TheCommandDemo
{
    interface Command
    {
        void Execute();
    }

    class JoyStickInvoker
    {
        Command _command;
        public void setCommand(Command command)
        {
            _command = command;
        }

        public void DoAction()
        {
            _command.Execute();
        }
    }
    class LongPase : Command
    {
        PlayerRevicer player = new PlayerRevicer();
        public void Execute()
        {
            player.DoLongPass();
        }
    }

    class Tackling : Command
    {
        PlayerRevicer player = new PlayerRevicer();
        public void Execute()
        {
            player.DoTakling();
        }
    }


    class PlayerRevicer
    {
       public bool HasBall()
        {
            return true;
        }

        public void DoLongPass()
        {
            Console.WriteLine("im player, im doing long pass");
        }

        public void DoTakling()
        {
            Console.WriteLine("im player, im doing a takling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JoyStickInvoker joyStickInvoker = new JoyStickInvoker();

            PlayerRevicer playerRevicer = new PlayerRevicer();

            if (playerRevicer.HasBall())
            {
                joyStickInvoker.setCommand(new LongPase());
            }
            else
            {
                joyStickInvoker.setCommand(new Tackling());
            }

            joyStickInvoker.DoAction();
        }
    }
}
