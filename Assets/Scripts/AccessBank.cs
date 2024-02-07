using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessBank : MonoBehaviour
{
    public Bank bank;
    private bool _isClient;
    [SerializeField]
    private Client _currentClient;

    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            bank = BankManager.Instance.banks[0];
            for(int i = 0; i < BankManager.Instance.clients.Length; i++)
            {
                if(BankManager.Instance.clients[i].name == other.GetComponent<Player>().myName )
                {
                    _isClient = true;
                    _currentClient = BankManager.Instance.clients[i];
                }
            }  
        }
        

    }
    
    
    void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {      
                bank.CheckBalance(_currentClient);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                bank.Deposit(_currentClient,  other.GetComponent<Player>());    
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {    
                bank.Withdrawl(_currentClient, other.GetComponent<Player>());        
            }
            
        }
    }
}
