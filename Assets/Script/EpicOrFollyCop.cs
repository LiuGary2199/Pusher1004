using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpicOrFollyCop : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Newrove")]    public GameObject Onetime;
[UnityEngine.Serialization.FormerlySerializedAs("Oldtop")]
    public GameObject Cither;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction")]    public GameObject Much_Instructive;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_1")]    public GameObject Much_Instructive_1;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_2")]    public GameObject Much_Instructive_2;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Bottom_1")]    public GameObject Much_Fuller_1;
[UnityEngine.Serialization.FormerlySerializedAs("SlotTop")]    public GameObject MuchEar;
[UnityEngine.Serialization.FormerlySerializedAs("Plane")]    public GameObject Ridge;
[UnityEngine.Serialization.FormerlySerializedAs("Image")]    public GameObject Egypt;
[UnityEngine.Serialization.FormerlySerializedAs("Arrow")]    public GameObject Pluck;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher")]    public MeshRenderer Denial;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher_mat")]    public Material Denial_Box;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom")]    public MeshRenderer Fuller;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom_mat")]    public Material Fuller_Box;
[UnityEngine.Serialization.FormerlySerializedAs("Hold")]    public MeshRenderer Open;
[UnityEngine.Serialization.FormerlySerializedAs("Hold_mat")]   // public MeshRenderer Hold_1;
    public Material Open_Box;
   // public Material Hold_1_mat;

    public void FaunaCopPurge() 
    {
        if (FalconErie.MyUnder())
        {
            Onetime.SetActive(true);
            Cither.SetActive(false);
            Much_Instructive.SetActive(false);
            Much_Instructive_1.SetActive(false);
            Much_Instructive_2.SetActive(false);
            MuchEar.SetActive(false);
            Ridge.SetActive(false);
            Egypt.SetActive(false);
            Much_Fuller_1.SetActive(false);
            Pluck.SetActive(false);
            Denial.material = Denial_Box;
            Fuller.material = Fuller_Box;
            Open.material = Open_Box;
        }
        else
        {
            Onetime.SetActive(false);
            Cither.SetActive(true);
            Much_Instructive.SetActive(true);
            Much_Instructive_1.SetActive(true);
            Much_Instructive_2.SetActive(true);
            MuchEar.SetActive(true);
            Ridge.SetActive(true);
            Egypt.SetActive(true);
            Much_Fuller_1.SetActive(true);
            Pluck.SetActive(true);
        }
    }
}
