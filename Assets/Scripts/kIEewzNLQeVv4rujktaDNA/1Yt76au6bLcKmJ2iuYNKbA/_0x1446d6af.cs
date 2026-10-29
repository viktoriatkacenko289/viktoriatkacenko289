using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x1446d6af : MonoBehaviour
{
    private Vector3 _0xec94ff7b { get; set; }

    private void Awake()
    {
        this._0xef1728ae = this.GetComponent<Camera>();
        _0x3581325e = this;
        this._0x9842dd1b();
    }

    private Vector3 _0x96b8a2be { get; set; }
    //public bool executeInUpdate;
    private float _0xb793f313 { get; set; }

    private float _0xaf14d589 = 1;
    private Vector3 _0xbab50b31 { get; set; }
    private Vector3 _0x6cdd8058 { get; set; }
    private Vector3 _0x114a880e { get; set; }

    private new Camera _0xef1728ae;
    private float _0xa1046780 { get; set; }
    private Vector3 _0x7c218bed { get; set; }

    private Color _0x2dc51498 = Color.white;
    private _0x5788456b _0x8b30c223 = _0x5788456b.Portrait;
    private Vector3 _0xc5636a71 { get; set; }

    private void _0x9842dd1b()
    {
        float _0x81eb7b87, _0x122c0d77, _0x71c68e9f, _0x9036947a;
        if (this._0x8b30c223 == _0x5788456b.Landscape)
            this._0xef1728ae.orthographicSize = 1f / this._0xef1728ae.aspect * this._0xaf14d589 / 2f;
        else
            this._0xef1728ae.orthographicSize = this._0xaf14d589 / 2f;
        this._0xa1046780 = 2f * this._0xef1728ae.orthographicSize;
        this._0xb793f313 = this._0xa1046780 * this._0xef1728ae.aspect;
        float _0x4f7a4834 = this._0xef1728ae.transform.position.x;
        float _0x99c25045 = this._0xef1728ae.transform.position.y;
        _0x81eb7b87 = _0x4f7a4834 - this._0xb793f313 / 2;
        _0x122c0d77 = _0x4f7a4834 + this._0xb793f313 / 2;
        _0x71c68e9f = _0x99c25045 + this._0xa1046780 / 2;
        _0x9036947a = _0x99c25045 - this._0xa1046780 / 2;
        this._0xc5636a71 = new Vector3(_0x81eb7b87, _0x9036947a, 0);
        this._0x6cdd8058 = new Vector3(_0x4f7a4834, _0x9036947a, 0);
        this._0x7c218bed = new Vector3(_0x122c0d77, _0x9036947a, 0);
        this._0x96b8a2be = new Vector3(_0x81eb7b87, _0x99c25045, 0);
        this._0xec94ff7b = new Vector3(_0x4f7a4834, _0x99c25045, 0);
        this._0x927cfe43 = new Vector3(_0x122c0d77, _0x99c25045, 0);
        this._0x6174d11a = new Vector3(_0x81eb7b87, _0x71c68e9f, 0);
        this._0x114a880e = new Vector3(_0x4f7a4834, _0x71c68e9f, 0);
        this._0xbab50b31 = new Vector3(_0x122c0d77, _0x71c68e9f, 0);
    }

    private Vector3 _0x927cfe43 { get; set; }

    public enum _0x5788456b
    {
        Landscape,
        Portrait
    }

    private static _0x1446d6af _0x3581325e;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x2dc51498;
        Matrix4x4 _0x321253eb = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xef1728ae.orthographic)
        {
            float _0xdc0617a0 = this._0xef1728ae.farClipPlane - this._0xef1728ae.nearClipPlane;
            float _0x6773bd2b = (this._0xef1728ae.farClipPlane + this._0xef1728ae.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x6773bd2b), new Vector3(this._0xef1728ae.orthographicSize * 2 * this._0xef1728ae.aspect, this._0xef1728ae.orthographicSize * 2, _0xdc0617a0));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xef1728ae.fieldOfView, this._0xef1728ae.farClipPlane, this._0xef1728ae.nearClipPlane, this._0xef1728ae.aspect);
        }

        Gizmos.matrix = _0x321253eb;
    }

    private Vector3 _0x6174d11a { get; set; }
}