using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using API.Providers;
using API.Models;
using Microsoft.Owin.Security.Facebook;

namespace API
{
    public partial class Startup
    {
        public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }
        public static GoogleOAuth2AuthenticationOptions googleAuthOptions { get; private set; }
        public static FacebookAuthenticationOptions facebookAuthOptions { get; private set; }
       

        public static string PublicClientId { get; private set; }

        public static bool IsDebug = false;

        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            OAuthBearerOptions = new OAuthBearerAuthenticationOptions();


            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/Token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(365),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),

                // In production mode set AllowInsecureHttp = false

            };

            // Enable the application to use bearer tokens to authenticate users
            //app.UseOAuthBearerTokens(OAuthOptions);
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(OAuthBearerOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

            //app.UseFacebookAuthentication(
            //    appId: "2266009516804148",
            //    appSecret: "ce0759fa705a771258fc23fc50f140cf"
            //);

            //For test

            //app.UseFacebookAuthentication(
            //    appId: "303718803111111",
            //    appSecret: "e7bbbc77bd4e98435955b780fec886fe"
            //);

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});


            /////////////

            //Configure Google External Login
            //https://developers.google.com/identity/sign-in/web/sign-in#before_you_begin

            //haiyeneyecare2019@gmail.com - Hai Yen EYE Care Project

            googleAuthOptions = new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "547336805419-gqcsvnmk1i4n865v431aqtuqgd0ujpfr.apps.googleusercontent.com",
                ClientSecret = "LxTfVghDdyGObyTlqXgwfedt",
                Provider = new GoogleAuthProvider()
            };
            app.UseGoogleAuthentication(googleAuthOptions);

            //Configure Facebook External Login

            if (IsDebug)
            {
                facebookAuthOptions = new FacebookAuthenticationOptions()
                {
                    //For test
                    AppId = "303718803111111",
                    AppSecret = "e7bbbc77bd4e98435955b780fec886fe",
                    Provider = new FacebookAuthProvider()
                };
            }
            else
            {
                facebookAuthOptions = new FacebookAuthenticationOptions()
                {
                    AppId = "2266009516804148",
                    AppSecret = "ce0759fa705a771258fc23fc50f140cf",
                    Provider = new FacebookAuthProvider()
                };
            }
            
            app.UseFacebookAuthentication(facebookAuthOptions);
        }
    }
}
