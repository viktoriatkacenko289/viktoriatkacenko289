using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// One of the five reels. The column holds five cells and is driven by a single fractional strip
// position: cell k shows strip[(floor(p) + k) mod length] and sits at
// pitch - (k - 1) * pitch - (1 - frac(p)) * pitch, which is continuous across every integer of p
// - so there is no index bookkeeping to get wrong and the landed window always equals the grid
// SpinEvaluator was given.
public sealed class _0xa4ea1eef : MonoBehaviour
{
    private bool _0x2e4e4fba;
    // Spins down through `cycles` full strips and lands exactly on `stopIndex`.
    public void _0x1949823e(int _0x4c24e995, int _0x0d04425b, float _0xb2a0eb1e, float _0xaaa13afe)
    {
        if (this._0xb2d12277 == null || this._0xb2d12277.Length == 0)
            return;
        if (this._0x2c5031c7 != null)
            this._0x2c5031c7.Kill();
        float _0xf39750b2 = this._0xb2d12277.Length;
        float _0xef1f8598 = _0x4c24e995;
        float _0xe2702c92 = _0xef1f8598 + (Mathf.Max(1, _0x0d04425b) * _0xf39750b2);
        this._0xeebe6594 = _0xe2702c92;
        Sequence _0x5d4e92b0 = DOTween.Sequence().SetLink(this.gameObject);
        _0x5d4e92b0.Append(DOTween.To(() => this._0xeebe6594, _0x8efb2805 =>
        {
            this._0xeebe6594 = _0x8efb2805;
            this._0xcc999c83();
        }, _0xef1f8598 + 0.11f, Mathf.Max(0.2f, _0xb2a0eb1e)).SetEase(Ease.OutQuart));
        _0x5d4e92b0.Append(DOTween.To(() => this._0xeebe6594, _0x8efb2805 =>
        {
            this._0xeebe6594 = _0x8efb2805;
            this._0xcc999c83();
        }, _0xef1f8598, Mathf.Max(0.08f, _0xaaa13afe)).SetEase(Ease.OutBack));
        this._0x2c5031c7 = _0x5d4e92b0;
    }

    private Sequence _0x2c5031c7;
    public const float CellPitch = 242f;
    private float _0xeebe6594;
    // Row 0 is the top of the window. At rest the position is a whole strip index, so
    // drop == 1 and the formula above collapses to y(k) = -(k - 1) * pitch: cell k sits on
    // row k. Only call this once the reel has landed.
    public _0xbc83cefe _0x31c15825(int _0xeb14f70f)
    {
        if (!this._0x2e4e4fba || _0xeb14f70f < 0 || _0xeb14f70f >= _0x27cd1a19.Rows)
            return null;
        return this._0x5301d4f9[_0xeb14f70f];
    }

    public void _0xfc723eab(int[] _0x20410e9d)
    {
        this._0xb2d12277 = _0x20410e9d;
    }

    public void _0xda06bbdb(_0x31f8b05c _0x97bceddb, int[] _0xe939fc19, int _0xb34ab5bc)
    {
        this._0xbb569623 = _0x97bceddb;
        this._0xb2d12277 = _0xe939fc19;
        if (!this._0x2e4e4fba)
        {
            for (int _0x04daa810 = 0; _0x04daa810 < CellCount; _0x04daa810++)
            {
                _0xbc83cefe _0x902c31c5 = Instantiate(this._cellPrefab, this._content, false);
                _0x902c31c5.name = _0x1853ae9e._0x30851a3e(new byte[4] { 13, 43, 34, 34 }, 78) + _0x04daa810.ToString();
                this._0x5301d4f9[_0x04daa810] = _0x902c31c5;
            }

            this._0x2e4e4fba = true;
        }

        this._0xeebe6594 = _0xb34ab5bc;
        this._0xcc999c83();
    }

    private _0x31f8b05c _0xbb569623;
    private void OnDestroy()
    {
        if (this._0x2c5031c7 != null)
            this._0x2c5031c7.Kill();
        DOTween.Kill(this.gameObject);
    }

    [SerializeField]
    private _0xbc83cefe _cellPrefab;
    public void _0x02e73bfd(int _0xabdac95e)
    {
        if (this._0x2c5031c7 != null)
            this._0x2c5031c7.Kill();
        this._0xeebe6594 = _0xabdac95e;
        this._0xcc999c83();
    }

    private int[] _0xb2d12277;
    [SerializeField]
    private Image _backdrop;
    private readonly _0xbc83cefe[] _0x5301d4f9 = new _0xbc83cefe[CellCount];
    public RectTransform _0x970b9aab
    {
        get
        {
            return this._root;
        }
    }

    [SerializeField]
    private RectTransform _content;
    public void _0x5863aeaf(Color _0x1ea84d04)
    {
        if (this._backdrop != null)
            this._backdrop.color = _0x1ea84d04;
    }

    public const int CellCount = 5;
    private void _0xcc999c83()
    {
        if (!this._0x2e4e4fba || this._0xb2d12277 == null || this._0xb2d12277.Length == 0)
            return;
        int _0x9fc8dbe8 = this._0xb2d12277.Length;
        int _0x2b2b6991 = Mathf.FloorToInt(this._0xeebe6594);
        float _0x9232458c = 1f - (this._0xeebe6594 - _0x2b2b6991);
        for (int _0x488aa5d0 = 0; _0x488aa5d0 < CellCount; _0x488aa5d0++)
        {
            _0xbc83cefe _0x2210541c = this._0x5301d4f9[_0x488aa5d0];
            if (_0x2210541c == null)
                continue;
            int _0x82befd3e = (((_0x2b2b6991 + _0x488aa5d0) % _0x9fc8dbe8) + _0x9fc8dbe8) % _0x9fc8dbe8;
            int _0xc1a1208e = this._0xb2d12277[_0x82befd3e];
            if (_0x2210541c._0x825021f9 != _0xc1a1208e)
                _0x2210541c._0x583140b7(_0xc1a1208e, this._0xbb569623 != null ? this._0xbb569623._0x988888bb(_0xc1a1208e) : null);
            _0x2210541c._0x84b295ce(CellPitch - ((_0x488aa5d0 - 1) * CellPitch) - (_0x9232458c * CellPitch));
        }
    }

    [SerializeField]
    private RectTransform _root;
}

internal static class _0x1853ae9e
{
    internal static string _0x30851a3e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}