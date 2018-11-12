//using System.Data.Entity;
//using System.Data.SqlClient;

//namespace Petrol_Pump_Point_Of_Sale_System.Commons.Helper
//{
//    public static class DbHelper
//    {
//        public static bool CheckConnection(DbContext context)
//        {
//            try
//            {
//                context.Database.Connection.Open();
//                context.Database.Connection.Close();
//            }
//            catch (SqlException)
//            {
//                return false;
//            }
//            return true;
//        }

//        public static string GetConnectionString()
//        {
//            switch (Properties.Settings.Default.Authentication)
//            {
//                case "Windows Authentication":
//                    return string.Format("data source={0};initial catalog={1};integrated security=true;MultipleActiveResultSets=True;App=EntityFramework;",
//                        Properties.Settings.Default.DataSource,
//                        Properties.Settings.Default.InitialCatalog);
//                case "Sql Server Authentication":
//                    return string.Format("data source={0};initial catalog={1};user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework;",
//                        Properties.Settings.Default.DataSource,
//                        Properties.Settings.Default.InitialCatalog,
//                        Properties.Settings.Default.UserID,
//                        Properties.Settings.Default.Password);
//            }

//            return string.Empty;
//        }
//    }
//}
