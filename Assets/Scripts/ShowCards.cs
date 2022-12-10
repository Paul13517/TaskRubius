using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShowCards : MonoBehaviour
{

[SerializeField] Dropdown dropdown;
[SerializeField] CardsManager cardsManager;

    public void ButtonClick()
    {
 
      if(dropdown.value == 0){
    cardsManager.AllAtOnceStart(); 
         }; 
      if(dropdown.value == 1){
     cardsManager.OneByOneStart();
         }; 
      if(dropdown.value == 2){
     cardsManager.CardsPositionBackFunction();
         }; 
    }
    
  void Update(){

}
       
   }
   












  
    








        
    

