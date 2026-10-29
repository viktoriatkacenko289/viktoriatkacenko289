using UnityEngine;

// The album of storms: nine symbols x three tiers = 27 shards, and the three lobby rooms they
// unlock. A four-of-a-kind earns that symbol's Bronze shard, a five its Silver, and a
// wild-assisted five its Gold.
public sealed class _0xce074dd9 : MonoBehaviour
{
    public bool _0x1911857e(int _0x70618ebf)
    {
        return this._0x7498f300 >= RoomThresholds[Mathf.Clamp(_0x70618ebf, 0, 2)];
    }

    public int _0xf84acb46(int _0x34a227f5)
    {
        return _0x289589d1.ShardMask(_0x34a227f5);
    }

    public int _0x7498f300
    {
        get
        {
            int _0xa170d18a = 0;
            for (int _0x48b4472c = 0; _0x48b4472c < _0x27cd1a19.SymbolCount; _0x48b4472c++)
            {
                int _0xf21b3fbe = _0x289589d1.ShardMask(_0x48b4472c);
                if ((_0xf21b3fbe & TierBronze) != 0)
                    _0xa170d18a++;
                if ((_0xf21b3fbe & TierSilver) != 0)
                    _0xa170d18a++;
                if ((_0xf21b3fbe & TierGold) != 0)
                    _0xa170d18a++;
            }

            return _0xa170d18a;
        }
    }

    public const int TierSilver = 2;
    private bool _0xc0e6e78c;
    public static readonly string[] RoomNames =
    {
        _0x7ffb8f21._0x47266d28(new byte[14] { 20, 24, 11, 27, 21, 28, 121, 13, 28, 11, 11, 24, 26, 28 }, 89),
        _0x7ffb8f21._0x47266d28(new byte[11] { 61, 58, 33, 60, 35, 78, 56, 47, 59, 34, 58 }, 110),
        _0x7ffb8f21._0x47266d28(new byte[10] { 251, 227, 241, 136, 252, 224, 250, 231, 230, 237 }, 168)
    };
    public const int TierGold = 4;
    public static readonly int[] RoomThresholds =
    {
        0,
        9,
        18,
        27
    };
    public Color _0xa03b593b(int _0x305da101)
    {
        if (_0x305da101 >= 2)
            return _0xc406d6f3.Amber;
        if (_0x305da101 == 1)
            return _0xc406d6f3.Silver;
        return _0xc406d6f3.Gold;
    }

    // Returns how many NEW shards this outcome earned, so the caller can report it.
    public int _0xdfe5c4dc(_0x27cd1a19._0x9c1f3a9c _0xc49682c5)
    {
        if (!this._0xc0e6e78c)
            this._0x947dd036();
        if (_0xc49682c5 == null)
            return 0;
        int _0x03bf6882 = 0;
        for (int _0xdfa96932 = 0; _0xdfa96932 < _0xc49682c5.Lines.Count; _0xdfa96932++)
        {
            _0x27cd1a19._0x4113515c _0xe66ecfa5 = _0xc49682c5.Lines[_0xdfa96932];
            if (_0xe66ecfa5.Symbol == _0x27cd1a19.Scatter)
                continue;
            int _0x4271c77b = 0;
            if (_0xe66ecfa5.Length == 4)
                _0x4271c77b = TierBronze;
            else if (_0xe66ecfa5.Length >= 5 && _0xe66ecfa5.WildAssisted)
                _0x4271c77b = TierGold;
            else if (_0xe66ecfa5.Length >= 5)
                _0x4271c77b = TierSilver;
            if (_0x4271c77b == 0)
                continue;
            int _0x2fb85980 = _0x289589d1.ShardMask(_0xe66ecfa5.Symbol);
            if ((_0x2fb85980 & _0x4271c77b) != 0)
                continue;
            _0x289589d1.SetShardMask(_0xe66ecfa5.Symbol, _0x2fb85980 | _0x4271c77b);
            _0x03bf6882++;
        }

        return _0x03bf6882;
    }

    // Room index 0..2. Each unlock visibly recolours the lobby trim and swaps the decor plate,
    // so the change is something a screenshot can show (CLAUDE-unity.md C.7).
    public int _0xf4877ba6
    {
        get
        {
            int _0x14073dfe = this._0x7498f300;
            if (_0x14073dfe >= RoomThresholds[3])
                return 2;
            if (_0x14073dfe >= RoomThresholds[2])
                return 2;
            if (_0x14073dfe >= RoomThresholds[1])
                return 1;
            return 0;
        }
    }

    public const int TierBronze = 1;
    public void _0x947dd036()
    {
        this._0xc0e6e78c = true;
    }
}

internal static class _0x7ffb8f21
{
    internal static string _0x47266d28(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}