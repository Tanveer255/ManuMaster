using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ManuMaster;

[Dependency(ReplaceServices = true)]
public class ManuMasterBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ManuMaster";
}
