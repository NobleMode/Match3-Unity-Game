﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    private ItemConfig _itemConfig;

    public void SetConfig(ItemConfig iC)
    {
        _itemConfig = iC;
        ItemType = iC.PrefabType;
    }

    protected override string GetPrefabName() => _itemConfig?.PrefabName;

    //protected override GameObject GetPrefab() => m_gameSettings.NormalItemDict[ItemType];

    protected override Sprite GetVisual() => m_gameSettings.CurrentNormalItemConfig.GetConfig(ItemType).visual;

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }

    public NormalItem(GameSettings gameSettings) : base(gameSettings)
    {
    }
}
