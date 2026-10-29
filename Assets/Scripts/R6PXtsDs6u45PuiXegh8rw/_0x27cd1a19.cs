using System.Collections.Generic;
using UnityEngine;

// Pure evaluation of one landed 3x5 grid over the ten fixed paylines. No Unity state is read
// here, which is what lets the same code run inside the headless balance simulation that proves
// the return-to-player band before a strip set is ever shown (CLAUDE-unity.md C.11).
public static class _0x27cd1a19
{
    // Everything one spin produced, in display order.
    public sealed class _0x9c1f3a9c
    {
        public List<_0x4113515c> Lines = new List<_0x4113515c>();
        public int Coins;
        public int Scatters;
        public int WildsLanded;
        public int TopMultiple;
        // NOT named Reset(): Reset/Start/Update/Awake/OnComplete/... are Unity message names, and the
        // obfuscator keeps such a name verbatim through an unguarded dictionary insert. A NESTED type is
        // walked twice (once as a member of its outer type, once by the outer type's own child walk), so
        // the second insert throws and the whole rename pass is abandoned - every class, method and local
        // in the project ships readable (CLAUDE-unity.md: obfuscation is a hard gate).
        public _0x9c1f3a9c _0xe50b7a68()
        {
            this.Lines.Clear();
            this.Coins = 0;
            this.Scatters = 0;
            this.WildsLanded = 0;
            this.TopMultiple = 0;
            return this;
        }
    }

    public const int SymbolCount = 9;
    public const int Scatter = 8;
    public const int Rows = 3;
    // grid is indexed [reel * Rows + row].
    public static _0x9c1f3a9c Evaluate(int[] _0x13b991dc, int _0x317a2628, _0x9c1f3a9c _0xa9aa209f)
    {
        _0x9c1f3a9c _0x9d7d2536 = _0xa9aa209f != null ? _0xa9aa209f._0xe50b7a68() : new _0x9c1f3a9c();
        for (int _0x016e8af2 = 0; _0x016e8af2 < _0x13b991dc.Length; _0x016e8af2++)
        {
            if (_0x13b991dc[_0x016e8af2] == Scatter)
                _0x9d7d2536.Scatters++;
            else if (_0x13b991dc[_0x016e8af2] == Wild)
                _0x9d7d2536.WildsLanded++;
        }

        for (int _0x7f5be930 = 0; _0x7f5be930 < Paylines.Length; _0x7f5be930++)
        {
            int[] _0xe1a7a60b = Paylines[_0x7f5be930];
            int _0x35a53948 = _0x13b991dc[_0xe1a7a60b[0]];
            if (_0x35a53948 == Scatter)
                continue;
            int _0x8b3b9fa9 = _0x35a53948;
            if (_0x8b3b9fa9 == Wild)
            {
                _0x8b3b9fa9 = -1;
                for (int _0x41ce48ca = 0; _0x41ce48ca < Reels; _0x41ce48ca++)
                {
                    int _0x40bb4554 = _0x13b991dc[(_0x41ce48ca * Rows) + _0xe1a7a60b[_0x41ce48ca]];
                    if (_0x40bb4554 == Wild)
                        continue;
                    if (_0x40bb4554 == Scatter)
                        break;
                    _0x8b3b9fa9 = _0x40bb4554;
                    break;
                }
            }

            int _0xa53ca387 = 0;
            while (_0xa53ca387 < Reels && _0x13b991dc[(_0xa53ca387 * Rows) + _0xe1a7a60b[_0xa53ca387]] == Wild)
                _0xa53ca387++;
            int _0x47cc0118 = 0;
            int _0x0ae33e15 = Wild;
            int _0x39ac83ec = 0;
            bool _0xf8ad589a = false;
            if (_0xa53ca387 >= 3)
            {
                _0x47cc0118 = PayTable[Wild][_0xa53ca387 - 3];
                _0x0ae33e15 = Wild;
                _0x39ac83ec = _0xa53ca387;
            }

            if (_0x8b3b9fa9 >= 0 && _0x8b3b9fa9 != Wild)
            {
                int _0x2f26594e = 0;
                while (_0x2f26594e < Reels)
                {
                    int _0x9c532cb7 = _0x13b991dc[(_0x2f26594e * Rows) + _0xe1a7a60b[_0x2f26594e]];
                    if (_0x9c532cb7 != _0x8b3b9fa9 && _0x9c532cb7 != Wild)
                        break;
                    _0x2f26594e++;
                }

                if (_0x2f26594e >= 3)
                {
                    int _0xe83b369b = PayTable[_0x8b3b9fa9][_0x2f26594e - 3];
                    if (_0xe83b369b > _0x47cc0118)
                    {
                        _0x47cc0118 = _0xe83b369b;
                        _0x0ae33e15 = _0x8b3b9fa9;
                        _0x39ac83ec = _0x2f26594e;
                        _0xf8ad589a = _0xa53ca387 > 0;
                    }
                }
            }

            if (_0x47cc0118 <= 0)
                continue;
            int payout = _0x47cc0118 * _0x317a2628;
            _0x9d7d2536.Lines.Add(new _0x4113515c()._0xaebdcba9(_0x7f5be930, _0x0ae33e15, _0x39ac83ec, payout, _0xf8ad589a));
            _0x9d7d2536.Coins += payout;
            if (_0x47cc0118 > _0x9d7d2536.TopMultiple)
                _0x9d7d2536.TopMultiple = _0x47cc0118;
        }

        return _0x9d7d2536;
    }

