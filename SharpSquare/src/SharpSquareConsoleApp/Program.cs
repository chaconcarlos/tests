// <copyright file="Program.cs" company="Smartmatic Corp.">
//   Smartmatic Corp. All Rights Reserved.
// </copyright>
// <author>carlos.rivas</author>
// <date>10/10/2013 4:31:17 PM</date>
//
// Confidential Information of Smartmatic Labs. Not for disclosure or distribution
// prior written consent. This software contains code, techniques and know-how which
// is confidential and proprietary to Smartmatic.
//
// Use of this software is subject to the terms of an end user license agreement.

using System;
using System.Collections.Generic;
using Igloo.SharpSquare.Core;
using Igloo.SharpSquare.Entities;

namespace SharpSquareConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string      clientId     = "CLIENT_ID";
            string      clientSecret = "CLIEND_SECRET";
            //string      redirectUri  = "REDIRECT_URI";
            SharpSquare sharpSquare  = new SharpSquare(clientId, clientSecret);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("ll", "8.98225, -79.50955");
            parameters.Add("radius", "8.98225, -79.50955");

            List<Venue> venues = sharpSquare.SearchVenues(parameters);

            foreach (Venue venue in venues)
            {
                Console.Out.WriteLine(venue.id + " " + venue.name + " " + venue.mayor);
            }
        }
    }
}
