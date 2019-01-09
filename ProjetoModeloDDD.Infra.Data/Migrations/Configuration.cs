namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoModeloDDD.Infra.Data.Context.ProjetoModeloDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoModeloDDD.Infra.Data.Context.ProjetoModeloDDDContext context)
        {
        }
    }
}
