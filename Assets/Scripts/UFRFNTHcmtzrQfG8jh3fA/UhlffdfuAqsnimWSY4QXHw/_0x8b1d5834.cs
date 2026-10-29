using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8b1d5834 : MonoBehaviour
{
    public List<TMP_Text> TimerText = new();
    private static _0x8b1d5834 _0x10143a14;
    private int _0xd7e5abce => this.CustomTimeInitial + _0x51e11591._0xb220032e._0x2aac3126 * 10;

    [HideInInspector]
    public int TimeLeft;
    private void _0x975d51e9()
    {
        this.IsGameEnd = true;
        _0x51e11591.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public int CurrentGameIndex;
    private void _0xfb72568a()
    {
        if (_0xca78fb95.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xbc4fc3f0 => _0xbc4fc3f0.text = $"{this.ScoreCurrent}/{this._0x88af122b}");
        else
            this.ScoreText.ForEach(_0xbc4fc3f0 => _0xbc4fc3f0.text = $"{this.ScoreCurrent}");
    }

    private IEnumerator _0x378859a1()
    {
        this._0xdec63a3e();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x51e11591.Instance._0x98004973 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x51e11591.Instance._0x13f79269)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xdec63a3e();
            }
        }

        if (!this.IsGameEnd)
            this._0x6af6130f();
    }

    public int CustomTargetScore = 10;
    private void _0x51456438()
    {
        if (this.ScoreCurrent >= this._0x88af122b)
            this._0xaca7f004();
        else
            this._0x6af6130f();
    }

    private void _0xdec63a3e()
    {
        this.TimerText.ForEach(_0xbc4fc3f0 => _0xbc4fc3f0.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x09f54e01._0x946a30b5(new byte[6] { 145, 145, 160, 198, 143, 143 }, 252)));
    }

    private int _0xa664d852 => this.ScoreCurrent;

    public List<TMP_Text> SubtitleText = new();
    private void Awake()
    {
        _0x10143a14 = this.gameObject.GetComponent<_0x8b1d5834>();
    }

    public void _0x6af6130f()
    {
        if (_0xca78fb95.Instance.IsOnlyWinGameEndEnabled)
            this._0xaca7f004();
        if (!this.IsGameEnd)
        {
            this._0x975d51e9();
            _0x51e11591.IsAfterLevelComplete = false;
            _0x51e11591.IsAfterLevelFailed = true;
            _0x411dd6a7 _0xeab5f1db = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.LOSE).GetComponent<_0x411dd6a7>();
            if (_0xca78fb95.Instance.IsCheckScoreEnabled)
                _0xeab5f1db.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x88af122b}";
            else
                _0xeab5f1db.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xeab5f1db.ContentAdditionalText.text = $"{0}";
            _0xe06f358c._0x0eee97d9._0x0f7fe95d += 0;
            _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.LOSE);
        }
    }

    private int _0x88af122b => this.CustomTargetScore + _0x51e11591._0xb220032e._0x2aac3126 * 10;

    private void _0x09106b0a()
    {
        if (this.ScoreCurrent > _0x51e11591._0xb220032e._0xe62297f1)
            _0x51e11591._0xb220032e._0xe62297f1 = this.ScoreCurrent;
        if (_0xca78fb95.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x88af122b)
                this._0xaca7f004();
    }

    public void _0xaca7f004()
    {
        if (!this.IsGameEnd)
        {
            this._0x975d51e9();
            _0x51e11591.IsAfterLevelComplete = true;
            _0x51e11591.IsAfterLevelFailed = false;
            _0x411dd6a7 _0xb5b9f4b9 = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.WIN).GetComponent<_0x411dd6a7>();
            if (_0xca78fb95.Instance.IsCheckScoreEnabled)
                _0xb5b9f4b9.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x88af122b}";
            else
                _0xb5b9f4b9.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xca78fb95.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xe06f358c._0x0eee97d9._0x0f7fe95d)
                    _0xe06f358c._0x0eee97d9._0x0f7fe95d = this.ScoreCurrent;
                _0xb5b9f4b9.ContentAdditionalText.text = $"{_0xe06f358c._0x0eee97d9._0x0f7fe95d}";
            }
            else
            {
                _0xb5b9f4b9.ContentAdditionalText.text = $"{this._0xa664d852}";
                _0xe06f358c._0x0eee97d9._0x0f7fe95d += this._0xa664d852;
            }

            if (_0xca78fb95.Instance.IsLevelIncrementOnWin)
                ++_0x51e11591._0xb220032e._0x2aac3126;
            _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.WIN);
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    public void _0xe0e3dd1b(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xfb72568a();
            this._0x09106b0a();
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    public List<TMP_Text> ScoreText = new();
    public int CustomTimeInitial = 30;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xd7e5abce;
        this.CurrentGameIndex = _0x51e11591.Instance._0x98004973;
        foreach (Button _0x56db7593 in this.HomeButtons)
            _0x56db7593.onClick.AddListener(() =>
            {
                this._0x209b5756();
            });
        foreach (Button _0x6115488a in this.PauseButtons)
            _0x6115488a.onClick.AddListener(() =>
            {
                _0x51e11591.Instance._0xc5f3775b(false);
                _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.PAUSE);
            });
        this._0xfb72568a();
        this.LevelNumberText.ForEach(_0xbc4fc3f0 => _0xbc4fc3f0.text = $"LVL {_0x51e11591._0xb220032e._0x2aac3126 + 1}");
        if (_0xca78fb95.Instance.IsTimerEnabled)
        {
            this._0xdec63a3e();
            this.StartCoroutine(this._0x378859a1());
        }
    }

    public List<Button> PauseButtons = new();
    public void _0x209b5756()
    {
        _0x51e11591.Instance._0xc5f3775b(true);
        _0x51e11591.Instance._0x05618a99(_0xe06f358c._0x55066aa5.SCENE_0);
    }
}

internal static class _0x09f54e01
{
    internal static string _0x946a30b5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}