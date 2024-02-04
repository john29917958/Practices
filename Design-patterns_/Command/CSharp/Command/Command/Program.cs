using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.AddCreateCommand("John");
            Console.WriteLine("============Step1============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            controller.ExecuteNext();
            Console.WriteLine("============Step2============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            controller.AddMoveToCommand(controller.Characters[0], 3, 3);
            Console.WriteLine("============Step3============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            controller.ExecuteNext();
            Console.WriteLine("============Step4============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            controller.Undo();
            Console.WriteLine("============Step5============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            controller.CancelLast();
            Console.WriteLine("============Step6============" + Environment.NewLine + controller + Environment.NewLine + "=============================" + Environment.NewLine);

            Console.ReadLine();
        }
    }
}
