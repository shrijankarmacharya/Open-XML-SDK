﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Global OpenXmlPart factory to create strong typed OpenXmlPart based on the relationship type.
    /// </summary>
    internal static partial class GlobalPartFactory
    {
        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="openXmlPackage">The container OpenXmlPackage.</param>
        /// <param name="relationshipType">The relationship type of the target part.</param>
        /// <returns>An instance of OpenXmlPart.</returns>
        internal static OpenXmlPart CreateOpenXmlPart(OpenXmlPackage openXmlPackage, string relationshipType)
        {
            if (relationshipType == null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            OpenXmlPart openXmlPart = null;

            CreatePartCore(openXmlPackage, relationshipType, ref openXmlPart);

            if (openXmlPart == null)
            {
                openXmlPart = new ExtendedPart(relationshipType);
            }

            return openXmlPart;
        }

        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="openXmlPackage">The container OpenXmlPackage.</param>
        /// <param name="relationshipType">The relationship type of the target part.</param>
        /// <param name="openXmlPart">The created instance of OpenXmlPart.</param>
        /// <remarks>This partial method will be generated by code generaotr.</remarks>
        static partial void CreatePartCore(OpenXmlPackage openXmlPackage, string relationshipType, ref OpenXmlPart openXmlPart);
    }

    /************************ the following are code template for code generator ******
    /// <summary>
    /// Global OpenXmlPart factory to create strong typed OpenXmlPart based on the relationship type.
    /// </summary>
    internal static partial class GlobalPartFactory
    {
        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="relationshipType">The relationship type.</param>
        /// <param name="openXmlPart">The created instance of OpenXmlPart.</param>
        /// <remarks>This partial method will be generated by code generator.</remarks>
        static partial void CreatePartCore(string relationshipType, ref OpenXmlPart openXmlPart)
        {
            if (relationshipType == null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }
            switch (relationshipType)
            {
                default:
                    return;
            }
        }
    }
    ******************************/
}
