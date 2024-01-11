using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerData : BaseData
{
    private int _coin, _gem, _exp;
    public float _maxTimePlay;

    public int levelUnlock;
    public int choosingMap;
    public List<MapRecord> mapUnlocks;

    public float time;
    public string timeRegister;

    public bool isRate;

    public float MaxTimePlay => _maxTimePlay;

    public int Coin
    {
        get => _coin;
        set
        {
            _coin = value;
            OutGameManager.OnChangeCoin?.Invoke(value);
        }
    }

    public int Gem
    {
        get => _gem;
        set
        {
            _gem = value;
            OutGameManager.OnChangeGem?.Invoke(value);
        }
    }

    public int Exp
    {
        get => _exp;
        set
        {
            _exp = value;
            OutGameManager.OnChangeExp?.Invoke(value);
        }
    }

    public void Rated()
    {
        isRate = true;
    }

    public bool IsRate => isRate;
    
    public void ResetTime()
    {
        time = 0;
        Save();
    }

    public override void ValidateData()
    {
        if (mapUnlocks == null || mapUnlocks.Count == 0)
        {
            mapUnlocks = new List<MapRecord>();
            mapUnlocks.Add(new MapRecord()
            {
                mapID = 0,
                time = 0
            });
        }
    }

    public override void Init()
    {
        prefString = Constant.DataKey_PlayerData;
        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }


    public override void ResetData()
    {
        timeRegister = DateTime.Now.ToBinary().ToString();
        time = 3 * 24 * 60 * 60;

        _coin = 0;
        _gem = 0;
        _exp = 0;

        levelUnlock = 0;
        mapUnlocks = new List<MapRecord>();
        mapUnlocks.Add(new MapRecord()
        {
            mapID = 0,
            time = 0
        });

        Save();
    }

    public bool IsUnlockMap(int mapID)
    {
        var findMap = mapUnlocks.Find(record => record.mapID == mapID);

        return (findMap != null);
    }

    public void UnlockMap(int mapID)
    {
        if (!IsUnlockMap(mapID))
        {
            mapUnlocks.Add(new MapRecord()
            {
                mapID = mapID,
                time = 0
            });
            mapUnlocks = mapUnlocks.OrderBy(i => i.mapID).ToList();
        }
    }

    public MapRecord GetMapWithID(int mapID)
    {
        var findMap = mapUnlocks.Find(record => record.mapID == mapID);

        return findMap;
    }

    public void SetMaxTime(float playTime)
    {
       if(_maxTimePlay > playTime)
           return;

       _maxTimePlay = playTime;
    }
}

public class MapRecord
{
    public int mapID;
    public long time;
}