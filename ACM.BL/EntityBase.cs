using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    
    // Sealed class- that cannot be extended by inheritance

        public enum EntityStateOption
    {
        Active,
        Deleted
    }

   public abstract class EntityBase
    {
        public EntityStateOption EntityState
        {
            get;
            set;
        }

        public bool HasChanges
        {
            get;
            set;
        }

        public bool IsNew
        {
            get;
            private set;
        }

        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }
        public abstract bool Validate();
        //abstract -when the method MUST BE overriden (no body)

        //virtual- when u want to provide the OPTION for the method
        //to be overriden (have their own implementation(body))
    }
}
