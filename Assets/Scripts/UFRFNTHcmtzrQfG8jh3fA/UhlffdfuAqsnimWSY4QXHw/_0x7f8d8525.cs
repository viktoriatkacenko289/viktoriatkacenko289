using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe06f358c;

public class _0x7f8d8525 : MonoBehaviour
{
    private _0x8f14dba3 _0xdb09c9b2(int _0xe5611498)
    {
        return this.Panels[_0xe5611498];
    }

    private void _0x1a4ff4cd(int _0xcf3c3921)
    {
        if (_0xcf3c3921 == _0x9fe1a6a5.SPLASH)
            _0x2196ea34.Instance._0x0991aefb();
        if (_0x51e11591.Instance._0x98004973 == _0x55066aa5.SCENE_0)
        {
        }
    }

    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    public void _0xca054787()
    {
        this.LastPanelIndexes.RemoveAll(_0x9feb03cd => _0x9feb03cd == this.CurrentPanelIndex);
        int _0xd7e7b59f = this.LastPanelIndexes.Last();
        this._0x1a4ff4cd(_0xd7e7b59f);
        this._0x2bb80cee(_0xd7e7b59f);
        this.CurrentPanelIndex = _0xd7e7b59f;
        this.Panels[_0xd7e7b59f].Show();
    }

    private void Start()
    {
        this._0x6aa86f40();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7f8d8525>();
    }

    public void _0xaa121859(int _0xe5847573)
    {
        if (_0xe5847573 == _0x9fe1a6a5.SPLASH && _0x51e11591.Instance._0x98004973 != _0x55066aa5.SCENE_0)
            _0x2196ea34.Instance._0x4f4b514f();
        if (_0x51e11591.Instance._0x98004973 != _0x55066aa5.SCENE_0)
        {
            if (_0xe5847573 == _0x9fe1a6a5.SPLASH || _0xe5847573 == _0x9fe1a6a5.TUTORIAL0)
                _0x51e11591.Instance._0xc5f3775b(false);
            else if (_0xe5847573 == _0x9fe1a6a5.DEFAULT)
                _0x51e11591.Instance._0xc5f3775b(true);
        }
    }

    public bool IsShowSplashOnStart = true;
    private void SwitchSplash()
    {
        if (_0xca78fb95.Instance.IsTutorialEnabled && !_0x51e11591._0xb220032e._0x37528f6e)
            this._0x8b4ff67b(_0x9fe1a6a5.TUTORIAL0);
        else
            this._0x8b4ff67b(_0x9fe1a6a5.DEFAULT);
    }

    private void _0x2bb80cee(int _0x88231cc9)
    {
        this.LastPanelIndexes.Add(_0x88231cc9);
        this.CurrentPanelIndex = _0x88231cc9;
        for (int _0xd1a7206a = 0; _0xd1a7206a < this.Panels.Count; _0xd1a7206a++)
            if (_0xd1a7206a != _0x88231cc9 && this.Panels[_0xd1a7206a] != null)
                this.Panels[_0xd1a7206a]._0x418a979b();
    }

    public void _0x8b4ff67b(int _0xfaf91703)
    {
        this._0x314f7dee(_0xfaf91703);
        this._0x1a4ff4cd(_0xfaf91703);
        this.CurrentPanelIndex = _0xfaf91703;
        this.Panels[_0xfaf91703].Show();
    }

    public List<_0x8f14dba3> Panels;
    private void _0x5f834362(int _0x8f479673)
    {
        this._0x314f7dee(_0x8f479673);
        this._0x1a4ff4cd(_0x8f479673);
        this.CurrentPanelIndex = _0x8f479673;
        this.Panels[_0x8f479673]._0x312d7078();
    }

    public int CurrentPanelIndex;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x6aa86f40()
    {
        this._0x5f834362(_0x9fe1a6a5.SPLASH);
        if (_0x51e11591.Instance._0x98004973 == _0x55066aa5.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x2196ea34.Instance.DefaultAnimationTime);
        }
    }

    public static _0x7f8d8525 Instance;
    private void _0x314f7dee(int _0x4713c534)
    {
        this.LastPanelIndexes.Add(_0x4713c534);
        this.CurrentPanelIndex = _0x4713c534;
        for (int _0xc409e9d4 = 0; _0xc409e9d4 < this.Panels.Count; _0xc409e9d4++)
            if (_0xc409e9d4 != _0x4713c534 && this.Panels[_0xc409e9d4] != null)
                this.Panels[_0xc409e9d4]._0x418a979b();
    }
}