namespace dPosit.Auth.Application.Common.Enums;

public enum ErrorCode
{
    None,
    DuplicatedUserName,
    InvalidEmailFormat,
    Required,
    LessThanMinimumLength,
    MustContainDigit,
    MustContainUppercaseLetter,
    MustContainLowercaseLetter,
    MustContainSpecialSymbol,
    InvalidToken,
    InvalidTokenType,
    InvalidCredentials,
    AccountInactive,
    EmailAlreadyTaken
}
