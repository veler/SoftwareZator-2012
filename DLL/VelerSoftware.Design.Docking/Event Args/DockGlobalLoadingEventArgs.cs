﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2010. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 4.3.1.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Diagnostics;

namespace VelerSoftware.Design.Docking
{
	/// <summary>
    /// Event data for loading global docking configuration.
	/// </summary>
	public class DockGlobalLoadingEventArgs : EventArgs
	{
		#region Instance Fields
        private KryptonDockingManager _manager;
        private XmlReader _xmlReader;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockGlobalLoadingEventArgs class.
		/// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlReading">Xml reader for persisting custom data.</param>
        public DockGlobalLoadingEventArgs(KryptonDockingManager manager,
                                          XmlReader xmlReading)
		{
            _manager = manager;
            _xmlReader = xmlReading;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the docking manager reference.
		/// </summary>
        public KryptonDockingManager DockingManager
		{
            get { return _manager; }
		}

        /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public XmlReader XmlReader
        {
            get { return _xmlReader; }
        }
        #endregion
	}
}