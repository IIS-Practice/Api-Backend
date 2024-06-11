using FluentValidation.Results;

namespace IIS.API.Application.Common.Exceptions;
public class ValidationException : Exception
{
    public IDictionary<string, string[]> ValidationErrors { get; }

    public ValidationException()
            : base("One or more validation failures have occurred.")
    {
        ValidationErrors = new Dictionary<string, string[]>();
    }

    public ValidationException(IEnumerable<ValidationFailure> failures)
        : this()
    {
        ValidationErrors = failures
            .GroupBy(validationFailure => validationFailure.PropertyName, validationFailure => validationFailure.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}
