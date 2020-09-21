using System;
using System.Collections.Generic;
using System.Text;

namespace PassingReferenceAndValue
{
    interface CallByReference
    {
        void ChangeReference(ref int[] pArray);
    }
}
