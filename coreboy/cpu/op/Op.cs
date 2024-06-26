using coreboy.gpu;

namespace coreboy.cpu.op;

public abstract class Op
{
	public virtual bool ReadsMemory() => false;

	public virtual bool WritesMemory() => false;

	public virtual int OperandLength() => 0;

	public virtual int Execute(
		Registers registers, IAddressSpace addressSpace, int[] args, int context)
	{
		return context;
	}

	public virtual void SwitchInterrupts(InterruptManager interruptManager)
	{
	}

	public virtual bool Proceed(Registers registers) => true;

	public virtual bool ForceFinishCycle() => false;

	public virtual SpriteBug.CorruptionType? CausesOemBug(
		Registers registers, int context)
	{
		return null;
	}

	protected static bool InOamArea(int address)
	{
		return address >= 0xfe00 && address <= 0xfeff;
	}
}
