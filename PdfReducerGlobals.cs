/**********************************************************************
 * Projet:                  pdfReducer.Cloud
 * Authors:                 - Evan Carrère.
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
using Orpalis.Globals.Localization;
using PassportPDF.Tools.Framework.Configuration;
using pdfReducerCloud.Utilities;

namespace pdfReducerCloud
{
    internal static class PdfReducerGlobals
    {
            public const string PRODUCT_NAME = "PassportPDF PDF Reducer Cloud";
            public const string APP_EXECUTABLE_NAME = "pdfReducerCloud.exe";
            public const string PASSPORT_PDF_APP_ID = "2ED8750B-AE6D-47B7-98CA-CB0A413BD24B";

            public static ReduceActionConfiguration ReduceActionConfiguration = new ReduceActionConfiguration();

            public static readonly OrpalisLocalizer LabelsLocalizer = new OrpalisLocalizer(AssemblyUtilities.GetManifestResourceStream("res.labels.json"));


            public static string GetLegalProductName(bool includeVersion)
            {
                string productName = PRODUCT_NAME;
                if (includeVersion)
                {
                    productName += " " + AssemblyUtilities.GetVersionString();
                }

                return productName;
            }


            public static string GetApplicationConfigurationFilePath()
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\settings.data";
            }


            public static string GetReduceActionConfigurationFilePath()
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\reduceActionConfiguration.data";
            }
        }
}