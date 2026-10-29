using UnityEngine;
using UnityEngine.UI;

public class _0x69696937 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0xf1ae3176 == null)
            if (!this.TryGetComponent(out this._0xf1ae3176))
                this._0xf1ae3176 = this.GetComponentInChildren<Button>();
    }

    private int _0x5b0980c5;
    private void Start()
    {
        if (this._0xb9fb2104)
            this._0xf1ae3176.onClick.AddListener(() => _0x7f8d8525.Instance._0xca054787());
        else
            this._0xf1ae3176.onClick.AddListener(() => _0x7f8d8525.Instance._0x8b4ff67b(this._0x5b0980c5));
    }

    private bool _0xb9fb2104;
    private Button _0xf1ae3176;
}