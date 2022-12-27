using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Beginning
{
    class FileIO
    {
        public void runner()
        {
            Console.WriteLine("*******************************************************************\n");
            int count = -1;
            string path = @"C:\Users\chad.moore\source\repos\Beginning\test.txt";
            //IF file does not exist, create a new one with some filler information
            if(!File.Exists(path))
            {
                //Create file to write and read from
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello, this is the start of the test");
                    sw.Write("This line will not have a return until one is put in it. ");
                    sw.Write(" Notice how \n this jumps in the middle.\n");
                    sw.Close();
                }
            }

            try
            {
                //find the end character to edit it.
                StreamReader read = File.OpenText(path);
                string l = read.ReadLine();
                while (l != null)
                {
                    try
                    {
                        count = Convert.ToInt32(l);
                        Console.WriteLine("Count: " + count);
                        count++;
                    }
                    catch (Exception e)
                    {
                        l = read.ReadLine();
                        continue;
                    }
                    l = read.ReadLine();
                }
                read.Close();
                //Append text and add the access counter
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("We are now appending lines to the text file");
                    if (count == -1)
                        sw.WriteLine("0");
                    else
                        sw.WriteLine("" + count);
                    sw.Close();
                }
            }

            catch (Exception e)
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\chad.moore\source\repos\Beginning\logging.txt"))
                {
                    sw.WriteLine(e);
                    sw.Close();
                }
            }

            finally
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
                Console.WriteLine("*******************************************************************\n");
            }
            /*
            string writeText = "THIS IS THE TEXT IN THE FILE\n";
            File.WriteAllText("filename.txt", writeText);
            File t = File.AppendText("filename.txt");
            File.AppendText("filename.txt", writeText);
            File.WriteAllText("filename.txt", writeText);
            File.WriteAllText("filename.txt", writeText);
            string reader = File.ReadAllText("filename.txt");
            Console.WriteLine(reader);*/
        }
    }
}
