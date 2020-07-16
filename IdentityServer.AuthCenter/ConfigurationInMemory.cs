using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace IdentityServer.AuthCenter
{
    public class ConfigurationInMemory
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>() {
                new Client {
                ClientId="1001",
                ClientName="mvc Client",
                ClientSecrets ={ new Secret( "secret".Sha256()) },
               AllowedGrantTypes= { GrantType.ResourceOwnerPassword },
               AllowedScopes={"productservice","orderservice" }
                }
            };
        }

        public  static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> {
                new ApiResource ("productservice", " product service api" ) ,
                new ApiResource ("orderservice", " order service api" ) ,
            };
        }

        public static List<TestUser> GetUsers()
        {

            return new List<TestUser> 
            {
               new TestUser() {  SubjectId ="user01", Username="Colin", Password="gww1981"},
               new TestUser() {  SubjectId ="user02", Username="gww1981", Password="gww1981"}
            };
        }
    }
}
