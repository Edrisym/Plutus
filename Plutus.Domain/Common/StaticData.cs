namespace Plutus.Domain.Common;

public static class StaticData
{
    public static class ConnectionStrings
    {
        public const string PlutusPostgresDb = nameof(PlutusPostgresDb);
    }

    public static class TableName
    {
        public const string Wallets = nameof(Wallets);
        public const string Currencies = nameof(Currencies);
        public const string Transactions = nameof(Transactions);
    }
    
    public static class WalletDbContextDefaultColumnType
    {
        public const string Decimal = "DECIMAL(18, 2)";
        public const string Nvarchar36 = "NVARCHAR(36)";
    }

    public static class ErrorMessages
    {
        public const string DuplicateInput =
            "Oops! It looks like there's already an entry with the same 'Code' and 'Name'. Please try again with different values.";
    }
}