﻿// <auto-generated />
namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class InitialTenantSchema : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(InitialTenantSchema));
        
        string IMigrationMetadata.Id
        {
            get { return "202012121258423_InitialTenantSchema"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
