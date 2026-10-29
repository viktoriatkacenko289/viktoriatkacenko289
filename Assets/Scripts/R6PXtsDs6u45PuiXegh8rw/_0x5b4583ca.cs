using TMPro;
using UnityEngine;

// The template ships more panels than this game dresses, and every one it did not dress still
// carries the template's own placeholder copy. Those panels are NOT deactivated - the
// controllers address them by index and a pulled-out object breaks navigation - their text is
// simply emptied (CLAUDE-unity.md C.15).
public sealed class _0x5b4583ca : MonoBehaviour
{
    public void _0x34214308()
    {
        if (_0x7f8d8525.Instance == null || _0x7f8d8525.Instance.Panels == null)
            return;
        int _0xe7f596a6 = _0x7f8d8525.Instance.Panels.Count;
        for (int _0x6165ca2f = 0; _0x6165ca2f < _0x4f6e056a.Length; _0x6165ca2f++)
        {
            int _0x09ba1bda = _0x4f6e056a[_0x6165ca2f];
            if (_0x09ba1bda < 0 || _0x09ba1bda >= _0xe7f596a6)
                continue;
            _0x8f14dba3 _0x0d75aa03 = _0x7f8d8525.Instance.Panels[_0x09ba1bda];
            if (_0x0d75aa03 == null)
                continue;
            this._0xccb5101c(_0x0d75aa03.HeaderText);
            this._0xccb5101c(_0x0d75aa03.MainText);
            if (_0x0d75aa03.Content == null)
                continue;
            TMP_Text[] _0xc2478ee9 = _0x0d75aa03.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xb8916083 = 0; _0xb8916083 < _0xc2478ee9.Length; _0xb8916083++)
                this._0xccb5101c(_0xc2478ee9[_0xb8916083]);
        }
    }

    private void _0xccb5101c(TMP_Text _0x2dd48d56)
    {
        if (_0x2dd48d56 == null)
            return;
        _0x2dd48d56.text = string.Empty;
    }

    private static readonly int[] _0x4f6e056a =
    {
        _0xe06f358c._0x9fe1a6a5.TUTORIAL0,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL1,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL2,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL3,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL4,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL5,
        _0xe06f358c._0x9fe1a6a5.TUTORIAL6,
        _0xe06f358c._0x9fe1a6a5.EMPTY
    };
}