namespace coreboy.memory;

public interface IRegister
{
	int Address { get; }
	RegisterType Type { get; }
}
