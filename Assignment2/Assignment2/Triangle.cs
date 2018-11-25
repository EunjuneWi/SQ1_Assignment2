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
        *                   The calculated value will have truncated value with
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
            bool trueForValidInput = true;

            // First convert the given length to decimal number
            try
            {
                if (strFirstSide.Length != 0)
                {
                    firstSide = Convert.ToDouble(strFirstSide);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                trueForValidInput = false;
            }

            try
            {
                if (trueForValidInput)
                {
                    if (strFirstSide.Length != 0)
                    {
                        secondSide = Convert.ToDouble(strSecondSide);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch
            {
                trueForValidInput = false;
            }

            // Calculate
            if (trueForValidInput)
            {
                double poweredFirst = Math.Pow(firstSide, 2);
                double poweredSecond = Math.Pow(secondSide, 2);
                result = Math.Sqrt((poweredFirst + poweredSecond));
            }

            // Round the reuslt
            result = Math.Round(result, 4);
            
            // Return the value
            return result;
        }
    }
}
