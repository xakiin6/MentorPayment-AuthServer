// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.




using System;


namespace MVCWeb.Controllers
{
    public class ErrorViewModel
    {
        public IdentityServer4.Models.ErrorMessage Error { get; set; }
    }

    public class ErrorMessage
    {
     public ErrorMessage(){}

        //
        // Summary:
        //     The display mode passed from the authorization request.
        public string DisplayMode { get; set; }
        //
        // Summary:
        //     The UI locales passed from the authorization request.
        public string UiLocales { get; set; }
        //
        // Summary:
        //     Gets or sets the error code.
        public string Error { get; set; }
        //
        // Summary:
        //     Gets or sets the error description.
        public string ErrorDescription { get; set; }
        //
        // Summary:
        //     The per-request identifier. This can be used to display to the end user and can
        //     be used in diagnostics.
        public string RequestId { get; set; }
        //
        // Summary:
        //     The redirect URI.
        public string RedirectUri { get; set; }
        //
        // Summary:
        //     The response mode.
        public string ResponseMode { get; set; }

        public static explicit operator ErrorMessage(IdentityServer4.Models.ErrorMessage v)
        {
            throw new NotImplementedException();
        }
    }
}