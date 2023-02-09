using JC.Samples.SymmetricEncryption;
using JC.Samples.SymmetricEncryption.Services;
using JC.Samples.SymmetricEncryption.Services.Interfaces;

string plainText = "https://jonathancrozier.com";
Console.WriteLine("Plain text: {0}", plainText);

IEncryptionServices encryptionServices = new EncryptionServices();

Console.WriteLine("Encrypting plain text...");
string encryptedText = encryptionServices.EncryptString(plainText, DemoKey.Value);
Console.WriteLine("Encrypted data: {0}", encryptedText);

Console.WriteLine("Decrypting encrypted data...");
string decryptedText = encryptionServices.DecryptString(encryptedText, DemoKey.Value);
Console.WriteLine("Decrypted text: {0}", decryptedText);