using System.Collections.Generic;
using UnityEngine;

// Builds a trial: five seeded reel strips, three missions drawn from a pool of eight, and the
// starting stop offsets. Nothing here is hardcoded except the fallback, and the generated set is
// SIMULATED before it is shown - a strip set outside the accepted bands is reseeded, never
// displayed (CLAUDE-unity.md C.11).
public static class _0x0aefce87
{
    // Accepted bands for the headless 500-spin simulation at the default bet.
    private const float RtpFloor = 0.80f;
    // A cheap headless run of 500 spins at the default bet. It costs about 25k comparisons -
    // well inside one frame - and it is the only reason a trial can be trusted before it is
    // drawn on screen.
    private static bool Simulate(_0x550b7745 _0x1120bda6, int _0x9714dc69, bool[] _0x6952c0bc)
    {
        int[] _0x95e83fd4 = new int[_0x27cd1a19.Reels * _0x27cd1a19.Rows];
        int[] _0x1d3f96be = new int[_0x27cd1a19.Reels];
        System.Random _0x009d20ec = new System.Random(_0x1120bda6.Seed ^ 0x5bd1);
        _0x27cd1a19._0x9c1f3a9c _0x8a91d95a = null;
        int totalBet = _0x27cd1a19.TotalBet(_0x9714dc69);
        long _0x26ea31aa = 0;
        long _0x82c61732 = 0;
        int _0x1b920701 = 0;
        int _0x2283f4cd = -1;
        int _0xef55ee31 = 0;
        int[] _0xa8257933 = new int[8];
        int _0x6899b4e5 = 0;
        int _0xf51a204e = 0;
        int _0xf83cb8fe = 0;
        bool[] _0x2221d543 = new bool[8];
        for (int _0x9f715ec2 = 0; _0x9f715ec2 < SimulatedSpins; _0x9f715ec2++)
        {
            if (_0x9f715ec2 % TrialSpinLimit == 0)
            {
                if (_0x9f715ec2 > 0)
                {
                    _0xef55ee31++;
                    for (int _0xb9016293 = 0; _0xb9016293 < 8; _0xb9016293++)
                        if (_0x2221d543[_0xb9016293])
                            _0xa8257933[_0xb9016293]++;
                }

                for (int _0xdf09f118 = 0; _0xdf09f118 < 8; _0xdf09f118++)
                    _0x2221d543[_0xdf09f118] = false;
                _0x6899b4e5 = 0;
                _0xf51a204e = 0;
                _0xf83cb8fe = 0;
            }

            for (int _0x3503c614 = 0; _0x3503c614 < _0x27cd1a19.Reels; _0x3503c614++)
                _0x1d3f96be[_0x3503c614] = _0x009d20ec.Next(StripLength);
            _0x27cd1a19.BuildGrid(_0x1120bda6.Strips, _0x1d3f96be, _0x95e83fd4);
            _0x8a91d95a = _0x27cd1a19.Evaluate(_0x95e83fd4, _0x9714dc69, _0x8a91d95a);
            _0x26ea31aa += totalBet;
            _0x82c61732 += _0x8a91d95a.Coins;
            if (_0x8a91d95a.Coins > 0)
            {
                _0x1b920701++;
                if (_0x2283f4cd < 0)
                    _0x2283f4cd = _0x9f715ec2;
            }

            _0x6899b4e5 += _0x8a91d95a.WildsLanded;
            _0xf51a204e += CountSymbol(_0x95e83fd4, 1);
            for (int _0xb8bc3e2b = 0; _0xb8bc3e2b < _0x8a91d95a.Lines.Count; _0xb8bc3e2b++)
                if (_0x8a91d95a.Lines[_0xb8bc3e2b].Length >= 4)
                    _0xf83cb8fe++;
            int _0x5bbb1719 = (_0x9f715ec2 % TrialSpinLimit) + 1;
            if (_0x6899b4e5 >= 2)
                _0x2221d543[MissionWilds] = true;
            if (_0x8a91d95a.Lines.Count >= 3)
                _0x2221d543[MissionThreeLines] = true;
            if (_0xf51a204e >= 6)
                _0x2221d543[MissionEagles] = true;
            if (_0x8a91d95a.Coins >= totalBet * 20)
                _0x2221d543[MissionBigMultiple] = true;
            if (_0x8a91d95a.Scatters >= 3)
                _0x2221d543[MissionSurge] = true;
            if (_0x8a91d95a.Coins >= 500)
                _0x2221d543[MissionBigWin] = true;
            if (_0x5bbb1719 >= 12)
                _0x2221d543[MissionSpins] = true;
            if (_0xf83cb8fe >= 3)
                _0x2221d543[MissionShards] = true;
        }

        if (_0xef55ee31 > 0)
            for (int _0x28e9f4e1 = 0; _0x28e9f4e1 < 8; _0x28e9f4e1++)
                if (_0x2221d543[_0x28e9f4e1])
                    _0xa8257933[_0x28e9f4e1]++;
        _0x1120bda6.MeasuredRtp = _0x26ea31aa > 0 ? (float)((double)_0x82c61732 / (double)_0x26ea31aa) : 0f;
        _0x1120bda6.MeasuredHitRate = (float)_0x1b920701 / (float)SimulatedSpins;
        if (_0x1120bda6.MeasuredRtp < RtpFloor || _0x1120bda6.MeasuredRtp > RtpCeil)
            return false;
        if (_0x1120bda6.MeasuredHitRate < HitFloor || _0x1120bda6.MeasuredHitRate > HitCeil)
            return false;
        if (_0x2283f4cd < 0 || _0x2283f4cd > 5)
            return false;
        int _0x897962fd = 0;
        int _0x25f707aa = Mathf.Max(1, _0xef55ee31 / 3);
        for (int _0x6ded0f05 = 0; _0x6ded0f05 < 8; _0x6ded0f05++)
        {
            _0x6952c0bc[_0x6ded0f05] = _0xa8257933[_0x6ded0f05] >= _0x25f707aa;
            if (_0x6952c0bc[_0x6ded0f05])
                _0x897962fd++;
        }

        return _0x897962fd >= MissionCount;
    }

