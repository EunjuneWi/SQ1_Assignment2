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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        *   PARAMETERS  
        *       string  firstSide   -   Length of one side. It must be decimal number.
        *       string  secondSide  -   Length of another side. It must be decimal number.
        *   RETURNS     
        *       double  -  Length of the remaining side.
        */
        public static double GetRemainingSide(string firstSide, string secondSide)
        {
            return 0.0;
        }
    }
}
