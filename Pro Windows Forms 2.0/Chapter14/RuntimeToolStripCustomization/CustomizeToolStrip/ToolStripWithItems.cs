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
using System;
using System.Windows.Forms;


namespace Microsoft.Samples.BoosterSamples.CustomizeToolStrip
{
    //=----------------------------------------------------------------------=
    // ToolStripWithItems
    //=----------------------------------------------------------------------=
    /// <summary>
    ///   This is a simple little class to hold a reference to a ToolStrip
    ///   as well as a collection of buttons that the user <em>would like</em>
    ///   assigned to it.  The Items collection does not reflect the 
    ///   list of <em>actul</em> buttons assigned to this strip.
    /// </summary>
    /// 
    public class ToolStripWithItems
    {
        /// 
        /// <summary>
        ///    A handle to a ToolStrip of some sort.
        /// </summary>
        /// 
        public ToolStrip Strip;

        /// 
        /// <summary>
        ///   The collection of items that the user <em>would like</em> to
        ///   see assigned to this ToolStrip
        /// </summary>
        /// 
        public ToolStripItem[] Items;
    }

}
