using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Apple
    {
        #region Fields
        float amountLeft = 1;
        bool isOrganic = true;
        #endregion

        #region Properties
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool IsOrganic
        {
            get { return isOrganic; }
        }
        #endregion
    }
}
