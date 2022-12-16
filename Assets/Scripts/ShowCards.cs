using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ShowCards : MonoBehaviour
{

[SerializeField] Dropdown dropdown;
[SerializeField] CardsManager cardsManager;
public bool exitAFree = true;


    public void ButtonClick()
    {
 
      if(dropdown.value == 0 && exitAFree){
    cardsManager.AllAtOnceStart(); 
    exitAFree = false;
         }
         else if(dropdown.value == 0){
          cardsManager.WaitingAllAtOnce ();
         }

      if(dropdown.value == 1 && exitAFree){
    cardsManager.OneByOneStart(); 
    exitAFree = false;
         }
         else if(dropdown.value == 1){
          cardsManager.WaitingOneByOne ();
         }
     /* if(dropdown.value == 2){
     cardsManager.CardsPositionBackFunction();
         }; */
    }
    
       
   }
   












  
    








        
    

