using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class DictonaryClass<TVal, TKey>
    {
        TVal[] vals;
        TKey[] keys;

        public DictonaryClass()
        {
            vals = new TVal[0];
            keys = new TKey[0];
        }

        public void Add(TVal val, TKey key)
        {
            TVal[] tempVals = vals;
            TKey[] tempKeys = keys;


            vals = new TVal[vals.Length + 1];
            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempVals.Length; i++)
            {
                vals[i] = tempVals[i];
                keys[i] = tempKeys[i];
                

            }
            vals[vals.Length - 1] = val;
            keys[keys.Length - 1] = key;

       

        }
        
        public int Count
        {
            get { return vals.Length; }
        }

    }
       
       



    
}
