﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public ulong id = 0;

    public InputField input_Name;
    public InputField input_LevelMin;
    public InputField input_LevelMax;
    public InputField input_Difficulty;
    public InputField input_Tankiness;
    public InputField input_Flavor;
    public InputField input_Icon;
    public ImageDownloader downloader;

    private void Awake()
    {
        MonsterSaveStack.instance.savables.Add(gameObject);
    }

    private void OnDestroy()
    {
        for (int i = 0; i < MonsterSaveStack.instance.savables.Count; i++)
        {
            if (MonsterSaveStack.instance.savables[i] == gameObject)
            {
                MonsterSaveStack.instance.savables.Remove(MonsterSaveStack.instance.savables[i]);
            }
        }
    }
}