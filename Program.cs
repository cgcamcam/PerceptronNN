//Cameron Gibson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronNN
{
    class Program
    {
        int[] CollectionImagesArray = new int[16];
        List<int> CollectionImagesList = new List<int>();
        //int[] Image = new int[4];
        double weight = 1;
        //0 = white, 1 = black pixel

        int[] Image_1 = { 0, 0, 0, 0 }; //bright
        int[] Image_2 = { 0, 1, 0, 0 }; //bright
        int[] Image_3 = { 0, 1, 1, 0 }; //bright
        int[] Image_4 = { 0, 1, 1, 1 }; //dark

        static void Main(string[] args)
        {


        }

        void GenerateImages()
        {
            //Random random = new Random();
            //for (int i = 0; i<4; i++)
            //{
            //    int randomPixel = random.Next(0, 2);

            //}





        }

        //int CalculateImagesList()
        //{

        //}

        //void CalculateImagesArray(CollectionImagesArray)
        //{

        //}

        void CalculateImagePixels(int[] image)
        {
            double sum = 0.0;
            for (int i = 0; i < 4; i++)
            {
                sum += image[i] * weight;

            }
            Console.Write("the sum is " + sum);

            if (sum == 0 || sum == 1)
            {
                Console.Write("This image is DARK");
            }

            if (sum == 2 || sum == 3 || sum ==4)
            {
                Console.Write("This image is BRIGHT");
            }

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
