﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
    /// <summary>
    /// Defines CustomUI.
    /// </summary>
    public partial class CustomUI : OpenXmlPartRootElement
    {
        /// <summary>
        /// CustomUI constructor.
        /// </summary>
        /// <param name="ownerPart">The owner part of the CustomUI.</param>
        internal CustomUI(CustomUIPart ownerPart)
            : base(ownerPart)
        {

        }

        /// <summary>
        /// Loads the DOM from an OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be loaded.</param>
        public void Load(CustomUIPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the OpenXML part.
        /// </summary>
        /// <param name="openXmlPart">The part to be saved to.</param>
        public void Save(CustomUIPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomUIPart associated with this element, it could either be a QuickAccessToolbarCustomizationsPart or a RibbonExtensibilityPart.
        /// </summary>
        public CustomUIPart CustomUIPart
        {
            get
            {
                return OpenXmlPart as CustomUIPart;
            }

            internal set
            {
                OpenXmlPart = value;
            }
        }
    }
}