    public const int Reels = 5;
    // The visible 3x5 window of one strip set at the given stop offsets.
    public static void BuildGrid(int[][] _0xbcad44a3, int[] _0xf7e5844e, int[] _0x7ea6d816)
    {
        for (int _0xf0e5cc66 = 0; _0xf0e5cc66 < Reels; _0xf0e5cc66++)
        {
            int[] _0x9e20b6e3 = _0xbcad44a3[_0xf0e5cc66];
            for (int _0x89552ee9 = 0; _0x89552ee9 < Rows; _0x89552ee9++)
            {
                int _0xf34eb0ee = ((_0xf7e5844e[_0xf0e5cc66] + _0x89552ee9) % _0x9e20b6e3.Length + _0x9e20b6e3.Length) % _0x9e20b6e3.Length;
                _0x7ea6d816[(_0xf0e5cc66 * Rows) + _0x89552ee9] = _0x9e20b6e3[_0xf34eb0ee];
            }
        }
    }

    // [symbol][matches-3] coins per line at one coin per line. The scatter row is zero: it pays
    // free spins, not line coins.
    public static readonly int[][] PayTable =
    {
        new[]
        {
            50,
            200,
            1000
        },
        new[]
        {
            25,
            90,
            400
        },
        new[]
        {
            20,
            70,
            300
        },
        new[]
        {
            15,
            50,
            200
        },
        new[]
        {
            10,
            30,
            120
        },
        new[]
        {
            8,
            24,
            100
        },
        new[]
        {
            5,
            15,
            60
        },
        new[]
        {
            4,
            12,
            50
        },
        new[]
        {
            0,
            0,
            0
        }
    };
    public const int Wild = 0;
    public static readonly string[] SymbolNames =
    {
        _0xefdd8f00._0x69c3d4b4(new byte[4] { 242, 255, 252, 228 }, 176),
        _0xefdd8f00._0x69c3d4b4(new byte[5] { 216, 220, 218, 209, 216 }, 157),
        _0xefdd8f00._0x69c3d4b4(new byte[5] { 254, 239, 242, 234, 243 }, 189),
        _0xefdd8f00._0x69c3d4b4(new byte[7] { 151, 155, 134, 158, 153, 132, 151 }, 214),
        _0xefdd8f00._0x69c3d4b4(new byte[4] { 164, 177, 186, 173 }, 232),
        _0xefdd8f00._0x69c3d4b4(new byte[4] { 57, 52, 61, 60 }, 113),
        _0xefdd8f00._0x69c3d4b4(new byte[6] { 213, 217, 218, 195, 219, 216 }, 150),
        _0xefdd8f00._0x69c3d4b4(new byte[7] { 13, 27, 8, 10, 1, 4, 8 }, 73),
        _0xefdd8f00._0x69c3d4b4(new byte[5] { 167, 160, 187, 166, 185 }, 244)
    };
    // Row index per reel; 0 = top, 1 = middle, 2 = bottom.
    public static readonly int[][] Paylines =
    {
        new[]
        {
            1,
            1,
            1,
            1,
            1
        },
        new[]
        {
            0,
            0,
            0,
            0,
            0
        },
        new[]
        {
            2,
            2,
            2,
            2,
            2
        },
        new[]
        {
            0,
            1,
            2,
            1,
            0
        },
        new[]
        {
            2,
            1,
            0,
            1,
            2
        },
        new[]
        {
            0,
            0,
            1,
            0,
            0
        },
        new[]
        {
            2,
            2,
            1,
            2,
            2
        },
        new[]
        {
            1,
            0,
            0,
            0,
            1
        },
        new[]
        {
            1,
            2,
            2,
            2,
            1
        },
        new[]
        {
            0,
            1,
            1,
            1,
            0
        }
    };
    // One winning line of one spin.
    public sealed class _0x4113515c
    {
        public int Line;
        public int Symbol;
        public int Length;
        public int Coins;
        public bool WildAssisted;
        public _0x4113515c _0xaebdcba9(int _0x8ee28f1f, int _0xbf84e8af, int _0x8bd9ca53, int _0x090aa860, bool _0x7efd79af)
        {
            this.Line = _0x8ee28f1f;
            this.Symbol = _0xbf84e8af;
            this.Length = _0x8bd9ca53;
            this.Coins = _0x090aa860;
            this.WildAssisted = _0x7efd79af;
            return this;
        }
    }

    public static int TotalBet(int _0x5d8e1d0c)
    {
        return _0x5d8e1d0c * Paylines.Length;
    }
}

internal static class _0xefdd8f00
{
    internal static string _0x69c3d4b4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}