    private static readonly int[] _0xa7db3bef =
    {
        3,
        3,
        4,
        4,
        5,
        5,
        6,
        6,
        2
    };
    public const int MissionSurge = 4;
    // One mission of the pool. Text carries its own line break so the engine never chooses one.
    public sealed class _0x7c3e136d
    {
        public int Id;
        public string Text;
        public int Target;
        public _0x7c3e136d _0xa13b3470(int _0xf472478b, string _0x3e950b95, int _0x4e0e4063)
        {
            this.Id = _0xf472478b;
            this.Text = _0x3e950b95;
            this.Target = _0x4e0e4063;
            return this;
        }
    }

    public const int MissionBigMultiple = 3;
    public const int MissionWilds = 0;
    private static _0x550b7745 Compose(System.Random _0xe6303e79, int _0x3cd943cd, int _0xdcb9cf0f)
    {
        _0x550b7745 _0x68397e58 = new _0x550b7745();
        _0x68397e58.Seed = _0x3cd943cd;
        _0x68397e58.Strips = new int[_0x27cd1a19.Reels][];
        for (int _0x518992b3 = 0; _0x518992b3 < _0x27cd1a19.Reels; _0x518992b3++)
            _0x68397e58.Strips[_0x518992b3] = BuildStrip(_0xe6303e79);
        _0x68397e58.StartOffsets = new int[_0x27cd1a19.Reels];
        for (int _0x34fe9181 = 0; _0x34fe9181 < _0x27cd1a19.Reels; _0x34fe9181++)
            _0x68397e58.StartOffsets[_0x34fe9181] = _0xe6303e79.Next(StripLength);
        bool[] _0x9f70b3f7 = new bool[8];
        if (!Simulate(_0x68397e58, _0xdcb9cf0f, _0x9f70b3f7))
            return null;
        List<int> _0x0e4447c0 = new List<int>();
        for (int _0x00ec4cd5 = 0; _0x00ec4cd5 < 8; _0x00ec4cd5++)
            _0x0e4447c0.Add(_0x00ec4cd5);
        for (int _0xa201ae0d = _0x0e4447c0.Count - 1; _0xa201ae0d > 0; _0xa201ae0d--)
        {
            int _0x9ba1ff6b = _0xe6303e79.Next(_0xa201ae0d + 1);
            int _0xcb368185 = _0x0e4447c0[_0xa201ae0d];
            _0x0e4447c0[_0xa201ae0d] = _0x0e4447c0[_0x9ba1ff6b];
            _0x0e4447c0[_0x9ba1ff6b] = _0xcb368185;
        }

        for (int _0x1862d577 = 0; _0x1862d577 < _0x0e4447c0.Count && _0x68397e58.Missions.Count < MissionCount; _0x1862d577++)
        {
            int _0xacf2e76e = _0x0e4447c0[_0x1862d577];
            if (!_0x9f70b3f7[_0xacf2e76e])
                continue;
            _0x68397e58.Missions.Add(PoolEntry(_0xacf2e76e));
        }

        if (_0x68397e58.Missions.Count < MissionCount)
            return null;
        _0x68397e58.BonusLadder = BuildLadder(_0xe6303e79);
        return _0x68397e58;
    }

