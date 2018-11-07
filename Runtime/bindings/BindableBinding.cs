using BeatThat.SafeRefs;
using BeatThat.TransformPathExt;
using UnityEngine;

namespace BeatThat.Bindings
{
    
    public class BindableBinding : Binding
    {
        public void Unbind()
        {
            var owner = m_owner.value;
            if (owner != null)
            {
                owner.Unbind();
                m_owner.value = null;
            }
        }

        public void BindTo(Bindable p)
        {
            m_owner = new SafeRef<Bindable>(p);
        }

        public void Invalidate()
        {
            m_owner.value = null;
        }

        public bool isBound
        {
            get
            {
                var owner = m_owner.value;
                return owner != null && owner.isBound;
            }
        }

        override public string ToString()
        {
            var owner = m_owner.value;
            var ownerComp = owner as Component;

            var ownerStr = ownerComp != null ?
                ownerComp.Path() : owner != null ? owner.GetType().Name : null;

            return "[Binding isBound=" + this.isBound
                                             + ", owner=" + ownerStr + "]";
        }

        private SafeRef<Bindable> m_owner;
    }
}

