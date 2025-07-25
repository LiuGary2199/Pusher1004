using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobSing : MonoBehaviour
{
    public GameObject arrow;
    public GameObject newarrow;
    public GameObject Slot_RightGold;
    public GameObject newSlot_RightGold;
    public GameObject Slot_LeftGold;
    public GameObject newSlot_LeftGold;
    public GameObject Slot_TopGold;
    public GameObject newSlot_TopGold;
    public GameObject Slot_Bottom_1;
    public GameObject newSlot_Bottom_1;
    public GameObject Plane;
    public GameObject newPlane_new;
    public GameObject Image;
    public GameObject newImagenew;
    public GameObject Slot_LeftGold_1;
    public GameObject newSlot_LeftGold_1;
    public GameObject Slot_RightGold_1;
    public GameObject newSlot_RightGold_1;
    public GameObject BG1;
    public GameObject newSBG1;
    public GameObject jiqi;
    public GameObject newjiqi;

    public GameObject Slot_Obstruction_1;
    public GameObject newSlot_Obstruction_1;

    public void SetSkin()
    {
        if (FalconErie.GetSkin())
        {
            newarrow.SetActive(true);
            newSlot_RightGold.SetActive(true);
            newSlot_LeftGold.SetActive(true);
            newSlot_TopGold.SetActive(true);
            newSlot_Bottom_1.SetActive(true);
            newPlane_new.SetActive(true);
            newImagenew.SetActive(true);
            newSlot_LeftGold_1.SetActive(true);
            newSlot_RightGold_1.SetActive(true);
            newSBG1.SetActive(true);
            newjiqi.SetActive(true);
            newSlot_Obstruction_1.SetActive(true);

            arrow.SetActive(false);
            Slot_RightGold.SetActive(false);
            Slot_LeftGold.SetActive(false);
            Slot_TopGold.SetActive(false);
            Slot_Bottom_1.SetActive(false);
            Image.SetActive(false);
            Plane.SetActive(false);
            Slot_LeftGold_1.SetActive(false);
            Slot_RightGold_1.SetActive(false);
            BG1.SetActive(false);
            jiqi.SetActive(false);
            Slot_Obstruction_1.SetActive(false);

        }
        else
        {
            newarrow.SetActive(false);
            newSlot_RightGold.SetActive(false);
            newSlot_LeftGold.SetActive(false);
            newSlot_TopGold.SetActive(false);
            newSlot_Bottom_1.SetActive(false);
            newPlane_new.SetActive(false);
            newImagenew.SetActive(false);
            newSlot_LeftGold_1.SetActive(false);
            newSlot_RightGold_1.SetActive(false);
            newSBG1.SetActive(false);
            newjiqi.SetActive(false);
            newSlot_Obstruction_1.SetActive(false);

            arrow.SetActive(true);
            Slot_RightGold.SetActive(true);
            Slot_LeftGold.SetActive(true);
            Slot_TopGold.SetActive(true);
            Slot_Bottom_1.SetActive(true);
            Image.SetActive(true);
            Plane.SetActive(true);
            Slot_LeftGold_1.SetActive(true);
            Slot_RightGold_1.SetActive(true);
            BG1.SetActive(true);
            jiqi.SetActive(true);
            Slot_Obstruction_1.SetActive(true);
        }
    }
}
