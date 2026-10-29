using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Builds the reel screen and runs the trial: bet, spin, payout, Thunder Surge, trial end.
// There is no round timer and no draining meter anywhere - the only way a trial ends is the
// 40-spin limit, which at roughly 11.8 s a spin is about 472 s of play, far past the review
// capture window (CLAUDE-unity.md C.5).
public sealed class _0x643422fd : MonoBehaviour
{
    private readonly int[] _0x78e38866 = new int[_0x27cd1a19.Reels * _0x27cd1a19.Rows];
    private TextMeshProUGUI _0xc3fa3f2e;
    public void _0x51032cbb(RectTransform _0x65d27ee6)
    {
        this._0x767c1611 = _0x65d27ee6;
        this._wallet._0x64c75b9b();
        this._album._0x947dd036();
        _0x289589d1._0x0cd0a267 = _0x289589d1._0x0cd0a267 + 1;
        this._0x0cdd2d9e = _0x0aefce87.Build(_0x289589d1._0x0cd0a267, _0x289589d1._0x8f011e44, this._0xaef0b513);
        this._0x5a9e4731 = new System.Random(this._0x0cdd2d9e.Seed ^ 0x2f17);
        this._0x7b3285d2(_0x65d27ee6);
        this._0x2fb0cc62(_0x65d27ee6);
        this._0x264d5c84(_0x65d27ee6);
        this._0xc3796ec3(_0x65d27ee6);
        this._0xd3cbf876(_0x65d27ee6);
        this._0xccffe00e(_0x65d27ee6);
        this._0x850dafbf(_0x65d27ee6);
        _0x2d485ba7.Label(_0x65d27ee6, _0x95700b5b._0xd67550d5(new byte[10] { 114, 94, 92, 65, 93, 88, 80, 95, 82, 84 }, 49), new Vector2(0f, -1014f), new Vector2(1130f, 56f), this._art, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        this._pops._0xda6c76ff(this._art, this);
        this._0x1dd020c1();
        this._0x65d37f03();
    }

    public const float IdleAutoSpinSeconds = 9f;
    private TextMeshProUGUI _0xa84e3b1d;
    private void _0x65d37f03()
    {
        this._0xee1001ec = IdleAutoSpinSeconds;
    }

    // ---- construction ---------------------------------------------------------------------
    private void _0x7b3285d2(RectTransform _0xe44b88e1)
    {
        RectTransform _0x822b7eb3 = _0x2d485ba7.Node(_0xe44b88e1, _0x95700b5b._0xd67550d5(new byte[6] { 162, 153, 134, 180, 151, 132 }, 246), new Vector2(0f, 1149f), new Vector2(1242f, 150f));
        _0x2d485ba7.Plate(_0x822b7eb3, _0x95700b5b._0xd67550d5(new byte[7] { 119, 84, 86, 94, 92, 91, 82 }, 53), Vector2.zero, new Vector2(1242f, 150f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.DeepInk, 0.72f), 10f);
        _0x2d485ba7.Plate(_0x822b7eb3, _0x95700b5b._0xd67550d5(new byte[4] { 205, 234, 243, 250 }, 159), new Vector2(0f, -74f), new Vector2(1242f, 3f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Gold, 0.55f), 2f);
        _0x2d485ba7.Label(_0x822b7eb3, _0x95700b5b._0xd67550d5(new byte[9] { 126, 83, 91, 84, 82, 69, 88, 71, 84 }, 49), Vector2.zero, new Vector2(700f, 70f), this._art, _0x95700b5b._0xd67550d5(new byte[16] { 252, 250, 225, 233, 228, 136, 231, 238, 136, 231, 228, 241, 229, 248, 253, 251 }, 168), 34f, 26f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        this._topBar._0x7fa7d748(_0x822b7eb3, this._art, this);
    }

    private static readonly int[] _0x017d9de1 =
    {
        1,
        2,
        5,
        10,
        25
    };
    private Image _0x1b03aff7;
    // Ten mini diagrams of the fixed lines, each in its own x-band, with the readout clear of
    // all of them.
    private void _0x850dafbf(RectTransform _0x47537abf)
    {
        RectTransform _0xf8bc7096 = _0x2d485ba7.Node(_0x47537abf, _0x95700b5b._0xd67550d5(new byte[8] { 3, 50, 42, 63, 58, 61, 54, 32 }, 83), new Vector2(0f, -774f), new Vector2(1130f, 120f));
        _0x2d485ba7.Plate(_0xf8bc7096, _0x95700b5b._0xd67550d5(new byte[7] { 141, 174, 172, 164, 166, 161, 168 }, 207), Vector2.zero, new Vector2(1130f, 120f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.72f), 20f);
        for (int _0x8dd3761a = 0; _0x8dd3761a < _0x27cd1a19.Paylines.Length; _0x8dd3761a++)
        {
            float _0xe8d560c0 = -482f + (_0x8dd3761a * 78f);
            RectTransform _0x8d34fd17 = _0x2d485ba7.Node(_0xf8bc7096, _0x95700b5b._0xd67550d5(new byte[1] { 175 }, 227) + (_0x8dd3761a + 1).ToString(), new Vector2(_0xe8d560c0, 0f), new Vector2(72f, 40f));
            Image _0x6f7f19e2 = _0x2d485ba7.Plate(_0x8d34fd17, _0x95700b5b._0xd67550d5(new byte[4] { 240, 219, 218, 195 }, 179), Vector2.zero, new Vector2(72f, 40f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Panel, 0.9f), 8f);
            int[] _0x54f6a218 = _0x27cd1a19.Paylines[_0x8dd3761a];
            for (int _0xf5f86039 = 0; _0xf5f86039 < _0x27cd1a19.Reels; _0xf5f86039++)
                _0x2d485ba7.Plate(_0x8d34fd17, _0x95700b5b._0xd67550d5(new byte[3] { 97, 74, 81 }, 37) + _0xf5f86039.ToString(), new Vector2(-26f + (_0xf5f86039 * 13f), 11f - (_0x54f6a218[_0xf5f86039] * 11f)), new Vector2(7f, 7f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Gold, 0.85f), 4f);
            this._0xe888a6ce.Add(_0x6f7f19e2);
        }

        this._0xa84e3b1d = _0x2d485ba7.Label(_0xf8bc7096, _0x95700b5b._0xd67550d5(new byte[7] { 146, 165, 161, 164, 175, 181, 180 }, 192), new Vector2(420f, 0f), new Vector2(250f, 80f), this._art, _0x95700b5b._0xd67550d5(new byte[19] { 171, 170, 186, 214, 211, 212, 223, 201, 144, 216, 223, 206, 186, 175, 181, 214, 211, 212, 223 }, 154), 28f, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Right);
    }

    [SerializeField]
    private _0x929c1da8 _missions;
    private void _0xd3cbf876(RectTransform _0x70ffaa2f)
    {
        RectTransform _0xd1d901ef = _0x2d485ba7.Node(_0x70ffaa2f, _0x95700b5b._0xd67550d5(new byte[9] { 94, 121, 108, 121, 94, 121, 127, 100, 125 }, 13), new Vector2(0f, -254f), new Vector2(1130f, 136f));
        _0x2d485ba7.Plate(_0xd1d901ef, _0x95700b5b._0xd67550d5(new byte[7] { 170, 137, 139, 131, 129, 134, 143 }, 232), Vector2.zero, new Vector2(1130f, 136f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Panel, 0.94f), 22f);
        _0x2d485ba7.Plate(_0xd1d901ef, _0x95700b5b._0xd67550d5(new byte[4] { 221, 252, 255, 253 }, 152), new Vector2(0f, 66f), new Vector2(1130f, 3f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Gold, 0.5f), 2f);
        this._0xd3e4f831 = _0xd1d901ef;
        this._0x46fc2e02 = this._0xe210d6fe(_0xd1d901ef, -377f, _0x95700b5b._0xd67550d5(new byte[7] { 11, 8, 5, 8, 7, 10, 12 }, 73), _0xc406d6f3.Amber, true);
        this._0xc3fa3f2e = this._0xe210d6fe(_0xd1d901ef, 0f, _0x95700b5b._0xd67550d5(new byte[9] { 20, 15, 20, 1, 12, 96, 2, 5, 20 }, 64), _0xc406d6f3.Cream, false);
        this._0x01082031 = this._0xe210d6fe(_0xd1d901ef, 377f, _0x95700b5b._0xd67550d5(new byte[8] { 248, 245, 231, 224, 148, 227, 253, 250 }, 180), _0xc406d6f3.Ember, false);
    }

    public void _0x68355450()
    {
        this._0x65d37f03();
        if (this._0x77db74a4 || this._0x9d8560f0 || this._0xa2feb70c)
            return;
        int _0xe5a2599e = this._0x131f8cc0;
        bool _0xbbe90081 = this._0x0da30aa6 > 0;
        if (!_0xbbe90081)
        {
            if (this._wallet._0xebc3a0c7(_0xe5a2599e))
                this._0x252b0520(_0x95700b5b._0xd67550d5(new byte[16] { 108, 101, 120, 126, 127, 100, 111, 10, 109, 120, 107, 100, 126, 10, 10, 1 }, 42) + _0xc406d6f3.Coins(_0xc7929e6b.FortuneGrant) + _0x95700b5b._0xd67550d5(new byte[6] { 40, 75, 71, 65, 70, 91 }, 8), _0x95700b5b._0xd67550d5(new byte[27] { 226, 254, 243, 150, 254, 249, 227, 229, 243, 150, 253, 243, 243, 230, 229, 150, 239, 249, 227, 150, 230, 250, 247, 239, 255, 248, 241 }, 182), _0xc406d6f3.Gold);
            if (!this._wallet._0x0a6fcb91(_0xe5a2599e))
                return;
        }

        this._0x77db74a4 = true;
        this._0x3ce49c19++;
        this._0xeb8aea6f(_0xbbe90081 ? (_0x95700b5b._0xd67550d5(new byte[10] { 8, 28, 11, 11, 110, 29, 30, 7, 0, 110 }, 78) + (SurgeSpins - this._0x0da30aa6 + 1).ToString() + _0x95700b5b._0xd67550d5(new byte[1] { 19 }, 60) + SurgeSpins.ToString()) : _0x95700b5b._0xd67550d5(new byte[8] { 203, 200, 209, 214, 214, 209, 214, 223 }, 152));
        this._0x74116d63.interactable = false;
        for (int _0xf85ca64e = 0; _0xf85ca64e < _0x27cd1a19.Reels; _0xf85ca64e++)
            this._0x940c695e[_0xf85ca64e] = this._0x5a9e4731.Next(_0x0aefce87.StripLength);
        bool _0x004a2739 = _0x289589d1._0x3dc83dc0 || _0xbbe90081;
        this._board._0xd16b2526(this._0x940c695e, _0x004a2739, () => this._0xb38ff647(_0xbbe90081));
    }

    private void _0x213d4a65()
    {
        if (this._0x0f615c7e == null)
            return;
        DOTween.Kill(this._0x0f615c7e);
        this._0x0f615c7e.alpha = 0f;
    }

    public void _0x348737e1(bool _0x8444608c)
    {
        this._0x9d8560f0 = _0x8444608c;
        this._0x65d37f03();
    }

    private void OnDestroy()
    {
        if (this._0x1b03aff7 != null)
            DOTween.Kill(this._0x1b03aff7);
        if (this._0x0f615c7e != null)
            DOTween.Kill(this._0x0f615c7e);
        if (this._0xdc889619 != null)
            DOTween.Kill(this._0xdc889619.rectTransform);
        for (int _0xbcc0ece9 = 0; _0xbcc0ece9 < this._0xe888a6ce.Count; _0xbcc0ece9++)
            if (this._0xe888a6ce[_0xbcc0ece9] != null)
                DOTween.Kill(this._0xe888a6ce[_0xbcc0ece9]);
        DOTween.Kill(this.gameObject);
    }

    private Button _0x74116d63;
    public int _0x45ead1dd
    {
        get
        {
            return this._missions != null ? this._missions._0x1e21ae20 : 0;
        }
    }

    private TextMeshProUGUI _0xe8f0eaf0;
    [SerializeField]
    private _0x0a61de5b _board;
    private RectTransform _0x767c1611;
    private void _0x264d5c84(RectTransform _0x9993380a)
    {
        RectTransform _0x7c5cb61b = _0x2d485ba7.Node(_0x9993380a, _0x95700b5b._0xd67550d5(new byte[9] { 201, 254, 254, 247, 221, 233, 250, 246, 254 }, 155), new Vector2(0f, 472f), new Vector2(_0x0a61de5b.FrameWidth, _0x0a61de5b.FrameHeight));
        _0x2d485ba7.Plate(_0x7c5cb61b, _0x95700b5b._0xd67550d5(new byte[9] { 153, 173, 190, 178, 186, 136, 186, 179, 179 }, 223), Vector2.zero, new Vector2(_0x0a61de5b.FrameWidth, _0x0a61de5b.FrameHeight), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.92f), 26f);
        this._board._0xc2c5fba3(_0x7c5cb61b, this._art, this._columnPrefab, this._0x0cdd2d9e.Strips, this._0x0cdd2d9e.StartOffsets);
    }

    public void _0x1dd020c1()
    {
        int _0xf0a91330 = this._0x131f8cc0;
        if (this._0xc3fa3f2e != null)
            _0xac23041c.SetText(this._0xc3fa3f2e, _0xc406d6f3.Coins(_0xf0a91330));
        if (this._0x01082031 != null)
            _0xac23041c.SetText(this._0x01082031, _0xc406d6f3.Coins(this._0x08255279));
        if (this._0xdc889619 != null)
            _0xac23041c.SetText(this._0xdc889619, _0x95700b5b._0xd67550d5(new byte[4] { 202, 205, 220, 168 }, 136) + this._0xaef0b513.ToString() + _0x95700b5b._0xd67550d5(new byte[7] { 194, 205, 194, 174, 171, 172, 167 }, 226));
        if (this._0xa84e3b1d != null)
            _0xac23041c.SetText(this._0xa84e3b1d, _0x95700b5b._0xd67550d5(new byte[13] { 2, 3, 19, 127, 122, 125, 118, 96, 57, 113, 118, 103, 19 }, 51) + this._0xaef0b513.ToString() + _0x95700b5b._0xd67550d5(new byte[5] { 101, 6, 3, 4, 15 }, 74));
        if (this._wallet != null)
            this._wallet._0x183a034b(false);
    }

    private float _0xee1001ec;
    public _0xc7929e6b _0x2b4fb0d7
    {
        get
        {
            return this._wallet;
        }
    }

    [SerializeField]
    private _0x7314f138 _pops;
    private bool _0x77db74a4;
    private void _0xff0bee81(bool _0xa63ae0dd, int payout, string _0xcf3ad388)
    {
        this._0xa2feb70c = true;
        _0x289589d1._0x8f011e44 = _0x289589d1._0x8f011e44 + 1;
        if (_0xa63ae0dd)
            this._pops._0x5732c3c9(payout, _0xcf3ad388);
        else
            this._pops._0x50b06def();
    }

    [SerializeField]
    private _0x31f8b05c _art;
    private void _0xb38ff647(bool _0x5a38fba0)
    {
        _0x27cd1a19.BuildGrid(this._0x0cdd2d9e.Strips, this._0x940c695e, this._0x78e38866);
        this._0xd6779993 = _0x27cd1a19.Evaluate(this._0x78e38866, this._0xaef0b513, this._0xd6779993);
        int _0xacf693f1 = _0x5a38fba0 ? 2 : 1;
        int payout = this._0xd6779993.Coins * _0xacf693f1;
        this._0x08255279 = payout;
        this._0x82d7d8c8 += this._0xd6779993.WildsLanded;
        for (int _0x1e8712b2 = 0; _0x1e8712b2 < this._0x78e38866.Length; _0x1e8712b2++)
            if (this._0x78e38866[_0x1e8712b2] == 1)
                this._0x5e0a49d2++;
        if (payout > 0)
            this._wallet.Add(payout);
        this._0xde9ef6da += this._album._0xdfe5c4dc(this._0xd6779993);
        this._board._0xecf517e2(this._0xd6779993, _0x289589d1._0x99257a82);
        bool _0xe809e68d = false;
        if (_0x5a38fba0)
        {
            this._0x0da30aa6 = Mathf.Max(0, this._0x0da30aa6 - 1);
            if (this._0x0da30aa6 == 0)
                this._board._0x72e49720(Color.white);
        }
        else if (this._0xd6779993.Scatters >= 3)
        {
            this._0x0da30aa6 = SurgeSpins;
            _0xe809e68d = true;
            this._board._0x72e49720(_0xc406d6f3.Sky);
        }

        int _0xfda016a2 = this._missions._0x1e21ae20;
        this._missions._0x67a151f9(this._0xd6779993, this._0x131f8cc0, this._0x3ce49c19, this._0x82d7d8c8, this._0x5e0a49d2, this._0xde9ef6da, _0xe809e68d || this._0x0da30aa6 > 0);
        int _0xe1d24f27 = this._missions._0x1e21ae20;
        this._0xa57e9b28();
        this._0x1dd020c1();
        if (_0xe809e68d)
            this._0x252b0520(_0x95700b5b._0xd67550d5(new byte[13] { 200, 212, 201, 210, 216, 217, 206, 188, 207, 201, 206, 219, 217 }, 156), SurgeSpins.ToString() + _0x95700b5b._0xd67550d5(new byte[26] { 174, 200, 220, 203, 203, 174, 221, 222, 199, 192, 221, 174, 163, 174, 217, 199, 192, 221, 174, 202, 193, 219, 204, 194, 203, 202 }, 142), _0xc406d6f3.Sky);
        else if (payout > 0)
            this._0x252b0520(_0x95700b5b._0xd67550d5(new byte[1] { 106 }, 65) + _0xc406d6f3.Coins(payout) + _0x95700b5b._0xd67550d5(new byte[6] { 227, 128, 140, 138, 141, 144 }, 195), this._0xd6779993.Lines.Count.ToString() + (this._0xd6779993.Lines.Count == 1 ? _0x95700b5b._0xd67550d5(new byte[5] { 189, 209, 212, 211, 216 }, 157) : _0x95700b5b._0xd67550d5(new byte[6] { 139, 231, 226, 229, 238, 248 }, 171)), _0xc406d6f3.Amber);
        this._0x77db74a4 = false;
        this._0x74116d63.interactable = true;
        this._0xeb8aea6f(this._0x0da30aa6 > 0 ? (_0x95700b5b._0xd67550d5(new byte[10] { 169, 189, 170, 170, 207, 188, 191, 166, 161, 207 }, 239) + (SurgeSpins - this._0x0da30aa6 + 1).ToString() + _0x95700b5b._0xd67550d5(new byte[1] { 244 }, 219) + SurgeSpins.ToString()) : _0x95700b5b._0xd67550d5(new byte[4] { 28, 31, 6, 1 }, 79));
        this._0x65d37f03();
        if (_0xe1d24f27 >= this._0x84b553a5 && this._0x84b553a5 > 0)
        {
            this._0xff0bee81(true, payout, _0xe1d24f27 > _0xfda016a2 ? this._missions._0x98db4ccd(this._0x84b553a5 - 1) : string.Empty);
            return;
        }

        if (this._0x3ce49c19 >= _0x0aefce87.TrialSpinLimit)
        {
            this._0xff0bee81(false, payout, string.Empty);
            return;
        }

        if (_0xe1d24f27 > _0xfda016a2)
            this._pops._0xcae2ff30(payout, this._missions._0x98db4ccd(_0xe1d24f27 - 1) + _0x95700b5b._0xd67550d5(new byte[9] { 72, 43, 39, 37, 56, 36, 45, 60, 45 }, 104));
        else if (this._0x131f8cc0 > 0 && payout >= this._0x131f8cc0 * BigWinMultiple)
            this._pops._0xcae2ff30(payout, _0x95700b5b._0xd67550d5(new byte[16] { 76, 45, 94, 89, 66, 95, 64, 45, 66, 75, 45, 78, 66, 68, 67, 94 }, 13));
        else if (this._0x0da30aa6 > 0)
            DOVirtual.DelayedCall(0.6f, () => this._0x68355450()).SetLink(this.gameObject);
    }

    private int _0x5e0a49d2;
    public int _0x90a007f7
    {
        get
        {
            return this._0x3ce49c19;
        }
    }

    private int _0x82d7d8c8;
    private void _0xccffe00e(RectTransform _0x32cfb312)
    {
        RectTransform _0x843087d1 = _0x2d485ba7.Node(_0x32cfb312, _0x95700b5b._0xd67550d5(new byte[10] { 196, 232, 233, 243, 245, 232, 235, 213, 232, 240 }, 135), new Vector2(0f, -524f), new Vector2(1130f, 192f));
        Button _0x3ab7b141 = _0x2d485ba7.IconAction(_0x843087d1, _0x95700b5b._0xd67550d5(new byte[7] { 241, 214, 199, 247, 220, 196, 221 }, 179), new Vector2(-400f, 0f), 168f, this._art, null, _0xc406d6f3.PanelRaise, 34f);
        _0x2d485ba7.Label(_0x3ab7b141.transform, _0x95700b5b._0xd67550d5(new byte[5] { 171, 128, 149, 156, 132 }, 236), Vector2.zero, new Vector2(120f, 90f), this._art, _0x95700b5b._0xd67550d5(new byte[5] { 181, 178, 163, 215, 218 }, 247), 34f, 26f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        _0x3ab7b141.onClick.AddListener(() => this._0x61618b3d(-1));
        RectTransform _0x872c1396 = _0x2d485ba7.Node(_0x843087d1, _0x95700b5b._0xd67550d5(new byte[4] { 47, 12, 21, 18 }, 124), Vector2.zero, new Vector2(560f, 192f));
        this._0x1b03aff7 = _0x2d485ba7.Plate(_0x872c1396, _0x95700b5b._0xd67550d5(new byte[4] { 7, 44, 47, 55 }, 64), Vector2.zero, new Vector2(590f, 220f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0.35f), 42f);
        Button _0x4fae0e4c = _0x2d485ba7.Action(_0x872c1396, _0x95700b5b._0xd67550d5(new byte[10] { 133, 166, 191, 184, 148, 163, 162, 162, 185, 184 }, 214), Vector2.zero, new Vector2(560f, 192f), this._art, _0x95700b5b._0xd67550d5(new byte[4] { 21, 22, 15, 8 }, 70), _0xc406d6f3.SizeSpin, _0xc406d6f3.Ember, _0xc406d6f3.Cream, 38f);
        _0x4fae0e4c.onClick.AddListener(() => this._0x68355450());
        this._0x74116d63 = _0x4fae0e4c;
        this._0xe8f0eaf0 = _0x4fae0e4c.GetComponentInChildren<TextMeshProUGUI>();
        Button _0x594e1b8d = _0x2d485ba7.IconAction(_0x843087d1, _0x95700b5b._0xd67550d5(new byte[5] { 54, 17, 0, 33, 4 }, 116), new Vector2(400f, 0f), 168f, this._art, null, _0xc406d6f3.PanelRaise, 34f);
        _0x2d485ba7.Label(_0x594e1b8d.transform, _0x95700b5b._0xd67550d5(new byte[5] { 53, 30, 11, 2, 26 }, 114), Vector2.zero, new Vector2(120f, 90f), this._art, _0x95700b5b._0xd67550d5(new byte[5] { 240, 247, 230, 146, 153 }, 178), 34f, 26f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        _0x594e1b8d.onClick.AddListener(() => this._0x61618b3d(1));
        this._0xdc889619 = _0x2d485ba7.Label(_0x843087d1, _0x95700b5b._0xd67550d5(new byte[7] { 95, 120, 105, 94, 117, 116, 109 }, 29), new Vector2(0f, 118f), new Vector2(420f, 44f), this._art, _0x95700b5b._0xd67550d5(new byte[12] { 232, 239, 254, 138, 159, 138, 133, 138, 230, 227, 228, 239 }, 170), 28f, 24f, _0xc406d6f3.Gold, TextAlignmentOptions.Center);
        Sequence _0x875ed3bb = DOTween.Sequence().SetLink(this._0x1b03aff7.gameObject);
        _0x875ed3bb.Append(this._0x1b03aff7.DOFade(0.85f, 0.8f));
        _0x875ed3bb.Append(this._0x1b03aff7.DOFade(0.35f, 0.8f));
        _0x875ed3bb.SetLoops(-1, LoopType.Restart);
    }

    private int _0x3ce49c19;
    [SerializeField]
    private _0xc7929e6b _wallet;
    [SerializeField]
    private _0xa4ea1eef _columnPrefab;
    private _0x27cd1a19._0x9c1f3a9c _0xd6779993;
    private _0x0aefce87._0x550b7745 _0x0cdd2d9e;
    private void _0x252b0520(string _0x09f53838, string _0xc3056afc, Color _0xa1e87a7e)
    {
        if (this._0x0f615c7e == null)
            return;
        _0xac23041c.SetText(this._0x48109de8, _0x09f53838);
        this._0x48109de8.color = _0xa1e87a7e;
        _0xac23041c.ApplyOutline(this._0x48109de8);
        _0xac23041c.SetText(this._0x3512030e, _0xc3056afc);
        DOTween.Kill(this._0x0f615c7e);
        this._0x0f615c7e.alpha = 0f;
        Sequence _0x3c415eb2 = DOTween.Sequence().SetLink(this._0x0f615c7e.gameObject);
        _0x3c415eb2.Append(this._0x0f615c7e.DOFade(1f, 0.22f));
        _0x3c415eb2.AppendInterval(2.4f);
        _0x3c415eb2.Append(this._0x0f615c7e.DOFade(0f, 0.4f));
    }

    private int _0xde9ef6da;
    private CanvasGroup _0x0f615c7e;
    private void _0xeb8aea6f(string _0x4bc198b8)
    {
        if (this._0xe8f0eaf0 == null)
            return;
        _0xac23041c.SetText(this._0xe8f0eaf0, _0x4bc198b8);
    }

    private void _0xc3796ec3(RectTransform _0xed7f117e)
    {
        RectTransform _0x7c0a76ff = _0x2d485ba7.Node(_0xed7f117e, _0x95700b5b._0xd67550d5(new byte[9] { 45, 19, 20, 56, 27, 20, 20, 31, 8 }, 122), new Vector2(0f, -44f), new Vector2(1130f, 150f));
        CanvasGroup _0x109fe955 = _0x7c0a76ff.gameObject.AddComponent<CanvasGroup>();
        _0x109fe955.alpha = 0f;
        _0x109fe955.interactable = false;
        _0x109fe955.blocksRaycasts = false;
        this._0x0f615c7e = _0x109fe955;
        _0x2d485ba7.Plate(_0x7c0a76ff, _0x95700b5b._0xd67550d5(new byte[7] { 234, 201, 203, 195, 193, 198, 207 }, 168), Vector2.zero, new Vector2(1130f, 150f), this._art.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelRaise, 0.9f), 24f);
        this._0x48109de8 = _0x2d485ba7.Label(_0x7c0a76ff, _0x95700b5b._0xd67550d5(new byte[4] { 186, 150, 158, 153 }, 247), new Vector2(0f, 22f), new Vector2(1060f, 86f), this._art, _0x95700b5b._0xd67550d5(new byte[8] { 44, 55, 39, 68, 72, 78, 73, 84 }, 7), 72f, 40f, _0xc406d6f3.Amber, TextAlignmentOptions.Center);
        this._0x3512030e = _0x2d485ba7.Label(_0x7c0a76ff, _0x95700b5b._0xd67550d5(new byte[3] { 199, 225, 246 }, 148), new Vector2(0f, -44f), new Vector2(1060f, 40f), this._art, _0x95700b5b._0xd67550d5(new byte[6] { 249, 232, 132, 129, 134, 141 }, 200), 30f, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x3512030e;
    public void _0x564d9a2c()
    {
        this._0x65d37f03();
        if (this._0xa2feb70c)
            return;
        this._0x9d8560f0 = true;
        this._pops._0xddb073ab();
    }

    public int _0x131f8cc0
    {
        get
        {
            return _0x27cd1a19.TotalBet(this._0xaef0b513);
        }
    }

    private TextMeshProUGUI _0x46fc2e02;
    private readonly List<Image> _0xe888a6ce = new List<Image>();
    private bool _0x9d8560f0;
    private TextMeshProUGUI _0x01082031;
    private System.Random _0x5a9e4731;
    [SerializeField]
    private _0xce074dd9 _album;
    private RectTransform _0xd3e4f831;
    private int _0x0da30aa6;
    public const int BigWinMultiple = 20;
    private TextMeshProUGUI _0x48109de8;
    public int _0x84b553a5
    {
        get
        {
            return this._missions != null ? this._missions._0x6acb316f : 0;
        }
    }

    public int _0xaef0b513
    {
        get
        {
            return _0x017d9de1[Mathf.Clamp(_0x289589d1._0xcf3b3499, 0, _0x017d9de1.Length - 1)];
        }
    }

    private RectTransform _0x17fda3eb;
    // Value boxes are sized for the widest value the game can show, so autosize never has to
    // shrink a counter (CLAUDE-unity.md C.10).
    private TextMeshProUGUI _0xe210d6fe(RectTransform _0x2ba8f688, float _0xd4c01af1, string _0x73a646f7, Color _0xf676011a, bool _0xbc68a4a2)
    {
        RectTransform _0x3f45f68e = _0x2d485ba7.Node(_0x2ba8f688, _0x73a646f7, new Vector2(_0xd4c01af1, 0f), new Vector2(370f, 120f));
        _0x2d485ba7.Label(_0x3f45f68e, _0x95700b5b._0xd67550d5(new byte[7] { 138, 168, 185, 189, 160, 166, 167 }, 201), new Vector2(0f, 38f), new Vector2(350f, 34f), this._art, _0x73a646f7, 26f, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        TextMeshProUGUI _0xea246326 = _0x2d485ba7.Label(_0x3f45f68e, _0x95700b5b._0xd67550d5(new byte[5] { 189, 138, 135, 158, 142 }, 235), new Vector2(0f, -22f), new Vector2(350f, 62f), this._art, _0x95700b5b._0xd67550d5(new byte[7] { 129, 129, 129, 129, 129, 129, 129 }, 177), _0xc406d6f3.SizeStatValue, 32f, _0xf676011a, TextAlignmentOptions.Center);
        if (_0xbc68a4a2)
        {
            _0x6d688570 _0x6e228b17 = _0xea246326.gameObject.AddComponent<_0x6d688570>();
            _0x6e228b17.MoneyCountText = _0xea246326;
            this._wallet._0x54a5bfb5(_0x6e228b17, _0x3f45f68e);
        }

        return _0xea246326;
    }

    private TextMeshProUGUI _0xdc889619;
    public const int SurgeSpins = 8;
    private void _0xa57e9b28()
    {
        for (int _0x33d57e32 = 0; _0x33d57e32 < this._0xe888a6ce.Count; _0x33d57e32++)
        {
            Image _0x086204b6 = this._0xe888a6ce[_0x33d57e32];
            if (_0x086204b6 == null)
                continue;
            DOTween.Kill(_0x086204b6);
            _0x086204b6.color = _0xc406d6f3.Alpha(_0xc406d6f3.Panel, 0.9f);
        }

        if (this._0xd6779993 == null)
            return;
        for (int _0xb1b374b3 = 0; _0xb1b374b3 < this._0xd6779993.Lines.Count; _0xb1b374b3++)
        {
            int _0xc678a917 = this._0xd6779993.Lines[_0xb1b374b3].Line;
            if (_0xc678a917 < 0 || _0xc678a917 >= this._0xe888a6ce.Count)
                continue;
            Image _0xc5bcced2 = this._0xe888a6ce[_0xc678a917];
            _0xc5bcced2.color = _0xc406d6f3.Amber;
            _0xc5bcced2.DOColor(_0xc406d6f3.Alpha(_0xc406d6f3.Panel, 0.9f), 1.1f).SetLink(_0xc5bcced2.gameObject);
        }
    }

    private readonly int[] _0x940c695e = new int[_0x27cd1a19.Reels];
    // ---- session --------------------------------------------------------------------------
    private void Update()
    {
        if (this._0x77db74a4 || this._0x9d8560f0 || this._0xa2feb70c)
            return;
        this._0xee1001ec -= Time.deltaTime;
        if (this._0xee1001ec > 0f)
            return;
        this._0x65d37f03();
        this._0x68355450();
    }

    private void _0x61618b3d(int _0x469cafff)
    {
        this._0x65d37f03();
        if (this._0x77db74a4 || this._0x0da30aa6 > 0)
            return;
        _0x289589d1._0xcf3b3499 = Mathf.Clamp(_0x289589d1._0xcf3b3499 + _0x469cafff, 0, _0x017d9de1.Length - 1);
        this._0x1dd020c1();
        if (this._0xdc889619 != null)
        {
            DOTween.Kill(this._0xdc889619.rectTransform);
            this._0xdc889619.rectTransform.localScale = Vector3.one;
            Sequence _0x75d493b0 = DOTween.Sequence().SetLink(this._0xdc889619.gameObject);
            _0x75d493b0.Append(this._0xdc889619.rectTransform.DOScale(1.14f, 0.1f).SetEase(Ease.OutQuad));
            _0x75d493b0.Append(this._0xdc889619.rectTransform.DOScale(1f, 0.1f).SetEase(Ease.InQuad));
        }
    }

    private bool _0xa2feb70c;
    private void _0x2fb0cc62(RectTransform _0x066097f9)
    {
        RectTransform _0xe80719c7 = _0x2d485ba7.Node(_0x066097f9, _0x95700b5b._0xd67550d5(new byte[13] { 39, 3, 25, 25, 3, 5, 4, 62, 3, 9, 1, 15, 24 }, 106), new Vector2(0f, 956f), new Vector2(1130f, _0x929c1da8.CellHeight));
        this._0x17fda3eb = _0xe80719c7;
        this._missions._0x7bc73bcb(_0xe80719c7, this._art, this._0x0cdd2d9e.Missions);
    }

    [SerializeField]
    private _0x785218b7 _topBar;
    // The ticker is rebuilt per trial, so the previous trial's cells are removed first.
    private void _0x03f5eaf7()
    {
        if (this._0x17fda3eb == null)
            return;
        for (int _0xea37019a = this._0x17fda3eb.childCount - 1; _0xea37019a >= 0; _0xea37019a--)
            Destroy(this._0x17fda3eb.GetChild(_0xea37019a).gameObject);
    }

    private int _0x08255279;
    // Starts the next trial with freshly generated strips and missions, so two trials in a row
    // differ in the symbol mix on the reels and in the mission set, not only in a HUD number.
    public void _0x0237f6bc()
    {
        this._0x0cdd2d9e = _0x0aefce87.Build(_0x289589d1._0x0cd0a267, _0x289589d1._0x8f011e44, this._0xaef0b513);
        this._0x5a9e4731 = new System.Random(this._0x0cdd2d9e.Seed ^ 0x2f17);
        this._board._0x6ebb08b1(this._0x0cdd2d9e.Strips);
        this._board._0x7eb56f0e(this._0x0cdd2d9e.StartOffsets);
        this._0x03f5eaf7();
        this._missions._0x7bc73bcb(this._0x17fda3eb, this._art, this._0x0cdd2d9e.Missions);
        this._0x3ce49c19 = 0;
        this._0x0da30aa6 = 0;
        this._0x82d7d8c8 = 0;
        this._0x5e0a49d2 = 0;
        this._0xde9ef6da = 0;
        this._0x08255279 = 0;
        this._0xa2feb70c = false;
        this._0x9d8560f0 = false;
        this._0x77db74a4 = false;
        this._board._0x72e49720(Color.white);
        this._0xeb8aea6f(_0x95700b5b._0xd67550d5(new byte[4] { 212, 215, 206, 201 }, 135));
        this._0x74116d63.interactable = true;
        this._0x213d4a65();
        this._0x1dd020c1();
        this._0x65d37f03();
    }
}

internal static class _0x95700b5b
{
    internal static string _0xd67550d5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}