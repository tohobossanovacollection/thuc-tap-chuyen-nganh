using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public static class CodeGenerator
    {
        public static string GetNextCode(string connectionString, string tableName, string columnName, string prefix, int padLength = 3)
        {
            string query = $"SELECT MAX({columnName}) FROM {tableName} WHERE {columnName} LIKE @prefix + '%';";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@prefix", prefix);
            conn.Open();

            string? maxCode = cmd.ExecuteScalar() as string;
            int nextNumber = 1;

            if (!string.IsNullOrWhiteSpace(maxCode) && maxCode.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                string numberPart = maxCode.Substring(prefix.Length);
                if (int.TryParse(numberPart, out int parsed))
                {
                    nextNumber = parsed + 1;
                    padLength = Math.Max(padLength, numberPart.Length);
                }
            }

            return $"{prefix}{nextNumber.ToString().PadLeft(padLength, '0')}";
        }
    }
}
