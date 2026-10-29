using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The Trial of Olympus: three missions drawn for this trial, their live progress, and the
// ticker that shows them. Each ticker cell keeps its state pip in its OWN x-band so the pip can
// never sit under the text (CLAUDE-unity.md C.25).
public sealed class _0x929c1da8 : MonoBehaviour
{
    private readonly List<TextMeshProUGUI> _0x0fa1ee31 = new List<TextMeshProUGUI>();
    private readonly List<int> _0x8c5f7b70 = new List<int>();
    private const float GutterWidth = 44f;
    public int _0x6acb316f
    {
        get
        {
            return this._0x1c8126ec.Count;
        }
    }

    private const float GutterCentre = -150f;
    public void _0x2109e9f1()
    {
        for (int _0x7bb90f68 = 0; _0x7bb90f68 < this._0x1c8126ec.Count; _0x7bb90f68++)
        {
            bool _0x89e243a4 = this._0x8c5f7b70[_0x7bb90f68] >= this._0x1c8126ec[_0x7bb90f68].Target;
            if (_0x7bb90f68 < this._0x57c78895.Count && this._0x57c78895[_0x7bb90f68] != null)
                this._0x57c78895[_0x7bb90f68].color = _0x89e243a4 ? _0xc406d6f3.Amber : _0xc406d6f3.Locked;
            if (_0x7bb90f68 >= this._0x0fa1ee31.Count || this._0x0fa1ee31[_0x7bb90f68] == null)
                continue;
            TextMeshProUGUI _0x25bc222e = this._0x0fa1ee31[_0x7bb90f68];
            _0x25bc222e.color = _0x89e243a4 ? _0xc406d6f3.Cream : _0xc406d6f3.Muted;
            string _0x2dc8e0e1 = this._0x1c8126ec[_0x7bb90f68].Target > 1 ? (_0x1cb1408d._0x721f4ccf(new byte[1] { 188 }, 182) + this._0x8c5f7b70[_0x7bb90f68].ToString() + _0x1cb1408d._0x721f4ccf(new byte[1] { 61 }, 18) + this._0x1c8126ec[_0x7bb90f68].Target.ToString()) : string.Empty;
            _0xac23041c.SetText(_0x25bc222e, this._0x1c8126ec[_0x7bb90f68].Text + _0x2dc8e0e1);
            _0xac23041c.ApplyOutline(_0x25bc222e);
        }
    }

    public const float CellHeight = 104f;
    private readonly List<Image> _0x57c78895 = new List<Image>();
    private readonly List<_0x0aefce87._0x7c3e136d> _0x1c8126ec = new List<_0x0aefce87._0x7c3e136d>();
    public const float CellWidth = 360f;
    public void _0x7db075eb(int _0x061c5b84, int _0xbfac4556)
    {
        for (int _0xaedd42ba = 0; _0xaedd42ba < this._0x1c8126ec.Count; _0xaedd42ba++)
        {
            if (this._0x1c8126ec[_0xaedd42ba].Id != _0x061c5b84)
                continue;
            if (_0xbfac4556 > this._0x8c5f7b70[_0xaedd42ba])
                this._0x8c5f7b70[_0xaedd42ba] = Mathf.Min(this._0x1c8126ec[_0xaedd42ba].Target, _0xbfac4556);
        }

        this._0x2109e9f1();
    }

    public int _0x1e21ae20
    {
        get
        {
            int _0xb93c9004 = 0;
            for (int _0x3d662c42 = 0; _0x3d662c42 < this._0x1c8126ec.Count; _0x3d662c42++)
                if (this._0x8c5f7b70[_0x3d662c42] >= this._0x1c8126ec[_0x3d662c42].Target)
                    _0xb93c9004++;
            return _0xb93c9004;
        }
    }

