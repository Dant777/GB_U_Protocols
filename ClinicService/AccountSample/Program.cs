using ClinicService.Utils;

var result = PasswordUtils.CreatePasswordHash("12345");
Console.WriteLine(result.passwordSalt);
Console.WriteLine(result.passwordHash);
Console.ReadKey();
