namespace BeatThat.Bindings
{
    
    public interface Bindable : HasBinding
	{
        bool isBound { get; }
        void Bind();
        void Unbind();
	}
}

