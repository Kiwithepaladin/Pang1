using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Weapons.Harpoon
{
    public class HarpoonController : HarpoonElement
    {
        public HarpoonModel _model;

        public void DestoryHarpoon()
        {
            Destroy(this.transform.root.gameObject);
        }
        public IEnumerator GrowthCoroutine()
        {
            _model.transform.root.localScale += new Vector3(0,_model._harpoonGrowth,0);
            yield return new WaitForSeconds(0.2f);
            yield return StartCoroutine("GrowthCoroutine");
        }
    
    }

}