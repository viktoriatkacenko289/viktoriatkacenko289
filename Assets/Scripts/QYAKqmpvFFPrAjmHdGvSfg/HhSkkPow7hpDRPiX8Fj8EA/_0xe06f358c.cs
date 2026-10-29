using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xe06f358c
{
    public static class _0x0d50bd34
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x55066aa5
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x9fe1a6a5
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x24d7a178
    {
        private static readonly _0x24d7a178 _0xcba3be4f = new();
        public static readonly _0x24d7a178[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xcba3be4f,
            _0xcba3be4f,
            _0xcba3be4f,
        };
        private int _0x0fec7840 => 0;
        private int _0xd87e73cb => 10;
        private string _0x64a88950 => _0xa4d1a28e._0x9825a1a6(new byte[4] { 254, 214, 221, 198 }, 179);
        private string _0x1dad4a98 => _0xa4d1a28e._0x9825a1a6(new byte[8] { 4, 13, 30, 13, 4, 51, 120, 53 }, 72);

        private int _0x619cecc0
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa4d1a28e._0x9825a1a6(new byte[25] { 211, 229, 226, 226, 245, 254, 228, 215, 252, 255, 242, 241, 252, 211, 248, 241, 224, 228, 245, 226, 217, 254, 244, 245, 232 }, 144)))
                    PlayerPrefs.SetInt(_0xa4d1a28e._0x9825a1a6(new byte[25] { 198, 240, 247, 247, 224, 235, 241, 194, 233, 234, 231, 228, 233, 198, 237, 228, 245, 241, 224, 247, 204, 235, 225, 224, 253 }, 133), 0);
                return PlayerPrefs.GetInt(_0xa4d1a28e._0x9825a1a6(new byte[25] { 205, 251, 252, 252, 235, 224, 250, 201, 226, 225, 236, 239, 226, 205, 230, 239, 254, 250, 235, 252, 199, 224, 234, 235, 246 }, 142));
            }

            set => PlayerPrefs.SetInt(_0xa4d1a28e._0x9825a1a6(new byte[25] { 55, 1, 6, 6, 17, 26, 0, 51, 24, 27, 22, 21, 24, 55, 28, 21, 4, 0, 17, 6, 61, 26, 16, 17, 12 }, 116), value);
        }

        public int _0x2aac3126
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x64a88950}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x64a88950}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x64a88950}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x64a88950}CurrentLevelIndex", value);
        }

        public int _0xe62297f1
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x64a88950}BestScore"))
                    this._0xe62297f1 = 0;
                return PlayerPrefs.GetInt($"{this._0x64a88950}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x64a88950}BestScore", value);
        }

        public bool _0x37528f6e
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x64a88950}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x64a88950}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x64a88950}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x64a88950}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x0eee97d9
    {
        public static int _0x0f7fe95d
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xa4d1a28e._0x9825a1a6(new byte[5] { 124, 80, 86, 81, 76 }, 63)))
                    PlayerPrefs.SetInt(_0xa4d1a28e._0x9825a1a6(new byte[5] { 119, 91, 93, 90, 71 }, 52), 0);
                return PlayerPrefs.GetInt(_0xa4d1a28e._0x9825a1a6(new byte[5] { 133, 169, 175, 168, 181 }, 198));
            }

            set
            {
                PlayerPrefs.SetInt(_0xa4d1a28e._0x9825a1a6(new byte[5] { 81, 125, 123, 124, 97 }, 18), value);
                _0x51e11591.Instance._0xa7bf546d();
            }
        }
    }
}

internal static class _0xa4d1a28e
{
    internal static string _0x9825a1a6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}