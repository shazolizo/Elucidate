﻿#region Copyright (C)
// ---------------------------------------------------------------------------------------------------------------
//  <copyright file="AssemblyInfo.cs" company="Smurf-IV">
// 
//  Copyright (C) 2010-2018 Simon Coghlan (Aka Smurf-IV)
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 2 of the License, or
//   any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program. If not, see http://www.gnu.org/licenses/.
//  </copyright>
//  <summary>
//  Url: https://github.com/Smurf-IV/Elucidate
//  Email: https://github.com/Smurf-IV
//  </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Elucidate")]
[assembly: AssemblyDescription("A SnapRAID GUI")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Smurf-IV")]
[assembly: AssemblyProduct("Elucidate")]
[assembly: AssemblyCopyright("Copyright © Simon Coghlan (Aka Smurf-IV) 2011-2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e8b00f72-5771-42a8-82a0-6e71bf310721")]

// Version information for an assembly consists of the following four values:
//
//      Major Version - Year
//      Minor Version - Month
//      Build Number  - Increment
//      Revision      - Day
//
[assembly: AssemblyVersion("2018.9.606.29")]
[assembly: AssemblyFileVersion("18.9.606.29")]
[assembly: AssemblyInformationalVersion("2018.9.606.29")]
[assembly: NeutralResourcesLanguage("en-US")]
// TODO: Add more relevant hints here
[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms.DataVisualization", LoadHint.Always)]
[assembly: Dependency("System.Xml", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Toolkit", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Navigator", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Workspace", LoadHint.Always)]

