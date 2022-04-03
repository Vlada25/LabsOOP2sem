namespace SalaryManager.ORM.Interfaces
{
    public interface ISqlExecutor
    {
        int ExecuteNonQuery(string sql);
        object ExecuteScalar(string sql);
    }
}
