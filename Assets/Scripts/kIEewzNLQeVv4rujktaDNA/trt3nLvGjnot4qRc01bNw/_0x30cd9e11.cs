using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x30cd9e11 : MonoBehaviour
{
    private AspectRatioFitter _0x4119eaa3;
    private float _0x736dccd3 = 4;
    private float _0xa9ae6c8d = 1.5f;
    private TMP_Text _0xf43f5d60;
    private void Update()
    {
        int _0xf23c7bf4 = 1;
        if (this._0xc658d134.Count > 0)
        {
            string _0xa6f80ff9 = this._0xf43f5d60.text;
            foreach (string _0x9a811fc6 in this._0xc658d134)
                while (_0xa6f80ff9.Contains(_0x9a811fc6))
                    _0xa6f80ff9 = _0xa6f80ff9.Replace(_0x9a811fc6, "");
            _0xf23c7bf4 = _0xa6f80ff9.Length;
        }
        else
        {
            _0xf23c7bf4 = this._0xf43f5d60.text.Length;
        }

        float _0x73fb6e65 = Mathf.Clamp(this._0xb87816dc + this._0x57dcd013 * _0xf23c7bf4, this._0xa9ae6c8d, this._0x736dccd3);
        if (!Mathf.Approximately(this._0x4119eaa3.aspectRatio, _0x73fb6e65))
            this._0x4119eaa3.aspectRatio = _0x73fb6e65;
    }

    private List<string> _0xc658d134 = new();
    private float _0x57dcd013 = 0.6f;
    private float _0xb87816dc;
}