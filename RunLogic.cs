using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionErrorHandling
{
    public class RunLogic
    {
        public Logic Logic { get; set; }
        public RunLogic(Logic logic)
        {
            Logic = logic;
        }


        public int RunLogic1(int[] numbers)
        {
            if (numbers == null) 
            {
                throw new ScubaException("array number cannot be null value", 7);            }
            if (numbers.Length == 0) 
            {
                throw new ScubaException("array number cannot be empty", 7);
            }
        
            return Logic.Logic1(numbers);
        }

        public void RunLogic2(string inputFileName, string outputFileName)
        {
            try
            {

                Logic.Logic2(inputFileName, outputFileName);
            }
            catch (ArgumentException argumnetError) {
                Console.WriteLine($"filename cannot be empty :  {argumnetError.Message}");
                throw;
            }
            catch (FileNotFoundException fileNotExistError)
            {
                Console.WriteLine($"The filename is not exist : {fileNotExistError.Message}");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed when RunLogic2 : {e.Message}");
                throw;
            }


        }

        public int RunLogic3(string data)
        {
            int number;
            if (!int.TryParse(data, out number)) 
            {
                throw new ScubaException($"data : {data} must be string number",7);
            }
            return Logic.Logic3(data);
        }

        public void RunLogic4(string data1, int data2, long data3)
        {
            try
            {
                Logic.Logic4(data1, data2, data3);
            }
            catch (NotImplementedException notImplementedException) {
                Console.WriteLine($"The function is not implementes : {notImplementedException.Message}");
                throw;
            }
            catch (Exception e) {
                Console.WriteLine($"The to Run RunLofic4 due to error : {e.Message}");
                throw;
            }
        }

        public void RunLogic5(string dllName)
        {
            try
            {
                Logic.Logic5(dllName);
            }
            catch (ArgumentException argumnetError)
            {
                Console.WriteLine($"dll {dllName} value cannot be empty :  {argumnetError.Message}");
                throw;
            }
            catch (FileNotFoundException fileNotExistError)
            {
                Console.WriteLine($"The dll {dllName} is not exist : {fileNotExistError.Message}");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed Load dll {dllName} : {e.Message}");
                throw;
            }
        }
    }
}