    private const float TextLeft = GutterCentre + (GutterWidth * 0.5f) + 24f;
    public void _0x7bc73bcb(RectTransform _0xfb53c216, _0x31f8b05c _0x80e398e9, List<_0x0aefce87._0x7c3e136d> _0x7f4830de)
    {
        this._0x1c8126ec.Clear();
        this._0x8c5f7b70.Clear();
        this._0x57c78895.Clear();
        this._0x0fa1ee31.Clear();
        for (int _0xcc819798 = 0; _0xcc819798 < _0x7f4830de.Count; _0xcc819798++)
        {
            this._0x1c8126ec.Add(_0x7f4830de[_0xcc819798]);
            this._0x8c5f7b70.Add(0);
        }

        float _0x6e5302c9 = CellWidth + 25f;
        float _0x39c9c249 = -_0x6e5302c9;
        for (int _0x7e9e0e29 = 0; _0x7e9e0e29 < this._0x1c8126ec.Count; _0x7e9e0e29++)
        {
            RectTransform _0x721a4a7b = _0x2d485ba7.Node(_0xfb53c216, _0x1cb1408d._0x721f4ccf(new byte[7] { 67, 103, 125, 125, 103, 97, 96 }, 14) + _0x7e9e0e29.ToString(), new Vector2(_0x39c9c249 + (_0x7e9e0e29 * _0x6e5302c9), 0f), new Vector2(CellWidth, CellHeight));
            _0x2d485ba7.Plate(_0x721a4a7b, _0x1cb1408d._0x721f4ccf(new byte[4] { 86, 112, 121, 121 }, 21), Vector2.zero, new Vector2(CellWidth, CellHeight), _0x80e398e9.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.85f), 18f);
            Image _0x1d66c42f = _0x2d485ba7.Plate(_0x721a4a7b, _0x1cb1408d._0x721f4ccf(new byte[3] { 1, 56, 33 }, 81), new Vector2(GutterCentre, 0f), new Vector2(22f, 22f), _0x80e398e9.Plate, _0xc406d6f3.Locked, 11f);
            float _0xe5f3eda4 = (CellWidth * 0.5f) - TextLeft - 18f;
            TextMeshProUGUI _0x28357512 = _0x2d485ba7.Label(_0x721a4a7b, _0x1cb1408d._0x721f4ccf(new byte[4] { 10, 59, 38, 42 }, 94), new Vector2(TextLeft + (_0xe5f3eda4 * 0.5f), 0f), new Vector2(_0xe5f3eda4, CellHeight - 20f), _0x80e398e9, this._0x1c8126ec[_0x7e9e0e29].Text, _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Left);
            this._0x57c78895.Add(_0x1d66c42f);
            this._0x0fa1ee31.Add(_0x28357512);
        }

        this._0x2109e9f1();
    }

    public string _0x98db4ccd(int _0x1a6a00b4)
    {
        if (_0x1a6a00b4 < 0 || _0x1a6a00b4 >= this._0x1c8126ec.Count)
            return _0x1cb1408d._0x721f4ccf(new byte[5] { 251, 253, 230, 238, 227 }, 175);
        return this._0x1c8126ec[_0x1a6a00b4].Text.Replace(_0x1cb1408d._0x721f4ccf(new byte[1] { 252 }, 246), _0x1cb1408d._0x721f4ccf(new byte[1] { 244 }, 212));
    }

    // Feeds one finished spin into every drawn mission at once.
    public void _0x67a151f9(_0x27cd1a19._0x9c1f3a9c _0x09fb0370, int totalBet, int _0x2d030918, int _0x4108b193, int _0x9b54f400, int _0x08f77a84, bool _0x6880b620)
    {
        if (_0x09fb0370 == null)
            return;
        this._0x7db075eb(_0x0aefce87.MissionWilds, _0x4108b193);
        this._0x7db075eb(_0x0aefce87.MissionEagles, _0x9b54f400);
        this._0x7db075eb(_0x0aefce87.MissionShards, _0x08f77a84);
        this._0x7db075eb(_0x0aefce87.MissionSpins, _0x2d030918);
        if (_0x09fb0370.Lines.Count >= 3)
            this._0x7db075eb(_0x0aefce87.MissionThreeLines, 1);
        if (totalBet > 0 && _0x09fb0370.Coins >= totalBet * 20)
            this._0x7db075eb(_0x0aefce87.MissionBigMultiple, 1);
        if (_0x09fb0370.Coins >= 500)
            this._0x7db075eb(_0x0aefce87.MissionBigWin, 1);
        if (_0x6880b620)
            this._0x7db075eb(_0x0aefce87.MissionSurge, 1);
    }

    public void _0x5667bbd2(int _0xca28577e, int _0x44a57862)
    {
        for (int _0x26161bd5 = 0; _0x26161bd5 < this._0x1c8126ec.Count; _0x26161bd5++)
        {
            if (this._0x1c8126ec[_0x26161bd5].Id != _0xca28577e)
                continue;
            if (this._0x8c5f7b70[_0x26161bd5] >= this._0x1c8126ec[_0x26161bd5].Target)
                continue;
            this._0x8c5f7b70[_0x26161bd5] = Mathf.Min(this._0x1c8126ec[_0x26161bd5].Target, this._0x8c5f7b70[_0x26161bd5] + _0x44a57862);
        }

        this._0x2109e9f1();
    }
}

internal static class _0x1cb1408d
{
    internal static string _0x721f4ccf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}