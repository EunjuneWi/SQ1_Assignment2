/*
* FILE			: Triangle.cs
* PROJECT		: INFO2180 - Assignment #2
* PROGRAMMER	: Eunjune Wi
* FIRST VERSION : 2018-11-26
* DESCRIPTION	:
*   This file contains methods for triangle class.
*   The class is used to measure missing components of triangle 
*   by using its characteristic.
*/



// *--------------*
// |  References  |
// *--------------*
using System;



namespace Assignment2
{
    /*
    *   Name    :   Triangle
    *   Purpose :   This static class is used to calculate missing components of triangle.
    *               For example, if two side is given for right triangle, 
    *               this will calcualate length of remaining side.
    *               Since this is static class, it only has static methods.
    */
    public static class Triangle
    {
        // *-----------*
        // |  Methods  |
        // *-----------*
        /*
        *   METHOD      :   GetRemainingSide
        *   DESCRIPTION :   This method takes length of two sides from right triangle,
        *                   and calcualte the remaining side.
        *                   The calculated value will have round the value with
        *                   four numbers after decimal point.
        *   PARAMETERS  
        *       string  strFirstSide   -   Length of one side. It must be decimal number.
        *       string  strSecondSide  -   Length of another side. It must be decimal number.
        *   RETURNS     
        *       double  -  Length of the remaining side.
        */
        public static double GetRemainingSide(string strFirstSide, string strSecondSide)
        {
            double firstSide = 0;
            double secondSide = 0;
            double result = 0;

            // First convert the given length to decimal number
            // In case, input with wrong format is entered, it should still catch and throw new one
            // Otherwise the test will always fail.
            try
            {
                firstSide = Convert.ToDouble(strFirstSide);
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (firstSide <= 0)
                {
                    throw new Exception();
                }
            }

            try
            {
                secondSide = Convert.ToDouble(strSecondSide);
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (secondSide <= 0)
                {
                    throw new Exception();
                }
            }

            // Calculate
            double poweredFirst = Math.Pow(firstSide, 2);
            double poweredSecond = Math.Pow(secondSide, 2);
            result = Math.Sqrt((poweredFirst + poweredSecond));

            // Round the result
            result = Math.Round(result, 4);

            // Return the value
            return result;
        }



        /*
        *   METHOD      :   GetArea
        *   DESCRIPTION :   This method takes length of two sides from right triangle,
        *                   and calcualte the area.
        *                   The calculated value will have round the value with
        *                   four numbers after decimal point.
        *   PARAMETERS  
        *       string  strFirstSide   -   Length of one side. It must be decimal number.
        *       string  strSecondSide  -   Length of another side. It must be decimal number.
        *   RETURNS     
        *       double  -  Length of the remaining side.
        */
        public static double GetArea(string strFirstSide, string strSecondSide)
        {
            double firstSide = 0;
            double secondSide = 0;
            double result = 0;

            // First convert the given length to decimal number
            // In case, input with wrong format is entered, it should still catch and throw new one
            // Otherwise the test will always fail.
            try
            {
                firstSide = Convert.ToDouble(strFirstSide);
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (firstSide <= 0)
                {
                    throw new Exception();
                }
            }

            try
            {
                secondSide = Convert.ToDouble(strSecondSide);
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (secondSide <= 0)
                {
                    throw new Exception();
                }
            }

            // Calculate
            result = firstSide * secondSide / 2;

            // Round the result
            result = Math.Round(result, 4);

            // Return the value
            return result;
        }
    }
}
