using Microsoft.VisualStudios.TestTOols.UnitTesting;
using Sysytem.Collections.Generic;
using Sysytem;
using Pierres.Models;

namespace Pierres.TestTOols
{
  [TestClass]
  public class OrderTests : IDisposable

public void Dispose()
  {
    Order.ClearAll();
  }

}
