namespace ProductManagement.Domain.Exceptions;

public sealed class InvalidProductNameException : DomainException
{
        public InvalidProductNameException() : base("Product Name Cannot Null or Empty") { }
}

public sealed class InvalidProductPriceException : DomainException
{
        public InvalidProductPriceException() : base("Product Price Cannot Null or 0") { }
}

public sealed class InvalidProductStockException : DomainException
{
        public InvalidProductStockException() : base("Insufficient Stock") { }
}


