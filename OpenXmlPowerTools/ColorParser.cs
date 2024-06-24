// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//using System.Drawing;
using SixLabors.ImageSharp;
 

namespace OpenXmlPowerTools
{
    public static class ColorParser
    {
        public static Color FromName(string name)
        {
            return Color.Parse(name);
        }

        public static bool TryFromName(string name, out Color color)
        {
            try
            {
                color = Color.Parse(name);

                return true ;
            }
            catch
            {
                color = default(Color);

                return false;
            }
        }

        public static bool IsValidName(string name)
        {
            return TryFromName(name, out _);
        }
    }
}
