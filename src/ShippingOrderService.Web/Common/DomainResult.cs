namespace ShippingOrderService.Web.Common;

public class DomainResult<T>
{
    public T? Value { get; set; }

    public string? Error { get; set; }

    public ResultStatus Status { get; set; }

    public bool IsSuccess => Status == ResultStatus.Success;

    private DomainResult(T value)
    {
        Value = value;
        Status = ResultStatus.Success;
    }

    private DomainResult(ResultStatus status, string error)
    {
        Status = status;
        Error = error;
    }

    public static DomainResult<T> Success(T result) => new(result);
    public static DomainResult<T> NotFound(string error) => new(ResultStatus.NotFound, error);
    public static DomainResult<T> Invalid(string error) => new(ResultStatus.Invalid, error);
    public static DomainResult<T> Failure(string error) => new(ResultStatus.Failure, error);
}

public enum ResultStatus
{
    Success,
    NotFound,
    Invalid,
    Failure
}