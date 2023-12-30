﻿using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace FoodDelivery_Backend.Provider
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] {
                "*"
                });
            //db Logic to validate user  
            //    if(user validated) {
            //    identity.AddClaim(new Claim("Age", "16"));
            //    var props = new AuthenticationProperties(new Dictionary<string, string> {
            //    {
            //        "userdisplayname",
            //        context.UserName
            //    },
            //    {
            //        "role",
            //        "admin"
            //    }
            //});
            //    var ticket = new AuthenticationTicket(identity, props);
            //    context.Validated(ticket);
            //}
            //else {
            //    context.SetError("invalid_grant", "Provide username and password is incorrect");
            //    context.Rejected();
            //}
        }
        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var newIdentity = new ClaimsIdentity(context.Ticket.Identity);
            newIdentity.AddClaim(new Claim("newClaim", "newValue"));
            var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
            context.Validated(newTicket);
            return Task.FromResult<object>(null);
        }

    }
}