using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        /// <summary>
        /// Main Method. Entry to the program
        /// </summary>
        /// <param name="args">None at this time</param>
        static void Main(string[] args)
        {
            DisplayScreenHeader("Square");
            Square(15);
            DisplayContinuePrompt();

            DisplayScreenHeader("Rectangle");
            Rectangle(15, 30);
            DisplayContinuePrompt();

            DisplayScreenHeader("Hollow Rectangle");
            HollowRectangle(15, 30);
            DisplayContinuePrompt();

            DisplayScreenHeader("Triangle");
            LeftTriangle(20);
            DisplayContinuePrompt();

            DisplayScreenHeader("Hollow Triangle");
            HollowLeftTraingle(20);
            DisplayContinuePrompt();

            DisplayScreenHeader("Filled Right Triangle (Right)");
            RightTriangle(20);
            DisplayContinuePrompt();

            DisplayScreenHeader("Hollow Right Triangle (Right)");
            HollowRightTriangle(20);
            DisplayContinuePrompt();
        }

        #region Methods for Creating Shapes
        /// <summary>
        /// Creates a Hollow Right Triangle (Facing Right)
        /// </summary>
        /// <param name="height">Set the height of the triangle. Base will automatically be the same</param>
        private static void HollowRightTriangle(int height)
        {
            for (int i = height; i >= 0; i--)
            {
                if (i == 0)
                {
                    for (int j = 0; j <= height; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int j = 0; j <= height; j++)
                    {
                        if (j == i)
                        {
                            Console.Write("* ");
                        }
                        else if (j == height)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a Solid Right Triangle (Facing Right)
        /// </summary>
        /// <param name="height">Set the height of the triangle. Base will automatically be the same</param>
        private static void RightTriangle(int height)
        {

            for (int i = height; i >= 0; i--)
            {
                if (i == 0)
                {
                    for (int j = 0; j <= height; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int j = 0; j <= height; j++)
                    {
                        if (j == i)
                        {
                            Console.Write("*");
                        }
                        else if (j == height || j > i)
                        {
                            Console.Write(" *");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a Hollow Right Triangle (Facing Left)
        /// </summary>
        /// <param name="height">Set the height of the triangle. Base will automatically be the same</param>
        private static void HollowLeftTraingle(int height)
        {
            for (int i = 0; i <= height; i++)
            {
                if (i != height)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j <= i ; j++)
                    {
                        Console.Write("* ");
                    }
                }
                
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a Hollow Rectangle
        /// </summary>
        /// <param name="rows">Sets the amount of rows the rectangle has (height)</param>
        /// <param name="columns">Sets the amount of columns the rectangle has (width)</param>
        private static void HollowRectangle(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                if (i == 0 || i == rows - 1)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("*");
                        }
                        else if (j == (columns - 1))
                        {
                            Console.Write(" *");
                        }
                        else
                        {
                            Console.Write("  ");
                        }

                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
        }

        /// <summary>
        /// Creates a Solid Right Triangle (Facing Left)
        /// </summary>
        /// <param name="height">Set the height of the triangle. Base will automatically be the same</param>
        private static void LeftTriangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a Solid Rectangle
        /// </summary>
        /// <param name="rows">Sets the amount of rows the rectangle has (height)</param>
        /// <param name="columns">Sets the amount of columns the rectangle has (width)</param>
        private static void Rectangle(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates a Square
        /// </summary>
        /// <param name="rows">Sets the amount of rows the square has (height & width)</param>
        private static void Square(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region HELPER METHODS

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThe Calculator");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using the Calculator!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
