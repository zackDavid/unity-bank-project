using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Client
{
    public string name;
    public int money;
};

public class BankManager : MonoBehaviour
{
  //it cant be changed
  private static BankManager _instance;
  //property BankManager
  public static BankManager Instance
  {
    get
    {
        if(_instance == null)
        {
            GameObject go = new GameObject("BankManager");
            go.AddComponent<BankManager>();
        }
        return _instance;
    }
  }

    public Bank[] banks = new Bank[1];
    public Client[] clients = new Client[1];

    //method Awake assigns the instance
    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        banks[0] = new Bank("Bank-name", 15000);
        clients[0].name = "Client-name";
        clients[0].money = 1000;
    }

}

