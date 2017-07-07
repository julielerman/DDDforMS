using SharedKernel.Enums;

namespace SharedKernel.Interfaces
{
  public interface IStateObject
  {
    ObjectState State { get; }
  }
}