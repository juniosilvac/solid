using System;
using System.Collections.Generic;

namespace dip
{
  public interface IRelationshipBrowser
  {
    IEnumerable<Person> FindAllChildrenOf(string name);
  }
}