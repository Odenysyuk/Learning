using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void output(char[][] ja, int size) {
            for (Int32 i = 0; i < size; i++)
            {
                foreach (char el in ja[i])
                {
                    Console.Write(el);
                }
                Console.WriteLine();

            }
        }


        static void Main(string[] args)
        {
            //Завдання 3.Створити рваний масив типу char та заповнити його *, результат має відповідати:

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            char[][] ja = new char[7][];

            for(Int32 i =1; i <= 7 ; i++)
            {
                ja[i-1] = new char[i];
                for (Int32 j = 0; j < i; j++) {
                    ja[i-1][j] = '*';
                }

            }

            output(ja, 7);

            //Створити рваний масив типу char та заповнити його зірочками та пропусками, результат має відповідати:

            //*******
            //******
            //*****
            //****
            //***
            //**
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            Console.WriteLine();

            char[][] ja_2 = new char[13][];

            Int32 counter = 0;

            for (Int32 i = 0; i < 13; i++)
            {
               
                ja_2[i] = new char[7];

                for (Int32 j = 0; j < 7; j++)
                {
                    Int32 Dev = (counter < 2)? counter: counter/ 2;
           
                    if(j < Dev && j < 4)
                        ja_2[i][j] = ' ';
                    else if(7 - (counter -Dev) <=j && j >= 4)
                        ja_2[i][j] = ' ';
                    else
                        ja_2[i][j] = '*';                  
                }

                if (i >= 6)
                    --counter;
                else
                    ++counter;

            }

            output(ja_2, 13);


        }


    }
}
