using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : ScriptableObject
{
    public int BoardSizeX = 5;

    public int BoardSizeY = 5;

    public int MatchesMin = 3;

    public int LevelMoves = 16;

    public float LevelTime = 30f;

    public float TimeForHint = 5f;

    [SerializeField]
    private List<ItemConfig> itemConfigList;

    private Dictionary<NormalItem.eNormalType, ItemConfig> itemConfigMap;

    public void Initialize()
    {
        itemConfigMap = new Dictionary<NormalItem.eNormalType, ItemConfig>();
        foreach (var iC in itemConfigList)
        {
            itemConfigMap.Add(iC.PrefabType, iC);
        }
    }

    public ItemConfig GetItemConfig(NormalItem.eNormalType type)
    {
        if (itemConfigMap.TryGetValue(type, out var iC))
        {
            return iC;
        }

        return null;
    }
}


