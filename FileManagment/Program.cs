﻿using FileManagment.Model;

namespace FileManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<char> fileList = new DLList<char>();
            int totalCharsCount = 0;
            char ch;
            string filePath = @"C:\tmp\file.txt";
            int ordinal;
            GenericNode<char>? node;


            try
            {
                using StreamReader reader = new StreamReader(filePath);

                while ((ordinal = reader.Read()) != -1)
                {
                    ch = (char)ordinal;
                    if (Convert.ToInt32(ch) == 13 || Convert.ToInt32(ch) == 10)     // CR or LF
                    {
                        reader.Read();
                        continue;
                    }

                    node = fileList.GetPosition(ch);
                    if (node == null)
                    {
                        fileList.InsertLast(ch);
                    }
                    fileList.IncreaseCount(node);
                }

                fileList.SortByCount();
                fileList.Traverse(totalCharsCount);
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
