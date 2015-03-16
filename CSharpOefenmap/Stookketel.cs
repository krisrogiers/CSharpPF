using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class Stookketel:IVervuiler
    {

        public Stookketel(float cONorm)
        {
            this.CONorm = cONorm;
        }
        
        private float CONOrmValue;
               

        public float CONorm
        {
            get { return CONOrmValue; }
            set 
            {
                if (value>0)
                {
                    CONOrmValue = value;
                }
            }
        }
        
        public double GeefVervuiling()
        {
            return CONorm * 100;
        }
    }
}
