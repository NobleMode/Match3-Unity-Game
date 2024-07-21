using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Config", menuName = "Config/Normal Item")]
public class NormalSO : ScriptableObject
{
    public string ThemeName;
    [SerializeField] private List<NormalItemConfig> configs;

    public Dictionary<NormalItem.eNormalType, NormalItemConfig> NormalItemDict = new Dictionary<NormalItem.eNormalType, NormalItemConfig>();

    public void Init()
    {
        foreach (var config in configs)
        {
            NormalItemDict.Add(config.type, config);
        }
    }

    public NormalItemConfig GetConfig(NormalItem.eNormalType type) => NormalItemDict[type];
}

[Serializable]
public class NormalItemConfig
{
    public NormalItem.eNormalType type;
    public Sprite visual;
}