using System.Data;
using System.Data.SqlClient;

namespace CalculateCalories.ORM
{
    internal static class ORMTools
    {
        const string connectionString = "Server=EGEMEN-PC;Database=CalculateCalories;Trusted_Connection=True;";
        private static SqlConnection _connection;

        public static bool HasParameter(this SqlCommand command) => command.Parameters.Count <= 0;

        public static SqlConnection Connection
        {
            get {
                if (_connection == null) {
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
            set { _connection = value; }
        }

        public static Result<bool> ExecuteQuery(this SqlCommand command) {
            try {
                if (command.Connection.State != ConnectionState.Open) {
                    command.Connection.Open();
                    int result = command.ExecuteNonQuery();
                    return new Result<bool> {
                        IsSuccess = true,
                        Message = "Islem Basarili!",
                        Data = result > 0
                    };
                }
            }
            catch (System.Exception ex) {
                return new Result<bool> {
                    IsSuccess = false,
                    Message = "Hata! " + ex.Message
                };
            }
            finally {
                if (command.Connection.State != ConnectionState.Closed) {
                    command.Connection.Close();
                }
            }
            return new Result<bool> {
                IsSuccess = false,
                Message = "Hata!",
            };
        }
    }
}
