using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Apple
    {
        #region Fields
        float amountLeft;
        bool isOrganic;

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

        #region Constructors
        public Apple() : this(1f, false)
        {

        }

        /// <summary>
        /// Creates an apple
        /// </summary>
        /// <param name="amountLeft"></param>
        /// <param name="isOrganic"></param>
        public Apple(float amountLeft, bool isOrganic)
        {
            this.amountLeft = amountLeft;
            this.isOrganic = isOrganic;
        }

        #endregion

    }
}