    private const float HitCeil = 0.42f;
    public const int MissionCount = 3;
    private const float HitFloor = 0.22f;
    // Per-symbol band of positions on one 32-cell strip. The draw lands anywhere in the band and
    // is then balanced back to exactly StripLength, so two trials differ in the symbol MIX on
    // the reels, not only in a HUD number.
    private static readonly int[] _0x1efc2729 =
    {
        2,
        2,
        3,
        3,
        4,
        4,
        5,
        5,
        1
    };
    public const int MissionThreeLines = 1;
    // Hand-tuned constants that are known to pass every band. They exist ONLY as the net under
    // the generator - never as the game.
    private static _0x550b7745 Fallback(int _0x3c5f1b5b)
    {
        _0x550b7745 _0x09c6315c = new _0x550b7745();
        _0x09c6315c.Seed = 0;
        _0x09c6315c.UsedFallback = true;
        _0x09c6315c.Strips = new int[_0x27cd1a19.Reels][];
        int[] _0x8b3463e4 =
        {
            6,
            4,
            7,
            2,
            5,
            0,
            6,
            3,
            7,
            1,
            5,
            6,
            4,
            8,
            7,
            2,
            6,
            5,
            3,
            7,
            0,
            4,
            6,
            1,
            5,
            7,
            2,
            6,
            4,
            3,
            5,
            7
        };
        for (int _0x8f11dda6 = 0; _0x8f11dda6 < _0x27cd1a19.Reels; _0x8f11dda6++)
        {
            int[] _0x25ac8943 = new int[StripLength];
            for (int _0xa1f216c0 = 0; _0xa1f216c0 < StripLength; _0xa1f216c0++)
                _0x25ac8943[_0xa1f216c0] = _0x8b3463e4[(_0xa1f216c0 + (_0x8f11dda6 * 5)) % StripLength];
            _0x09c6315c.Strips[_0x8f11dda6] = _0x25ac8943;
        }

        _0x09c6315c.StartOffsets = new[]
        {
            3,
            11,
            19,
            6,
            27
        };
        _0x09c6315c.Missions.Add(PoolEntry(MissionSpins));
        _0x09c6315c.Missions.Add(PoolEntry(MissionWilds));
        _0x09c6315c.Missions.Add(PoolEntry(MissionEagles));
        _0x09c6315c.BonusLadder = BuildLadder(new System.Random(1));
        _0x09c6315c.MeasuredRtp = 0f;
        _0x09c6315c.MeasuredHitRate = 0f;
        return _0x09c6315c;
    }

    private static readonly int[] _0x338d73e5 =
    {
        500,
        750,
        1000,
        1500,
        2500,
        4000,
        7500
    };
    private static int CountSymbol(int[] _0xd1bd31f0, int _0x54e3f3fc)
    {
        int _0x56261335 = 0;
        for (int _0x7ceb08b2 = 0; _0x7ceb08b2 < _0xd1bd31f0.Length; _0x7ceb08b2++)
            if (_0xd1bd31f0[_0x7ceb08b2] == _0x54e3f3fc)
                _0x56261335++;
        return _0x56261335;
    }

