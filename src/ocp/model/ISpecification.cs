using System;

namespace ocp
{
  // interface open for extension
  public interface ISpecification<T>
  {
    bool IsSatisfied(Product p);
  }
}