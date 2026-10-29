using TMPro;
using UnityEngine;

// Every generated image and the font asset, reached only through serialized references.
// One instance of this block is written into each scene's own root object, so no code ever
// looks an asset up by name or through Resources (both are erased by obfuscation).
[System.Serializable]
public sealed class _0x31f8b05c
{
    public Sprite SymColumn;
    // Reel symbol order is the single source of truth shared by the strips, the pay table and
    // the album; index 0 is the wild and index 8 the scatter.
    public Sprite _0x988888bb(int _0xc265ba27)
    {
        if (_0xc265ba27 == 0)
            return this.SymBolt;
        if (_0xc265ba27 == 1)
            return this.SymEagle;
        if (_0xc265ba27 == 2)
            return this.SymCrown;
        if (_0xc265ba27 == 3)
            return this.SymAmphora;
        if (_0xc265ba27 == 4)
            return this.SymLyre;
        if (_0xc265ba27 == 5)
            return this.SymHelm;
        if (_0xc265ba27 == 6)
            return this.SymColumn;
        if (_0xc265ba27 == 7)
            return this.SymDrachma;
        return this.SymStorm;
    }

    public Sprite SymDrachma;
    public Sprite SymStorm;
    public Sprite UrnBonus;
    // Plate sprite that ships with the template: a 512px rounded square with a 127px 9-slice
    // border. Used for every chrome surface, so no generated PNG can ever dangle behind a plate.
    public Sprite Plate;
    public Sprite IconPause;
    public Sprite SymHelm;
    public Sprite SymBolt;
    public Sprite IconBack;
    public Sprite SymAmphora;
    public Sprite FrameReel;
    public TMP_FontAsset Font;
    public Sprite MarkBolt;
    public Sprite IconClose;
    public Sprite SymEagle;
    public Sprite SymLyre;
    public Sprite SymCrown;
}