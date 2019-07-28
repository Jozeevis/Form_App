namespace Valtech_Form_BusinessLogic.Data
{
    public class DbInitializer
    {
        public static void Initialize(FormDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
