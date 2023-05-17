using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CPU
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1- The program starts by creating an instance of the Simulator class.
                2- The Simulator class constructor takes four parameters:
                    - processorInitializer: an instance of the ProcessorInitializer class.
                    - tasksPriorityHandler: an instance of the TasksPriorityHandler class.
                    - scheduler: an instance of the Scheduler class.
                    - outputFile: an instance of the OutputFile class.
                3- The Simulator class has a Start method that starts the simulation process.
                4- The Start method calls the InitializeProcessors method of the processorInitializer object to initialize the processors.
                5- The Start method calls the InitializeTasks method of the tasksPriorityHandler object to initialize the tasks.
                6- The Start method calls the ScheduleTasks method of the scheduler object to schedule the tasks.
                7- The Start method calls the WriteOutput method of the outputFile object to write the output to the output file.
            */

            IProcessorInitializer processorInitializer = new ProcessorInitializer();
            ITasksPriorityHandler tasksPriorityHandler = new TasksPriorityHandler();
            Scheduler scheduler = new Scheduler();
            OutputFile outputFile = new OutputFile();

            Simulator simulator = new Simulator(processorInitializer, tasksPriorityHandler, scheduler, outputFile);
            simulator.Start();
        }
    }


}