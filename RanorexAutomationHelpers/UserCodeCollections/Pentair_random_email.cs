/*
 * Created by Ranorex
 * User: E1238450
 * Date: 10/12/2020
 * Time: 3:51 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Ranorex_Automation_Helpers.UserCodeCollections
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class Pentair_random_email
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
                /// <summary>
        /// Use this to generate a random email.  You will need to specify a return variable that can be
        /// used to type in the email later.
        /// </summary>
        [UserCodeMethod]
        public static string getRandomEmail()
        {
        
         Random myrandom = new Random();
         
         string varEmail = "Ranorex" + (myrandom.Next(100000)) + "@mailinator.com";
         
         return varEmail;
        }

       
    }
}
