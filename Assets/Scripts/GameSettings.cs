using System;
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

    public GameObject CellBGPrefab;

    public GameObject ItemPrefab;

    [HideInInspector] public NormalSO CurrentNormalItemConfig;

    [SerializeField] private List<NormalSO> NormalItemConfigList;

    public BonusSO BonusItemConfig;

    private int configIndex = 0;

    public void Init()
    {
        foreach (var config in NormalItemConfigList)
        {
            config.Init();
        }

        BonusItemConfig.Init();

        CurrentNormalItemConfig = NormalItemConfigList[configIndex];
    }

    public ItemConfig GetItemConfig(NormalItem.eNormalType eNormalType)
    {
        var NormalItemDict = CurrentNormalItemConfig.NormalItemDict;
        if (NormalItemDict.ContainsKey(eNormalType))
        {
            return new ItemConfig
            {
                PrefabType = eNormalType
            };
        }
        return null;
    }

    public void CycleTheme(){
        configIndex = configIndex == NormalItemConfigList.Count - 1 ? 0 : configIndex + 1;

        CurrentNormalItemConfig = NormalItemConfigList[configIndex]; 
    }
}





