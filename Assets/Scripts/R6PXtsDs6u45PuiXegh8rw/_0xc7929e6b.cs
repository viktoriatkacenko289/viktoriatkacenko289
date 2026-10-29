using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

// The fictional purse. Coins are NOT purchasable and NOT redeemable; there is no deposit,
// withdrawal, prize or network call anywhere in this game. The balance itself lives in the
// template's own SETTINGS.PlayerSYSTEM.Coins, and every readout is a template MoneyCount
// component bound to a label of ours (CLAUDE-unity.md A / rule G).
public sealed class _0xc7929e6b : MonoBehaviour
{
    public void _0x183a034b(bool _0xfb1fb5b3)
    {
        string _0x30f4ea3a = _0xc406d6f3.Coins(_0x289589d1._0x4e747bd2);
        for (int _0x79a8810a = 0; _0x79a8810a < this._0x4593a99e.Count; _0x79a8810a++)
        {
            _0x6d688570 _0x1bc5f913 = this._0x4593a99e[_0x79a8810a];
            if (_0x1bc5f913 == null || _0x1bc5f913.MoneyCountText == null)
                continue;
            TMP_Text _0x1be88753 = _0x1bc5f913.MoneyCountText;
            _0xac23041c.SetText(_0x1be88753, _0x30f4ea3a);
        }

        if (!_0xfb1fb5b3)
            return;
        for (int _0xc384cd00 = 0; _0xc384cd00 < this._0x86f629ba.Count; _0xc384cd00++)
        {
            RectTransform _0xf3e035c7 = this._0x86f629ba[_0xc384cd00];
            if (_0xf3e035c7 == null)
                continue;
            DOTween.Kill(_0xf3e035c7);
            _0xf3e035c7.localScale = Vector3.one;
            Sequence _0x517930e3 = DOTween.Sequence().SetLink(_0xf3e035c7.gameObject);
            _0x517930e3.Append(_0xf3e035c7.DOScale(1.08f, 0.11f).SetEase(Ease.OutQuad));
            _0x517930e3.Append(_0xf3e035c7.DOScale(1f, 0.11f).SetEase(Ease.InQuad));
        }
    }

    public void _0x64c75b9b()
    {
        if (this._0x5d366898)
            return;
        this._0x5d366898 = true;
        // Touching the property seeds the starting balance on a first run.
        int _0xae9f8218 = _0x289589d1._0x4e747bd2;
        if (_0xae9f8218 < 0)
            _0x289589d1._0x4e747bd2 = 0;
    }

    public void Add(int _0x24e36033)
    {
        if (_0x24e36033 == 0)
            return;
        _0x289589d1._0x4e747bd2 = _0x289589d1._0x4e747bd2 + _0x24e36033;
        this._0x183a034b(true);
    }

    public const int FortuneGrant = 2000;
    // The one and only "out of coins" path, closed by construction: the house tops the purse up
    // instead of ever asking for anything.
    public bool _0xebc3a0c7(int _0xfdc1b294)
    {
        if (_0x289589d1._0x4e747bd2 >= _0xfdc1b294)
            return false;
        _0x289589d1._0x4e747bd2 = _0x289589d1._0x4e747bd2 + FortuneGrant;
        this._0x183a034b(true);
        return true;
    }

    public int _0xfc1db04f
    {
        get
        {
            return _0x289589d1._0x4e747bd2;
        }
    }

    private readonly List<RectTransform> _0x86f629ba = new List<RectTransform>();
    // `readout` is the template MoneyCount sitting on the value label; `plate` is the surface
    // that punches when the number changes.
    public void _0x54a5bfb5(_0x6d688570 _0xab2abe97, RectTransform _0xef2a57f5)
    {
        this._0x64c75b9b();
        if (_0xab2abe97 != null && !this._0x4593a99e.Contains(_0xab2abe97))
        {
            this._0x4593a99e.Add(_0xab2abe97);
            if (_0x51e11591.Instance != null && !_0x51e11591.Instance.MoneyCountContainers.Contains(_0xab2abe97))
                _0x51e11591.Instance.MoneyCountContainers.Add(_0xab2abe97);
        }

        if (_0xef2a57f5 != null && !this._0x86f629ba.Contains(_0xef2a57f5))
            this._0x86f629ba.Add(_0xef2a57f5);
        this._0x183a034b(false);
        // MoneyCount writes the raw integer from its own Start(), whose order against ours is
        // undefined; a zero-length delay runs after every Start of the frame and has the last word.
        DOVirtual.DelayedCall(0f, () => this._0x183a034b(false)).SetLink(this.gameObject);
    }

    private void OnDestroy()
    {
        for (int _0x85cc74c9 = 0; _0x85cc74c9 < this._0x86f629ba.Count; _0x85cc74c9++)
            if (this._0x86f629ba[_0x85cc74c9] != null)
                DOTween.Kill(this._0x86f629ba[_0x85cc74c9]);
        DOTween.Kill(this.gameObject);
    }

    private readonly List<_0x6d688570> _0x4593a99e = new List<_0x6d688570>();
    private bool _0x5d366898;
    public bool _0x0a6fcb91(int _0x206339a7)
    {
        if (_0x289589d1._0x4e747bd2 < _0x206339a7)
            return false;
        _0x289589d1._0x4e747bd2 = _0x289589d1._0x4e747bd2 - _0x206339a7;
        this._0x183a034b(true);
        return true;
    }
}