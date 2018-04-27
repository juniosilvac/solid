using System;
using System.Collections.Generic;

namespace ocp
{
  // interface open for extension
  public interface IFilter<T>
  {
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
  }
}