﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Specifies event handlers that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs.
    /// </summary>
    [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
    public class OpenXmlPackageValidationSettings
    {
        private EventHandler<OpenXmlPackageValidationEventArgs> valEventHandler;

        /// <summary>
        /// Gets the event handler.
        /// </summary>
        /// <returns></returns>
        internal EventHandler<OpenXmlPackageValidationEventArgs> GetEventHandler()
        {
            return this.valEventHandler;
        }

        /// <summary>
        /// Represents the callback method that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs.
        /// </summary>
        public event EventHandler<OpenXmlPackageValidationEventArgs> EventHandler
        {
            add
            {
                this.valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Combine(this.valEventHandler, value);
            }

            remove
            {
                this.valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Remove(this.valEventHandler, value);
            }
        }

        /// <summary>
        /// Gets or sets the file format version that the validation is targeting.
        /// </summary>
        internal FileFormatVersions FileFormat
        {
            get;
            set;
        }
    }
}
