using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{

    internal class Apple
    {
        #region Fields
        float amountLeft;
        const float biteSize = 0.25f;
        bool isOrganic;
        #endregion

        #region Properties
        public float AmountLeft
        {
            get { return amountLeft; } 
        }

        public float BiteSize
        {
            get { return biteSize; }
        }

        public bool IsOrganic
        {
            get { return isOrganic; }
        }

        #endregion

        #region Constructors
        public Apple() : this(1, false)
        {

        }

        public Apple(float amountLeft, bool isOrganic)
        {
            this.amountLeft = amountLeft;
            this.isOrganic = isOrganic;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Take a bite of the apple
        /// </summary>
        public void TakeBite()
        {
            amountLeft = Math.Clamp(amountLeft - biteSize, 0, amountLeft);
        }

        #endregion
    }
}