    private const float RtpCeil = 1.10f;
    public const int TrialSpinLimit = 40;
    private const int MaxAttempts = 20;
    public const int MissionEagles = 2;
    private static int[] BuildLadder(System.Random _0xcae343b5)
    {
        int[] _0x49eb62ee = new int[_0x338d73e5.Length];
        for (int _0x10c9bab2 = 0; _0x10c9bab2 < _0x338d73e5.Length; _0x10c9bab2++)
            _0x49eb62ee[_0x10c9bab2] = _0x338d73e5[_0x10c9bab2];
        // Only the two mid-tier days swap, so the ladder still climbs but is not identical.
        if (_0xcae343b5.Next(2) == 0)
        {
            int _0xf5a51928 = _0x49eb62ee[2];
            _0x49eb62ee[2] = _0x49eb62ee[3];
            _0x49eb62ee[3] = _0xf5a51928;
        }

        return _0x49eb62ee;
    }

    public const int MissionBigWin = 5;
    public static _0x7c3e136d PoolEntry(int _0xe6a2ffca)
    {
        if (_0xe6a2ffca == MissionWilds)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[17] { 131, 142, 129, 139, 239, 253, 239, 152, 134, 131, 139, 239, 141, 128, 131, 155, 156 }, 207), 2);
        if (_0xe6a2ffca == MissionThreeLines)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[23] { 208, 206, 201, 167, 180, 167, 203, 206, 201, 194, 212, 141, 206, 201, 167, 200, 201, 194, 167, 212, 215, 206, 201 }, 135), 1);
        if (_0xe6a2ffca == MissionEagles)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[16] { 220, 208, 211, 211, 218, 220, 203, 191, 169, 191, 218, 222, 216, 211, 218, 204 }, 159), 6);
        if (_0xe6a2ffca == MissionBigMultiple)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[16] { 10, 29, 25, 27, 16, 120, 25, 120, 106, 104, 32, 120, 11, 8, 17, 22 }, 88), 1);
        if (_0xe6a2ffca == MissionSurge)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[21] { 45, 43, 48, 62, 62, 60, 43, 115, 45, 49, 44, 55, 61, 60, 43, 89, 42, 44, 43, 62, 60 }, 121), 1);
        if (_0xe6a2ffca == MissionBigWin)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[25] { 223, 193, 198, 168, 189, 184, 184, 168, 203, 199, 193, 198, 219, 130, 193, 198, 168, 199, 198, 205, 168, 219, 216, 193, 198 }, 136), 1);
        if (_0xe6a2ffca == MissionSpins)
            return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[13] { 73, 74, 83, 84, 58, 43, 40, 58, 78, 83, 87, 95, 73 }, 26), 12);
        return new _0x7c3e136d()._0xa13b3470(_0xe6a2ffca, _0xc4f4d3bd._0x67fe1ef0(new byte[18] { 193, 206, 203, 203, 167, 180, 167, 198, 203, 197, 210, 202, 167, 212, 203, 200, 211, 212 }, 135), 3);
    }

    public static _0x550b7745 Build(int _0xe23e4a79, int _0x1810d358, int _0x8e6906d6)
    {
        int _0x3e14b1fd = (_0xe23e4a79 * 7919) ^ (_0x1810d358 * 104729);
        for (int _0xbf9c6394 = 0; _0xbf9c6394 < MaxAttempts; _0xbf9c6394++)
        {
            System.Random _0x71480e13 = new System.Random(_0x3e14b1fd);
            _0x550b7745 _0xbb4c2e31 = Compose(_0x71480e13, _0x3e14b1fd, _0x8e6906d6);
            if (_0xbb4c2e31 != null)
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[trial] seed={_0xbb4c2e31.Seed} rtp={_0xbb4c2e31.MeasuredRtp:F3} hit={_0xbb4c2e31.MeasuredHitRate:F3} attempt={_0xbf9c6394}");
                    }
#endif
                }

                return _0xbb4c2e31;
            }

            _0x3e14b1fd = (_0x3e14b1fd * 31) + 7;
        }

        return Fallback(_0x8e6906d6);
    }

    // Everything one trial is made of.
    public sealed class _0x550b7745
    {
        public int[][] Strips;
        public int[] StartOffsets;
        public List<_0x7c3e136d> Missions = new List<_0x7c3e136d>();
        public int[] BonusLadder;
        public int Seed;
        public bool UsedFallback;
        public float MeasuredRtp;
        public float MeasuredHitRate;
    }

    private const int SimulatedSpins = 500;
    public const int MissionShards = 7;
    public const int MissionSpins = 6;
    private static int[] BuildStrip(System.Random _0x6f4374ab)
    {
        int[] _0x4ca32263 = new int[_0x27cd1a19.SymbolCount];
        int _0x359b08ad = 0;
        for (int _0xde1c9e8d = 0; _0xde1c9e8d < _0x27cd1a19.SymbolCount; _0xde1c9e8d++)
        {
            _0x4ca32263[_0xde1c9e8d] = _0x1efc2729[_0xde1c9e8d] + _0x6f4374ab.Next((_0xa7db3bef[_0xde1c9e8d] - _0x1efc2729[_0xde1c9e8d]) + 1);
            _0x359b08ad += _0x4ca32263[_0xde1c9e8d];
        }

        // Balance back to exactly StripLength using the low-paying ranks, so the high symbols
        // keep the frequency the band asked for.
        int[] _0xd0936f77 =
        {
            6,
            7,
            5,
            4
        };
        int _0x758b5ed1 = 0;
        while (_0x359b08ad != StripLength && _0x758b5ed1 < 256)
        {
            for (int _0x06928568 = 0; _0x06928568 < _0xd0936f77.Length && _0x359b08ad != StripLength; _0x06928568++)
            {
                int _0xd0f4e8b0 = _0xd0936f77[_0x06928568];
                if (_0x359b08ad < StripLength)
                {
                    _0x4ca32263[_0xd0f4e8b0]++;
                    _0x359b08ad++;
                }
                else if (_0x4ca32263[_0xd0f4e8b0] > 2)
                {
                    _0x4ca32263[_0xd0f4e8b0]--;
                    _0x359b08ad--;
                }
            }

            _0x758b5ed1++;
        }

        List<int> _0xe6fc2e6e = new List<int>();
        for (int _0x7ce5a83a = 0; _0x7ce5a83a < _0x27cd1a19.SymbolCount; _0x7ce5a83a++)
            for (int _0x896ed003 = 0; _0x896ed003 < _0x4ca32263[_0x7ce5a83a]; _0x896ed003++)
                _0xe6fc2e6e.Add(_0x7ce5a83a);
        for (int _0x3bd0ae39 = _0xe6fc2e6e.Count - 1; _0x3bd0ae39 > 0; _0x3bd0ae39--)
        {
            int _0x31888c9e = _0x6f4374ab.Next(_0x3bd0ae39 + 1);
            int _0x95451b70 = _0xe6fc2e6e[_0x3bd0ae39];
            _0xe6fc2e6e[_0x3bd0ae39] = _0xe6fc2e6e[_0x31888c9e];
            _0xe6fc2e6e[_0x31888c9e] = _0x95451b70;
        }

        // Break runs of three identical neighbours so the window never reads as a solid block.
        for (int _0x6d6dc8c7 = 0; _0x6d6dc8c7 < 4; _0x6d6dc8c7++)
        {
            for (int _0xf62190e4 = 0; _0xf62190e4 < _0xe6fc2e6e.Count; _0xf62190e4++)
            {
                int _0x2db2a4c5 = _0xe6fc2e6e[_0xf62190e4];
                int _0xa3d254c2 = _0xe6fc2e6e[(_0xf62190e4 + 1) % _0xe6fc2e6e.Count];
                int _0xe7351f74 = _0xe6fc2e6e[(_0xf62190e4 + 2) % _0xe6fc2e6e.Count];
                if (_0x2db2a4c5 != _0xa3d254c2 || _0xa3d254c2 != _0xe7351f74)
                    continue;
                int _0xfb2b41e2 = (_0xf62190e4 + 2 + (_0xe6fc2e6e.Count / 2)) % _0xe6fc2e6e.Count;
                int _0x2aec9f0c = _0xe6fc2e6e[(_0xf62190e4 + 2) % _0xe6fc2e6e.Count];
                _0xe6fc2e6e[(_0xf62190e4 + 2) % _0xe6fc2e6e.Count] = _0xe6fc2e6e[_0xfb2b41e2];
                _0xe6fc2e6e[_0xfb2b41e2] = _0x2aec9f0c;
            }
        }

        return _0xe6fc2e6e.ToArray();
    }

    public const int StripLength = 32;
}

internal static class _0xc4f4d3bd
{
    internal static string _0x67fe1ef0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}