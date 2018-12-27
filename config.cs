using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
 namespace MVCWeb
{
public class Config {

    public static IEnumerable<ApiResource> GetApiResources()
{
    return new List<ApiResource>
    {
        new ApiResource("api1", "My API")
    };
}

public static List<IdentityResource> GetIdentityResources()
{
    return new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile() // <-- usefull
    };
}
public static IEnumerable<Client> GetClients()
{
    return new List<Client>
    {
        new Client
        {
            ClientId = "client",

            // no interactive user, use the clientid/secret for authentication
            AllowedGrantTypes = GrantTypes.ClientCredentials,

            // secret for authentication
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },

            // scopes that client has access to
            AllowedScopes = { "api1" }
        },
       

        //Development Test Client
new Client
{
    ClientId = "jsDev",
    ClientName = "JavaScript Client",
    AllowedGrantTypes = GrantTypes.Implicit,
    AllowAccessTokensViaBrowser = true,
    
    ClientUri =  "http://localhost:4200/",
    Enabled =true,

    RedirectUris =           { "http://localhost:4200/assets/signin-callback.html",
                               "http://localhost:4200/assets/silent-callback.html",
                               "http://localhost:4200/silent-callback"
     },
    
    PostLogoutRedirectUris = { "http://localhost:4200/callback" },
    AllowedCorsOrigins =     { "http://localhost:4200/" },

    AllowedScopes =
    {
       IdentityServerConstants.StandardScopes.OpenId,
        IdentityServerConstants.StandardScopes.Profile,
       IdentityServerConstants.StandardScopes.Email,
       IdentityServerConstants.StandardScopes.OfflineAccess,
        "api1"
    },

    RequireConsent = false,
    AllowOfflineAccess=true,
    AccessTokenLifetime =(60 * 5),
    IdentityTokenLifetime=(60 * 5)
    
}
    };
}
public static List<TestUser> GetUsers()
{
    return new List<TestUser>
    {
        new TestUser
        {
            SubjectId = "1",
            Username = "test",
            Password = "tst",

            Claims = new []
            {
                new Claim("username", "test"),
                new Claim("name", "test test"),
                new Claim("website", "https://example.com")
            }
        },
        new TestUser
        {
            SubjectId = "2",
            Username = "test2",
            Password = "test2",

            Claims = new []
            {
                new Claim("username", "test2"),
                new Claim("name", "test test2"),
                new Claim("website", "https://example.com")
            }
        }
    };
}
}
}
