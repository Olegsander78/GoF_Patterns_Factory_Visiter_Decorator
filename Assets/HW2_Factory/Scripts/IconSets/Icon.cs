﻿using UnityEngine;

namespace Assets.HW2_Factory
{
    public abstract class Icon
    {
        public Sprite SpriteIcon { get; private set; }

        public IconTypes IconTypes { get; private set; }

        public Icon(IconTypes iconTypes, Sprite sprite)
        {
            IconTypes = iconTypes;
            SpriteIcon = sprite;
        }
    }
}