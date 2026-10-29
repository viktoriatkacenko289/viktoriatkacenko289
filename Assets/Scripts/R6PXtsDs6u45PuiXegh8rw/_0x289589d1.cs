using UnityEngine;

// All local persistence. Keys are written INLINE at every use site on purpose: a `const string`
// pulled into a shared static field becomes a runtime-initialised field after string encryption,
// and the obfuscator may then order it below its first reader (CLAUDE-unity.md C.52).
public static class _0x289589d1
{
    public static bool _0x99257a82
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[12] { 122, 121, 108, 120, 101, 96, 102, 59, 118, 116, 121, 120 }, 21), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[12] { 127, 124, 105, 125, 96, 101, 99, 62, 115, 113, 124, 125 }, 16), value ? 1 : 0);
        }
    }

    public static int _0x8f011e44
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 229, 230, 243, 231, 250, 255, 249, 164, 254, 248, 227, 235, 230 }, 138), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 36, 39, 50, 38, 59, 62, 56, 101, 63, 57, 34, 42, 39 }, 75), value);
        }
    }

    public static int _0x4e747bd2
    {
        get
        {
            if (!PlayerPrefs.HasKey(_0x88a2d2d0._0x0350a3a2(new byte[5] { 59, 23, 17, 22, 11 }, 120)))
                _0xe06f358c._0x0eee97d9._0x0f7fe95d = StartingBalance;
            return _0xe06f358c._0x0eee97d9._0x0f7fe95d;
        }

        set
        {
            _0xe06f358c._0x0eee97d9._0x0f7fe95d = Mathf.Max(0, value);
        }
    }

    public static int _0xcf3b3499
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[11] { 87, 84, 65, 85, 72, 77, 75, 22, 90, 93, 76 }, 56), 2), 0, 4);
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[11] { 197, 198, 211, 199, 218, 223, 217, 132, 200, 207, 222 }, 170), Mathf.Clamp(value, 0, 4));
        }
    }

    public static bool _0xf250efdc
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[16] { 6, 5, 16, 4, 25, 28, 26, 71, 10, 6, 7, 29, 27, 8, 26, 29 }, 105), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[16] { 29, 30, 11, 31, 2, 7, 1, 92, 17, 29, 28, 6, 0, 19, 1, 6 }, 114), value ? 1 : 0);
        }
    }

    public static bool _0x3dc83dc0
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 146, 145, 132, 144, 141, 136, 142, 211, 140, 136, 148, 158, 150 }, 253), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 174, 173, 184, 172, 177, 180, 178, 239, 176, 180, 168, 162, 170 }, 193), value ? 1 : 0);
        }
    }

    public const int StartingBalance = 25000;
    // Day index of the last claim, as days since the Unix epoch; -1 means never claimed.
    public static int _0x09211c8d
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[16] { 4, 7, 18, 6, 27, 30, 24, 69, 8, 7, 10, 2, 6, 15, 10, 18 }, 107), -1);
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[16] { 126, 125, 104, 124, 97, 100, 98, 63, 114, 125, 112, 120, 124, 117, 112, 104 }, 17), value);
        }
    }

    public static int _0xf08ea6bb
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[14] { 65, 66, 87, 67, 94, 91, 93, 0, 93, 90, 92, 75, 79, 69 }, 46), 0), 0, 7);
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[14] { 115, 112, 101, 113, 108, 105, 111, 50, 111, 104, 110, 121, 125, 119 }, 28), Mathf.Clamp(value, 0, 7));
        }
    }

    // One PlayerPrefs int per symbol holds a 3-bit tier mask (1 bronze, 2 silver, 4 gold).
    public static int ShardMask(int _0xc91b2a68)
    {
        return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 19, 16, 5, 17, 12, 9, 15, 82, 15, 20, 29, 14, 24 }, 124) + _0xc91b2a68.ToString(), 0);
    }

    public static void ResetProgress()
    {
        for (int _0x1e22a54f = 0; _0x1e22a54f < 9; _0x1e22a54f++)
            SetShardMask(_0x1e22a54f, 0);
        _0x8f011e44 = 0;
        _0xf08ea6bb = 0;
        _0x09211c8d = -1;
        _0xcf3b3499 = 2;
        _0xe06f358c._0x0eee97d9._0x0f7fe95d = StartingBalance;
        PlayerPrefs.Save();
    }

    public static int _0x0cd0a267
    {
        get
        {
            return PlayerPrefs.GetInt(_0x88a2d2d0._0x0350a3a2(new byte[15] { 116, 119, 98, 118, 107, 110, 104, 53, 104, 126, 104, 104, 114, 116, 117 }, 27), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[15] { 242, 241, 228, 240, 237, 232, 238, 179, 238, 248, 238, 238, 244, 242, 243 }, 157), value);
        }
    }

    public static void SetShardMask(int _0x05027e8f, int _0x281be741)
    {
        PlayerPrefs.SetInt(_0x88a2d2d0._0x0350a3a2(new byte[13] { 172, 175, 186, 174, 179, 182, 176, 237, 176, 171, 162, 177, 167 }, 195) + _0x05027e8f.ToString(), _0x281be741 & 7);
    }

    public static int Today()
    {
        System.DateTime _0x55954f53 = System.DateTime.UtcNow;
        System.TimeSpan _0x0493a042 = _0x55954f53 - new System.DateTime(1970, 1, 1);
        return (int)_0x0493a042.TotalDays;
    }

    public const int ShardTotal = 27;
}

internal static class _0x88a2d2d0
{
    internal static string _0x0350a3a2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}