namespace JC.Samples.SymmetricEncryption.Services.Interfaces;

/// <summary>
/// Encryption services interface.
/// </summary>
public interface IEncryptionServices
{
    #region Methods

    string DecryptString(string text, byte[] key);
    string EncryptString(string text, byte[] key);
    bool IsEncrypted(string text);

    #endregion
}