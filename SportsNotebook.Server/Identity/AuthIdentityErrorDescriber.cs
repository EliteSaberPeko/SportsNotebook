using Microsoft.AspNetCore.Identity;

namespace SportsNotebook.Server.Identity;

public class AuthIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        => new() { Code = nameof(PasswordRequiresUniqueChars), Description = $"В пароле должно быть не менее {uniqueChars} уникального символа." };

    public override IdentityError PasswordTooShort(int length)
        => new() { Code = nameof(PasswordTooShort), Description = $"Пароль должен содержать не менее {length} символов." };
}
