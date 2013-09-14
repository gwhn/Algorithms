﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    /// <summary>
    /// Sometimes when computer programs have a limited number of colors to use, they use a technique called dithering. 
    /// Dithering is when you use a pattern made up of different colors such that when the colors are viewed together, 
    /// they appear like another color. 
    /// For example, you can use a checkerboard pattern of black and white pixels to achieve the illusion of gray.
    /// You are writing a program to determine how much of the screen is covered by a certain dithered color. 
    /// Given a computer screen where each pixel has a certain color, 
    /// and a list of all the solid colors that make up the dithered color, 
    /// return the number of pixels on the screen that are used to make up the dithered color. 
    /// Each pixel will be represented by a character in screen. 
    /// Each character in screen and in dithered will be an uppercase letter ('A'-'Z') representing a color.
    /// Assume that any pixel which is a color contained in dithered is part of the dithered color.
    /// 
    /// Constraints
    /// dithered will contain between 2 and 26 upper case letters ('A'-'Z'), inclusive.
    /// There will be no repeated characters in dithered.
    /// screen will have between 1 and 50 elements, inclusive.
    /// Each element of screen will contain between 1 and 50 upper case letters ('A'-'Z'), inclusive.
    /// All elements of screen will contain the same number of characters.
    /// </summary>
public class ImageDithering
{
    public int Count(string dithered, string[] screen)
    {
        return dithered.Sum(c => screen.Sum(r => r.Count(x => x == c)));
    }
}
}
