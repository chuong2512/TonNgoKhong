using System;
using System.Collections.Generic;
using System.Linq;
using Game;
using UnityEngine;

public class PlayerData : BaseData
{
    public int _coin, _gem, _exp;

    public int choosingMap;
    public List<MapRecord> mapUnlocks;

    public float time;
    public string timeRegister;

    public bool isRate;

    public int Coin
    {
        get => _coin;
        set
        {
            _coin = value;
            OutGameAction.OnChangeCoin?.Invoke(value);
            Save();
        }
    }

    public int Gem
    {
        get => _gem;
        set
        {
            _gem = value;
            OutGameAction.OnChangeGem?.Invoke(value);
            Save();
        }
    }

    public int Exp
    {
        get => _exp;
        set
        {
            _exp = value;
            OutGameAction.OnChangeExp?.Invoke(value);
            Save();
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

        _coin = 10;
        _gem = 10;
        _exp = 0;

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
        
        Save();
    }

    public MapRecord GetMapWithID(int mapID)
    {
        var findMap = mapUnlocks.Find(record => record.mapID == mapID);

        return findMap;
    }

    public void SetMaxTime(long playTime, int chapter)
    {
        if (GetMapWithID(chapter).time > playTime)
            return;

        GetMapWithID(chapter).time = playTime;
    }
}

[Serializable]
public class MapRecord
{
    public int mapID;
    public long time;
}