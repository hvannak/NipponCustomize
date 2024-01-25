using System;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace NipponCustomize
{
  public class NPSetupMaint : PXGraph<NPSetupMaint>
  {

    public PXSave<NPSetup> Save;
    public PXCancel<NPSetup> Cancel;


    public SelectFrom<NPSetup>.View Setup;

    }
}