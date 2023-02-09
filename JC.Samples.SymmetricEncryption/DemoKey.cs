namespace JC.Samples.SymmetricEncryption;

/// <summary>
/// Holds a demo encryption key.
/// </summary>
internal class DemoKey
{
    #region Static Readonlys

    /// <summary>
    /// The encryption key value.
    /// </summary>
    internal static readonly byte[] Value = new byte[32] // 32 bytes = 256-bit.
    {
        73, 84, 28, 39, 182, 122, 193, 73, 43, 71, 106, 142, 76, 16, 54, 19, 21, 115, 138, 75, 45, 114, 41, 79, 181, 196, 40, 148, 154, 81, 173, 56
    };

    #endregion
}