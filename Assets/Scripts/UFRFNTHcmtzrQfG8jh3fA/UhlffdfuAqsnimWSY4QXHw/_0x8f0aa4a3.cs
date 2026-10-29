using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe06f358c;

public class _0x8f0aa4a3 : MonoBehaviour
{
    public static _0x8f0aa4a3 Instance;
    public List<_0x411dd6a7> Pops;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x411dd6a7 _0x9b66099d in this.Pops)
            if (_0x9b66099d != null)
                _0x9b66099d.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8f0aa4a3>();
    }

    public List<int> LastPopIndexes = new();
    public void _0x885f3061(int _0x3fe04555)
    {
        this.CurrentPopIndex = _0x3fe04555;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x29dd211f(true);
        this._0x855c8a47();
        this.Pops[_0x3fe04555].Show();
        foreach (GameObject _0x7b1f7a0f in this.GameObjectsToHide)
            _0x7b1f7a0f.SetActive(false);
    }

    private void _0x10e63404()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public GameObject BlurBackground;
    private void _0x29dd211f(bool _0x973fb93d = false)
    {
        for (int _0x6312df01 = 0; _0x6312df01 < this.Pops.Count; ++_0x6312df01)
            if (this.Pops[_0x6312df01] != null && !(_0x6312df01 == this.CurrentPopIndex && _0x973fb93d))
                this.Pops[_0x6312df01]._0x79dffccb();
    }

    public _0x411dd6a7 _0x36f45b52(int _0xac665c3b)
    {
        return this.Pops[_0xac665c3b];
    }

    public List<GameObject> GameObjectsToHide;
    private void _0x855c8a47()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0xed11e002()
    {
        this.LastPopIndexes.Clear();
        this._0x29dd211f();
        foreach (GameObject _0xd5b36111 in this.GameObjectsToHide)
            if (_0xd5b36111 != null)
                _0xd5b36111.SetActive(true);
        this._0x10e63404();
    }

    public void _0xb67ca9cc()
    {
        this.LastPopIndexes.RemoveAll(_0x9feb03cd => _0x9feb03cd == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xed11e002();
        else
            this._0x885f3061(this.LastPopIndexes.Last());
    }

    public int CurrentPopIndex;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }
}