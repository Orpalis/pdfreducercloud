﻿/**********************************************************************
 * Project:                  pdfReducer.Cloud
 * Authors:					- Evan Carrère.
 *                          - Loïc Carrère.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/

using System;
using System.Diagnostics;
using System.Reflection;

namespace pdfReducerCloud.Utilities
{
    internal static class AssemblyUtilities
    {
        private const string ASSEMBLY_ROOT = "pdfReducerCloud";

        public static Version GetVersion()
        {
            return new Version(GetVersionString());
        }


        public static string GetVersionString()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return GetMajorVersion() + "." + fvi.FileMinorPart.ToString() + "." + fvi.FilePrivatePart.ToString();
        }


        public static string GetMajorVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileMajorPart.ToString();
        }


        public static System.IO.Stream GetManifestResourceStream(string resourceName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(ASSEMBLY_ROOT + "." + resourceName);
        }
    }
}
