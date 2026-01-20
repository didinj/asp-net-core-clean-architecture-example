namespace CleanArchitectureDemo.Domain.Exceptions;

public class InvalidProductException(string message) : Exception(message)
{
}
