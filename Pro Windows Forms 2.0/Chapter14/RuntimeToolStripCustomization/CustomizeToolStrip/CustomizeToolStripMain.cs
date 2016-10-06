//---------------------------------------------------------------------
//  This file is part of the Microsoft .NET Framework SDK Code Samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//This source code is intended only as a supplement to Microsoft
//Development Tools and/or on-line documentation.  See these other
//materials for detailed information regarding Microsoft code samples.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------
using System.Resources;
using System.Windows.Forms;

namespace Microsoft.Samples.BoosterSamples.CustomizeToolStrip
{
    //=----------------------------------------------------------------------=
    // CustomizeToolStripMain
    //=----------------------------------------------------------------------=
    /// <summary>
    /// This class holds global routines for our sample, and doesn't actualy
    /// contain any instance members.  The static routines are useful for such
    /// things as getting localized reosurces, etc.
    /// </summary>
    /// 
    public class CustomizeToolStripMain
    {
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //                    Private Members/Types/etc.
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=

        /// 
        /// <summary>
        /// The resource manager with which we will work for this dialog, 
        /// particularly for loading in error strings, etc.
        /// </summary>
        /// 
        private static ResourceManager s_resourceManager;


        private const string RESFILE_NAMESPACE = "Microsoft.Samples.BoosterSamples.CustomizeToolStrip.CustomizeToolStripResources";


        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //           Publicly Consumable Methods/Functions/Properties
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=
        //=------------------------------------------------------------------=


        //=------------------------------------------------------------------=
        // GetResourceManager
        //=------------------------------------------------------------------=
        /// <summary>
        /// Loads in the resource manager for this library if we haven't done
        /// so already.  This just loads in the .resx file containing our 
        /// primary set of localized resources, such as error strings, etc.
        /// </summary>
        /// 
        /// <returns>
        /// A System.Resources.ResourceManager object
        /// </returns>
        /// 
        public static ResourceManager GetResourceManager()
        {
            System.Type t;

            //
            // load in the resource manager if we have not yet done so.
            //
            if (s_resourceManager == null)
            {
                t = typeof(Microsoft.Samples.BoosterSamples.CustomizeToolStrip.CustomizeToolStripForm);
                s_resourceManager = new ResourceManager(RESFILE_NAMESPACE,
                                                        t.Assembly);
            }

            System.Diagnostics.Debug.Assert(s_resourceManager != null);

            //
            // now we return what we have.  We'd have thrown an exception
            // if we didn't have this yet.
            //
            return s_resourceManager;
        }


        //=------------------------------------------------------------------=
        // ArrayContainsStrip
        //=------------------------------------------------------------------=
        /// <summary>
        /// A simple little Array.Contains-like method, since that doesn't
        /// actually appear to exist on the Array class.
        /// </summary>
        /// 
        /// <param name="in_array">
        /// Array in which to search.
        /// </param>
        /// <param name="in_item">
        /// Item to be found.
        /// </param>
        /// 
        /// <returns>
        /// True means it was found, false means it wasn't
        /// </returns>
        /// 
        public static bool ArrayContainsStrip
        (
            ToolStrip[] in_array,
            ToolStrip in_item
        )
        {
            //
            // this is already checked above more robustly, but we'll put
            // this here to be safe.
            //
            System.Diagnostics.Debug.Assert(in_array != null);

            //
            // look for it.
            //
            for (int x = 0; x < in_array.Length; x++)
            {
                if (in_array[x] == in_item)
                {
                    return true;
                }
            }

            //
            // didna' find it.
            //
            return false;
        }

    }
}
