/*
 * CS 4242
Cameron Gibson
000582604
Assignment 4
4/16/19
CG
Score"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronNN
{
    class Program
    {
        static int[] CollectionImagesArray = new int[16];
        static List<int> CollectionImagesList = new List<int>();
        //int[] Image = new int[4];
        static double weight = 0.75;

        //0 = white, 1 = black pixel
        //probably should have flipped values and meaning
        static double[] Image_1 = { 0, 0, 0, 0 }; //bright
        static double[] Image_2 = { 0, 1, 0, 0 }; //bright
        static double[] Image_3 = { 0, 1, 1, 0 }; //bright
        static double[] Image_4 = { 0, 1, 1, 1 }; //dark
        static double[] Image_5 = { 1, 1, 1, 1 }; //dark
        static double[] Image_6 = { 1, 0, 1, 0 };//bright
        static double[] Image_7 = { 1, 1, 0, 1 }; //dark
        static double[] Image_8 = { 1, 1, 1, 1 };
        static double[] Image_9 = { 1, 0, 0, 1 };
        static double[] Image_10 = { 1, 1, 1, 0 };
        static double[] Image_11 = { 0, 0, 0, 1 };
        static double[] Image_12 = { 1, 1, 1, 1 };
        static double[] Image_13 = { 1, 0, 1, 1 };
        static double[] Image_14 = { 1, 0, 1, 1 };
        static double[] Image_15 = { 1, 1, 0, 1 };
        static double[] Image_16 = { 0, 0, 0, 1 };

        static void Main(string[] args)
        {
            Console.WriteLine("Image 1");
            CalculateImagePixels(Image_1);
            Console.WriteLine("Image 2");
            CalculateImagePixels(Image_2);
            Console.WriteLine("Image 3");
            CalculateImagePixels(Image_3);
            Console.WriteLine("Image 4");
            CalculateImagePixels(Image_4);

            Console.WriteLine("Image 5");
            CalculateImagePixels(Image_5);
            Console.WriteLine("Image 6");
            CalculateImagePixels(Image_6);
            Console.WriteLine("Image 7");
            CalculateImagePixels(Image_7);
            Console.WriteLine("Image 8");
            CalculateImagePixels(Image_8);

            Console.WriteLine("Image 9");
            CalculateImagePixels(Image_9);
            Console.WriteLine("Image 10");
            CalculateImagePixels(Image_10);
            Console.WriteLine("Image 11");
            CalculateImagePixels(Image_11);
            Console.WriteLine("Image 12");
            CalculateImagePixels(Image_12);

            Console.WriteLine("Image 13");
            CalculateImagePixels(Image_13);
            Console.WriteLine("Image 14");
            CalculateImagePixels(Image_14);
            Console.WriteLine("Image 15");
            CalculateImagePixels(Image_15);
            Console.WriteLine("Image 16");
            CalculateImagePixels(Image_16);
            Console.Read();
            
        }

        //static void GenerateImages()
        //{
            //Random random = new Random();
            //for (int i = 0; i<4; i++)
            //{
            //    int randomPixel = random.Next(0, 2);

            //}



        //}

        //int CalculateImagesList()
        //{

        //}

        //void CalculateImagesArray(CollectionImagesArray)
        //{

        //}

        static void CalculateImagePixels(double[] image) //previously this method took int[]
        {
            //basically this function counts up number of black pixels
            double sum = 0.0;
            for (int i = 0; i < 4; i++)
            {
                sum += image[i] * weight;
                Console.WriteLine(sum);
            }
            Console.WriteLine("the sum is " + sum);

             //this works with int values
            //if (sum == 0 || sum == 1 || sum == 2)
            //{
            //    Console.WriteLine("This image is BRIGHT\n");
            //}

            //if (sum == 3 || sum ==4)
            //{
            //    Console.WriteLine("This image is DARK\n");
            //}

            if(sum <=2 )
            {
                Console.WriteLine("This image is BRIGHT\n");
            }

            if(sum >2 && sum <=5)
            {
                Console.WriteLine("This image is DARK\n");
            }

            //else
            //{
            //    Console.WriteLine("Can't figure it out...\n");
            //}
        }

    }

    class Image
    {
        public Image (int pixel_1, int pixel_2, int pixel_3,
            int pixel_4)
        {

        }

        //default constructor
        public Image()
        {
            int pixel_1 = 0;
            int pixel_2 = 0;
            int pixel_3 = 0;
            int pixel_4 = 0;
        }
    }
}

